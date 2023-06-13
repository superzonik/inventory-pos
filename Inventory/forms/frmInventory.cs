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

        int StockQuantity = 0;

        //OPERATION CODE: 0 = NONE; 1 = DELETE; 2 = UPDATE;
        int OperationCode = 0;

        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            items.loadItemData(dtgInventory, lblRecordCount);
            if (dtgInventory.RowCount != 0)
            {
                items.SetRowNumber(dtgInventory);
                populateTextboxes(0, dtgInventory);
                if (txtCategory.Text == "Fire Extinguisher")
                {
                    cmdRestock.Enabled = false;
                }
                else
                {
                    cmdRestock.Enabled = true;
                }
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
            if (dtgInventory.RowCount != 0)
            {
                items.SetRowNumber(dtgInventory);
                populateTextboxes(0, dtgInventory);
                if (txtCategory.Text == "Fire Extinguisher")
                {
                    cmdRestock.Enabled = false;
                }
                else
                {
                    cmdRestock.Enabled = true;
                }
            }
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
                if (txtCategory.Text == "Fire Extinguisher")
                {
                    cmdRestock.Enabled = false;
                }
                else
                {
                    cmdRestock.Enabled = true;
                }

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
                if (txtCategory.Text == "Fire Extinguisher")
                {
                    cmdRestock.Enabled = false;
                }
                else
                {
                    cmdRestock.Enabled = true;
                }
            }
            else if (e.KeyCode == Keys.Up && i - 1 >= 0)
            {
                i = dtgInventory.CurrentRow.Index - 1;
                populateTextboxes(i, dtgInventory);
                if (txtCategory.Text == "Fire Extinguisher")
                {
                    cmdRestock.Enabled = false;
                }
                else
                {
                    cmdRestock.Enabled = true;
                }
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

            if (val.AuthorizationToken)
            {                                
                if (OperationCode == 1)
                {
                    //DELETE
                    DeleteItem();
                    OperationCode = 0;
                } else if (OperationCode == 2)
                {
                    //UPDATE
                    UpdateItem();
                    OperationCode = 0;
                }
            }
            else
            {
                MessageBox.Show(this, "Operation not authorized!", "Invalid Authorization", MessageBoxButtons.OK, MessageBoxIcon.Error);
                val.AuthorizationToken = false;
            }
        }

        private void DeleteItem()
        {
            int i = dtgInventory.CurrentRow.Index;
            items.DeleteRecord(int.Parse(lblRecordID.Text));

            items.loadItemData(dtgInventory, lblRecordCount);
            dtgInventory.Refresh();
            populateTextboxes(0, dtgInventory);
            logs.logthis(val.UserName + " authorized removal of record for: " + txtProductName.Text);

            MessageBox.Show(this, "Item removed from inventory!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            val.AuthorizationToken = false;

        }
        private void UpdateItem()
        {
            int i = dtgInventory.CurrentRow.Index;

            if (txtCategory.Text == "Fire Extinguisher")
            {
                items.updateRecord(int.Parse(lblRecordID.Text), txtCategory.Text, txtProductName.Text, txtFireExType.Text, txtFireExCapacity.Text, "",
                txtProductStatus.Text, dtManufactureDate.Value, double.Parse(txtProductPrice.Text), 1);

                //LOG ADMIN AUTHORIZING UPDATE OF RECORD
                logs.logthis(val.UserName + " authorized update of record for: " + txtProductName.Text + ", " + txtFireExCapacity.Text + " " + txtFireExType.Text);

            }
            else if (txtCategory.Text == "Fire Prevention Equipment")
            {
                int xStock = (int)dtgInventory["quantity", i].Value;
                MessageBox.Show(this, "Current Stock: " + xStock + " Additional Stock: " + StockQuantity, "Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StockQuantity = StockQuantity + (int)dtgInventory["quantity", i].Value;

                items.updateRecord(int.Parse(lblRecordID.Text), txtCategory.Text, txtProductName.Text, "", "", txtProductDescription.Text,
                "", null, double.Parse(txtProductPrice.Text), StockQuantity);

                //LOG ADMIN AUTHORIZING UPDATE OF RECORD
                logs.logthis(val.UserName + " authorized update of record for: " + txtProductName.Text);
                StockQuantity = 0;

            }
            else if (txtCategory.Text == "Raw Materials")
            {
                int xStock = (int)dtgInventory["quantity", i].Value;
                MessageBox.Show(this, "Current Stock: " + xStock + " Additional Stock: " + StockQuantity, "Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StockQuantity = StockQuantity + (int)dtgInventory["quantity", i].Value;

                items.updateRecord(int.Parse(lblRecordID.Text), txtCategory.Text, txtProductName.Text, "", "", txtProductDescription.Text,
                "", null, double.Parse(txtProductPrice.Text), StockQuantity);
                //LOG ADMIN AUTHORIZING UPDATE OF RECORD
                logs.logthis(val.UserName + " authorized update of record for: " + txtProductName.Text);
                StockQuantity = 0;
            }

            MessageBox.Show(this, "Item record updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            items.loadItemData(dtgInventory, lblRecordCount);
            dtgInventory.Refresh();
            populateTextboxes(0, dtgInventory);

            //DISABLE CONTROL BUTTONS AND ENABLE UPDATE BUTTON
            cmdSave.Enabled = false;
            cmdCancel.Enabled = false;
            cmdUpdate.Enabled = true;

            lockTextboxes();

            val.AuthorizationToken = false;
        }

        private void dtgInventory_Sorted(object sender, EventArgs e)
        {
            if (dtgInventory.RowCount != 0)
            {
                items.SetRowNumber(dtgInventory);
                dtgInventory.CurrentCell = dtgInventory.Rows[0].Cells[1];
                populateTextboxes(0, dtgInventory);
            }
        }

        private void cmdRestock_Click(object sender, EventArgs e)
        {
            ShowInputQuantityDialog(ref StockQuantity);

            if (StockQuantity != 0 )
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
        }

        private static DialogResult ShowInputQuantityDialog(ref int input)
        {
            System.Drawing.Size size = new System.Drawing.Size(300, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Enter Additional Stocks";
            inputBox.StartPosition = FormStartPosition.CenterScreen;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 50);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input.ToString();
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();

            if (result == DialogResult.OK)
            {
                input = int.Parse(textBox.Text);
            }
            else
            {
                input = 0;
            }

            return result;

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Are you sure you want to delete this inventory item?", "Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OperationCode = 1;
                    forms.frmAuthenticateAdmin authenticateAdmin = new forms.frmAuthenticateAdmin();
                    authenticateAdmin.FormClosing += new FormClosingEventHandler(AuthenticateAdmin_FormClosing);
                    authenticateAdmin.ShowDialog();
                }
                
            }
            catch (Exception error)
            {
                logs.logthis("Error Deleting Record: " + error.Message);
            }
        }
    }
}
