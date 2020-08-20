using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NMS_POS
{
    public partial class New_Purchase : Form
    {
        public List<string> vendorKeys = new List<string>();
        public List<Vendor_class> vendorList = new List<Vendor_class>();

        List<string> keys = new List<string>();
        List<Products_class> productList = new List<Products_class>();
        //this list is used for purchases node
        List<Products_class> selectedProductsList = new List<Products_class>();
        
        //List<string> selectedKeys = new List<string>();

        //these lists are used to update inventory
        List<Products_class> selectedProductsListUPDATE = new List<Products_class>();
        List<string> keysUPDATE = new List<string>();
        List<Products_class> newProductList = new List<Products_class>();



        DataTable dt = new DataTable();


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "m6NNKfbxyufWFj9YzHObMf2LTPXB9caps9qNjCrs",
            BasePath = "https://nms-pharmacy-e0da6.firebaseio.com/"
        };
        IFirebaseClient client;

        public New_Purchase()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addVendor_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Vendor av = new Add_Vendor();
            av.Show();
            
        }

        private void vendor_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void New_Purchase_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
           

            quantity_editText.Text = "1";
           // cashier_editText.Text = "Admin";
            orderNo_editText.Text = "1000";
            orderDate_editText.Text = DateTime.Now.ToString();
            orderDate_editText.Enabled = false;

            featured_list.Items.Add(false);
            featured_list.Items.Add(true);

            prescription_list.Items.Add(false);
            prescription_list.Items.Add(true);

            featured_list.SelectedIndex = 0;
            prescription_list.SelectedIndex = 0;

            discount_editText.Text = "0";

            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Discount");
            dt.Columns.Add("Total");
            dt.Columns.Add("Description");
            dt.Columns.Add("Featured");
            dt.Columns.Add("Prescription");
            dt.Columns.Add("Date");

            products_grid.DataSource = dt;

            updateVendorList();
            updateProductsList();


        }

        public async void updateVendorList()
        {
            try
            {
                FirebaseResponse resp = await client.GetTaskAsync("vendors/");
                Dictionary<string, Vendor_class> dict = resp.ResultAs<Dictionary<string, Vendor_class>>();



                //Adding vendor keys to Array vendorKeys
                foreach (KeyValuePair<string, Vendor_class> ele1 in dict)
                {
                    vendorKeys.Add(ele1.Key);
                    // Console.WriteLine("{0} and {1}",
                    //  ele1.Key, ele1.Value);
                }

                //traversing list vendorkeys to fetch vendor details
                for (int i = 0; i < vendorKeys.Count; i++)
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("vendors/" + vendorKeys[i]);
                    Vendor_class vendor = resp2.ResultAs<Vendor_class>();
                    vendor_list.Items.Add(vendor.name);
                    vendorList.Add(vendor);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cant download available vendors. Add a vendor and/or check your internet connection.");
            }
        }

        private async void updateProductsList()
        {
            try
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
                product_list.Items.Add(product.name);


            }

                
            }
            catch (Exception)
            {
                MessageBox.Show("Cant connect to FIREBASE. Check your internet connection!");
            }
        }

        private void addNewItem_btn_Click(object sender, EventArgs e)
        {
            New_Item ni = new New_Item();
            ni.Show();
            this.Hide();
        }

        private async void addToOrder_btn_Click(object sender, EventArgs e)
        {
            if (name_editText.Text == "" || name_editText == null)
            {
                MessageBox.Show("Fill Name field first.");
            }

            else if (price_editText.Text == "" || price_editText == null)
            {
                MessageBox.Show("Fill price field first.");
            }

            

            else if (quantity_editText.Text == "" || quantity_editText == null)
            {
                MessageBox.Show("Fill quantity field first.");
            }

            else
            {
                bool check = false;
                int indexFound = -1;

                for (int i = 0; i < productList.Count; i++)
                {
                    if (name_editText.Text.ToLower() == productList[i].name.ToLower())
                    {
                        check = true;
                        indexFound = i;
                        break;
                    }

                }

                if (!check)
                {
                    //Adding product to firebase if it doesn't exist
                    Products_class product = new Products_class(description_editText.Text, discount_editText.Text, false, image_editText.Text + "", name_editText.Text, false, double.Parse(price_editText.Text), int.Parse(quantity_editText.Text), DateTime.Now.ToString());

                    //PushResponse response = await client.PushTaskAsync("products", product);

                    //productList.Add(product);
                    //product_list.Items.Add(product.name);

                    newProductList.Add(product);

                    //FirebaseResponse resp = await client.GetTaskAsync("products/");
                    //Dictionary<string, Products_class> dict = resp.ResultAs<Dictionary<string, Products_class>>();

                    //Adding new key to keys array
                  /*  foreach (KeyValuePair<string, Products_class> ele1 in dict)
                    {
                        if (!keys.Contains(ele1.Key))
                        {
                            keys.Add(ele1.Key);
                            break;
                        }

                    }*/

                    //adding new row to DT
                    DataRow row = dt.NewRow();
                    row["Name"] = product.name;
                    row["Price"] = product.price;
                    row["Quantity"] = product.quantity;
                    row["Discount"] = product.discount;
                    row["Total"] = "" +product.quantity * product.price;
                    row["Description"] = product.description;
                    row["Featured"] = product.featured;
                    row["Prescription"] = product.prescription;
                    row["Date"] = product.timestamp;

                    dt.Rows.Add(row);

                    totalBill_label.Text = "" + (double.Parse(totalBill_label.Text)+product.quantity * product.price);

                    name_editText.Text = "";

                }

                else
                {
                    //MessageBox.Show("Product already exists in the inventory.");
                    Products_class product = new Products_class(description_editText.Text, discount_editText.Text, false, image_editText.Text + "", name_editText.Text, false, double.Parse(price_editText.Text), Int32.Parse(quantity_editText.Text) + productList[indexFound].quantity, DateTime.Now.ToString());
                    Products_class product2 = new Products_class(description_editText.Text, discount_editText.Text, false, image_editText.Text + "", name_editText.Text, false, double.Parse(price_editText.Text), int.Parse(quantity_editText.Text), DateTime.Now.ToString());

                    //adding new row to DT
                    DataRow row = dt.NewRow();
                    row["Name"] = product.name;
                    row["Price"] = product.price;
                    row["Quantity"] = quantity_editText.Text;
                    row["Discount"] = product.discount;
                    row["Total"] = "" + double.Parse(quantity_editText.Text) * product.price;
                    row["Description"] = product.description;
                    row["Featured"] = product.featured;
                    row["Prescription"] = product.prescription;
                    row["Date"] = product.timestamp;
                    

                    dt.Rows.Add(row);

                    totalBill_label.Text = "" + (double.Parse(totalBill_label.Text) + double.Parse(quantity_editText.Text) * product.price);

                    selectedProductsListUPDATE.Add(product);
                    keysUPDATE.Add(keys[indexFound]);
                    selectedProductsList.Add(product2);

                    //FirebaseResponse resp = await client.SetTaskAsync<Products_class>("products/"+keys[indexFound],product);
                    //Products_class result = resp.ResultAs<Products_class>();

                    //MessageBox.Show("Updated SUCCESSFULLY");
                    name_editText.Text = "";
                }
            }
        }

        private void product_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = product_list.SelectedIndex;
                name_editText.Text = productList[index].name;
            }
            catch (Exception)
            {

            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {

                int temp = products_grid.CurrentCell.RowIndex;
                string name = products_grid.Rows[temp].Cells[0].Value.ToString();
             

                for (int i = 0; i < selectedProductsList.Count; i++)
                {
                    if(name == selectedProductsList[i].name)
                    {
                        totalBill_label.Text = "" + (double.Parse(totalBill_label.Text) - (selectedProductsList[i].price * selectedProductsList[i].quantity));
                        selectedProductsList.RemoveAt(i);
                        //Console.WriteLine("Removec from selectproduclis");
                        break;

                        
                    }
                }

                for (int i = 0; i < selectedProductsListUPDATE.Count; i++)
                {
                    if (name == selectedProductsListUPDATE[i].name)
                    {
                        selectedProductsListUPDATE.RemoveAt(i);
                        break;

                    }
                }

                for (int i = 0; i < newProductList.Count; i++)
                {
                    if (name == newProductList[i].name)
                    {
                        totalBill_label.Text = "" + (double.Parse(totalBill_label.Text) - (newProductList[i].price * newProductList[i].quantity));
                        newProductList.RemoveAt(i);
                       // Console.WriteLine("Removec from newproduclis");
                            break;

                    }
                }

                

                
                // selectedProductList.RemoveAt(temp);
                // selectedKeys.RemoveAt(temp);
                // selectedQuantity.RemoveAt(temp);
                dt.Rows.RemoveAt(temp);
                MessageBox.Show("Deleted Successfully");


            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to delete");

            }
        }

        private async void createOrder_btn_Click(object sender, EventArgs e)
        {
            if (products_grid.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Please select a product first");
            }
            else
            {
                try
                {
                    Vendor_class v = vendorList[vendor_list.SelectedIndex];

                    List<Products_class> newList = new List<Products_class>();

                    newList = selectedProductsList.Concat(newProductList).ToList();

                    PurchaseOrder_class po = new PurchaseOrder_class
                    {
                        vendor = v,
                        orderNo = orderNo_editText.Text,
                        orderDate = orderDate_editText.Text,
                        totalBill = totalBill_label.Text,
                        productList = newList,
                        punchedBy = Form1.loggedInUser.name
                    };

                    try
                    {
                        PushResponse response = await client.PushTaskAsync("purchases", po);
                        PurchaseOrder_class p2 = response.ResultAs<PurchaseOrder_class>();
                        for (int i = 0; i < newProductList.Count; i++)
                        {
                            PushResponse res = await client.PushTaskAsync("products", newProductList[i]);
                            Products_class pp = res.ResultAs<Products_class>();
                        }

                        for (int i = 0; i < selectedProductsListUPDATE.Count; i++)
                        {
                            FirebaseResponse response2 = await client.UpdateTaskAsync("products/" + keysUPDATE[i], selectedProductsListUPDATE[i]);
                            Products_class product = response2.ResultAs<Products_class>();

                        }
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Error connecting to FIREBASE. Please check your internet connection!");
                    }

                    MessageBox.Show("Order added successfully");

                    this.Hide();
                    Purchasing p = new Purchasing();
                    p.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select a vendor first!");
                }
            }
        }

        private void products_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
