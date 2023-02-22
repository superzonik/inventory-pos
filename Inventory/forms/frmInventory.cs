using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.forms
{
    public partial class frmInventory : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Items items = new functions.Items();
        functions.Logs logs = new functions.Logs();

        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            items.loadItemData(dtgInventory, lblRecordCount);
            if (dtgInventory.RowCount != 0)
            {
                populateTextboxes(0, dtgInventory);
            }
        }

        private void tileAddNew_Click(object sender, EventArgs e)
        {
            forms.frmAddNewItem addnew = new forms.frmAddNewItem();
            addnew.FormClosing += new FormClosingEventHandler(AddNew_FormClosing);
            addnew.ShowDialog();
        }

        private void AddNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            items.loadItemData(dtgInventory, lblRecordCount);
            dtgInventory.Update();
            dtgInventory.Refresh();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if ((txtKeyword.Text == "") || (cboColumn.Text == ""))
            {
                items.loadItemData(dtgInventory, lblRecordCount);
            }
            else
            {
                items.searchItem(cboColumn.Text, txtKeyword.Text, dtgInventory, lblRecordCount);
            }
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmdSearch_Click(sender, e);
        }

        private void txtKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            cmdSearch_Click(sender, e);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInventory.CurrentRow != null)
            {
                int i = dtgInventory.CurrentRow.Index;
                populateTextboxes(i, dtgInventory);
            }
        }

        private void populateTextboxes(int row, DataGridView mDataGrid)
        {
            try
            {
                if (!row.Equals(null))
                {
                    String mRecordID = (string)mDataGrid["itemid", row].Value.ToString();
                    String mCategory = (string)mDataGrid["category", row].Value.ToString();
                    String mProductName = (string)mDataGrid["productname", row].Value.ToString();
                    String mFXtype = (string)mDataGrid["fxtype", row].Value.ToString();
                    String mFXcapacity = (string)mDataGrid["fxcapacity", row].Value.ToString();
                    String mProductDescription = (string)mDataGrid["productdescription", row].Value.ToString();
                    String mProductStatus = (string)mDataGrid["productstatus", row].Value.ToString();
                    double mProductPrice = (double)mDataGrid["productprice", row].Value;
                    DateTime? mManufactureDate = null;

                    
                    if (mCategory == "Fire Extinguisher")
                    {
                        this.lblRecordID.Text = mRecordID;
                        this.txtCategory.Text = mCategory;
                        this.txtProductName.Text = mProductName;
                        this.txtFireExType.Text = mFXtype;
                        this.txtFireExCapacity.Text = mFXcapacity;
                        this.txtProductDescription.Text = mProductDescription;
                        this.txtProductStatus.Text = mProductStatus;
                        this.txtProductPrice.Text = mProductPrice.ToString("n");
                        mManufactureDate = (DateTime)mDataGrid["manufacturedate", row].Value;
                        this.dtManufactureDate.Value = mManufactureDate.Value;

                        //HIDE FDAS ONLY DETAILS
                        this.lblDescription.Visible = false;
                        this.txtProductDescription.Visible = false;

                        //SHOW FIRE EXTINGUISHER ONLY DETAILS
                        this.txtFireExCapacity.Visible = true;
                        this.txtFireExType.Visible = true;
                        this.lblManufactureDate.Visible = true;
                        this.dtManufactureDate.Visible = true;
                        this.txtProductStatus.Visible = true;
                        this.lblProductStatus.Visible = true;
                        this.lblFireExCapacity.Visible = true;
                        this.lblFireExType.Visible = true;

                    }
                    else 
                    {
                        this.lblRecordID.Text = mRecordID;
                        this.txtCategory.Text = mCategory;
                        this.txtProductName.Text = mProductName;
                        this.txtFireExType.Text = mFXtype;
                        this.txtFireExCapacity.Text = mFXcapacity;
                        this.txtProductDescription.Text = mProductDescription;
                        this.txtProductStatus.Text = mProductStatus;
                        this.txtProductPrice.Text = mProductPrice.ToString("n");

                        //SHOW FDAS ONLY DETAILS
                        this.lblDescription.Visible = true;
                        this.txtProductDescription.Visible = true;

                        //HIDE FIRE EXTINGUISHER ONLY DETAILS
                        this.txtFireExCapacity.Visible = false;
                        this.txtFireExType.Visible = false;
                        this.lblManufactureDate.Visible = false;
                        this.dtManufactureDate.Visible = false;
                        this.txtProductStatus.Visible = false;
                        this.lblProductStatus.Visible = false;
                        this.lblFireExCapacity.Visible = false;
                        this.lblFireExType.Visible = false;

                    }



                    //this.dtManufactureDate = mManufactureDate;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error populating textboxes: " + e);
            }
        }


        private void metroGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            int i = dtgInventory.CurrentRow.Index;

            if (e.KeyCode == Keys.Down && i + 2 <= dtgInventory.RowCount)
            {
                i = dtgInventory.CurrentRow.Index + 1;
                populateTextboxes(i, dtgInventory);
            }
            else if (e.KeyCode == Keys.Up && i - 1 >= 0)
            {
                i = dtgInventory.CurrentRow.Index - 1;
                populateTextboxes(i, dtgInventory);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            //ENABLE CONTROL BUTTONS AND DISABLE UPDATE BUTTON
            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;
            cmdUpdate.Enabled = false;

            unlockTextboxes();
            txtCategory.Focus();

        }

        private void cmdCancel_Click_1(object sender, EventArgs e)
        {
            //DISABLE CONTROL BUTTONS AND ENABLE UPDATE BUTTON
            cmdSave.Enabled = false;
            cmdCancel.Enabled = false;
            cmdUpdate.Enabled = true;

            lockTextboxes();
        }

        private void lockTextboxes()
        {
            txtCategory.ReadOnly = true;
            txtProductName.ReadOnly = true;
            txtFireExCapacity.ReadOnly = true;
            txtFireExType.ReadOnly = true;
            txtProductDescription.ReadOnly = true;
            txtProductStatus.ReadOnly = true;
            dtManufactureDate.Enabled = false;
            txtProductPrice.ReadOnly= true;
        }

        private void unlockTextboxes()
        {
            txtCategory.ReadOnly = false;
            txtProductName.ReadOnly = false;
            txtFireExCapacity.ReadOnly = false;
            txtFireExType.ReadOnly = false;
            txtProductDescription.ReadOnly= false;
            txtProductStatus.ReadOnly = false;
            dtManufactureDate.Enabled = true;
            txtProductPrice.ReadOnly = false;
        }

        private void txtProductPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                forms.frmAuthenticateAdmin authenticateAdmin = new forms.frmAuthenticateAdmin();
                authenticateAdmin.FormClosing += new FormClosingEventHandler(AuthenticateAdmin_FormClosing);
                authenticateAdmin.ShowDialog();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Saving Record: " + error);
            }
        }

        private void AuthenticateAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (val.AuthorizationToken == 1)
            {                                
                if (txtCategory.Text == "Fire Extinguisher")
                {
                    items.updateRecord(int.Parse(lblRecordID.Text), txtCategory.Text, txtProductName.Text, txtFireExType.Text, txtFireExCapacity.Text, "",
                    txtProductStatus.Text, dtManufactureDate.Value, double.Parse(txtProductPrice.Text));
                   
                    //LOG ADMIN AUTHORIZING UPDATE OF RECORD
                    logs.logthis(val.UserName + " authorized update of record for: " + txtProductName.Text + ", " + txtFireExCapacity.Text + " " + txtFireExType.Text);

                }
                else if (txtCategory.Text == "FDAS")
                {
                    items.updateRecord(int.Parse(lblRecordID.Text), txtCategory.Text, txtProductName.Text, "", "", txtProductDescription.Text,
                    "", null, double.Parse(txtProductPrice.Text));
                    
                    //LOG ADMIN AUTHORIZING UPDATE OF RECORD
                    logs.logthis(val.UserName + " authorized update of record for: " + txtProductName.Text );
                }
                else if (txtCategory.Text == "Raw Materials")
                {
                    items.updateRecord(int.Parse(lblRecordID.Text), txtCategory.Text, txtProductName.Text, "", "", txtProductDescription.Text,
                    "", null, double.Parse(txtProductPrice.Text));
                    //LOG ADMIN AUTHORIZING UPDATE OF RECORD
                    logs.logthis(val.UserName + " authorized update of record for: " + txtProductName.Text);
                }

                MessageBox.Show(this, "Item record updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                items.loadItemData(dtgInventory, lblRecordCount);
                populateTextboxes(0, dtgInventory);

                //DISABLE CONTROL BUTTONS AND ENABLE UPDATE BUTTON
                cmdSave.Enabled = false;
                cmdCancel.Enabled = false;
                cmdUpdate.Enabled = true;

                lockTextboxes();

                val.AuthorizationToken = 0;

            }
            else
            {
                MessageBox.Show(this, "Update not authorized!", "Invalid Authorization", MessageBoxButtons.OK, MessageBoxIcon.Error);
                val.AuthorizationToken = 0;
            }
        }
    }
}
