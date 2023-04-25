using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Inventory.forms
{
    public partial class frmReportDaily : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Transactions transaction = new functions.Transactions();
        functions.Installment installment = new functions.Installment();

        public frmReportDaily()
        {
            InitializeComponent();
        }

        private void frmReportDaily_Load(object sender, EventArgs e)
        {
            searchdate(dtDateSelected.Value);
        }

        private void cmdSearchDate_Click(object sender, EventArgs e)
        {
            searchdate(dtDateSelected.Value);
        }

        private void searchdate(DateTime mSearchDate)
        {
            dataset.salesreport dsDailySales = transaction.GetDailySales(mSearchDate.Date);
            ReportDataSource datasource = new ReportDataSource("dailysales", dsDailySales.Tables["dailysales"]);
            ReportParameter[] rParams = new ReportParameter[] {
                new ReportParameter("pTransactionDate", dtDateSelected.Value.ToShortDateString()),

            };

            this.reportViewer1.LocalReport.SetParameters(rParams);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
