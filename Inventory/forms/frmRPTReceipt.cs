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
        functions.Transactions Transactions = new functions.Transactions();

        public frmRPTReceipt()
        {
            InitializeComponent();
        }

        private void frmRPTReceipt_Load(object sender, EventArgs e)
        {
            // var settings = reportViewer1.GetPageSettings();
            // settings.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
            // reportViewer1.SetPageSettings(settings);

            items dsItems = Transactions.GetTransactionDetail(Transactions.TransactionCode);
            ReportDataSource datasource = new ReportDataSource("receipt", dsItems.Tables["receipt"]);
            ReportParameter[] rParams = new ReportParameter[] {
                new ReportParameter("transaction_id", Transactions.TransactionCode.ToString()),
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
