using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Inventory.components
{
    public class Connection
    {
        public string conString = String.Format("datasource={0};port={1};username={2};password={3}",
            Values.server_address, Values.server_port, Values.server_username, Values.server_password);

        //THE GUY FROM YOUTUBE MYSQL CONNECTION
        public static MySqlConnection con;
        public static MySqlCommand cmd;
        public static MySqlDataAdapter da;
        public static MySqlDataReader dr;
        public static DataTable dt;
        public static DataSet ds;
        public static string Conn_String
        {
            get
            {
                return $"server=127.0.0.1;port=3305;username=superzonik;password=4735489;database=inventorydb;sslmode=None";
            }
        }

        public static void Query (string sql)
        {
            using (con = new MySqlConnection(Conn_String))
            {
                con.Open();
                using (cmd = new MySqlCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetData (string sql)
        {
            using (con = new MySqlConnection(Conn_String))
            {
                dt = new DataTable();
                using (da = new MySqlDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataSet DataSet (string sql, string tbl)
        {
            using (con = new MySqlConnection(Conn_String))
            {
                ds = new DataSet();

                using (da = new MySqlDataAdapter(sql, con))
                {
                    da.Fill(ds, tbl);
                }
            }

            return ds;
        }

    }
}
