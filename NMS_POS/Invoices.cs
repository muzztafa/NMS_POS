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
    public partial class Invoices : Form
    {
        List<string> keys = new List<string>();
        public List<Invoices_class> invoicesList = new List<Invoices_class>();
        
        DataTable dt = new DataTable();

       // public static string invoiceNo = "";
        //public static string cashier = "";
        //public static string totalBill = "";
        
        

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "m6NNKfbxyufWFj9YzHObMf2LTPXB9caps9qNjCrs",
            BasePath = "https://nms-pharmacy-e0da6.firebaseio.com/"
        };

        IFirebaseClient client;

        public Invoices()
        {
            InitializeComponent();
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            dt.Columns.Add("Invoice #");
            dt.Columns.Add("Cashier");
            dt.Columns.Add("TimeStamp");
            dt.Columns.Add("Total Bill");

            invoices_datagrid.DataSource = dt;


            updateInvoice();
            }

        private  async void updateInvoice() {
            try
            {
                FirebaseResponse resp = await client.GetTaskAsync("invoices/");
                Dictionary<string, Products_class> dict = resp.ResultAs<Dictionary<string, Products_class>>();


                //Adding product keys to Array Keys
                foreach (KeyValuePair<string, Products_class> ele1 in dict)
                {
                    keys.Add(ele1.Key);
                   
                }

                //traversing list keys to fetch product details
                for (int i = 0; i < keys.Count; i++)
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("invoices/" + keys[i]);
                    Invoices_class invoice = resp2.ResultAs<Invoices_class>();
                   
                    invoicesList.Add(invoice);


                    //Adding firebase data to the data grid
                    DataRow row = dt.NewRow();
                    row["Invoice #"] = invoicesList[i].invoiceNo;
                    row["Cashier"] = invoicesList[i].cashier;
                    row["TimeStamp"] = invoicesList[i].timestamp;
                    row["Total Bill"] = invoicesList[i].totalBill;

                    dt.Rows.Add(row);
                 //   Console.WriteLine("Row added");
                }
            }
            catch (Exception)
            { 
               MessageBox.Show("Connectivity Error.\nCheck your INTERNET and try again.");
            }



        }

        private void newInvoice_btn_Click(object sender, EventArgs e)
        {
            Hide();
            New_Invoice ni = new New_Invoice();
            ni.Show();
        }

        private void invoices_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = invoices_datagrid.CurrentCell.RowIndex;
            if(temp<0 || temp >= invoicesList.Count)
            {
                MessageBox.Show("Please select a valid invoice!");
            }
            else
            {
               // Console.WriteLine("temp:" + temp);
               
                Modal_Invoices_Detail md = new Modal_Invoices_Detail(temp, invoicesList);
                md.Show();
            }
            
            
          
        }

        private void invoices_datagrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    

    }

