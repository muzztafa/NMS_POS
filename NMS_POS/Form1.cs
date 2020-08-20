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
        List<Pos_Users> usersList = new List<Pos_Users>();
        List<string> keys = new List<string>();

        public static Pos_Users loggedInUser;
        
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

            updateUsersList();
            
        }

        private async void button1_Click(object sender, EventArgs e)

        {
            bool check = false;

            for (int i = 0; i < usersList.Count; i++)
            {
                if (name_editText.Text == usersList[i].name && pw_editText.Text == usersList[i].password)
                {
                    check = true;

                    loggedInUser = new Pos_Users()
                    {
                        name = usersList[i].name,
                        password = usersList[i].password,
                        role = usersList[i].role
                    };

                    MessageBox.Show("Logged in Successfully");

                    Home Home = new Home(); //this is the change, code for redirect  
                    Home.Show();
                    Hide();

                    break;
                }
            }
                if (!check)
                {
                    MessageBox.Show("Wrong username or password.");
                }
            

            



        }

        private async void updateUsersList()
        {
            try
            {
                FirebaseResponse resp = await client.GetTaskAsync("posUsers/");
                Dictionary<string, Pos_Users> dict = resp.ResultAs<Dictionary<string, Pos_Users>>();



                //Adding product keys to Array Keys
                foreach (KeyValuePair<string, Pos_Users> ele1 in dict)
                {
                    keys.Add(ele1.Key);

                }

                //traversing list keys to fetch product details
                for (int i = 0; i < keys.Count; i++)
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("posUsers/" + keys[i]);
                    Pos_Users user = resp2.ResultAs<Pos_Users>();
                    usersList.Add(user);


                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("No Users Exist Already.");
            }
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
