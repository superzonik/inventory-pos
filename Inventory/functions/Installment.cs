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
    class Installment
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Logs logs = new Logs();


        public static int installment_id = 0;
        public static double installment_principalamount = 0;
        public static double installment_balance = 0;

        public int InstallmentID
        {
            get { return installment_id; }
            set { installment_id = value; }
        }

        public double InstallmentPrincipalAmount
        {
            get { return installment_principalamount; }
            set { installment_principalamount = value; }
        }

        public double InstallmentBalance
        {
            get { return installment_balance; }
            set { installment_balance = value; }
        }

        public void GenerateInstallmentID()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM inventorydb.tblinstallment";
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
                            installment_id = int.Parse(rowcount.ToString());
                        }
                        else
                        {
                            installment_id = 1;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creating transaction code: " + e);
            }
        }

        public bool SaveInstallment(int mInstallmentID, int mClientID, double mPrincipalAmount, int mPaymentTerm, double mMonthlyDue, double mInterest, int mUserID,
            DateTime mDateCreated, string mDueDate, double mInstallmentBalance, double mDownpayment)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO inventorydb.tblinstallment" +
                        "(installmentid, clientid, principalamount, paymentterm, monthlydue, interest, userid, datecreated, duedate, installmentbalance, downpayment) " +
                        "VALUES(@installmentid, @clientid, @principalamount, @paymentterm, @monthlydue, @interest, @userid, @datecreated, @duedate, @installmentbalance, @downpayment);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@installmentid", mInstallmentID);
                        cmd.Parameters.AddWithValue("@clientid", mClientID);
                        cmd.Parameters.AddWithValue("@principalamount", mPrincipalAmount);
                        cmd.Parameters.AddWithValue("@paymentterm", mPaymentTerm);
                        cmd.Parameters.AddWithValue("@monthlydue", mMonthlyDue);
                        cmd.Parameters.AddWithValue("@interest", mInterest);
                        cmd.Parameters.AddWithValue("@userid", mUserID);
                        cmd.Parameters.AddWithValue("@datecreated", mDateCreated);
                        cmd.Parameters.AddWithValue("@duedate", mDueDate);
                        cmd.Parameters.AddWithValue("@installmentbalance", mInstallmentBalance);
                        cmd.Parameters.AddWithValue("@downpayment", mDownpayment);

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
                Console.WriteLine("Error saving installment: " + e);
                return false;
            }
        }

        public bool SaveInstallmentDetails(int mInstallmentID, double mPaymentAmount, DateTime mPaymentDate, int mUserID)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO inventorydb.tblinstallmentdetails(installmentid, paymentamount, paymentdate, userid) " +
                        "VALUES (@installmentid, @paymentamount, @paymentdate, @userid);";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@installmentid", mInstallmentID);
                        cmd.Parameters.AddWithValue("@paymentamount", mPaymentAmount);
                        cmd.Parameters.AddWithValue("@paymentdate", mPaymentDate);
                        cmd.Parameters.AddWithValue("@userid", mUserID);

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
                Console.WriteLine("Error saving installment details: " + e);
                return false;
            }
        }

        public void LoadInstallmentDataToGrid(DataGridView mDatagrid, Label lblRecordCount)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT tblinstallment.installmentid as 'installmentid', tblclients.clientname as 'clientname', tblinstallment.principalamount as 'principalamount', " +
                        "tblinstallment.installmentbalance as 'balance', tblclients.clientid as 'clientid' FROM inventorydb.tblinstallment INNER JOIN inventorydb.tblclients ON tblinstallment.clientid = tblclients.clientid;";
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
                            mDatagrid.Columns["installmentid"].Visible = false;
                            mDatagrid.Columns["clientname"].HeaderText = "Client Name";
                            mDatagrid.Columns["clientname"].Width = 150;
                            mDatagrid.Columns["principalamount"].HeaderText = "Principal Amount";
                            mDatagrid.Columns["principalamount"].DefaultCellStyle.Format = "N2";
                            mDatagrid.Columns["principalamount"].Width = 100;
                            mDatagrid.Columns["principalamount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            mDatagrid.Columns["principalamount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                            mDatagrid.Columns["balance"].HeaderText = "Balance";
                            mDatagrid.Columns["balance"].DefaultCellStyle.Format = "N2";
                            mDatagrid.Columns["balance"].Width = 100;
                            mDatagrid.Columns["balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                            mDatagrid.Columns["clientid"].Visible = false;

                            lblRecordCount.Text = mDatagrid.RowCount.ToString();
                        }
                    }

                }
            }
            catch (Exception e)
            {
                //LOG ERROR IN LOADING ITEM DATA TO DATAGRID
                logs.logthis("Error loading installment data to datagrid: " + e);
            }
        }

        public void LoadPaymentDataToGrid(DataGridView mDatagrid, int mInstallmentID)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM inventorydb.tblinstallmentdetail WHERE installmentid = @installmentid ORDER BY paymentdate ASC;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                        cmd.Parameters.AddWithValue("@installmentid", mInstallmentID);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count != 0)
                        {
                            mDatagrid.DataSource = dt;
                            mDatagrid.Columns["installmentdetailid"].Visible = false;
                            mDatagrid.Columns["installmentid"].Visible= false;
                            mDatagrid.Columns["paymentdate"].DisplayIndex = 0;
                            mDatagrid.Columns["paymentdate"].HeaderText = "Payment Date";
                            mDatagrid.Columns["paymentdate"].Width = 100;
                            mDatagrid.Columns["paymentamount"].DisplayIndex = 1;
                            mDatagrid.Columns["paymentamount"].DefaultCellStyle.Format = "N2";
                            mDatagrid.Columns["paymentamount"].Width = 100;
                            mDatagrid.Columns["paymentamount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            mDatagrid.Columns["username"].DisplayIndex = 2;
                            mDatagrid.Columns["username"].HeaderText = "Processed By";
                            mDatagrid.Columns["username"].Width = 150;

                        }
                    }

                }
            }
            catch (Exception e)
            {
                //LOG ERROR IN LOADING ITEM DATA TO DATAGRID
                logs.logthis("Error loading payment data to datagrid: " + e);
            }
        }
    }
}
