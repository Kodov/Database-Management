using Microsoft.Extensions.Logging;
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
    public partial class UserControlPostView : UserControl
    {
        public int PostId;
        public UserControlPostView()
        {
            InitializeComponent();
        }

        private void picbox_Like_Click(object sender, EventArgs e)
        {

            MainForm mainForm = this.FindForm() as MainForm;

            // Create a connection to the SQL database
            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Create a SQL command to increment the value of vote_option1 by 1 in the polls table
            string commandText = "UPDATE posts SET likes = likes + 1 WHERE id = @id";
            SqlCommand command = new SqlCommand(commandText, connection);

            // Set the parameter for the poll_id
            command.Parameters.AddWithValue("@id", PostId);

            // Open the database connection
            connection.Open();

            // Execute the command
            int rowsAffected = command.ExecuteNonQuery();

            // Close the database connection
            connection.Close();

            // runs getPollChart to populate feed view with chart and most recent vote implemented
            if (mainForm != null)
                mainForm.getLikes();

            picbox_Like.Enabled = false;
        }
    }
}
