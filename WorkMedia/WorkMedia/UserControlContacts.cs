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
        private readonly string connString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
        public int currentUserId;
        public string currentUsername;
        public UserControlContacts()
        {
            InitializeComponent();
            PopulateGridContacts();
        }

        private void PopulateGridContacts()
        {

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

            // Set the DataGridView's data source to the data table
            dataGridView2.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // sets current user's id for querying
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.SetCurrentUserIdContact();

            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO friends (user_id, friend) VALUES (@user_id, @friend)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                            currentUsername = selectedRow.Cells["username"].Value.ToString();

                            // Check if the user_id and friend combination already exists
                            string checkQuery = "SELECT COUNT(*) FROM friends WHERE user_id = @user_id AND friend = @friend";
                            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                            {
                                checkCommand.Parameters.AddWithValue("@user_id", currentUserId);
                                checkCommand.Parameters.AddWithValue("@friend", currentUsername);

                                int existingRows = (int)checkCommand.ExecuteScalar();

                                if (existingRows > 0)
                                {
                                    MessageBox.Show("Friend already added");
                                    return; // Exit the method without executing the insert query
                                }
                            }

                            command.Parameters.AddWithValue("@user_id", currentUserId);
                            command.Parameters.AddWithValue("@friend", currentUsername);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Friend added successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Friend request failed!");
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

                PopulateGridFriends();
            }
        }

        private void btn_updateFriends_Click(object sender, EventArgs e)
        {
            // sets current user's id for querying
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.SetCurrentUserIdContact();
            PopulateGridFriends();
        }

        private void btn_removeFriend_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM friends WHERE user_id = @user_id AND friend = @friend";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (dataGridView2.SelectedRows.Count > 0)
                        {
                            DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                            currentUsername = selectedRow.Cells["friend"].Value.ToString();

                            command.Parameters.AddWithValue("@user_id", currentUserId);
                            command.Parameters.AddWithValue("@friend", currentUsername);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Friend removed successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Friend removal failed!");
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

                PopulateGridFriends();
            }
        }
    }
}
