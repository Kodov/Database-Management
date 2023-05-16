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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WorkMedia
{
    public partial class UserControlSettings : UserControl
    {
        string connString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
        public int currentUserId;

        public UserControlSettings()
        {
            InitializeComponent();
        }

        private void Delete_Account_Click(object sender, EventArgs e)
        {
            // sets current user's id for querying
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.SetCurrentUserIdSettings();

            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // SQL query to delete rows from multiple tables
                string query = @"
                DELETE FROM Teams WHERE member_id = @memberId;
                DELETE FROM reports WHERE user_id = @userId;
                DELETE FROM Logs WHERE user_id = @userId;
                DELETE FROM posts WHERE user_id = @userId;
                DELETE FROM Polls WHERE user_id = @userId;
                DELETE FROM events WHERE user_id = @userId;
                DELETE FROM friends WHERE user_id = @userId;
                DELETE FROM users WHERE id = @userId;
                ";

                // Create a new SqlConnection object
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // Create a new SqlCommand object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the parameter for the currentUserId
                        command.Parameters.AddWithValue("@memberId", currentUserId);
                        command.Parameters.AddWithValue("@userId", currentUserId);

                        // Open the database connection
                        connection.Open();

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check the number of rows affected
                        Console.WriteLine($"{rowsAffected} rows deleted.");
                    }
                }

                mainForm.isAuthorized = false;
                mainForm.picbox_home_Click(this, EventArgs.Empty);
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.isAuthorized = false;
            mainForm.picbox_home_Click(this, EventArgs.Empty);
        }
    }
}
