using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Inventory.functions
{
    class Transactions
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();

        public static long  transaction_code = 0;

        public long TransactionCode
        {
            get { return transaction_code; }
            set { transaction_code = value; }
        }

        public void GenerateTransactionCode()
        {
            string datenow = DateTime.Now.ToString("yyyyMMdd");

            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM inventorydb.tbltransactions WHERE transactiondate = " + DateTime.Today.ToString("d");
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count != 0)
                        {
                            int rowcount = dt.Rows.Count + 1;
                            transaction_code = long.Parse(datenow + rowcount.ToString());
                        }
                        else
                        {
                            transaction_code = long.Parse(datenow + 1);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creating transaction code: " + e);
            }
        }
    }
}
