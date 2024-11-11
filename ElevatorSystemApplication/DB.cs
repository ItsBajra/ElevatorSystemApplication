using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorControl
{
    internal class DB
    {
        private bool filled;
        public DataSet ds = new DataSet();

        public void insertdata(string action, System.Windows.Forms.ListBox database_listbox)
        {
            string dbconnection = "Server=BAJRA;Database=lift;Trusted_Connection=True;";
            string dbcommand = "INSERT INTO Actions (Date, Time, Action) VALUES (@date, @time, @action)";

            using (SqlConnection conn_db = new SqlConnection(dbconnection))
            {
                SqlCommand comm_insert = new SqlCommand(dbcommand, conn_db);
                comm_insert.Parameters.AddWithValue("@date", DateTime.Now.Date);  // Passing only the date part
                comm_insert.Parameters.AddWithValue("@time", DateTime.Now.TimeOfDay);  // Passing only the time part
                comm_insert.Parameters.AddWithValue("@action", action);

                conn_db.Open();
                comm_insert.ExecuteNonQuery();
            }

            database_listbox.Items.Add(DateTime.Now.ToShortDateString() + "\t\t" + DateTime.Now.ToLongTimeString() + "\t\t" + action);
        }

        public void fetch_data (System.Windows.Forms.ListBox database_listbox)
        {

            try
            {
                string dbconnection = "Server=BAJRA;Database=lift;Trusted_Connection=True;";
                string dbcommand = "SELECT * FROM Actions;";

                using (SqlConnection conn = new SqlConnection(dbconnection))
                {
                    SqlCommand comm = new SqlCommand(dbcommand, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);

                    conn.Open();
                    while (filled == false)
                    {
                        adapter.Fill(ds);
                        filled = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot open connection!");
                string message = "Error in connection to datasource";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }

            database_listbox.Items.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                // Formatting date
                string date = Convert.ToDateTime(row["Date"]).ToShortDateString();

                // Formatting time to 12-hour format with AM/PM
                string time = DateTime.TryParse(row["Time"].ToString(), out DateTime parsedTime)
                             ? parsedTime.ToString("hh:mm:ss tt") // 12-hour format 
                             : row["Time"].ToString();

                // Add formatted string to the listbox
                database_listbox.Items.Add($"{date}\t\t{time}\t\t{row["Action"]}");
            }
        }
    }
}
