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
            updateInvoice();
            }

        private async void updateInvoice() {
            FirebaseResponse resp = await client.GetTaskAsync("Counter/node");
            Counter_class get = resp.ResultAs<Counter_class>();

            MessageBox.Show(get.cnt);
        }

        private void newInvoice_btn_Click(object sender, EventArgs e)
        {
            Hide();
            New_Invoice ni = new New_Invoice();
            ni.Show();
        }
    }

    

    }

