using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WorkMedia
{
    public partial class UserControlContacts : UserControl
    {
        string text = null;
        private readonly string connString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
        int id = 1;
        public UserControlContacts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // when clicked, check the if the text matches any names in the database
            // for ( int i = 0; i < number of columns in the database for users; i ++)
            // if(text == "**Name of anyone in the database**")
            // {
            //    add that name to the user's friend list
            //    text = null;
            // }
            // 
            string user_id = null;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    string numRows = "SELECT COUNT(usernames) FROM users";
                    SqlCommand com = new SqlCommand(numRows, connection);
                    int rowCount = (int)com.ExecuteScalar();

                    string stringVal = "SELECT usernames from users";
                    SqlCommand com2 = new SqlCommand(stringVal, connection);

                    SqlDataReader reader = com2.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < rowCount; i++)
                        {
                            if (reader.GetValue(i).ToString() == text)
                            {
                                // string query2 = ("Select id from users where username = ");
                                string query = ("INSERT INTO FRIENDS (user_id, friend) " +
                                "VALUES (user_id, friend)");
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                
                                    command.Parameters.AddWithValue("user_id", user_id);
                                    command.Parameters.AddWithValue("friend", text);

                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Friend added successfully!");
                                        id++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Freind request failed!");
                                    }

                                }

                            }
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = AddFriendsBox.Text;
        }

        private void showAll()
        {
            // call this method to show all friends, regardless of status in 
            // the friends text box

        }

        private void showOnline()
        {
            // call this to show friends that are online in the friends text box
        }

        private void showOffline()
        {
            // call to show friends that are offline

        }

        private void showBusy()
        {
            // Call method to show friends that are busy
        }
    }
}
