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
        int currentUserId;
        string currentUsername;
        public UserControlContacts()
        {
            InitializeComponent();
            dataGridView1.Refresh();

        }

        public void SetCurrentUserInfo(string username)
        {
            this.currentUsername = username;
        }


        public void getUserId()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
            string username = currentUsername;
            int user_id = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id FROM users WHERE username=@username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user_id = reader.GetInt32(reader.GetOrdinal("id"));
                            }
                            else
                            {
                                throw new Exception("Username not found");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            currentUserId = user_id;
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


            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                               
                    string query = ("INSERT INTO FRIENDS (user_id, friend) " +
                                    "VALUES (user_id, friend)");
                    
                    
                    using (SqlCommand command = new SqlCommand(query, connection))     
                    {

                        if (dataGridView1.SelectedRows.Count > 0) // check if any row is selected
                        {
                            // Get the currently selected row
                            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                            // Retrieve the value of the "username" column from the selected row
                            string username = selectedRow.Cells["username"].Value.ToString();

                            getUserId();

                            // Do something with the username value

                            command.Parameters.AddWithValue("user_id", currentUserId);

                            command.Parameters.AddWithValue("friend", username);

                        }


                        

                                 
                        int rowsAffected = command.ExecuteNonQuery();

                                
                        if (rowsAffected > 0)
                               
                        {
                                  
                            MessageBox.Show("Friend added successfully!");
                              
                                  
                        }
                                   
                        else
                        
                        {
                        
                            MessageBox.Show("Freind request failed!");
                            
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


    }
}
