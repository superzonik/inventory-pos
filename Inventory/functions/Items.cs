using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.functions
{
    class Items
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Logs logs = new functions.Logs();

        public bool AddItemRecord(string category, string product_name, string fxtype, string fxcapacity, string product_description, string product_status, DateTime? manufacture_date,
            Double product_price, int is_product_sold)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO inventorydb.tblitems(category, productname, fxtype, fxcapacity, productdescription, productstatus, manufacturedate, productprice, isproductsold)" +
                        "VALUES(@category, @productname, @fxtype, @fxcapacity, @productdescription, @productstatus, @manufacturedate, @productprice, @isproductsold)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@productname", product_name);
                        cmd.Parameters.AddWithValue("@fxtype", fxtype);
                        cmd.Parameters.AddWithValue("@fxcapacity", fxcapacity);
                        cmd.Parameters.AddWithValue("@productdescription", product_description);
                        cmd.Parameters.AddWithValue("@productstatus", product_status);
                        cmd.Parameters.AddWithValue("@manufacturedate", manufacture_date);
                        cmd.Parameters.AddWithValue("@productprice", product_price);
                        cmd.Parameters.AddWithValue("@isproductsold", is_product_sold);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        //LOG SUCCESSFUL ITEM ADD
                        logs.logthis(val.UserName + " added new item: " + product_name);

                        return true;

                    }
                }
            }
            catch (Exception e)
            {
                //LOG ERROR IN ADDING ITEM
                logs.logthis("Error adding item: " + e);
                return false;
            }
        }

        public int CountStock(string mProductName)
        {

            int countstock = 0;
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM inventorydb.tblitems WHERE productname = @productname AND isproductsold = 0";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                        cmd.Parameters.AddWithValue("@productname", mProductName);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                                               
                        if (dt.Rows.Count != 0)
                        {
                            countstock = dt.Rows.Count;
                            return countstock;
                        }
                        return countstock;
                    }
                }
            }
            catch (Exception e)
            {
                //LOG ERROR IN COUNTING ITEM STOCK DATA
                logs.logthis("Error counting item stock: " + e);
                return countstock;
            }
        }

        public void loadItemData(DataGridView mDatagrid, Label lblRecordCount)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM inventorydb.tblitems WHERE isproductsold = 0";
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
                            mDatagrid.Columns["itemid"].Visible = false;
                            mDatagrid.Columns["category"].HeaderText = "Category";
                            mDatagrid.Columns["productname"].HeaderText = "Product Name";
                            mDatagrid.Columns["productname"].Width = 300;
                            mDatagrid.Columns["fxtype"].HeaderText = "FireEx Type";
                            mDatagrid.Columns["fxcapacity"].HeaderText = "Capacity";
                            mDatagrid.Columns["productdescription"].HeaderText = "Description";
                            mDatagrid.Columns["productdescription"].Width = 300;
                            mDatagrid.Columns["productstatus"].HeaderText = "Status";
                            mDatagrid.Columns["manufacturedate"].HeaderText = "Manufacture Date";
                            mDatagrid.Columns["productprice"].HeaderText = "Price";
                            mDatagrid.Columns["productprice"].DefaultCellStyle.Format = "N2";
                            mDatagrid.Columns["isproductsold"].Visible = false;
                            mDatagrid.Columns["serialnumber"].Visible = false;

                            lblRecordCount.Text = mDatagrid.RowCount.ToString();
                        }
                    }
                    
                }
            } 
            catch (Exception e)
            {
                //LOG ERROR IN LOADING ITEM DATA TO DATAGRID
                logs.logthis("Error loading item data to datagrid: " + e);
            }
        }

        public void searchItem (string mColumn, string keyword, DataGridView mDatagrid, Label lblRecordCount)
        {
            try
            {
                string column = "";

                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    switch (mColumn)
                    {
                        case "Category":
                            column = "category";
                            break;

                        case "Product Name":
                            column = "productname";
                            break;
                    }

                    string sql = @"SELECT * FROM inventorydb.tblitems WHERE " + column + " LIKE @keyword";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@keyword", String.Format("{0}{1}{2}", "%", keyword, "%"));

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count != 0)
                        {
                            mDatagrid.DataSource = dt;
                            mDatagrid.Columns["itemid"].Visible = false;
                            mDatagrid.Columns["category"].HeaderText = "Category";
                            mDatagrid.Columns["productname"].HeaderText = "Product Name";
                            mDatagrid.Columns["productname"].Width = 300;
                            mDatagrid.Columns["fxtype"].HeaderText = "FireEx Type";
                            mDatagrid.Columns["fxcapacity"].HeaderText = "Capacity";
                            mDatagrid.Columns["productdescription"].HeaderText = "Description";
                            mDatagrid.Columns["productdescription"].Width = 300;
                            mDatagrid.Columns["productstatus"].HeaderText = "Status";
                            mDatagrid.Columns["manufacturedate"].HeaderText = "Manufacture Date";
                            mDatagrid.Columns["productprice"].HeaderText = "Price";
                            mDatagrid.Columns["productprice"].DefaultCellStyle.Format = "N2";
                            mDatagrid.Columns["isproductsold"].Visible = false;
                            mDatagrid.Columns["serialnumber"].Visible = false;

                            lblRecordCount.Text = mDatagrid.RowCount.ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in search module: " + e);
            }
        }

        public bool updateRecord(int mItemID, String mCategory, String mProductName, String mFXtype, String mFXcapacity, String mProductDescription,
            String mProductStatus, DateTime? mManufactureDate, double mProductPrice)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"UPDATE inventorydb.tblitems SET category=@category, productname=@productname, fxtype=@fxtype, fxcapacity=@fxcapacity,
                                productdescription=@productdescription, productstatus=@productstatus, manufacturedate=@manufacturedate, productprice=@productprice
                                WHERE itemid=@itemid;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@category", mCategory);
                        cmd.Parameters.AddWithValue("@productname", mProductName);
                        cmd.Parameters.AddWithValue("@fxtype", mFXtype);
                        cmd.Parameters.AddWithValue("@fxcapacity", mFXcapacity);
                        cmd.Parameters.AddWithValue("@productdescription", mProductDescription);
                        cmd.Parameters.AddWithValue("@productstatus", mProductStatus);
                        cmd.Parameters.AddWithValue("@manufacturedate", mManufactureDate);
                        cmd.Parameters.AddWithValue("@productprice", mProductPrice);
                        cmd.Parameters.AddWithValue("@itemid", mItemID);

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
                Console.WriteLine("Error Updating Product Record: " + e);
                return false;
            }
        }

        public bool updateItemStatus(int mItemID, String mSerialNumber)
        {
            try
            {

                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"UPDATE inventorydb.tblitems SET isproductsold=@isproductsold, serialnumber=@serialnumber
                                WHERE itemid=@itemid;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@serialnumber", mSerialNumber);
                        cmd.Parameters.AddWithValue("@isproductsold", 1);
                        cmd.Parameters.AddWithValue("@itemid", mItemID);

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
                Console.WriteLine("Error Updating Product Status: " + e);
                return false;
            }
        }

        //SET ROW NUMBER FOR DATAGRID
        public void SetRowNumber(DataGridView dtg)
        {
            foreach (DataGridViewRow row in dtg.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        
    }
}
