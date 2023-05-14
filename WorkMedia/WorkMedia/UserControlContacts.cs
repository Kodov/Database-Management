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
            PopulateGridContacts();
        }

        private void PopulateGridContacts()
        {
            //MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            //currentUserId = mainForm.currentUserId;
            //mainForm.SetCurrentUsername(currentUsername);

            // Create a connection to the SQL database
            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Create a SQL command to retrieve data from the users table
            string commandText = "SELECT username, first_name, last_name FROM users";
            SqlCommand command = new SqlCommand(commandText, connection);

            // Open the database connection
            connection.Open();

            // Create a data adapter to retrieve the data and fill a DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = table;

            // Close the database connection
            connection.Close();
        }

        private void PopulateGridFriends()
        {
            // Create a connection to the SQL database
            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Create a SQL command to retrieve data from the friends table
            string commandText = "SELECT friend FROM friends WHERE user_id = @userId";
            SqlCommand command = new SqlCommand(commandText, connection);

            // Add a parameter for the user ID to the SQL command
            command.Parameters.AddWithValue("@userId", currentUserId);

            // Create a data adapter to retrieve the data from the SQL command
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Create a new data table to hold the results
            DataTable dataTable = new DataTable();

            // Fill the data table with the results from the data adapter
            adapter.Fill(dataTable);

            // Set the DataGridView's data source to the data table, and display only the friends column
            dataGridView2.DataSource = dataTable;
            dataGridView2.Columns["friend"].Visible = true;
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

                    string query = "SELECT id FROM users WHERE username = @username";

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



            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    getUserId();

                    string query = ("INSERT INTO FRIENDS (user_id, friend) " +
                                    "VALUES (@user_id, @friend)");

                    MessageBox.Show(currentUserId.ToString());
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

                            command.Parameters.AddWithValue("@user_id", currentUserId);

                            command.Parameters.AddWithValue("@friend", username);

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

                PopulateGridFriends();
            }
        }


    }
}
