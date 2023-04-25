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
    public partial class frmCollectibles : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Logs logs = new functions.Logs();
        functions.Installment installment = new functions.Installment();
        functions.Items items = new functions.Items();
        functions.Transactions transactions = new functions.Transactions();

        int _installmentid = 0;

        public frmCollectibles()
        {
            InitializeComponent();
        }

        private void frmCollectibles_Load(object sender, EventArgs e)
        {
            installment.LoadInstallmentDataToGrid(dtgInstallment, lblRecordCount);
            if (dtgInstallment.RowCount != 0)
            {
                items.SetRowNumber(dtgInstallment);
                int i = 0;
                DataChangeTriggers(i);
                //populateTextboxes(0, dtgInstallment);
            }
        }

        private void populateTextboxes(int row, DataGridView mDataGrid)
        {
            //try
            //{
            //    if (!row.Equals(null))
            //    {
            //        int mDeliveryID = (int)mDataGrid["deliveryid", row].Value;
            //        String mDRNum = (string)mDataGrid["drnum", row].Value.ToString();
            //        String mDeliveredBy = (string)mDataGrid["deliveredby", row].Value.ToString();
            //        DateTime mDeliveryDate = (DateTime)mDataGrid["deliverydate", row].Value;
            //        String mDeliveryRemarks = (string)mDataGrid["deliveryremarks", row].Value.ToString();

            //        this.lblDeliveryID.Text = mDeliveryID.ToString();
            //        this.txtDRNum.Text = mDRNum;
            //        this.txtDeliveredBy.Text = mDeliveredBy;
            //        this.dtDeliveryDate.Value = mDeliveryDate.Date;
            //        this.txtRemarks.Text = mDeliveryRemarks;

            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error populating textboxes: " + e);
            //}
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgInstallment_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (dtgInstallment.RowCount != 0)
            {
                items.SetRowNumber(dtgInstallment);
                //populateTextboxes(0, dtgInstallment);
            }
        }

        private void dtgInstallment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInstallment.RowCount != 0)
            {
                int i = dtgInstallment.CurrentRow.Index;
                DataChangeTriggers(i);
                //populateTextboxes(0, dtgInstallment);
            }
        }

        private void dtgInstallment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInstallment.RowCount != 0)
            {
                int i = dtgInstallment.CurrentRow.Index;
                DataChangeTriggers(i);
                //populateTextboxes(0, dtgInstallment);
            }
        }

        private void dtgInstallment_Sorted(object sender, EventArgs e)
        {
            if (dtgInstallment.RowCount != 0)
            {
                items.SetRowNumber(dtgInstallment);
                dtgInstallment.CurrentCell = dtgInstallment.Rows[0].Cells[1];
                //populateTextboxes(0, dtgInstallment);
            }
        }

        private void dtgInstallment_SelectionChanged(object sender, EventArgs e)
        {

            //int i = dtgInstallment.CurrentRow.Index;
            //int installmentid = (int)dtgInstallment["installmentid", i].Value;

            //installment.LoadPaymentDataToGrid(dtgPayments, installmentid);
        }

        private void dtgInstallment_KeyDown(object sender, KeyEventArgs e)
        {
            int i = dtgInstallment.CurrentRow.Index;

            if (e.KeyCode == Keys.Down && i + 2 <= dtgInstallment.RowCount)
            {
                i = dtgInstallment.CurrentRow.Index + 1;
                DataChangeTriggers(i);
                //populateTextboxes(i, dtgInstallment);
            }
            else if (e.KeyCode == Keys.Up && i - 1 >= 0)
            {
                i = dtgInstallment.CurrentRow.Index - 1;
                DataChangeTriggers(i);
                //populateTextboxes(i, dtgInstallment);
            }
        }

        //TRIGGERS COMMANDS WHEN DATA FROM dtgInstallment CHANGES
        private void DataChangeTriggers(int i)
        {
            _installmentid = (int)dtgInstallment["installmentid", i].Value;
            items.SetRowNumber(dtgInstallment);
            installment.LoadPaymentDataToGrid(dtgPayments, _installmentid);
            transactions.TransactionCode = (long)dtgInstallment["transactionid", i].Value;
            lblTransactionCode.Text = transactions.TransactionCode.ToString();
            items.SetRowNumber(dtgPayments);

            //SET INSTALLMENT ID FOR UPDATING INSTALLMENT RECORD
            installment.InstallmentID = _installmentid;
        }

        private void cmdPay_Click(object sender, EventArgs e)
        {

            //SEND PAYMENT BALANCE TO SETTLE PAYMENT WINDOW
            int i = dtgInstallment.CurrentRow.Index;
            double balance = (double)dtgInstallment["balance", i].Value;
            double principalamount = (double)dtgInstallment["principalamount", i].Value;

            val.CartTotalDue = balance;
            installment.InstallmentBalance = balance;
            installment.InstallmentPrincipalAmount = principalamount;

            //CHECK IF THERE IS STILL BALANCE ON THE INSTALLMENT
            if (balance == 0)
            {
                MessageBox.Show(this, "This record is already fully paid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //OPEN COLLECTIBLE SETTLE PAYMENT DIALOG
                forms.frmCollectibleSettlePayment CollectibleSettlePayment = new frmCollectibleSettlePayment();
                CollectibleSettlePayment.FormClosing += new FormClosingEventHandler(FrmCollectibleSettlePayment_FormClosing);
                CollectibleSettlePayment.ShowDialog();
            }
            
        }

        private void FrmCollectibleSettlePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (transactions.TransactionSuccess == 1)
            {
                if (dtgInstallment.RowCount != 0)
                {
                    int i = dtgInstallment.CurrentRow.Index;
                    DataChangeTriggers(i);
                    //populateTextboxes(0, dtgInstallment);
                }
                dtgInstallment.Refresh();
                dtgPayments.Refresh();

                transactions.TransactionSuccess = 0;
            }

        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
