using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.functions
{
    class Logs
    {
        components.Connection connection = new components.Connection();
        components.Values values = new components.Values();

        public bool logthis (string details)
        {
            try
            {

                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO inventorydb.tbllogs(logtimestamp, logdetails)
                                    VALUES(@timestamp,@logdetails)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        DateTime timestamp = DateTime.Now;
                        cmd.Parameters.AddWithValue("@timestamp", timestamp);
                        cmd.Parameters.AddWithValue("@logdetails", details);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error logging data: " + e);
                return false;
            }
        }
    }
}
