using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMS_POS
{
    public partial class Modal_Purchases_Detail : Form
    {
        int index;
        List<PurchaseOrder_class> orderList;
        Vendor_class vendor;
        DataTable dt = new DataTable();

        public Modal_Purchases_Detail(int temp, List<PurchaseOrder_class> orderList, Vendor_class vendor)
        {
            index = temp;
            this.orderList = orderList;
            this.vendor = vendor;

            InitializeComponent();
        }

        private void Modal_Purchases_Detail_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Discount");
            dt.Columns.Add("Description");
            dt.Columns.Add("Featured");
            dt.Columns.Add("Prescription");
            dt.Columns.Add("Date");

            invoicesDetails_grid.DataSource = dt;

            orderNo_editText.Text = orderList[index].orderNo;
            orderDate_editText.Text = orderList[index].orderDate;
            totalBill_editText.Text = orderList[index].totalBill;
            vendorName_editText.Text = vendor.name;
            vendorMobileNo_editText.Text = vendor.mobileNo;

            updateOrderList();


        }

        public void updateOrderList()
        {
            for (int i = 0; i < orderList[index].productList.Count; i++)
            {

                DataRow row = dt.NewRow();
                // Console.WriteLine("INDEX: " + index);
                row["Name"] = orderList[index].productList[i].name;
                row["Price"] = orderList[index].productList[i].price;
                row["Quantity"] = orderList[index].productList[i].quantity;
                row["Discount"] = orderList[index].productList[i].discount;
                row["Description"] = orderList[index].productList[i].description;
                row["Featured"] = orderList[index].productList[i].featured;
                row["Prescription"] = orderList[index].productList[i].prescription;
                row["Date"] = orderList[index].productList[i].timestamp;

                dt.Rows.Add(row);
            }
        
    }
    }
}
