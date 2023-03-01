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

        public items GetTransactionDetail(string  transaction_id)
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM tbltransactions 
                            inner join tbltransactiondetails on tbltransactions.transactionid = tbltransactiondetails.transactionid
                            inner join tblitems on tbltransactiondetails.itemid = tblitems.itemid
                            inner join tblclients on tbltransactions.clientid = tblclients.clientid
                            where tblitems.itemid in (SELECT itemid from tbltransactiondetails where tbltransactiondetails.transactionid = @id)
                            and tbltransactions.transactionid = @id
                            ";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", transaction_id);
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        items dsItems = new items();
                        dt.Clear();
                        da.Fill(dt);
                        da.Fill(dsItems, "receipt");

                        return dsItems;
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("Error Getting Transaction Data: " + e);
                return null;
            }
        }
    }
}
