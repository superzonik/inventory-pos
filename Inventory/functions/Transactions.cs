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
        Logs logs = new Logs();

        public static long  transaction_code = 0;
        public static int transaction_success = 0;

        //CLIENT INFORMATION DURING TRANSACTION
        public static int client_id;
        public static string client_name;
        public static string client_address;
        public static string client_contact;
        public static string client_salesagent;
        public static string client_remarks;

        public int ClientID
        {
            get { return client_id; }
            set { client_id = value; }
        }

        public string ClientName
        {
            get { return client_name; }
            set { client_name = value; }
        }

        public string ClientAddress
        {
            get { return client_address; }
            set { client_address = value; }
        }

        public string ClientContact
        {
            get { return client_contact; }
            set { client_contact = value; }
        }

        public string ClientSalesAgent
        {
            get { return client_salesagent; }
            set { client_salesagent = value; }
        }

        public string ClientRemarks
        {
            get { return client_remarks; }
            set { client_remarks = value; }
        }

        public int TransactionSuccess
        {
            get { return transaction_success; }
            set { transaction_success = value; }
        }

        public long TransactionCode
        {
            get { return transaction_code; }
            set { transaction_code = value; }
        }

        public void GenerateTransactionCode()
        {
            string datenow = DateTime.Now.ToString("yyyy-MM-dd");
            string dateforcode = DateTime.Now.ToString("yyyyMMdd");

            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM inventorydb.tbltransactions WHERE transactiondate >= '" + datenow + "'";
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
                            transaction_code = long.Parse(dateforcode + rowcount.ToString());
                        }
                        else
                        {
                            transaction_code = long.Parse(dateforcode + 1);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creating transaction code: " + e);
            }
        }


        public items GetTransactionDetail(long  transaction_id)
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM inventorydb.tbltransactions 
                            inner join inventorydb.tbltransactiondetails on tbltransactions.transactionid = tbltransactiondetails.transactionid
                            inner join inventorydb.tblitems on tbltransactiondetails.itemid = tblitems.itemid
                            inner join inventorydb.tblclients on tbltransactions.clientid = tblclients.clientid
                            inner join inventorydb.tblinstallment on tbltransactions.paymentrefnumber = tblinstallment.installmentid
                            where tblitems.itemid in (SELECT itemid from inventorydb.tbltransactiondetails where tbltransactiondetails.transactionid = @id)
                            and tbltransactions.transactionid = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", transaction_id);
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        items dsItems = new items();
                        dt.Clear();
                        da.Fill(dt);
                        da.Fill(dsItems, "installmentreceipt");

                        return dsItems;
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("Error Getting Transaction Data: " + e);
                return null;
            }
        }

        public bool SaveTransaction(int mTransactionID, string mORnum, double mTotalSales, double mDiscount, double mTax, double mTotalDue, double mCashtendered, 
            double mChange, int mClientID, int mUserID, DateTime mTransactionDate, string mPaymentType, int mPaymentReference)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO inventorydb.tbltransactions" +
                        "(transactionid, ornumber, totalsales, discount, tax, totaldue, cashtendered, cashchange, clientid, userid, transactiondate, paymenttype, paymentrefnumber) " + 
                        "VALUES(@transactionid, @ornumber, @totalsales, @discount, @tax, @totaldue, @cashtendered, @change, @clientid, @userid, @transactiondate, @paymenttype, @paymentreference);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@transactionid", mTransactionID);
                        cmd.Parameters.AddWithValue("@ornumber", mORnum);
                        cmd.Parameters.AddWithValue("@totalsales", mTotalSales);
                        cmd.Parameters.AddWithValue("@discount", mDiscount);
                        cmd.Parameters.AddWithValue("@tax", mTax);
                        cmd.Parameters.AddWithValue("@totaldue", mTotalDue);
                        cmd.Parameters.AddWithValue("@cashtendered", mCashtendered);
                        cmd.Parameters.AddWithValue("@change", mChange);
                        cmd.Parameters.AddWithValue("@clientid", mClientID);
                        cmd.Parameters.AddWithValue("@userid", mUserID);
                        cmd.Parameters.AddWithValue("@transactiondate", mTransactionDate);
                        cmd.Parameters.AddWithValue("@paymenttype", mPaymentType);
                        cmd.Parameters.AddWithValue("@paymentreference", mPaymentReference);

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
                Console.WriteLine("Error saving transaction: " + e);
                return false;
            }
        }

        public bool SaveTransactionDetails(long mTransactionID, int mItemID, int mQuantity, double mTotalPrice)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO inventorydb.tbltransactiondetails(transactionid, itemid, itemquantity, itemtotalprice) " +
                        "VALUES (@transactionid, @itemid, @itemquantity, @itemtotalprice);";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@transactionid", mTransactionID);
                        cmd.Parameters.AddWithValue("@itemid", mItemID);
                        cmd.Parameters.AddWithValue("@itemquantity", mQuantity);
                        cmd.Parameters.AddWithValue("@itemtotalprice", mTotalPrice);

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
                Console.WriteLine("Error saving transaction details: " + e);
                return false;
            }
        }

        public bool SaveClientInfo(string mClientName, string mClientAddress, string mContactPerson, string mSalesAgent, string mRemarks)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO inventorydb.tblclients(clientname, clientaddress, contactperson, salesagent, remarks) " +
                        "VALUES (@clientname, @clientaddress, @contactperson, @salesagent, @remarks);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@clientname", mClientName);
                        cmd.Parameters.AddWithValue("@clientaddress", mClientAddress);
                        cmd.Parameters.AddWithValue("@contactperson", mContactPerson);
                        cmd.Parameters.AddWithValue("@salesagent", mSalesAgent);
                        cmd.Parameters.AddWithValue("@remarks", mRemarks);

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
                Console.WriteLine("Error saving client data: " + e);
                return false;
            }
        }

        public void loadClientData(DataGridView mDatagrid, Label lblRecordCount)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM inventorydb.tblclients";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count != 0)
                        {
                            mDatagrid.DataSource = dt;
                            mDatagrid.Columns["clientid"].Visible = false;
                            mDatagrid.Columns["clientname"].HeaderText = "Customer Name";
                            mDatagrid.Columns["clientaddress"].HeaderText = "Customer Address";
                            mDatagrid.Columns["clientaddress"].Width = 100;
                            mDatagrid.Columns["contactperson"].Visible = false;
                            mDatagrid.Columns["salesagent"].Visible = false;
                            mDatagrid.Columns["remarks"].Visible = false;

                            lblRecordCount.Text = mDatagrid.RowCount.ToString();
                        }
                    }

                }
            }
            catch (Exception e)
            {
                //LOG ERROR IN LOADING ITEM DATA TO DATAGRID

                Console.WriteLine("Error loading client data to datagrid: " + e);
            }
        }
    }
}
