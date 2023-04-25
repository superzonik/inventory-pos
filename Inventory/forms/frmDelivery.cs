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
    public partial class frmDelivery : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Login login = new functions.Login();
        functions.MySQL mysql = new functions.MySQL();
        functions.Logs logs = new functions.Logs();
        functions.Transactions transactions = new functions.Transactions();
        functions.Delivery delivery = new functions.Delivery();
        functions.Items items = new functions.Items();

        int AddorEdit= 0;

        public frmDelivery()
        {
            InitializeComponent();
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            delivery.LoadDeliveryDataToGrid(dtgDelivery, lblDeliveryCount);
            delivery.LoadDeliveredDataToGrid(dtgDelivered, lblDeliveredCount);

            if (dtgDelivery.RowCount != 0)
            {
                items.SetRowNumber(dtgDelivery);
                populateTextboxes(0, dtgDelivery);
            }

            if (dtgDelivered.RowCount != 0)
            {
                items.SetRowNumber(dtgDelivered);
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void populateTextboxes(int row, DataGridView mDataGrid)
        {
            try
            {
                if (!row.Equals(null))
                {
                    lblTransactionID.Text = (string)mDataGrid["transactionid", row].Value.ToString();


                    //String mDRNum = (string)mDataGrid["drnum", row].Value.ToString();
                    //String mDeliveredBy = (string)mDataGrid["deliveredby", row].Value.ToString();
                    //DateTime mDeliveryDate = (DateTime)mDataGrid["deliverydate", row].Value;
                    //String mDeliveryRemarks = (string)mDataGrid["deliveryremarks", row].Value.ToString();

                    //this.lblDeliveryID.Text = mDeliveryID.ToString();
                    //this.txtDRNum.Text = mDRNum;
                    //this.txtDeliveredBy.Text = mDeliveredBy;
                    //this.dtDeliveryDate.Value = mDeliveryDate.Date;
                    //this.txtRemarks.Text = mDeliveryRemarks;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error populating textboxes: " + e);
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //AddOrEdit = 0 means save button should call ADD function
            AddorEdit = 0;
            EnableControls();
            txtRemarks.Clear();
            txtDeliveredBy.Clear();
            txtDRNum.Clear();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            //AddOrEdit = 1 means save button should call EDIT function
            AddorEdit = 1;
            EnableControls();
        }

        private void EnableControls()
        {
            grpDeliver.Visible = true;

            //DISABLE OTHER CONTROLS
            cmdPrint.Enabled = false;
            cmdExit.Enabled = false;

            cmdSave.Enabled = true;
            cmdCancel.Enabled = true;

            txtDRNum.Focus();
            txtDRNum.SelectAll();
        }

        private void DisableControls()
        {
            grpDeliver.Visible = false;

            dtgDelivered.Refresh();
            dtgDelivery.Refresh();

            //if (dtgDelivery.Rows.Count <= 0)
            //{
            //    grpForDelivery.Refresh();
            //    dtgDelivery.Update();
            //    dtgDelivery.Refresh();
            //    dtgDelivery.Parent.Refresh();
            //    dtgDelivery.Visible = false;
            //}

            //DISABLE OTHER CONTROLS
            cmdPrint.Enabled = true;
            cmdExit.Enabled = true;

            cmdSave.Enabled = false;
            cmdCancel.Enabled = false;
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                forms.frmAuthenticateAdmin authenticateAdmin = new forms.frmAuthenticateAdmin();
                authenticateAdmin.FormClosing += new FormClosingEventHandler(AuthenticateAdmin_FormClosing);
                authenticateAdmin.ShowDialog();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Deleting Record: " + error);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are the data you entered correct?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtDRNum.Text != "" || txtDeliveredBy.Text != "" || txtRemarks.Text != "")
                {
                    delivery.AddDeliveryInfo(txtDRNum.Text, txtDeliveredBy.Text, dtDeliveryDate.Value.Date, txtRemarks.Text, int.Parse(lblTransactionID.Text));
                    transactions.SaveTransactionDelivery(2, int.Parse(lblTransactionID.Text));

                    frmDelivery_Load(sender, e);
                    delivery.LoadDeliveryDataToGrid(dtgDelivery, lblDeliveryCount);
                    DisableControls();

                    if (lblDeliveryCount.Text == "0")
                    {
                        cmdDeliver.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show(this, "All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            else
            {
                txtDRNum.Focus();
                txtDRNum.SelectAll();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DisableControls();
            frmDelivery_Load(sender, e);
        }

        private void dtgDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDelivery.CurrentRow != null)
            {
                int i = dtgDelivery.CurrentRow.Index;
                populateTextboxes(i, dtgDelivery);
            }
        }

        private void dtgDelivery_KeyDown(object sender, KeyEventArgs e)
        {
            int i = dtgDelivery.CurrentRow.Index;

            if (e.KeyCode == Keys.Down && i + 2 <= dtgDelivery.RowCount)
            {
                i = dtgDelivery.CurrentRow.Index + 1;
                populateTextboxes(i, dtgDelivery);
            }
            else if (e.KeyCode == Keys.Up && i - 1 >= 0)
            {
                i = dtgDelivery.CurrentRow.Index - 1;
                populateTextboxes(i, dtgDelivery);
            }
        }

        private void AuthenticateAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (val.AuthorizationToken == 1)
            {
                //LOG ADMIN AUTHORIZING UPDATE OF RECORD
                logs.logthis(val.UserName + " authorized delete of delivery record by: " + txtDeliveredBy.Text + " with DR Number " + txtDRNum.Text + " on " + dtDeliveryDate.Value.Date);
                delivery.DeleteDeliveryInfo(int.Parse(lblDeliveryID.Text));

                MessageBox.Show(this, "Delivery detail deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDelivery_Load(sender, e);

                val.AuthorizationToken = 0;

            }
            else
            {
                MessageBox.Show(this, "Delete not authorized!", "Invalid Authorization", MessageBoxButtons.OK, MessageBoxIcon.Error);
                val.AuthorizationToken = 0;
            }
        }

        private void cmdDeliver_Click(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void lblTransactionID_TextChanged(object sender, EventArgs e)
        {
            cmdDeliver.Enabled = true;
        }
    }
}
