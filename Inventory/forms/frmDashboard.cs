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
    public partial class frmDashboard : MetroFramework.Forms.MetroForm
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void tileInventory_Click(object sender, EventArgs e)
        {
            forms.frmInventory inventory= new forms.frmInventory();
            inventory.ShowDialog();
        }

        private void tilePOS_Click(object sender, EventArgs e)
        {
            forms.frmPOS POS = new forms.frmPOS();
            POS.ShowDialog();
        }

        private void tileDelivery_Click(object sender, EventArgs e)
        {
            forms.frmDelivery delivery = new forms.frmDelivery();
            delivery.ShowDialog();
        }

        private void tileCollectibles_Click(object sender, EventArgs e)
        {
            forms.frmCollectibles collectibles = new forms.frmCollectibles();
            collectibles.ShowDialog();
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewProductNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewArticle addNewArticle = new frmAddNewArticle();
            addNewArticle.ShowDialog();
        }

        private void tileReports_Click(object sender, EventArgs e)
        {
            forms.frmRPTReceipt rPTReceipt = new frmRPTReceipt();
            rPTReceipt.ShowDialog();
        }
    }
}
