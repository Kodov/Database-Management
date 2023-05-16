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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WorkMedia
{
    public partial class UserControlTeams : UserControl
    {

        string connString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
        public int currentUserId;
        string currentUsername;

        public UserControlTeams()
        {
            InitializeComponent();
            PopulateGridTeams();
        }

        private void PopulateGridTeams()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT DISTINCT team_name FROM teams";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assign the DataTable as the DataSource for the DataGridView
                        dataGridView_Teams.DataSource = dataTable;
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

        private void PopulateGridMembers()
        {
            ClearMembers();

            // Get the selected team name from the DataGridView
            DataGridViewRow selectedRow = dataGridView_Teams.SelectedRows[0];
            string selectedTeamName = selectedRow.Cells["team_name"].Value.ToString();

            // SQL query to select users based on the selected team name
            string query = "SELECT u.username, u.first_name, u.last_name " +
                           "FROM users u " +
                           "JOIN Teams t ON u.id = t.member_id " +
                           "WHERE t.team_name = @teamName";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connString))
            {
                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameter for the team name
                    command.Parameters.AddWithValue("@teamName", selectedTeamName);

                    // Open the database connection
                    connection.Open();

                    // Execute the query and get a SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear the existing rows in the DataGridView
                        if (dataGridView_Members.Rows.Count > 0)
                            dataGridView_Members.Rows.Clear();

                        // Check if there are any rows returned
                        if (reader.HasRows)
                        {
                            // Iterate through the rows
                            while (reader.Read())
                            {
                                // Retrieve the values from the reader
                                string username = reader["username"].ToString();
                                string firstName = reader["first_name"].ToString();
                                string lastName = reader["last_name"].ToString();

                                // Add a new row to the DataGridView
                                dataGridView_Members.Rows.Add(username, firstName, lastName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No users found for the selected team.");
                            PopulateGridTeams();
                            ClearMembers();
                        }
                    }
                }
            }
        }

        private void btn_viewTeam_Click(object sender, EventArgs e)
        {
            PopulateGridMembers();
        }

        private void btn_createTeam_Click(object sender, EventArgs e)
        {
            // sets current user's id for querying
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.SetCurrentUserIdTeam();

            // Get the team name from the TextBox
            string teamName = txtbox_createTeam.Text;

            // SQL query to insert a new row into the Teams table
            string query = "INSERT INTO Teams (team_name, member_id) VALUES (@teamName, @memberId)";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connString))
            {
                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameters for the team name and member ID
                    command.Parameters.AddWithValue("@teamName", teamName);
                    command.Parameters.AddWithValue("@memberId", currentUserId);

                    // Open the database connection
                    connection.Open();

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New team inserted successfully.");
                        PopulateGridTeams();
                        ClearMembers();
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert a new team.");
                    }
                }
            }
        }

        private void btn_updateTeam_Click(object sender, EventArgs e)
        {
            // sets current user's id for querying
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.SetCurrentUserIdTeam();
            PopulateGridTeams();
            ClearMembers();
        }

        private void btn_joinTeam_Click(object sender, EventArgs e)
        {
            // sets current user's id for querying
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.SetCurrentUserIdTeam();

            if (dataGridView_Teams.SelectedRows.Count > 0)
            {
                // Get the selected team name from the DataGridView
                string selectedTeamName = dataGridView_Teams.SelectedRows[0].Cells["team_name"].Value.ToString();

                // Check if the team and member combination already exists
                string checkQuery = "SELECT COUNT(*) FROM teams WHERE team_name = @team_name AND member_id = @member_id";

                // Create a new SqlConnection object
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // Create a new SqlCommand object to check for existing row
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        // Add the parameters for the team name and member ID
                        checkCommand.Parameters.AddWithValue("@team_name", selectedTeamName);
                        checkCommand.Parameters.AddWithValue("@member_id", currentUserId);

                        // Open the database connection
                        connection.Open();

                        // Execute the query to check for existing row
                        int existingRows = (int)checkCommand.ExecuteScalar();

                        if (existingRows > 0)
                        {
                            MessageBox.Show("You are in that team already");
                            return; // Exit the method without executing the insert query
                        }
                    }

                    // SQL query to insert the row into the Teams table
                    string insertQuery = "INSERT INTO teams (team_name, member_id) VALUES (@team_name, @member_id)";

                    // Create a new SqlCommand object for insert query
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        // Add the parameters for the team name and member ID
                        insertCommand.Parameters.AddWithValue("@team_name", selectedTeamName);
                        insertCommand.Parameters.AddWithValue("@member_id", currentUserId);

                        // Execute the insert query
                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        // Check if the insertion was successful
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Joined Team successfully.");
                            PopulateGridMembers();
                        }
                        else
                        {
                            Console.WriteLine("Failed to join team.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the left-most data row cell to view");
            }

        }

        private void btn_LeaveTeam_Click(object sender, EventArgs e)
        {
            // Get the selected team name from the DataGridView
            string selectedTeamName = dataGridView_Teams.SelectedRows[0].Cells["team_name"].Value.ToString();

            // SQL query to delete the row from the Teams table
            string query = "DELETE FROM Teams WHERE team_name = @teamName AND member_id = @memberId";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(connString))
            {
                // Create a new SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameters for the team name and member ID
                    command.Parameters.AddWithValue("@teamName", selectedTeamName);
                    command.Parameters.AddWithValue("@memberId", currentUserId);

                    // Open the database connection
                    connection.Open();

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the deletion was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("removed from team successfully.");
                        PopulateGridMembers();
                    }
                    else
                    {
                        Console.WriteLine("Failed to remove from team.");
                    }
                }
            }
        }

        private void ClearMembers()
        {
            // Clear the existing rows in the DataGridView
            if (dataGridView_Members.Rows.Count > 0)
                dataGridView_Members.Rows.Clear();
        }
    }
}
