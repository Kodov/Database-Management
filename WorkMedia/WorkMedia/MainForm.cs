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
        }

        // create instances of user controls corresponding to (panel) tab views
        UserControlContacts uc_contacts = new UserControlContacts();
        UserControlHome uc_home = new UserControlHome();
        UserControlEvent uc_event = new UserControlEvent();
        UserControlLog uc_log = new UserControlLog();
        UserControlMessages uc_messages = new UserControlMessages();
        UserControlPoll uc_poll = new UserControlPoll();
        UserControlPost uc_post = new UserControlPost();
        UserControlSettings uc_settings = new UserControlSettings();
        UserControlTeams uc_teams = new UserControlTeams();

        #region Tab Click Operations
        /// <summary>
        /// relocates active tab marker & changes tab header text
        /// clears FlowLayoutPanel & adds new tab uc on click
        /// </summary>
        private void picbox_home_Click(object sender, EventArgs e)
        {
            panel_ActiveTab.Location = new Point(3, picbox_home.Location.Y);
            label_TabHeader.Text = "Home";
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(uc_home);
        }

        private void picbox_contacts_Click(object sender, EventArgs e)
        {
            panel_ActiveTab.Location = new Point(3, picbox_contacts.Location.Y);
            label_TabHeader.Text = "Contacts";
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(uc_contacts);
        }

        private void picbox_teams_Click(object sender, EventArgs e)
        {
            panel_ActiveTab.Location = new Point(3, picbox_teams.Location.Y);
            label_TabHeader.Text = "Teams";
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(uc_teams);
        }

        private void picbox_messages_Click(object sender, EventArgs e)
        {
            panel_ActiveTab.Location = new Point(3, picbox_messages.Location.Y);
            label_TabHeader.Text = "Messages";
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(uc_messages);
        }

        private void picbox_post_Click(object sender, EventArgs e)
        {
            panel_ActiveTab.Location = new Point(3, picbox_post.Location.Y);
            label_TabHeader.Text = "Post";
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(uc_post);
        }

        private void picbox_event_Click(object sender, EventArgs e)
        {
            panel_ActiveTab.Location = new Point(3, picbox_event.Location.Y);
            label_TabHeader.Text = "Event";
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(uc_event);
        }

        private void picbox_poll_Click(object sender, EventArgs e)
        {
            panel_ActiveTab.Location = new Point(3, picbox_poll.Location.Y);
            label_TabHeader.Text = "Poll";
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(uc_poll);
        }

        private void picbox_log_Click(object sender, EventArgs e)
        {
            panel_ActiveTab.Location = new Point(3, picbox_log.Location.Y);
            label_TabHeader.Text = "Log";
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(uc_log);
        }

        private void picbox_settings_Click(object sender, EventArgs e)
        {
            panel_ActiveTab.Location = new Point(3, picbox_settings.Location.Y);
            label_TabHeader.Text = "Settings";
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(uc_settings);
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
    }
}
