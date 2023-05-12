using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkMedia
{
    public partial class UserControlPost : UserControl
    {
        public int currentUserId;

        public UserControlPost()
        {
            InitializeComponent();
        }

        private void Discard_button_Click(object sender, EventArgs e)
        {
            // clears all fields on click or after successfully posting
            Text_body_box.Clear();
            Header_box.Clear();

            for (int i = 0; i < Filters_Check_List.Items.Count; i++)
            {
                Filters_Check_List.SetItemChecked(i, false);
            }

        }

        private void Post_button_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.SetCurrentUserIdPost();
            int user_id = currentUserId;

            //MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            //string userId = MainForm.username; //TODO - check if this is getting the current instance of the username var?
            string title = Header_box.Text;
            string body = Text_body_box.Text;
            string tag = Filters_Check_List.SelectedItem.ToString();

            // Create a connection string with the appropriate credentials
            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";

            // Define the SQL query with parameter placeholders
            string sqlQuery = "INSERT INTO posts (user_id, title, body, tag) VALUES (@user_id, @title, @body, @tag)";

            // Create a new SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a new SqlCommand using the SQL query and the SqlConnection
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Add parameter values to the SqlCommand
                    command.Parameters.AddWithValue("@user_id", user_id);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@body", body);
                    command.Parameters.AddWithValue("@tag", tag);

                    // Execute the SQL command
                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Poll created successfully!");
                        Discard_button_Click(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Poll creation failed!");
                    }
                }
            }
        }

        private void Filters_Check_List_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Uncheck the previously checked box
            for (int i = 0; i < Filters_Check_List.Items.Count; i++)
            {
                if (i != e.Index && Filters_Check_List.GetItemChecked(i))
                {
                    Filters_Check_List.SetItemChecked(i, false);
                }
            }
        }
    }
}
