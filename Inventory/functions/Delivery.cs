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
                    string sql = @"SELECT * FROM inventorydb.tbldelivery;";
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
                            mDatagrid.Columns["deliveryid"].Visible = false;
                            mDatagrid.Columns["drnum"].HeaderText = "DR Number";
                            mDatagrid.Columns["deliveredby"].HeaderText = "Delivered By";
                            mDatagrid.Columns["deliveredby"].Width = 200;
                            mDatagrid.Columns["deliverydate"].HeaderText = "Delivery Date";
                            mDatagrid.Columns["deliveryremarks"].HeaderText = "Remarks";
                            mDatagrid.Columns["deliveryremarks"].Width = 300;

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

        public bool AddDeliveryInfo(string mDRnum, string mDeliveredBy, DateTime mDeliveryDate, string mDeliveryRemarks)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO inventorydb.tbldelivery(drnum, deliveredby, deliverydate, deliveryremarks) " +
                        "VALUES (@drnum, @deliveredby, @deliverydate, @deliveryremarks);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@drnum", mDRnum);
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
