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
    public partial class UserControlPoll : UserControl
    {
        private readonly string connString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
        public int currentUserId;

        public UserControlPoll()
        {
            InitializeComponent();
        }

        private void Discard()
        {
            txtbox_pollTitle.Clear();
            txtbox_option1.Clear();
            txtbox_option2.Clear();
            txtbox_option3.Clear();
            txtbox_option4.Clear();
            txtbox_option5.Clear();
        }

        private void btn_publish_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.SetCurrentUserIdPoll();

            int user_id = currentUserId;
            string pollTitle = txtbox_pollTitle.Text;
            string option1 = txtbox_option1.Text;
            string option2 = txtbox_option2.Text;
            string option3 = txtbox_option3.Text;
            string option4 = txtbox_option4.Text;
            string option5 = txtbox_option5.Text;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Polls (user_id, title, option1, option2, option3, option4, option5, created) " +
                                   "VALUES (@user_id, @title, @option1, @option2, @option3, @option4, @option5, @created)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@user_id", user_id);
                        command.Parameters.AddWithValue("@title", pollTitle);
                        command.Parameters.AddWithValue("@option1", option1);
                        command.Parameters.AddWithValue("@option2", option2);
                        command.Parameters.AddWithValue("@option3", option3);
                        command.Parameters.AddWithValue("@option4", option4);
                        command.Parameters.AddWithValue("@option5", option5);
                        command.Parameters.AddWithValue("@created", DateTime.Now);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Poll created successfully!");
                            Discard();
                        }
                        else
                        {
                            MessageBox.Show("Poll creation failed!");
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
