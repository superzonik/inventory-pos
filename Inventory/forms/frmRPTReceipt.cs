using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace Inventory.forms
{
    public partial class frmRPTReceipt : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Transactions transaction = new functions.Transactions();

        string _total, _cashtendered, _change, _discount, _tax, _subtotal, _transactionid, _paymentmethod, _transactiondate;

        private void frmRPTReceipt_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frmPOSSettlePayment frmPOSSettlePayment = new frmPOSSettlePayment();
            //frmPOSSettlePayment.Dispose();
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmPOSSettlePayment")
                {
                    Application.OpenForms["frmPOSSettlePayment"].Close();
                }
                else if (frm.Name == "frmCreateInstallment")
                {
                    Application.OpenForms["frmCreateInstallment"].Close();
                }
                    
            }            

        }

        public frmRPTReceipt()
        {
            InitializeComponent();
            _subtotal = val.CartTotalSales.ToString();
            _total = val.CartTotalDue.ToString();
            _cashtendered = val.CartCashTendered.ToString();
            _change = val.CartChange.ToString();
            _discount = val.CartDiscount.ToString();
            _tax = val.CartTax.ToString();
            _transactionid = transaction.TransactionCode.ToString();
            _paymentmethod = val.PaymentType;
            _transactiondate = val.CartTransactionDate.ToShortDateString();
            
        }

        private void frmRPTReceipt_Load(object sender, EventArgs e)
        {
            // var settings = reportViewer1.GetPageSettings();
            // settings.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
            // reportViewer1.SetPageSettings(settings);

            items dsItems = transaction.GetTransactionDetail(transaction.TransactionCode);
            ReportDataSource datasource = new ReportDataSource("receipt", dsItems.Tables["receipt"]);
            ReportParameter[] rParams = new ReportParameter[] {
                //new ReportParameter("transaction_id", transaction.TransactionCode.ToString()),
                new ReportParameter("pSubTotal", _subtotal),
                new ReportParameter("pTotal", _total),
                new ReportParameter("pCashTendered", _cashtendered),
                new ReportParameter("pDiscount", _discount),
                new ReportParameter("pTax", _tax),
                new ReportParameter("pChange", _change),
                new ReportParameter("pTransactionID", _transactionid),
                new ReportParameter("pPaymentMethod", _paymentmethod),
                new ReportParameter("pTransactionDate", _transactiondate),
            };

            this.reportViewer1.LocalReport.SetParameters(rParams);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
            
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("transactionds", connection.DataSet($"SELECT * FROM (((tbltransactions inner join " +
            //    "tbltransactiondetails on tbltransactions.transactionid = tbltransactiondetails.transactionid) inner join " +
            //    "tblitems on tbltransactiondetails.itemid = tblitems.itemid) inner join " +
            //    "tblclients on tblclients.clientid = tbltransactions.clientid);", "receipt").Tables[0]));
            //reportViewer1.LocalReport.ReportPath = $"{Application.StartupPath}/reports/rptReceipt.rdlc";
            //reportViewer1.RefreshReport();
        }
    }
}
