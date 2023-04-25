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
    public partial class frmReportList : MetroFramework.Forms.MetroForm
    {
        public frmReportList()
        {
            InitializeComponent();
        }

        private void cmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdDailySales_Click(object sender, EventArgs e)
        {
            frmReportDaily frmReportDaily = new frmReportDaily();
            frmReportDaily.ShowDialog();
        }
    }
}
