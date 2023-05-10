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
    public partial class UserControlLogin : UserControl
    {
        public string username;
        public string password;

        public UserControlLogin()
        {
            InitializeComponent();
        }

        public void SetUsername(string username)
        {
            this.username = username;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            username = txtbox_username.Text;
            password = txtbox_password.Text;
            mainForm.SetCurrentUsername(username);
            mainForm.getUserId();

            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    // allows admin access to LOG tab view
                    if (username == "Admin" && password == "Admin" || username == "admin" && password == "admin")
                        mainForm.isAdmin = true;

                    mainForm.isAuthorized = true;
                    if (mainForm != null)
                    {
                        FlowLayoutPanel flowLayoutPanel = mainForm.FlowLayoutPanel;
                        // Use the FlowLayoutPanel
                        flowLayoutPanel.Controls.Clear();
                        flowLayoutPanel.Controls.Add(mainForm.uc_home);
                            mainForm.picbox_home_Click(this, EventArgs.Empty);
                    }
                    else
                    {
                        // MainForm is not open
                        return;
                    }

                }
                else
                {
                    mainForm.isAuthorized = false;
                    MessageBox.Show("Incorrect credentials");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            if (mainForm != null)
            {
                FlowLayoutPanel flowLayoutPanel = mainForm.FlowLayoutPanel;
                // Use the FlowLayoutPanel
                flowLayoutPanel.Controls.Clear();
                flowLayoutPanel.Controls.Add(mainForm.uc_signup);
            }
        }
    }
}
