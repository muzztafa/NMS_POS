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
using System.Collections;

namespace NMS_POS
{
    public partial class New_Invoice : Form
    {
        List<string> keys = new List<string>();
        List<Products_class> productList = new List<Products_class>();
        DataTable dt = new DataTable();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "m6NNKfbxyufWFj9YzHObMf2LTPXB9caps9qNjCrs",
            BasePath = "https://nms-pharmacy-e0da6.firebaseio.com/"
        };
        IFirebaseClient client;

        public New_Invoice()
        {
            InitializeComponent();
        }

        private async void New_Invoice_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            // FirebaseResponse resp = await client.GetTaskAsync("Counter/node");
            //  Counter_class get = resp.ResultAs<Counter_class>();

            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Discount");
            dt.Columns.Add("Description");

            products_grid.DataSource = dt;

            updateProductsList();
            



        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (products_list.GetItemText(products_list.SelectedItem) != null && products_list.GetItemText(products_list.SelectedItem) != string.Empty)
            {
                string text = products_list.GetItemText(products_list.SelectedItem);
                int temp = 0;
                for (int i = 0; i < productList.Count; i++)
                {
                    if (productList[i].name == text) {
                        temp = i;
                        break;
                    }
                }
                DataRow row = dt.NewRow();
                row["Name"] = text;
                row["Price"] = productList[temp].price;
                row["Quantity"] = productList[temp].quantity;
                row["Discount"] = productList[temp].discount;
                row["Description"] = productList[temp].description;

                dt.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("Please select a product first!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void updateProductsList()
        {
            FirebaseResponse resp = await client.GetTaskAsync("products/");
            Dictionary<string, Products_class> dict = resp.ResultAs<Dictionary<string, Products_class>>();
            


            //Adding product keys to Array Keys
            foreach (KeyValuePair<string, Products_class> ele1 in dict)
            {
                keys.Add(ele1.Key);
               // Console.WriteLine("{0} and {1}",
                        //  ele1.Key, ele1.Value);
            }
            
            //traversing list keys to fetch product details
            for(int i =0; i < keys.Count; i++)
            {
                FirebaseResponse resp2 = await client.GetTaskAsync("products/"+keys[i]);
                Products_class product = resp2.ResultAs<Products_class>();
                products_list.Items.Add(product.name);
                productList.Add(product);
                //Console.WriteLine(product.name+" : "+product.price);
            }
        }

        private void addToInvoice(string name)
        {

        }

        private void products_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
