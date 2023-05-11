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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WorkMedia
{
    public partial class UserControlTeams : UserControl
    {
        string createTeam = null;
        string joinTeam = null;
        string leaveTeam = null;
        string viewTeam = null;

       
        private readonly string connString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
        int currentUserId;
        string currentUsername;
        public UserControlTeams()
        {
            InitializeComponent();
        }


        public void SetCurrentUserInfo(string username)
        {
            this.currentUsername = username;
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

                    string query = "SELECT id FROM users WHERE username=@username";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            createTeam = textBox1.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // creates a team if there is a name in the team name box
            // that is not a duplicate team name
            

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    string query = ("INSERT INTO TEAMS (team_name, member_id) " +
                                    "VALUES (team_name, member_id)");

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if(textBox1 != null)
                        {
                            command.Parameters.AddWithValue("team_name", textBox1);

                            command.Parameters.AddWithValue("member_id", currentUserId);
                        }

                        int rowsAffected = command.ExecuteNonQuery();


                        if (rowsAffected > 0)

                        {

                            MessageBox.Show("Team added successfully!");


                        }

                        else

                        {

                            MessageBox.Show("Team creation failed!");

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

        private void button2_Click(object sender, EventArgs e)
        {
            // joins a team 
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    string query = ("INSERT INTO TEAMS (team_name, member_id) " +
                                    "VALUES (team_name, member_id)");


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            DataGridViewRow selectedRowMember = dataGridView1.SelectedRows[0];
                            int memberId = (int)selectedRowMember.Cells["member_id"].Value;

                            if(memberId != currentUserId)
                            {
                                // Get the currently selected row
                                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                                // Retrieve the value of the "team_name" column from the selected row
                                string teamName = selectedRow.Cells["team_name"].Value.ToString();



                                // Do something with the username value

                                command.Parameters.AddWithValue("team_name", teamName);

                                command.Parameters.AddWithValue("member_id", currentUserId);
                            }
                        }

                        int rowsAffected = command.ExecuteNonQuery();


                        if (rowsAffected > 0)

                        {

                            MessageBox.Show("Joined team successfully!");


                        }

                        else

                        {

                            MessageBox.Show("Failed to join team!");

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

        private void button3_Click(object sender, EventArgs e)
        {
            // leaves a team
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    string query = ("Delete from Teams where member_id = @currentUserId");
                                    


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            DataGridViewRow selectedRowMember = dataGridView1.SelectedRows[0];
                            int memberId = (int)selectedRowMember.Cells["member_id"].Value;

                            if (memberId == currentUserId)
                            {
                                // Get the currently selected row
                                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                                // Retrieve the value of the "team_name" column from the selected row
                                string teamName = selectedRow.Cells["team_name"].Value.ToString();





                                // Do something with the username value

                                command.Parameters.AddWithValue("team_name", teamName);

                                command.Parameters.AddWithValue("member_id", currentUserId);
                            }
                        }

                        int rowsAffected = command.ExecuteNonQuery();


                        if (rowsAffected > 0)

                        {

                            MessageBox.Show("Left team successfully!");


                        }

                        else

                        {

                            MessageBox.Show("Failed to leave team!");

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

        private void button4_Click(object sender, EventArgs e)
        {
            // views the members of a team if the name entered in the text box exists
            // shows the team members in the text box that shows all of the different teams
            // back button displayed to go back to the all team view




        }


    }
}
