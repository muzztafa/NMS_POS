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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void invoices_btn_Click(object sender, EventArgs e)
        {
            Invoices invoice = new Invoices();
            invoice.Show();
            Hide();
        }
    }
}
