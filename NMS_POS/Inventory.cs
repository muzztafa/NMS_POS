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
    public partial class Inventory : Form
    {
        IFirebaseClient client;
        List<Products_class> productList = new List<Products_class>();
        DataTable dt = new DataTable();
        List<string> keys = new List<string>();
        int selectedRow = -1;
       
        //FirebaseHelper fh = new FirebaseHelper();

        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
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

            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Discount");
            dt.Columns.Add("Description");
            dt.Columns.Add("Featured");
            dt.Columns.Add("Prescription");
            dt.Columns.Add("Date");

            inventory_datagrid.DataSource = dt;
            updateProductList();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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
                    Products_class product = new Products_class(description_editText.Text, discount_editText.Text, temp1, image_editText.Text + "", name_editText.Text, temp2, price_editText.Text, quantity_editText.Text, DateTime.Now.ToString());

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

                    //adding new row to DT
                    DataRow row = dt.NewRow();
                    row["Name"] = product.name;
                    row["Price"] = product.price;
                    row["Quantity"] = product.quantity;
                    row["Discount"] = product.discount;
                    row["Description"] = product.description;
                    row["Featured"] = product.featured;
                    row["Prescription"] = product.prescription;
                    row["Date"] = product.timestamp;

                    dt.Rows.Add(row);

                }

                else
                {
                    MessageBox.Show("Product already exists in the inventory.");
                }
            }
        }

        private async void updateProductList()
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
            for (int i = 0; i < keys.Count; i++)
            {
                FirebaseResponse resp2 = await client.GetTaskAsync("products/" + keys[i]);
                Products_class product = resp2.ResultAs<Products_class>();
                productList.Add(product);


            }

            for (int i = 0; i < productList.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["Name"] = productList[i].name;
                row["Price"] = productList[i].price;
                row["Quantity"] = productList[i].quantity;
                row["Discount"] = productList[i].discount;
                row["Description"] = productList[i].description;
                row["Featured"] = productList[i].featured;
                row["Prescription"] = productList[i].prescription;
                row["Date"] = productList[i].timestamp;

                dt.Rows.Add(row);
            }
        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                int temp = inventory_datagrid.CurrentCell.RowIndex;
                FirebaseResponse response = await client.DeleteTaskAsync("products/" + keys[temp]);
                dt.Rows.RemoveAt(temp);
                keys.RemoveAt(temp);
                MessageBox.Show("Deleted Successfully");
             

            }
            catch(Exception)
            {
                MessageBox.Show("Please select a row to delete");
            }
            }

        private void inventory_datagrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRow = inventory_datagrid.CurrentCell.RowIndex;
            if (selectedRow < 0 || selectedRow >= productList.Count)
            {
                MessageBox.Show("Please select a valid box!");
            }
            else
            {
                name_editText.Text = productList[selectedRow].name;
                price_editText.Text = productList[selectedRow].price;
                description_editText.Text = productList[selectedRow].description;
                quantity_editText.Text = productList[selectedRow].quantity;
                image_editText.Text = productList[selectedRow].image;
                discount_editText.Text = productList[selectedRow].discount;

                if (productList[selectedRow].featured == false)
                {
                    featured_list.SelectedIndex = 0;
                }
                else featured_list.SelectedIndex = 1;

                if (productList[selectedRow].prescription == false)
                {
                    prescription_list.SelectedIndex = 0;
                }
                else prescription_list.SelectedIndex = 1;
              
            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            Products_class product = productList[selectedRow];

            if (product.name != name_editText.Text)
            {
                product.name = name_editText.Text;
                inventory_datagrid.Rows[selectedRow].Cells[0].Value =product.name;
            }

            if (product.price != price_editText.Text)
            {
                product.price = price_editText.Text;
                inventory_datagrid.Rows[selectedRow].Cells[1].Value = product.price;
            }

            if (product.quantity != quantity_editText.Text)
            {
                product.quantity = quantity_editText.Text;
                inventory_datagrid.Rows[selectedRow].Cells[2].Value = product.quantity;
            }

            if (product.discount != discount_editText.Text)
            {
                product.discount = discount_editText.Text;
                inventory_datagrid.Rows[selectedRow].Cells[3].Value = product.discount;
            }

            if (product.description != description_editText.Text)
            {
                product.description = description_editText.Text;
                inventory_datagrid.Rows[selectedRow].Cells[4].Value = product.description;
            }

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

            product.image = image_editText.Text;
            product.featured = temp1;
            product.prescription = temp2;
            inventory_datagrid.Rows[selectedRow].Cells[5].Value = product.featured;
            inventory_datagrid.Rows[selectedRow].Cells[6].Value = product.prescription;
            try
            {
                FirebaseResponse response = await client.UpdateTaskAsync("products/" + keys[selectedRow], product);
                //setting values to default
                name_editText.Text = "";
                price_editText.Text = "";
                description_editText.Text = "";
                prescription_list.SelectedIndex = 0;
                featured_list.SelectedIndex = 0;
                discount_editText.Text = "0";
                quantity_editText.Text = "";
                image_editText.Text = "";

                MessageBox.Show("Updated Successfully!");
            }

            catch (Exception)
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void inventory_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
