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
using FireSharp.Interfaces;
using FireSharp.Response;

namespace NMS_POS
{
    public partial class Manage_Users : Form
    {
        DataTable dt = new DataTable();
        List<Pos_Users> usersList = new List<Pos_Users>();
        List<string> keys = new List<string>();

        int selectedRow = -1;



        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "m6NNKfbxyufWFj9YzHObMf2LTPXB9caps9qNjCrs",
            BasePath = "https://nms-pharmacy-e0da6.firebaseio.com/"
        };
        IFirebaseClient client;

        public Manage_Users()
        {
            InitializeComponent();
        }

        private void Manage_Users_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            role_list.Items.Add("Cashier");
            role_list.Items.Add("Admin");
            role_list.SelectedIndex = 0;

            dt.Columns.Add("Name");
            dt.Columns.Add("Password");
            dt.Columns.Add("Role");
            

            users_datagrid.DataSource = dt;
            updateUsersList();
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if(name_editText.Text != "" && password_editText.Text != "") {
                int temp = role_list.SelectedIndex;
                string role;
                //cashier is selected
                if(temp == 0)
                {
                    role = "Cashier";
                }
                else
                {
                    role = "Admin";
                }

                Pos_Users user = new Pos_Users()
                {
                    name = name_editText.Text,
                    password = password_editText.Text,
                    role = role

                };
                try
                {
                    PushResponse response = await client.PushTaskAsync("posUsers", user);
                    Pos_Users result = response.ResultAs<Pos_Users>();

                    usersList.Add(user);

                    FirebaseResponse resp = await client.GetTaskAsync("posUsers/");
                    Dictionary<string, Pos_Users> dict = resp.ResultAs<Dictionary<string, Pos_Users>>();

                    //Adding new key to keys array
                    foreach (KeyValuePair<string, Pos_Users> ele1 in dict)
                    {
                        if (!keys.Contains(ele1.Key))
                        {
                            keys.Add(ele1.Key);
                            break;
                        }

                    }

                    //adding new row to DT
                    DataRow row = dt.NewRow();
                    row["Name"] = user.name;
                    row["Password"] = user.password;
                    row["Role"] = user.role;

                    dt.Rows.Add(row);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to connect to database. Check your internet connection and try again.");
                }
            }
            else
            {
                MessageBox.Show("Please fill the fields first.");
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

                for (int i = 0; i < usersList.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row["Name"] = usersList[i].name;
                    row["Password"] = usersList[i].password;
                    row["Role"] = usersList[i].role;

                    dt.Rows.Add(row);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Users Exist Already.");
            }
            }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {

                int temp = users_datagrid.CurrentCell.RowIndex;
                FirebaseResponse response = await client.DeleteTaskAsync("posUsers/" + keys[temp]);
                dt.Rows.RemoveAt(temp);
                keys.RemoveAt(temp);
                MessageBox.Show("User Deleted Successfully");


            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void users_datagrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             selectedRow = users_datagrid.CurrentCell.RowIndex;
            if (selectedRow < 0 || selectedRow >= usersList.Count)
            {
                MessageBox.Show("Please select a valid box!");
            }
            else
            {
                name_editText.Text = usersList[selectedRow].name;
                password_editText.Text = usersList[selectedRow].password;
                

               

                if (usersList[selectedRow].role == "Cashier")
                {
                    role_list.SelectedIndex = 0;
                }
                else role_list.SelectedIndex = 1;

            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            if (name_editText.Text != "" && password_editText.Text != "")
            {
                string role;
                if (role_list.SelectedIndex == 0) { role = "Cashier"; } else role = "Admin"; 
                try
                {
                    Pos_Users user = new Pos_Users
                    {
                        name = name_editText.Text,
                        password = password_editText.Text,
                        role = role
                    };

                    FirebaseResponse response = await client.UpdateTaskAsync("posUsers/" + keys[selectedRow], user);
                    //setting values to default
                    name_editText.Text = "";
                    password_editText.Text = "";
                    

                    MessageBox.Show("Updated Successfully!");
                }

                catch (Exception)
                {
                    MessageBox.Show("Update Failed");
                }
            }
        }
    }
}
