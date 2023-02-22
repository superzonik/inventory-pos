using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.functions
{
    class Login
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();

        //Authenticate username and password
        public bool AuthenticateUser(String username, String password)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = "SELECT * FROM inventorydb.tblusers WHERE username = @username AND password = MD5(@password);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        
                        if (dt.Rows.Count == 1)
                        {
                            val.UserID = dt.Rows[0].Field<int>("userid");
                            val.UserName = dt.Rows[0].Field<string>("username");
                            val.UserPassword = dt.Rows[0].Field<string>("password");
                            val.UserLevel = dt.Rows[0].Field<int>("userlevel");

                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Login Error: Incorrect username or password");
                            return false;
                        }
                    }
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool AuthenticateAdmin(String admin_username, String admin_password)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = "SELECT * FROM inventorydb.tblusers WHERE username = @username AND password = MD5(@password);";
                    
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@username", admin_username);
                        cmd.Parameters.AddWithValue("@password", admin_password);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            //DO ADMIN STUFF HERE
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Login Error: Incorrect username or password");
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Authenticating Admin: " + e);
                return false;
            }
        }
    }
}
