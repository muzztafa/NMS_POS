﻿using System;
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
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (Form1.loggedInUser.role == "Cashier")
            {
                reports_btn.Visible = false;
                addUsers_btn.Visible = false;
            }
            else
            {
                reports_btn.Visible = true;
                addUsers_btn.Visible = true;
            }
        }

        private void reports_btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            i.Show();
                    }

        private void reports_btn_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.Show();
            
        }

        private void addUsers_btn_Click(object sender, EventArgs e)
        {
            Manage_Users mu = new Manage_Users();
            mu.Show();
            
        }

        private void purchase_btn_Click(object sender, EventArgs e)
        {
            Purchasing p = new Purchasing();
            p.Show();
        }
    }
}
