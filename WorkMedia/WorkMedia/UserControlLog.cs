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
    public partial class UserControlLog : UserControl
    {
        
        public UserControlLog()
        {
            InitializeComponent();
            filter_date.Enabled = false;
        }

        private void Log_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Filters_Check_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filter_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Filters_Check_List_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Uncheck the previously checked box
            for (int i = 0; i < Filters_Check_List.Items.Count; i++)
            {
                if (i != e.Index && Filters_Check_List.GetItemChecked(i))
                {
                    Filters_Check_List.SetItemChecked(i, false);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
            string query = "SELECT logs.action, logs.login, logs.user_id " +
                           "FROM logs ";

            // alters query syntax in case date selection is added
            bool addDate = false;

            // Check if the DateTimePicker is checked
            if (filter_date.Enabled)
            {
                query += "WHERE CAST(logs.login AS DATE) = '" + filter_date.Value.ToString("yyyy-MM-dd") + "'";
                // flags date selection to alter filter check syntax
                addDate = true;
            }
            else
            {
                // sets query back to default
                query = "SELECT logs.action, logs.login, logs.user_id " +
                           "FROM logs ";
            }

            string selectedFilter = Filters_Check_List.CheckedItems.Count > 0 ? Filters_Check_List.CheckedItems[0].ToString() : "";
            // alters to 'AND' statement to match syntax query
            if (addDate && selectedFilter != "")
            {
                query += "AND logs.action = '" + selectedFilter + "'";
            }
            else if (selectedFilter != "")
            {
                query += "WHERE logs.action = '" + selectedFilter + "'";
                // resets bool flag in case a new search occurs with date included
                addDate = false;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView_Log.DataSource = dataTable;
            }

        }

        private void checkbox_dateFilter_CheckedChanged(object sender, EventArgs e)
        {
            filter_date.Enabled = !filter_date.Enabled;
        }

        // was used to test exact value strings of the DateTimePicker and CheckBoxList
/*        private void btn_getDate_Click(object sender, EventArgs e)
        {
            // shows string value of date time picker
            MessageBox.Show(filter_date.Value.ToString("yyyy-MM-dd"));
            // shows string value of checkbox
            string selectedFilter = Filters_Check_List.CheckedItems.Count > 0 ? Filters_Check_List.CheckedItems[0].ToString() : "";
            MessageBox.Show(selectedFilter);
        }*/
    }
}
