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
        List<string> selectedKeys = new List<string>();
        List<string> selectedQuantity = new List<string>();
        List<Products_class> productList = new List<Products_class>();
        List<Products_class> selectedProductList = new List<Products_class>();
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
            dt.Columns.Add("Total");

            quantity_editText.Text = "1";
            cashier_editText.Text = "Admin";
            invoiceDate_editText.Text = DateTime.Now.ToString();
            invoiceDate_editText.Enabled = false;

            invoiceNo_editText.Text = "1000";

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

                if (Int32.Parse(productList[temp].quantity) < Int32.Parse(quantity_editText.Text))
                {
                    MessageBox.Show("Insufficient Stocks. You only have "+ productList[temp].quantity+ " of stocks available in the inventory.");
                }
                else
                {
                    DataRow row = dt.NewRow();
                    row["Name"] = text;
                    row["Price"] = productList[temp].price;

                    row["Quantity"] = quantity_editText.Text;
                    row["Discount"] = productList[temp].discount;
                    row["Description"] = productList[temp].description;

                    int tempPrice = Int32.Parse(productList[temp].price);
                    int tempDisc = Int32.Parse(productList[temp].discount);
                    int discountedPrice = tempPrice - ((tempDisc * tempPrice) / 100);

                    row["Total"] = "" + discountedPrice * Int32.Parse(quantity_editText.Text);

                    totalBill_label.Text = ""+(double)(double.Parse(totalBill_label.Text) + discountedPrice * Int32.Parse(quantity_editText.Text));

                    dt.Rows.Add(row);

                    //adding to selectedProdList
                    Products_class product = new Products_class
                    {
                        name = productList[temp].name,
                        price = productList[temp].price,
                        quantity = quantity_editText.Text,
                        discount = productList[temp].discount,
                        featured = productList[temp].featured,
                        prescription = productList[temp].prescription,
                        avgReviews = productList[temp].avgReviews,
                        description = productList[temp].description,
                        image = productList[temp].image,
                        timestamp = productList[temp].timestamp,
                        totalReviews = productList[temp].totalReviews


                    };
                    // selectedProductList.Add(productList[temp]);
                    selectedProductList.Add(product);
                    selectedKeys.Add(keys[temp]);
                    selectedQuantity.Add(productList[temp].quantity);
                }
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

        private async void createInvoice_btn_Click(object sender, EventArgs e)
        {
            Invoices_class invoice = new Invoices_class
            {
                cashier = cashier_editText.Text,
                timestamp = invoiceDate_editText.Text,
                invoiceNo = invoiceNo_editText.Text,
                totalBill = totalBill_label.Text,
                productList = selectedProductList

            };

            PushResponse response = await client.PushTaskAsync("invoices", invoice);

            for (int i = 0; i < selectedKeys.Count; i++)
            {
                int finalQuantity = Int32.Parse(selectedQuantity[i]) - Int32.Parse(selectedProductList[i].quantity);
                selectedProductList[i].quantity = "" + finalQuantity;
                FirebaseResponse response2 = await client.UpdateTaskAsync("products/" + keys[i],selectedProductList[i]);
            }
           
            MessageBox.Show("Invoice Added Successfully!");
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {

                int temp = products_grid.CurrentCell.RowIndex;
                //Console.WriteLine("temp " + temp);
                //FirebaseResponse response = await client.DeleteTaskAsync("products/" + keys[temp]);

                ////Console.WriteLine("Removing: " + selectedProductList[temp].name);
                

                totalBill_label.Text = ""+(double.Parse(totalBill_label.Text) - (double.Parse(selectedProductList[temp].price) * double.Parse(selectedProductList[temp].quantity)));
                selectedProductList.RemoveAt(temp);
                selectedKeys.RemoveAt(temp);
                selectedQuantity.RemoveAt(temp);
                dt.Rows.RemoveAt(temp);
                MessageBox.Show("Deleted Successfully");


            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to delete");
               
            }
        }
    }
}
