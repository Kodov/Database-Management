using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string username = uc_login.username;
        string password = uc_login.password;
        public bool isAdmin;

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
                picBox_DownArrow.Visible = false;
                picBox_UpArrow.Visible = false;
                panel_ActiveTab.Location = new Point(3, picbox_home.Location.Y);
                label_TabHeader.Text = "Home";
                FlowLayoutPanel.Controls.Clear();
                FlowLayoutPanel.Controls.Add(uc_login);
            }
            else
            {
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
                    picBox_UpArrow.Visible = false;
                    picBox_DownArrow.Visible = false;
                    panel_ActiveTab.Location = new Point(3, picbox_log.Location.Y);
                    label_TabHeader.Text = "Log";
                    FlowLayoutPanel.Controls.Clear();
                    FlowLayoutPanel.Controls.Add(uc_log);
                }
                else
                {
                    MessageBox.Show("Admin Privilege Required");
                }
            }
            else
                return;
        }

        private void picbox_settings_Click(object sender, EventArgs e)
        {
            if (isAuthorized)
            {
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
    }
}
