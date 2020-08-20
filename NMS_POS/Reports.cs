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
    public partial class Reports : Form
    {
        IFirebaseClient client;
        bool custom = false;
        DataTable dt = new DataTable();
        string currentDate = DateTime.Now.ToString("d");

        //mode = 0 means sales, 1 means purchases is selected
        int mode = 0;

        //these lists will be used for details activities
        List<Invoices_class> InvoicesList = new List<Invoices_class>();
        List<PurchaseOrder_class> PurchasesList = new List<PurchaseOrder_class>();


        List<string> salesKeys = new List<string>();
        List<Invoices_class> salesList = new List<Invoices_class>();

        List<string> purchasesKeys = new List<string>();
        List<PurchaseOrder_class> purchasesList = new List<PurchaseOrder_class>();



        public Reports()
        {
            InitializeComponent();
        }

        

        private void Reports_Load(object sender, EventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "m6NNKfbxyufWFj9YzHObMf2LTPXB9caps9qNjCrs",
                BasePath = "https://nms-pharmacy-e0da6.firebaseio.com/"
            };


            client = new FireSharp.FirebaseClient(config);

            try
            {
                Load_Invoices();
                Load_Purchases();
            }
            catch (Exception)
            {
                MessageBox.Show("Error connecting to the database. Check your internet connection and restart the application.");
            }

            searchBy_list.Items.Add("Today");
            searchBy_list.Items.Add("This Week");
            searchBy_list.Items.Add("This Month");
            searchBy_list.SelectedIndex = 0;

            selection_list.Items.Add("Sales");
            selection_list.Items.Add("Purchases");
            selection_list.SelectedIndex = 0;

            fromDate_editText.Visible = false;
            fromDate_label.Visible = false;
            toDate_editText.Visible = false;
            toDate_label.Visible = false;

            format_label.Visible = false;
        }

        private void customSearch_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            bool check = customSearch_checkbox.Checked;
            //if checkbox is ticked
            if (check)
            {
                searchBy_list.Enabled = false;
                //selection_list.Enabled = false;
                fromDate_editText.Visible = true;
                fromDate_label.Visible = true;
                toDate_editText.Visible = true;
                toDate_label.Visible = true;
                format_label.Visible = true;

                custom = true;

            }

            else
            {
                searchBy_list.Enabled = true;
                selection_list.Enabled = true;
                fromDate_editText.Visible = false;
                fromDate_label.Visible = false;
                toDate_editText.Visible = false;
                toDate_label.Visible = false;
                format_label.Visible = false;

                custom = false;
            }
        }

        private async void Load_Invoices()
        {
            try
            {
                FirebaseResponse resp = await client.GetTaskAsync("invoices/");
                Dictionary<string, Invoices_class> dict = resp.ResultAs<Dictionary<string, Invoices_class>>();

                //Adding invoice keys to Array salesKeys
                foreach (KeyValuePair<string, Invoices_class> ele1 in dict)
                {
                    salesKeys.Add(ele1.Key);

                }

                //traversing list keys to fetch invoice details
                for (int i = 0; i < salesKeys.Count; i++)
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("invoices/" + salesKeys[i]);
                    Invoices_class invoice = resp2.ResultAs<Invoices_class>();
                    salesList.Add(invoice);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error connecting to the database. Check your internet connection and restart the application.");
            }
        }

        private async void Load_Purchases()
        {
            try
            {
                FirebaseResponse resp = await client.GetTaskAsync("purchases/");
                Dictionary<string, PurchaseOrder_class> dict = resp.ResultAs<Dictionary<string, PurchaseOrder_class>>();

                //Adding invoice keys to Array salesKeys
                foreach (KeyValuePair<string, PurchaseOrder_class> ele1 in dict)
                {
                    purchasesKeys.Add(ele1.Key);

                }

                //traversing list keys to fetch invoice details
                for (int i = 0; i < purchasesKeys.Count; i++)
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("purchases/" + purchasesKeys[i]);
                    PurchaseOrder_class order = resp2.ResultAs<PurchaseOrder_class>();
                    purchasesList.Add(order);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error connecting to the database. Check your internet connection and restart the application.");
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            int index = selection_list.SelectedIndex;
            if (index == 0) { mode = 0; } else mode = 1;

            //if custom reporting is selected
            if (custom)
            {
                //custom search for sales
                if(index == 0)
                {
                    Custom_Search_Sales();
                }
                //custom search for purchases
                else
                {
                    Custom_Search_Purchases();
                }
            }

            else
            {

                
                //if sales is selected
                if (index == 0)
                {
                    int index_searchBy = searchBy_list.SelectedIndex;

                    //searchby == today
                    if (index_searchBy == 0)
                    {
                        Get_Sales_Today();
                    }
                    //searchby == this week
                    else if (index_searchBy == 1)
                    {
                        Get_Sales_ThisWeek();
                    }
                    //searchby == this month
                    else
                    {
                        Get_Sales_ThisMonth();
                    }
                }
                //for purchases reports
                else
                {
                    int index_searchBy = searchBy_list.SelectedIndex;

                    //searchby == today
                    if (index_searchBy == 0)
                    {
                        Get_Purchases_Today();
                    }
                    //searchby == this week
                    else if (index_searchBy == 1)
                    {
                        Get_Purchases_ThisWeek();
                    }
                    //searchby == this month
                    else
                    {
                        Get_Purchases_ThisMonth();
                    }
                }
            }
        }

        private void Get_Sales_Today()
        {
            List<Invoices_class> list = new List<Invoices_class>();

            for (int i = 0; i < salesList.Count; i++)
            {
                string timestamp = salesList[i].timestamp;
                string [] temp = timestamp.Split(' ');
                string date = temp[0];

                if(date == currentDate) {
                    list.Add(salesList[i]);
                }
            }

            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("Cashier's Name");
            dt.Columns.Add("Invoice No");
            dt.Columns.Add("Time Stamp");
            dt.Columns.Add("Total Bill");

            datagrid.DataSource = dt;

            double temp2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["Cashier's Name"] = list[i].cashier;
                row["Invoice No"] = list[i].invoiceNo;
                row["Time Stamp"] = list[i].timestamp;
                row["Total Bill"] = list[i].totalBill;

                dt.Rows.Add(row);

                temp2 += double.Parse(list[i].totalBill);
            }
            totalBill_label.Text = temp2 + "";
            noOfRecords_label.Text = "" + list.Count;
            InvoicesList = list;

            //if list is empty
            if (!list.Any())
            {
                MessageBox.Show("No records found for the requested query.");
            }
        }

        private void Get_Sales_ThisWeek()
        {
            List<Invoices_class> list = new List<Invoices_class>();
            List<string> lastSevenDates = new List<string>();

            DateTime dateTime = DateTime.Now;
            //adding current date too
            lastSevenDates.Add(dateTime.ToString("d"));

            for (int i = 0; i < 7; i++)
            {
                dateTime = dateTime.AddDays(-1);
                lastSevenDates.Add(dateTime.ToString("d"));
            }

            for (int i = 0; i < salesList.Count; i++)
            {
                string timestamp = salesList[i].timestamp;
                string[] temp = timestamp.Split(' ');
                string date = temp[0];

                for (int j = 0; j < lastSevenDates.Count; j++)
                {
                    if(date == lastSevenDates[j])
                    {
                        list.Add(salesList[i]);
                    }
                }

            }

            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("Cashier's Name");
            dt.Columns.Add("Invoice No");
            dt.Columns.Add("Time Stamp");
            dt.Columns.Add("Total Bill");

            datagrid.DataSource = dt;

            double temp2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["Cashier's Name"] = list[i].cashier;
                row["Invoice No"] = list[i].invoiceNo;
                row["Time Stamp"] = list[i].timestamp;
                row["Total Bill"] = list[i].totalBill;

                dt.Rows.Add(row);

                temp2 += double.Parse(list[i].totalBill);
            }
            totalBill_label.Text = temp2 + "";
            noOfRecords_label.Text = "" + list.Count;
            InvoicesList = list;

            //if list is empty
            if (!list.Any())
            {
                MessageBox.Show("No records found for the requested query.");
            }

        }

        private void Get_Sales_ThisMonth()
        {
            List<Invoices_class> list = new List<Invoices_class>();
            string[] breaker = currentDate.Split('/');
            string currentMonth = breaker[0];
            string currentYear = breaker[2];

            for (int i = 0; i < salesList.Count; i++)
            {
                string timestamp = salesList[i].timestamp;
                string[] temp = timestamp.Split(' ');
                string date = temp[0];
                string[] breaker2 = date.Split('/');

                    if (currentMonth == breaker2[0] && currentYear == breaker2[2])
                    {
                        list.Add(salesList[i]);
                    }   

            }

            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("Cashier's Name");
            dt.Columns.Add("Invoice No");
            dt.Columns.Add("Time Stamp");
            dt.Columns.Add("Total Bill");

            datagrid.DataSource = dt;

            double temp2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["Cashier's Name"] = list[i].cashier;
                row["Invoice No"] = list[i].invoiceNo;
                row["Time Stamp"] = list[i].timestamp;
                row["Total Bill"] = list[i].totalBill;

                dt.Rows.Add(row);

                temp2 += double.Parse(list[i].totalBill);
            }
            totalBill_label.Text = temp2 + "";
            noOfRecords_label.Text = "" + list.Count;
            InvoicesList = list;

            //if list is empty
            if (!list.Any())
            {
                MessageBox.Show("No records found for the requested query.");
            }
        }











        private void Get_Purchases_Today()
        {
            List<PurchaseOrder_class> list = new List<PurchaseOrder_class>();

            for (int i = 0; i < purchasesList.Count; i++)
            {
                string timestamp =purchasesList[i].orderDate;
                string[] temp = timestamp.Split(' ');
                string date = temp[0];

                if (date == currentDate)
                {
                    list.Add(purchasesList[i]);
                }
            }

            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("Vendor's Name");
            dt.Columns.Add("Order No");
            dt.Columns.Add("Time Stamp");
            dt.Columns.Add("Total Bill");

            datagrid.DataSource = dt;

            double temp2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["Vendor's Name"] = list[i].vendor.name;
                row["Order No"] = list[i].orderNo;
                row["Time Stamp"] = list[i].orderDate;
                row["Total Bill"] = list[i].totalBill;

                temp2 += double.Parse(list[i].totalBill);
                dt.Rows.Add(row);
            }
            totalBill_label.Text = "" + temp2;
            noOfRecords_label.Text = "" + list.Count;
            PurchasesList = list;

            //if list is empty
            if (!list.Any())
            {
                MessageBox.Show("No records found for the requested query.");
            }
        }

        private void Get_Purchases_ThisWeek()
        {
            List<PurchaseOrder_class> list = new List<PurchaseOrder_class>();
            List<string> lastSevenDates = new List<string>();

            DateTime dateTime = DateTime.Now;
            //adding current date too
            lastSevenDates.Add(dateTime.ToString("d"));

            for (int i = 0; i < 7; i++)
            {
                dateTime = dateTime.AddDays(-1);
                lastSevenDates.Add(dateTime.ToString("d"));
            }

            for (int i = 0; i < purchasesList.Count; i++)
            {
                string timestamp = purchasesList[i].orderDate;
                string[] temp = timestamp.Split(' ');
                string date = temp[0];

                for (int j = 0; j < lastSevenDates.Count; j++)
                {
                    if (date == lastSevenDates[j])
                    {
                        list.Add(purchasesList[i]);
                    }
                }

            }

            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("Vendor's Name");
            dt.Columns.Add("Order No");
            dt.Columns.Add("Time Stamp");
            dt.Columns.Add("Total Bill");

            datagrid.DataSource = dt;

            double temp2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["Vendor's Name"] = list[i].vendor.name;
                row["Order No"] = list[i].orderNo;
                row["Time Stamp"] = list[i].orderDate;
                row["Total Bill"] = list[i].totalBill;

                temp2 += double.Parse(list[i].totalBill);
                dt.Rows.Add(row);
            }
            totalBill_label.Text = "" + temp2;
            noOfRecords_label.Text = "" + list.Count;
            PurchasesList = list;

            //if list is empty
            if (!list.Any())
            {
                MessageBox.Show("No records found for the requested query.");
            }
        }

        private void Get_Purchases_ThisMonth()
        {
            List<PurchaseOrder_class> list = new List<PurchaseOrder_class>();
            string[] breaker = currentDate.Split('/');
            string currentMonth = breaker[0];
            string currentYear = breaker[2];

            for (int i = 0; i < purchasesList.Count; i++)
            {
                string timestamp = purchasesList[i].orderDate;
                string[] temp = timestamp.Split(' ');
                string date = temp[0];
                string[] breaker2 = date.Split('/');

                if (currentMonth == breaker2[0] && currentYear == breaker2[2])
                {
                    list.Add(purchasesList[i]);
                }

            }

            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("Vendor's Name");
            dt.Columns.Add("Order No");
            dt.Columns.Add("Time Stamp");
            dt.Columns.Add("Total Bill");

            datagrid.DataSource = dt;

            double temp2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["Vendor's Name"] = list[i].vendor.name;
                row["Order No"] = list[i].orderNo;
                row["Time Stamp"] = list[i].orderDate;
                row["Total Bill"] = list[i].totalBill;

                temp2 += double.Parse(list[i].totalBill);
                dt.Rows.Add(row);
            }
            totalBill_label.Text = "" + temp2;
            noOfRecords_label.Text = "" + list.Count;

            PurchasesList = list;

            //if list is empty
            if (!list.Any())
            {
                MessageBox.Show("No records found for the requested query.");
            }
        }






        private void Custom_Search_Sales()
        {
            List<Invoices_class> list = new List<Invoices_class>();
            List<string> totalDatesList = new List<string>();


            string fromDate = fromDate_editText.Text;
            string toDate = toDate_editText.Text;

            if(fromDate == "")
            {
                MessageBox.Show("Please enter a date to search first.");
            }

            //searching for a single date
            else if (toDate == "" && fromDate!="") {

                for (int i = 0; i < salesList.Count; i++)
                {
                    string timestamp = salesList[i].timestamp;
                    string[] temp = timestamp.Split(' ');
                    string date = temp[0];

                    if (date == fromDate)
                    {
                        list.Add(salesList[i]);
                    }
                }

                dt.Clear();
                dt.Columns.Clear();

                dt.Columns.Add("Cashier's Name");
                dt.Columns.Add("Invoice No");
                dt.Columns.Add("Time Stamp");
                dt.Columns.Add("Total Bill");

                datagrid.DataSource = dt;

                double temp2 = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row["Cashier's Name"] = list[i].cashier;
                    row["Invoice No"] = list[i].invoiceNo;
                    row["Time Stamp"] = list[i].timestamp;
                    row["Total Bill"] = list[i].totalBill;

                    dt.Rows.Add(row);

                    temp2 += double.Parse(list[i].totalBill);
                }
                totalBill_label.Text = temp2 + "";
                noOfRecords_label.Text = "" + list.Count;
                InvoicesList = list;

                //if list is empty
                if (!list.Any())
                {
                    MessageBox.Show("No records found for the requested query.");
                }
            }

            else if(fromDate != "" && toDate != "")
            {
                try
                {
                    DateTime dt1 = DateTime.Parse(fromDate);
                    DateTime dt2 = DateTime.Parse(toDate);
                }
                catch (Exception)
                {
                    MessageBox.Show("Date Format Error! Please provide dates in the given format.");
                }
                
                //DateTime t = DateTime.Parse(fromDate);
                //Console.WriteLine("S " + t);

                DateTime dateTime = DateTime.Parse(fromDate);
                //adding current date too
                totalDatesList.Add(dateTime.ToString("d"));

                while(true)
                {
                    if (dateTime.ToString("d") == DateTime.Parse(toDate).ToString("d"))
                    {
                        break;
                    }
                   // Console.WriteLine("da " + dateTime);
                    dateTime = dateTime.AddDays(+1);
                    totalDatesList.Add(dateTime.ToString("d"));
                }


               // for (int i = 0; i < totalDatesList.Count; i++)
                //{
                  //  Console.WriteLine("D: " + totalDatesList[i]);
                //}

                for (int i = 0; i < salesList.Count; i++)
                {
                    string timestamp = salesList[i].timestamp;
                    string[] temp = timestamp.Split(' ');
                    string date = temp[0];

                    for (int j = 0; j < totalDatesList.Count; j++)
                    {
                        if (date == totalDatesList[j])
                        {
                            list.Add(salesList[i]);
                        }
                    }

                }

                dt.Clear();
                dt.Columns.Clear();

                dt.Columns.Add("Cashier's Name");
                dt.Columns.Add("Invoice No");
                dt.Columns.Add("Time Stamp");
                dt.Columns.Add("Total Bill");

                datagrid.DataSource = dt;

                double temp2 = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row["Cashier's Name"] = list[i].cashier;
                    row["Invoice No"] = list[i].invoiceNo;
                    row["Time Stamp"] = list[i].timestamp;
                    row["Total Bill"] = list[i].totalBill;

                    dt.Rows.Add(row);

                    temp2 += double.Parse(list[i].totalBill);
                }
                totalBill_label.Text = temp2 + "";
                noOfRecords_label.Text = "" + list.Count;

                InvoicesList = list;

                //if list is empty
                if (!list.Any())
                {
                    MessageBox.Show("No records found for the requested query.");
                }
            }

        }

        private void Custom_Search_Purchases()
        {
            List<PurchaseOrder_class> list = new List<PurchaseOrder_class>();
            List<string> totalDatesList = new List<string>();


            string fromDate = fromDate_editText.Text;
            string toDate = toDate_editText.Text;

            if (fromDate == "")
            {
                MessageBox.Show("Please enter a date to search first.");
            }

            //searching for a single date
            else if (toDate == "" && fromDate != "")
            {

                for (int i = 0; i < purchasesList.Count; i++)
                {
                    string timestamp = purchasesList[i].orderDate;
                    string[] temp = timestamp.Split(' ');
                    string date = temp[0];

                    if (date == fromDate)
                    {
                        list.Add(purchasesList[i]);
                    }
                }

                dt.Clear();
                dt.Columns.Clear();

                dt.Columns.Add("Vendor's Name");
                dt.Columns.Add("Order No");
                dt.Columns.Add("Time Stamp");
                dt.Columns.Add("Total Bill");

                datagrid.DataSource = dt;

                double temp2 = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row["Vendor's Name"] = list[i].vendor.name;
                    row["Order No"] = list[i].orderNo;
                    row["Time Stamp"] = list[i].orderDate;
                    row["Total Bill"] = list[i].totalBill;

                    temp2 += double.Parse(list[i].totalBill);
                    dt.Rows.Add(row);
                }
                totalBill_label.Text = "" + temp2;
                noOfRecords_label.Text = "" + list.Count;

                PurchasesList = list;

                //if list is empty
                if (!list.Any())
                {
                    MessageBox.Show("No records found for the requested query.");
                }
            }

            else if (fromDate != "" && toDate != "")
            {
                try
                {
                    DateTime dt1 = DateTime.Parse(fromDate);
                    DateTime dt2 = DateTime.Parse(toDate);
                }
                catch (Exception)
                {
                    MessageBox.Show("Date Format Error! Please provide dates in the given format.");
                }

                //DateTime t = DateTime.Parse(fromDate);
                //Console.WriteLine("S " + t);

                DateTime dateTime = DateTime.Parse(fromDate);
                //adding current date too
                totalDatesList.Add(dateTime.ToString("d"));

                while (true)
                {
                    if (dateTime.ToString("d") == DateTime.Parse(toDate).ToString("d"))
                    {
                        break;
                    }
                    //Console.WriteLine("da " + dateTime);
                    dateTime = dateTime.AddDays(+1);
                    totalDatesList.Add(dateTime.ToString("d"));
                }


                // for (int i = 0; i < totalDatesList.Count; i++)
                //{
                //  Console.WriteLine("D: " + totalDatesList[i]);
                //}

                for (int i = 0; i < purchasesList.Count; i++)
                {
                    string timestamp = purchasesList[i].orderDate;
                    string[] temp = timestamp.Split(' ');
                    string date = temp[0];

                    for (int j = 0; j < totalDatesList.Count; j++)
                    {
                        if (date == totalDatesList[j])
                        {
                            list.Add(purchasesList[i]);
                        }
                    }

                }

                dt.Clear();
                dt.Columns.Clear();

                dt.Columns.Add("Vendor's Name");
                dt.Columns.Add("Order No");
                dt.Columns.Add("Time Stamp");
                dt.Columns.Add("Total Bill");

                datagrid.DataSource = dt;

                double temp2 = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row["Vendor's Name"] = list[i].vendor.name;
                    row["Order No"] = list[i].orderNo;
                    row["Time Stamp"] = list[i].orderDate;
                    row["Total Bill"] = list[i].totalBill;

                    temp2 += double.Parse(list[i].totalBill);
                    dt.Rows.Add(row);
                }
                totalBill_label.Text = "" + temp2;
                noOfRecords_label.Text = "" + list.Count;

                PurchasesList = list;

                //if list is empty
                if (!list.Any())
                {
                    MessageBox.Show("No records found for the requested query.");
                }
            }
        }

        private void datagrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mode == 0)
            {
                int temp = datagrid.CurrentCell.RowIndex;
                if (temp < 0 || temp >= InvoicesList.Count)
                {
                    MessageBox.Show("Please select a valid invoice!");
                }
                else
                {
                    // Console.WriteLine("temp:" + temp);

                    Modal_Invoices_Detail md = new Modal_Invoices_Detail(temp, InvoicesList);
                    md.Show();
                }
            }

            else
            {
                int temp = datagrid.CurrentCell.RowIndex;
                if (temp < 0 || temp >= PurchasesList.Count)
                {
                    MessageBox.Show("Please select a valid order!");
                }
                else
                {
                    // Console.WriteLine("temp:" + temp);

                    Modal_Purchases_Detail md = new Modal_Purchases_Detail(temp, PurchasesList, PurchasesList[temp].vendor);
                    md.Show();
                }
            }
        }
    }
}
