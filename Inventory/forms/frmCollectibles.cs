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
                items.SetRowNumber(dtgInstallment);
                //populateTextboxes(0, dtgInstallment);
            }
        }

        private void dtgInstallment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInstallment.RowCount != 0)
            {
                items.SetRowNumber(dtgInstallment);
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
    }
}
