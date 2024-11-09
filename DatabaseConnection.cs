using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
    internal class DatabaseConnection
    {
        string connectionString =
       @"Server=DESKTOP-EQ55Q8H\SQLEXPRESS;Database = ElevatorLogs;Trusted_Connection=True;";


        public void InsertLogIntoDB(DateTime logTime, string eventDescription)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Logs (logtime, eventdescription) VALUES (@logtime, @eventdescription)";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@logtime", logTime);
                        command.Parameters.AddWithValue("@eventdescription", eventDescription);

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving logs into Database: " + ex.Message);
            }
        }

        public DataTable FetchDataFromDb()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT id, logtime, eventdescription FROM logs ORDER BY logtime"; 

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }


        public bool DeleteLogById(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM logs WHERE id = @id"; 

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if a row was deleted
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; // Return false if there's an error
            }
        }


    }


}
