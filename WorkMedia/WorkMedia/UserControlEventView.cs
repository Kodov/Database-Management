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
    public partial class UserControlEventView : UserControl
    {
        public int EventId;
        public UserControlEventView()
        {
            InitializeComponent();
        }

        private void Header_Label_Click(object sender, EventArgs e)
        {

        }

        private void Event_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void Attendees_header_Click(object sender, EventArgs e)
        {

        }

        private void Attendees_TextChanged(object sender, EventArgs e)
        {

        }

        private void Event_date_Click(object sender, EventArgs e)
        {

        }

        private void Event_picture_Click(object sender, EventArgs e)
        {

        }

        private void Attend_event_button_Click(object sender, EventArgs e)
        {
            Attend_event_button.Enabled = false;

            MainForm mainForm = this.FindForm() as MainForm;

            // Create a connection to the SQL database
            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Create a SQL command to increment the value of vote_option1 by 1 in the polls table
            string commandText = "UPDATE events SET attendees = attendees + 1 WHERE id = @id";
            SqlCommand command = new SqlCommand(commandText, connection);

            // Set the parameter for the poll_id
            command.Parameters.AddWithValue("@id", EventId);

            // Open the database connection
            connection.Open();

            // Execute the command
            int rowsAffected = command.ExecuteNonQuery();

            // Close the database connection
            connection.Close();

            // runs getPollChart to populate feed view with chart and most recent vote implemented
            if (mainForm != null)
                mainForm.getAttendees();

        }
    }
}
