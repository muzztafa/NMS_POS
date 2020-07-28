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
    public partial class Form1 : Form
    {
        
        IFirebaseConfig config = new FirebaseConfig {
            AuthSecret = "m6NNKfbxyufWFj9YzHObMf2LTPXB9caps9qNjCrs",
            BasePath = "https://nms-pharmacy-e0da6.firebaseio.com/"
        };

        IFirebaseClient client;


        public Form1()
        {
            InitializeComponent();
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null) {
                MessageBox.Show("Connection established to firebase");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            /*var data = new Data
             {
                 name = name_editText.Text,
                 pass = pw_editText.Text
             };

             SetResponse response = await client.SetTaskAsync("Test/mustafa",data);
             Data result = response.ResultAs<Data>();

             MessageBox.Show("Data Inserted");*/
            Home h = new Home();
            h.Show();
            this.Hide();
            Home Home = new Home(); //this is the change, code for redirect  
            Home.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_editText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pw_editText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
