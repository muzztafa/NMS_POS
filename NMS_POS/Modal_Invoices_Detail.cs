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
    public partial class Modal_Invoices_Detail : Form
    {
        int index;
        List<Invoices_class> invoicesList;
        DataTable dt = new DataTable();

        public Modal_Invoices_Detail(int index, List<Invoices_class> list)
        {
            
            this.index = index;
            this.invoicesList = list;

            InitializeComponent();
        }

        private void invoicesDetails_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modal_Invoices_Detail_Load(object sender, EventArgs e)
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
            
                cashier_editText.Text = invoicesList[index].cashier;
                invoiceNo_editText.Text = invoicesList[index].invoiceNo;
                totalBill_editText.Text = invoicesList[index].totalBill;

                updateInvoiceList();
            
            
        }

        public void updateInvoiceList()
        {
            for (int i = 0; i < invoicesList[index].productList.Count; i++)
            {
             
                DataRow row = dt.NewRow();
               // Console.WriteLine("INDEX: " + index);
                row["Name"] = invoicesList[index].productList[i].name;
                row["Price"] = invoicesList[index].productList[i].price;
                row["Quantity"] = invoicesList[index].productList[i].quantity;
                row["Discount"] = invoicesList[index].productList[i].discount;
                row["Description"] = invoicesList[index].productList[i].description;
                row["Featured"] = invoicesList[index].productList[i].featured;
                row["Prescription"] = invoicesList[index].productList[i].prescription;
                row["Date"] = invoicesList[index].productList[i].timestamp;

                dt.Rows.Add(row);
            }
        }
    }
}
