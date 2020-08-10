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
    public partial class Add_Vendor : Form
    {
        public Vendor_class vendor;
        public bool inserted = false;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "m6NNKfbxyufWFj9YzHObMf2LTPXB9caps9qNjCrs",
            BasePath = "https://nms-pharmacy-e0da6.firebaseio.com/"
        };
        IFirebaseClient client;

        public Add_Vendor()
        {
            InitializeComponent();
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if(name_editText.Text!="" && name_editText.Text != null)
            {
                if(mobileNo_editText.Text.Count() == 11) {
                   
                    try
                    {
                        vendor = new Vendor_class
                        {
                            name = name_editText.Text,
                            mobileNo = mobileNo_editText.Text
                        };

                        PushResponse response = await client.PushTaskAsync("vendors", vendor);
                        Vendor_class result = response.ResultAs<Vendor_class>();
                        MessageBox.Show("Vendor Added Successfully!");
                        
                        
                        this.Hide();
                        New_Purchase np = new New_Purchase();
                        np.Show();
                    }
                    catch (Exception)
                    {
                        //inserted = false;
                        MessageBox.Show("Failed to add vendor. Check your internet connectivity.");
                    }
                }

                else
                {
                    MessageBox.Show("Mobile Number invalid!");
                }
            }

            else
            {
                MessageBox.Show("Name invalid!");
                }



        }

        private void Add_Vendor_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}
