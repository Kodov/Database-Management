using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkMedia
{
    public partial class UserControlSignup : UserControl
    {
        public UserControlSignup()
        {
            InitializeComponent();
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {

            if (txtbox_FirstName.Text == "" || txtbox_LastName.Text == "" || txtbox_username.Text == "" || txtbox_password.Text == "")
                MessageBox.Show("Fill out all credentials");
            else
            {
                MessageBox.Show("here");
                // Read the user input from text boxes
                string firstName = txtbox_FirstName.Text;
                string lastName = txtbox_LastName.Text;
                string username = txtbox_username.Text;
                string password = txtbox_password.Text;
                bool isAdmin = false;

                // Define the SQL query to insert a new user into the "users" table
                string query = "INSERT INTO users (username, first_name, last_name, password, isAdmin) VALUES (@username, @firstName, @lastName, @password, @isAdmin);";

                // Set up a connection to the database
                string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // Create a new SqlCommand object to execute the SQL query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query to prevent SQL injection
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@isAdmin", isAdmin);

                        // Execute the SQL query to insert the new user into the "users" table
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Console.WriteLine("New user created successfully.");
                            //TODO: send user to login page

                        }
                        else
                        {
                            Console.WriteLine("Failed to create a new user.");
                        }
                    }

                    // Close the database connection
                    connection.Close();
                }

                btn_login_Click(this, EventArgs.Empty);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                FlowLayoutPanel flowLayoutPanel = mainForm.FlowLayoutPanel;
                // Use the FlowLayoutPanel
                flowLayoutPanel.Controls.Clear();
                flowLayoutPanel.Controls.Add(MainForm.uc_login);
            }
        }
    }
}
