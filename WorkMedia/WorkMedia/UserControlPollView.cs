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
    public partial class UserControlPollView : UserControl
    {
        public int pollId;

        public UserControlPollView()
        {
            InitializeComponent();
            PollChart.Visible = false;
        }

        public void DisableAllCheckboxes()
        {
            checkBox_Option1.Enabled = false;
            checkBox_Option2.Enabled = false;
            checkBox_Option3.Enabled = false;
            checkBox_Option4.Enabled = false;
            checkBox_Option5.Enabled = false;

            checkBox_Option1.ForeColor = SystemColors.GrayText;
            checkBox_Option2.ForeColor = SystemColors.GrayText;
            checkBox_Option3.ForeColor = SystemColors.GrayText;
            checkBox_Option4.ForeColor = SystemColors.GrayText;
            checkBox_Option5.ForeColor = SystemColors.GrayText;
        }

        public void EnableAllCheckboxes()
        {
            checkBox_Option1.Checked = false;
            checkBox_Option2.Checked = false;
            checkBox_Option3.Checked = false;
            checkBox_Option4.Checked = false;
            checkBox_Option5.Checked = false;

            checkBox_Option1.Enabled = true;
            checkBox_Option2.Enabled = true;
            checkBox_Option3.Enabled = true;
            checkBox_Option4.Enabled = true;
            checkBox_Option5.Enabled = true;

            checkBox_Option1.ForeColor = Color.IndianRed;
            checkBox_Option2.ForeColor = Color.IndianRed;
            checkBox_Option3.ForeColor = Color.IndianRed;
            checkBox_Option4.ForeColor = Color.IndianRed;
            checkBox_Option5.ForeColor = Color.IndianRed;
        }

        private void checkBox_Option1_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = this.FindForm() as MainForm;

            if (checkBox_Option1.Checked)
            {
                DisableAllCheckboxes();
                PollChart.Visible = true;

                // Create a connection to the SQL database
                string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                // Create a SQL command to increment the value of vote_option1 by 1 in the polls table
                string commandText = "UPDATE polls SET vote_option1 = vote_option1 + 1 WHERE id = @id";
                SqlCommand command = new SqlCommand(commandText, connection);

                // Set the parameter for the poll_id
                command.Parameters.AddWithValue("@id", pollId);

                // Open the database connection
                connection.Open();

                // Execute the command
                int rowsAffected = command.ExecuteNonQuery();

                // Close the database connection
                connection.Close();

                // runs getPollChart to populate feed view with chart and most recent vote implemented
                if (mainForm != null)
                    mainForm.getPollChart();
            }
        }

        private void checkBox_Option2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Option2.Checked)
            {
                DisableAllCheckboxes();
                PollChart.Visible = true;

                // Create a connection to the SQL database
                string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                // Create a SQL command to increment the value of vote_option1 by 1 in the polls table
                string commandText = "UPDATE polls SET vote_option2 = vote_option2 + 1 WHERE id = @id";
                SqlCommand command = new SqlCommand(commandText, connection);

                // Set the parameter for the poll_id
                command.Parameters.AddWithValue("@id", pollId);

                // Open the database connection
                connection.Open();

                // Execute the command
                int rowsAffected = command.ExecuteNonQuery();

                // Close the database connection
                connection.Close();

                // runs getPollChart to populate feed view with chart and most recent vote implemented
                MainForm mainForm = this.FindForm() as MainForm;
                if (mainForm != null)
                    mainForm.getPollChart();
            }
        }
    

        private void checkBox_Option3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Option3.Checked)
            {
                DisableAllCheckboxes();
                PollChart.Visible = true;

                // Create a connection to the SQL database
                string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                // Create a SQL command to increment the value of vote_option1 by 1 in the polls table
                string commandText = "UPDATE polls SET vote_option3 = vote_option3 + 1 WHERE id = @id";
                SqlCommand command = new SqlCommand(commandText, connection);

                // Set the parameter for the poll_id
                command.Parameters.AddWithValue("@id", pollId);

                // Open the database connection
                connection.Open();

                // Execute the command
                int rowsAffected = command.ExecuteNonQuery();

                // Close the database connection
                connection.Close();

                // runs getPollChart to populate feed view with chart and most recent vote implemented
                MainForm mainForm = this.FindForm() as MainForm;
                if (mainForm != null)
                    mainForm.getPollChart();
            }
        }

        private void checkBox_Option4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Option4.Checked)
            {
                DisableAllCheckboxes();
                PollChart.Visible = true;

                // Create a connection to the SQL database
                string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                // Create a SQL command to increment the value of vote_option1 by 1 in the polls table
                string commandText = "UPDATE polls SET vote_option4 = vote_option4 + 1 WHERE id = @id";
                SqlCommand command = new SqlCommand(commandText, connection);

                // Set the parameter for the poll_id
                command.Parameters.AddWithValue("@id", pollId);

                // Open the database connection
                connection.Open();

                // Execute the command
                int rowsAffected = command.ExecuteNonQuery();

                // Close the database connection
                connection.Close();

                // runs getPollChart to populate feed view with chart and most recent vote implemented
                MainForm mainForm = this.FindForm() as MainForm;
                if (mainForm != null)
                    mainForm.getPollChart();
            }
        }

        private void checkBox_Option5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Option5.Checked)
            {
                DisableAllCheckboxes();
                PollChart.Visible = true;

                // Create a connection to the SQL database
                string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                // Create a SQL command to increment the value of vote_option1 by 1 in the polls table
                string commandText = "UPDATE polls SET vote_option5 = vote_option5 + 1 WHERE id = @id";
                SqlCommand command = new SqlCommand(commandText, connection);

                // Set the parameter for the poll_id
                command.Parameters.AddWithValue("@id", pollId);

                // Open the database connection
                connection.Open();

                // Execute the command
                int rowsAffected = command.ExecuteNonQuery();

                // Close the database connection
                connection.Close();

                // runs getPollChart to populate feed view with chart and most recent vote implemented
                MainForm mainForm = this.FindForm() as MainForm;
                if (mainForm != null)
                    mainForm.getPollChart();
            }
        }
    }
}
