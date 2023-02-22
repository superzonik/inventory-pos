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
        functions.Items items = new functions.Items();
        functions.Logs logs = new functions.Logs();

        public frmRPTReceipt()
        {
            InitializeComponent();
        }

        private void frmRPTReceipt_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("transactionds", connection.DataSet($"SELECT * FROM (((tbltransactions inner join " +
                "tbltransactiondetails on tbltransactions.transactionid = tbltransactiondetails.transactionid) inner join " +
                "tblitems on tbltransactiondetails.itemid = tblitems.itemid) inner join " +
                "tblclients on tblclients.clientid = tbltransactions.clientid);", "receipt").Tables[0]));
            reportViewer1.LocalReport.ReportPath = $"{Application.StartupPath}/reports/rptReceipt.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
