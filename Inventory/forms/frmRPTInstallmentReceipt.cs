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
    public partial class frmRPTInstallmentReceipt : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Transactions transaction = new functions.Transactions();
        functions.Installment installment = new functions.Installment();

        string _principalamount, _remainingbalance, _cashtendered, _newbalance, _transactionid, _paymentmethod, _transactiondate;
        double numNewBalance;

        private void frmRPTInstallmentReceipt_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmCollectibleSettlePayment")
                {
                    Application.OpenForms["frmCollectibleSettlePayment"].Close();
                }
                else if (frm.Name == "frmCreateInstallment")
                {
                    Application.OpenForms["frmCreateInstallment"].Close();
                }
            }
        }

        public frmRPTInstallmentReceipt()
        {
            InitializeComponent();
            _principalamount = installment.InstallmentPrincipalAmount.ToString();
            _remainingbalance = installment.InstallmentBalance.ToString();
            _cashtendered = val.CartCashTendered.ToString();
            numNewBalance = double.Parse(_remainingbalance) - double.Parse(_cashtendered);
            _newbalance = numNewBalance.ToString();
            _transactionid = transaction.TransactionCode.ToString();
            _paymentmethod = val.PaymentType;
            _transactiondate = val.CartTransactionDate.ToShortDateString();
        }

        private void frmRPTInstallmentReceipt_Load(object sender, EventArgs e)
        {

            dataset.items dsInstallment = transaction.GetInstallmentTransactionDetail(transaction.TransactionCode);
            ReportDataSource datasource = new ReportDataSource("installmentreceipt", dsInstallment.Tables["installmentreceipt"]);
            ReportParameter[] rParams = new ReportParameter[] {
                new ReportParameter("pTransactionID", transaction.TransactionCode.ToString()),
                new ReportParameter("pPrincipalAmount", _principalamount),
                new ReportParameter("pRemainingBalance", _remainingbalance),
                new ReportParameter("pCashTendered", _cashtendered),
                new ReportParameter("pNewBalance", _newbalance),
                new ReportParameter("pTransactionID", _transactionid),
                new ReportParameter("pPaymentMethod", _paymentmethod),
                new ReportParameter("pTransactionDate", _transactiondate),

            };

            this.reportViewer1.LocalReport.SetParameters(rParams);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();

        }
    }
}
