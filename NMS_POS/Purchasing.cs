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
    public partial class Purchasing : Form
    {
        List<string> keys = new List<string>();
        public List<PurchaseOrder_class> orderList = new List<PurchaseOrder_class>();

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


        public Purchasing()
        {
            InitializeComponent();
        }

        private void newPurchase_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Purchase np = new New_Purchase();
            np.Show();
        }

        private void Purchasing_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            dt.Columns.Add("Purchase Order #");
            dt.Columns.Add("TimeStamp");
            dt.Columns.Add("Total Bill");

            purchasing_datagrid.DataSource = dt;


            updateOrders();
        }

        private async void updateOrders()
        {
            try
            {
                FirebaseResponse resp = await client.GetTaskAsync("purchases/");
                Dictionary<string, PurchaseOrder_class> dict = resp.ResultAs<Dictionary<string, PurchaseOrder_class>>();


                //Adding product keys to Array Keys
                foreach (KeyValuePair<string, PurchaseOrder_class> ele1 in dict)
                {
                    keys.Add(ele1.Key);

                }

                //traversing list keys to fetch product details
                for (int i = 0; i < keys.Count; i++)
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("purchases/" + keys[i]);
                    PurchaseOrder_class order = resp2.ResultAs<PurchaseOrder_class>();

                    orderList.Add(order);


                    //Adding firebase data to the data grid
                    DataRow row = dt.NewRow();
                    row["Purchase Order #"] = orderList[i].orderNo;
                    row["TimeStamp"] = orderList[i].orderDate;
                    row["Total Bill"] = orderList[i].totalBill;

                    dt.Rows.Add(row);
                    //   Console.WriteLine("Row added");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connectivity Error.\nCheck your INTERNET and try again.");
            }
        }
        private void purchasing_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = purchasing_datagrid.CurrentCell.RowIndex;
            if (temp < 0 || temp >= orderList.Count)
            {
                MessageBox.Show("Please select a valid order!");
            }
            else
            {
                // Console.WriteLine("temp:" + temp);

                Modal_Purchases_Detail md = new Modal_Purchases_Detail(temp, orderList, orderList[temp].vendor);
                md.Show();
            }



        }
    }
}
