using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkMedia
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();

            // shows home page on launch
            picbox_home_Click(this, EventArgs.Empty);

        }

        // create instances of user controls corresponding to (panel) tab views
        UserControlContacts uc_contacts = new UserControlContacts();
        public UserControlHome uc_home = new UserControlHome();
        UserControlEvent uc_event = new UserControlEvent();
        UserControlLog uc_log = new UserControlLog();
        UserControlMessages uc_messages = new UserControlMessages();
        UserControlPoll uc_poll = new UserControlPoll();
        UserControlPost uc_post = new UserControlPost();
        UserControlSettings uc_settings = new UserControlSettings();
        UserControlTeams uc_teams = new UserControlTeams();
        public static UserControlLogin uc_login = new UserControlLogin();
        public UserControlSignup uc_signup = new UserControlSignup();

        public bool isAuthorized = false;
        string password = uc_login.password;
        public bool isAdmin;
        string currentUsername;
        int currentUserId;

        // lists storing the three categories of home feed (posts, polls, events)
        List<string[]> postList = new List<string[]>();
        List<string[]> pollList = new List<string[]>();
        List<string[]> eventList = new List<string[]>();

        // used to send instance reference of MainForm username to user controls
        public void SetCurrentUsername(string username)
        {
            this.currentUsername = username;
        }
        public void SetCurrentUserIdPoll()
        {
            uc_poll.currentUserId = currentUserId;
        }
        public void SetCurrentUserIdPost()
        {
            uc_post.currentUserId = currentUserId;
        }
        public void SetCurrentUserIdEvent()
        {
            uc_event.currentUserId = currentUserId;
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

        // UC instances for feed views
        UserControlPollView uc_pollView = new UserControlPollView();
        UserControlEventView uc_eventView = new UserControlEventView();
        UserControlPostView uc_postView = new UserControlPostView();

        #region Tab Click Operations
        /// <summary>
        /// relocates active tab marker & changes tab header text
        /// clears FlowLayoutPanel & adds new tab uc on click
        /// </summary>
        public void picbox_home_Click(object sender, EventArgs e)
        {
            if (!isAuthorized)
            {
                btn_loadFeed.Visible = false;
                checkbox_Events.Visible = false;
                checkbox_polls.Visible = false;
                checkbox_posts.Visible = false;
                picBox_DownArrow.Visible = false;
                picBox_UpArrow.Visible = false;
                panel_ActiveTab.Location = new Point(3, picbox_home.Location.Y);
                label_TabHeader.Text = "Home";
                FlowLayoutPanel.Controls.Clear();
                FlowLayoutPanel.Controls.Add(uc_login);
            }
            else
            {
                btn_loadFeed.Visible = true;
                checkbox_Events.Visible = true;
                checkbox_polls.Visible = true;
                checkbox_posts.Visible = true;
                picBox_DownArrow.Visible = true;
                picBox_UpArrow.Visible = true;
                panel_ActiveTab.Location = new Point(3, picbox_home.Location.Y);
                label_TabHeader.Text = "Home";
                FlowLayoutPanel.Controls.Clear();
                FlowLayoutPanel.Controls.Add(uc_home);
            }
        }

        private void picbox_contacts_Click(object sender, EventArgs e)
        {
            if (isAuthorized)
            {
                btn_loadFeed.Visible = false;
                checkbox_Events.Visible = false;
                checkbox_polls.Visible = false;
                checkbox_posts.Visible = false;
                picBox_UpArrow.Visible = false;
                picBox_DownArrow.Visible = false;
                panel_ActiveTab.Location = new Point(3, picbox_contacts.Location.Y);
                label_TabHeader.Text = "Contacts";
                FlowLayoutPanel.Controls.Clear();
                FlowLayoutPanel.Controls.Add(uc_contacts);
            }
            else
                return;
        }

        private void picbox_teams_Click(object sender, EventArgs e)
        {
            if (isAuthorized)
            {
                btn_loadFeed.Visible = false;
                checkbox_Events.Visible = false;
                checkbox_polls.Visible = false;
                checkbox_posts.Visible = false;
                picBox_UpArrow.Visible = false;
                picBox_DownArrow.Visible = false;
                panel_ActiveTab.Location = new Point(3, picbox_teams.Location.Y);
                label_TabHeader.Text = "Teams";
                FlowLayoutPanel.Controls.Clear();
                FlowLayoutPanel.Controls.Add(uc_teams);
            }
            else
                return;
        }

        private void picbox_messages_Click(object sender, EventArgs e)
        {
            if (isAuthorized)
            {
                btn_loadFeed.Visible = false;
                checkbox_Events.Visible = false;
                checkbox_polls.Visible = false;
                checkbox_posts.Visible = false;
                picBox_UpArrow.Visible = false;
                picBox_DownArrow.Visible = false;
                panel_ActiveTab.Location = new Point(3, picbox_messages.Location.Y);
                label_TabHeader.Text = "Messages";
                FlowLayoutPanel.Controls.Clear();
                FlowLayoutPanel.Controls.Add(uc_messages);
            }
            else
                return;
        }

        private void picbox_post_Click(object sender, EventArgs e)
        {
            if (isAuthorized)
            {
                btn_loadFeed.Visible = false;
                checkbox_Events.Visible = false;
                checkbox_polls.Visible = false;
                checkbox_posts.Visible = false;
                picBox_UpArrow.Visible = false;
                picBox_DownArrow.Visible = false;
                panel_ActiveTab.Location = new Point(3, picbox_post.Location.Y);
                label_TabHeader.Text = "Post";
                FlowLayoutPanel.Controls.Clear();
                FlowLayoutPanel.Controls.Add(uc_post);
            }
            else
                return;
        }

        private void picbox_event_Click(object sender, EventArgs e)
        {
            if (isAuthorized)
            {
                btn_loadFeed.Visible = false;
                checkbox_Events.Visible = false;
                checkbox_polls.Visible = false;
                checkbox_posts.Visible = false;
                picBox_UpArrow.Visible = false;
                picBox_DownArrow.Visible = false;
                panel_ActiveTab.Location = new Point(3, picbox_event.Location.Y);
                label_TabHeader.Text = "Event";
                FlowLayoutPanel.Controls.Clear();
                FlowLayoutPanel.Controls.Add(uc_event);
            }
            else
                return;
        }

        private void picbox_poll_Click(object sender, EventArgs e)
        {
            if (isAuthorized)
            {
                btn_loadFeed.Visible = false;
                checkbox_Events.Visible = false;
                checkbox_polls.Visible = false;
                checkbox_posts.Visible = false;
                picBox_UpArrow.Visible = false;
                picBox_DownArrow.Visible = false;
                panel_ActiveTab.Location = new Point(3, picbox_poll.Location.Y);
                label_TabHeader.Text = "Poll";
                FlowLayoutPanel.Controls.Clear();
                FlowLayoutPanel.Controls.Add(uc_poll);
            }
            else
                return;
        }

        private void picbox_log_Click(object sender, EventArgs e)
        {
            if (isAuthorized)
            {
                if (isAdmin)
                {
                    btn_loadFeed.Visible = false;
                    checkbox_Events.Visible = false;
                    checkbox_polls.Visible = false;
                    checkbox_posts.Visible = false;
                    picBox_UpArrow.Visible = false;
                    picBox_DownArrow.Visible = false;
                    panel_ActiveTab.Location = new Point(3, picbox_log.Location.Y);
                    label_TabHeader.Text = "Log";
                    FlowLayoutPanel.Controls.Clear();
                    FlowLayoutPanel.Controls.Add(uc_log);
                }
                else
                {
                    MessageBox.Show("Admin Status Required");
                }
            }
            else
                return;
        }

        private void picbox_settings_Click(object sender, EventArgs e)
        {
            if (isAuthorized)
            {
                btn_loadFeed.Visible = false;
                checkbox_Events.Visible = false;
                checkbox_polls.Visible = false;
                checkbox_posts.Visible = false;
                picBox_UpArrow.Visible = false;
                picBox_DownArrow.Visible = false;
                panel_ActiveTab.Location = new Point(3, picbox_settings.Location.Y);
                label_TabHeader.Text = "Settings";
                FlowLayoutPanel.Controls.Clear();
                FlowLayoutPanel.Controls.Add(uc_settings);
            }
            else
                return;
        }

        private void picbox_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        #endregion

        // shows new form to submit report
        private void picbox_report_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.Show();
        }

        // backcolor states for up arrow control
        private void picBox_UpArrow_MouseDown(object sender, MouseEventArgs e)
        {
            picBox_UpArrow.BackColor = Color.Maroon;
        }

        private void picBox_UpArrow_MouseUp(object sender, MouseEventArgs e)
        {
            if (picBox_UpArrow.ClientRectangle.Contains(e.Location))
                picBox_UpArrow.BackColor = Color.Brown;
            else
                picBox_UpArrow.BackColor = Color.MistyRose;
        }

        private void picBox_UpArrow_MouseEnter(object sender, EventArgs e)
        {
            picBox_UpArrow.BackColor= Color.Brown;
        }

        private void picBox_UpArrow_MouseLeave(object sender, EventArgs e)
        {
            picBox_UpArrow.BackColor = Color.MistyRose;
        }

        // backcolor states for down arrow control
        private void picBox_DownArrow_MouseDown(object sender, MouseEventArgs e)
        {
            picBox_DownArrow.BackColor = Color.Maroon;
        }

        private void picBox_DownArrow_MouseUp(object sender, MouseEventArgs e)
        {
            if (picBox_DownArrow.ClientRectangle.Contains(e.Location))
                picBox_DownArrow.BackColor = Color.Brown;
            else
                picBox_DownArrow.BackColor = Color.MistyRose;
        }

        private void picBox_DownArrow_MouseEnter(object sender, EventArgs e)
        {
            picBox_DownArrow.BackColor = Color.Brown;
        }

        private void picBox_DownArrow_MouseLeave(object sender, EventArgs e)
        {
            picBox_DownArrow.BackColor = Color.MistyRose;
        }

        // arrow boxes refresh user control with next or previous media feed item from database
        private void picBox_UpArrow_Click(object sender, EventArgs e)
        {
            // DB Conn -- traverse table UP
        }

        private void picBox_DownArrow_Click(object sender, EventArgs e)
        {
            // DB Conn -- traverse table DOWN
        }

        private void btn_loadFeed_Click(object sender, EventArgs e)
        {
            if (checkbox_Events.Checked == false && checkbox_polls.Checked == false && checkbox_posts.Checked == false)
            {
                MessageBox.Show("Select a category from below before loading feed");
            }
            else
            {
                btn_loadFeed.Visible = false;

                if (checkbox_Events.Checked) // show event view
                {
                    LoadEvents();
                    FlowLayoutPanel.Controls.Clear();
                    FlowLayoutPanel.Controls.Add(uc_eventView);
                }
                else if(checkbox_polls.Checked) // show poll view
                {
                    LoadPolls();
                    FlowLayoutPanel.Controls.Clear();
                    FlowLayoutPanel.Controls.Add(uc_pollView);
                }
                else // show post view
                {
                    LoadPosts();
                    FlowLayoutPanel.Controls.Clear();
                    FlowLayoutPanel.Controls.Add(uc_postView);
                }
            }
        }

        private void LoadPosts()
        {
            // clears all items to reload the list
            postList.Clear();

            // Create a connection to the SQL database
            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Create a SQL command to retrieve data from the posts table
            string commandText = "SELECT title, body, tag, likes FROM posts ORDER BY created DESC";
            SqlCommand command = new SqlCommand(commandText, connection);

            // Open the database connection
            connection.Open();

            // Execute the command and store data in list
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] post = new string[4];
                    post[0] = reader.GetString(0);              // title
                    post[1] = reader.GetString(1);              // body
                    post[2] = reader.GetString(2);              // tag
                    post[3] = reader.GetInt32(3).ToString();    // likes
                    postList.Add(post);
                }
            }
            else
                MessageBox.Show("No feed available from this category");


            // Close the data reader and the database connection
            reader.Close();
            connection.Close();
        }

        private void LoadPolls()
        {
            // clears all items to reload the list
            pollList.Clear();

            // Create a connection to the SQL database
            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Create a SQL command to retrieve data from the posts table
            string commandText = "SELECT title, option1, option2, option3, option4, option5, vote_option1, vote_option2, vote_option3, vote_option4, vote_option5 " +
                                 "FROM polls ORDER BY created DESC";
            SqlCommand command = new SqlCommand(commandText, connection);

            // Open the database connection
            connection.Open();

            // Execute the command and store data in list
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] poll = new string[11];
                    poll[0] = reader.GetString(0);              // title
                    poll[1] = reader.GetString(1);              // option1
                    poll[2] = reader.GetString(2);              // option2
                    poll[3] = reader.GetString(3);              // option3
                    poll[4] = reader.GetString(4);              // option4
                    poll[5] = reader.GetString(5);              // option5
                    poll[6] = reader.GetInt32(6).ToString();    // vote_option1
                    poll[7] = reader.GetInt32(7).ToString();    // vote_option2
                    poll[8] = reader.GetInt32(8).ToString();    // vote_option3
                    poll[9] = reader.GetInt32(9).ToString();    // vote_option4
                    poll[10] = reader.GetInt32(10).ToString();  // vote_option5
                    pollList.Add(poll);
                }
            }
            else
                MessageBox.Show("No feed available from this category");

            // Close the data reader and the database connection
            reader.Close();
            connection.Close();
        }

        private void LoadEvents()
        {
            // clears all items to reload the list
            eventList.Clear();

            // Create a connection to the SQL database
            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Create a SQL command to retrieve data from the posts table
            string commandText = "SELECT title, date, description, attendees FROM events ORDER BY created DESC";
            SqlCommand command = new SqlCommand(commandText, connection);

            // Open the database connection
            connection.Open();

            // Execute the command and store data in list
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] events = new string[4];
                    events[0] = reader.GetString(0);              // title
                    events[1] = reader.GetDateTime(1).ToString(); // date
                    events[2] = reader.GetString(2);              // description
                    events[3] = reader.GetInt32(3).ToString();    // attendees
                    eventList.Add(events);
                }
            }
            else
                MessageBox.Show("No feed available from this category");


            // Close the data reader and the database connection
            reader.Close();
            connection.Close();
        }

        // makes sure only one checkbox is checked at a time for loading category feed
        private void checkbox_posts_Click(object sender, EventArgs e)
        {
            checkbox_Events.Checked = false;
            checkbox_polls.Checked = false;
        }

        private void checkbox_polls_Click(object sender, EventArgs e)
        {
            checkbox_Events.Checked = false;
            checkbox_posts.Checked = false;
        }

        private void checkbox_Events_Click(object sender, EventArgs e)
        {
            checkbox_posts.Checked = false;
            checkbox_polls.Checked = false;
            
        }

        private void checkbox_posts_CheckedChanged(object sender, EventArgs e)
        {
            btn_loadFeed.Visible = true;
            FlowLayoutPanel.Controls.Clear();
        }

        private void checkbox_polls_CheckedChanged(object sender, EventArgs e)
        {
            btn_loadFeed.Visible = true;
            FlowLayoutPanel.Controls.Clear();
        }

        private void checkbox_Events_CheckedChanged(object sender, EventArgs e)
        {
            btn_loadFeed.Visible = true;
            FlowLayoutPanel.Controls.Clear();
        }
    }
}
