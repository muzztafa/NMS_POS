using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace NMS_POS
{
    public partial class New_Item : Form
    {
        IFirebaseClient client;
        List<Products_class> productList = new List<Products_class>();
        List<string> keys = new List<string>();

        public New_Item()
        {
            InitializeComponent();
        }

        private void New_Item_Load(object sender, EventArgs e)
        {

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "m6NNKfbxyufWFj9YzHObMf2LTPXB9caps9qNjCrs",
                BasePath = "https://nms-pharmacy-e0da6.firebaseio.com/"
            };


            client = new FireSharp.FirebaseClient(config);


            featured_list.Items.Add("false");
            featured_list.Items.Add("true");
            featured_list.SelectedIndex = 0;

            prescription_list.Items.Add("false");
            prescription_list.Items.Add("true");
            prescription_list.SelectedIndex = 0;

            discount_editText.Text = "0";
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if (name_editText.Text == "" || name_editText == null)
            {
                MessageBox.Show("Fill Name field first.");
            }

            else if (price_editText.Text == "" || price_editText == null)
            {
                MessageBox.Show("Fill price field first.");
            }

            else if (description_editText.Text == "" || description_editText == null)
            {
                MessageBox.Show("Fill description field first.");
            }

            else if (quantity_editText.Text == "" || quantity_editText == null)
            {
                MessageBox.Show("Fill quantity field first.");
            }

            else
            {
                bool check = false;

                for (int i = 0; i < productList.Count; i++)
                {
                    if (name_editText.Text.ToLower() == productList[i].name.ToLower())
                    {
                        check = true;
                        break;
                    }

                }

                if (!check)
                {
                    bool temp1, temp2;
                    if (featured_list.GetItemText(featured_list.SelectedItem) == "false")
                    {
                        temp1 = false;
                    }
                    else
                    {
                        temp1 = true;
                    }

                    if (prescription_list.GetItemText(prescription_list.SelectedItem) == "false")
                    {
                        temp2 = false;
                    }
                    else
                    {
                        temp2 = true;
                    }

                    //Adding product to firebase
                    Products_class product = new Products_class(description_editText.Text, discount_editText.Text, temp1, image_editText.Text + "", name_editText.Text, temp2, double.Parse(price_editText.Text), int.Parse(quantity_editText.Text), DateTime.Now.ToString());

                    PushResponse response = await client.PushTaskAsync("products", product);

                    productList.Add(product);

                    FirebaseResponse resp = await client.GetTaskAsync("products/");
                    Dictionary<string, Products_class> dict = resp.ResultAs<Dictionary<string, Products_class>>();

                    //Adding new key to keys array
                    foreach (KeyValuePair<string, Products_class> ele1 in dict)
                    {
                        if (!keys.Contains(ele1.Key))
                        {
                            keys.Add(ele1.Key);
                            break;
                        }

                    }


                    //Console.WriteLine("response: "+response.Result.ToString());

                  

                }

                else
                {
                    MessageBox.Show("Product already exists in the inventory.");
                }
            }
        }
    }
    }

