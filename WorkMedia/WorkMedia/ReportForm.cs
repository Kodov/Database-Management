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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WorkMedia
{
    public partial class ReportForm : Form
    {

        int currentUserId;
        string currentUsername;
        
        public ReportForm()
        {
            InitializeComponent();
            txtbox_report.MaxLength = 100;
            lbl_charLimit.Text = txtbox_report.Text.Length + "/100";
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            currentUserId = mainForm.currentUserId;
            mainForm.logAction = "Bug Report";
            mainForm.createLog();
        }

        private void txtbox_report_TextChanged(object sender, EventArgs e)
        {
            lbl_charLimit.Text = txtbox_report.Text.Length + "/100";
        }


        private void btn_submit_Click(object sender, EventArgs e)
        {
            // TODO add db query
            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";

            if (!string.IsNullOrEmpty(txtbox_report.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        //getUserId();

                        string query = "INSERT INTO reports (user_id, report) VALUES (@user_id, @report)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@user_id", currentUserId);
                            command.Parameters.AddWithValue("@report", txtbox_report.Text);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Report created successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Report creation failed!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        MessageBox.Show("An error occurred while creating the report.");
                    }
                    finally
                    {
                        connection.Close();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a report.");
            }
        }
    }
}
