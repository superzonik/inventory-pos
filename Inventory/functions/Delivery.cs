using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.functions
{
    class Delivery
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Logs logs = new functions.Logs();

        public void LoadDeliveryDataToGrid(DataGridView mDatagrid, Label lblRecordCount)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM inventorydb.tbltransactions INNER JOIN inventorydb.tblclients ON tbltransactions.clientid = tblclients.clientid WHERE fordelivery = 1;";
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
                            mDatagrid.Columns["transactionid"].HeaderText = "Transaction ID";
                            mDatagrid.Columns["ornumber"].HeaderText = "OR Number";
                            mDatagrid.Columns["totalsales"].Visible = false;
                            mDatagrid.Columns["discount"].Visible = false;
                            mDatagrid.Columns["tax"].Visible = false;
                            mDatagrid.Columns["totaldue"].HeaderText = "Total Due";
                            mDatagrid.Columns["cashtendered"].Visible = false;
                            mDatagrid.Columns["cashchange"].Visible = false;
                            mDatagrid.Columns["clientid1"].Visible = false;
                            mDatagrid.Columns["userid"].Visible = false;
                            mDatagrid.Columns["transactiondate"].HeaderText = "Transaction Date";
                            mDatagrid.Columns["paymenttype"].Visible = false;
                            mDatagrid.Columns["paymentrefnumber"].Visible = false;
                            mDatagrid.Columns["fordelivery"].Visible = false;
                            mDatagrid.Columns["clientid"].Visible = false;
                            mDatagrid.Columns["clientname"].HeaderText = "Client Name";
                            mDatagrid.Columns["clientaddress"].HeaderText = "Address";
                            mDatagrid.Columns["clientaddress"].Width = 200;
                            mDatagrid.Columns["contactperson"].HeaderText = "Contact Person";
                            mDatagrid.Columns["salesagent"].Visible = false;
                            mDatagrid.Columns["remarks"].Visible = false;

                            lblRecordCount.Text = mDatagrid.RowCount.ToString();
                        } 
                        else
                        {
                            mDatagrid.Refresh();
                            mDatagrid.Visible = false;
                            lblRecordCount.Text = "0";
                        }
                    }

                }
            }
            catch (Exception e)
            {
                //LOG ERROR IN LOADING ITEM DATA TO DATAGRID
                logs.logthis("Error loading delivery data to datagrid: " + e);
            }
        }

        public void LoadDeliveredDataToGrid(DataGridView mDatagrid, Label lblRecordCount)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM inventorydb.tbltransactions INNER JOIN inventorydb.tblclients ON tbltransactions.clientid = tblclients.clientid WHERE fordelivery = 2 ORDER BY transactiondate ASC;";
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
                            mDatagrid.Columns["transactionid"].HeaderText = "Transaction ID";
                            mDatagrid.Columns["ornumber"].HeaderText = "OR Number";
                            mDatagrid.Columns["totalsales"].Visible = false;
                            mDatagrid.Columns["discount"].Visible = false;
                            mDatagrid.Columns["tax"].Visible = false;
                            mDatagrid.Columns["totaldue"].HeaderText = "Total Due";
                            mDatagrid.Columns["totaldue"].DefaultCellStyle.Format = "N2";
                            mDatagrid.Columns["cashtendered"].Visible = false;
                            mDatagrid.Columns["cashchange"].Visible = false;
                            mDatagrid.Columns["clientid"].Visible = false;
                            mDatagrid.Columns["userid"].Visible = false;
                            mDatagrid.Columns["transactiondate"].HeaderText = "Transaction Date";
                            mDatagrid.Columns["transactiondate"].DisplayIndex = 0;
                            mDatagrid.Columns["paymenttype"].Visible = false;
                            mDatagrid.Columns["paymentrefnumber"].Visible = false;
                            mDatagrid.Columns["fordelivery"].Visible = false;
                            mDatagrid.Columns["clientid1"].Visible = false;
                            mDatagrid.Columns["clientname"].HeaderText = "Client Name";
                            mDatagrid.Columns["clientaddress"].HeaderText = "Address";
                            mDatagrid.Columns["clientaddress"].Width = 200;
                            mDatagrid.Columns["contactperson"].HeaderText = "Contact Person";
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
                logs.logthis("Error loading delivery data to datagrid: " + e);
            }
        }

        public bool AddDeliveryInfo(string mDRnum, string mDeliveredBy, DateTime mDeliveryDate, string mDeliveryRemarks, int mTransactionID)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO inventorydb.tbldelivery(drnum, deliveredby, deliverydate, deliveryremarks, transactionid) " +
                        "VALUES (@drnum, @deliveredby, @deliverydate, @deliveryremarks, @transactionid);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@drnum", mDRnum);
                        cmd.Parameters.AddWithValue("@deliveredby", mDeliveredBy);
                        cmd.Parameters.AddWithValue("@deliverydate", mDeliveryDate);
                        cmd.Parameters.AddWithValue("@deliveryremarks", mDeliveryRemarks);
                        cmd.Parameters.AddWithValue("@transactionid", mTransactionID);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        MessageBox.Show("Delivery data successfully saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error adding item data: " + e);
                return false;
            }

        }
        
        public bool EditDeliveryInfo(int mDeliveryID, string mDrnum, string mDeliveredBy, DateTime mDeliveryDate, string mDeliveryRemarks)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"UPDATE inventorydb.tbldelivery SET drnum=@drnum, deliveredby=@deliveredby, deliverydate=@deliverydate, " +
                        "deliveryremarks=@deliveryremarks WHERE deliveryid=@deliveryid;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@deliveryid", mDeliveryID);
                        cmd.Parameters.AddWithValue("@drnum", mDrnum);
                        cmd.Parameters.AddWithValue("@deliveredby", mDeliveredBy);
                        cmd.Parameters.AddWithValue("@deliverydate", mDeliveryDate);
                        cmd.Parameters.AddWithValue("@deliveryremarks", mDeliveryRemarks);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        MessageBox.Show("Delivery data successfully saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error updating data: " + e);
                return false;
            }
        }

        public bool DeleteDeliveryInfo(int mDeliveryID)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"DELETE FROM inventorydb.tbldelivery WHERE deliveryid=@deliveryid;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@deliveryid", mDeliveryID);

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
                Console.WriteLine("Error deleting delivery record: " + e);
                return false;
            }
        }
    }
}
