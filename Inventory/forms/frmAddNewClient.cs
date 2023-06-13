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
    public partial class frmAddNewClient : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Login login = new functions.Login();
        functions.MySQL mysql = new functions.MySQL();
        functions.Logs logs = new functions.Logs();
        functions.Transactions transactions = new functions.Transactions();
        functions.Items items = new functions.Items();

        public frmAddNewClient()
        {
            InitializeComponent();
        }

        private void frmAddNewClient_Load(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to save this customer?","Add Customer",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                transactions.SaveClientInfo(txtCustomerName.Text, txtCustomerAddress.Text, txtContactPerson.Text, txtSalesAgent.Text, txtRemarks.Text, txtTIN.Text);
                MessageBox.Show(this, "Client information saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
