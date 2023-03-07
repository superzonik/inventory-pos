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
    public partial class frmPOSSettlePayment : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Login login = new functions.Login();
        functions.MySQL mysql = new functions.MySQL();
        functions.Logs logs = new functions.Logs();
        functions.Transactions transactions = new functions.Transactions();

        string cashTendered = "";

        public frmPOSSettlePayment()
        {
            InitializeComponent();
        }

        private void frmPOSSettlePayment_Load(object sender, EventArgs e)
        {
            lbltransactionid.Text = transactions.TransactionCode.ToString();
            txtTotal.Text = val.CartTotalDue.ToString("n2");
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            cashTendered += "7";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
            ComputeChange();

        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            cashTendered += "8";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
            ComputeChange();
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            cashTendered += "9";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
            ComputeChange();
        }

        private void cmdC_Click(object sender, EventArgs e)
        {

            if (cashTendered.Length > 1)
            {
                cashTendered = cashTendered.Substring(0, cashTendered.Length - 1);
                ComputeChange();
            }
            else
            {
                cashTendered = "0";
                txtChange.Text = "0";
                ComputeChange();
            }

            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            cashTendered += "4";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
            ComputeChange();
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            cashTendered += "5";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
            ComputeChange();
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            cashTendered += "6";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
            ComputeChange();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            cashTendered += "1";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
            ComputeChange();
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            cashTendered += "2";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
            ComputeChange();
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            cashTendered += "3";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
            ComputeChange();
        }

        private void cmdDecimal_Click(object sender, EventArgs e)
        {
            if (cashTendered != "")
            {
                cashTendered += ".";
                txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
            }

        }

        private void cmdEnter_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtChange.Text) >= 0)
            {                
                val.CartTransactionDate = DateTime.Now;
                val.CartChange = double.Parse(txtChange.Text);

                transactions.SaveTransaction(int.Parse(transactions.TransactionCode.ToString()),"Test OR", val.CartTotalSales, val.CartDiscount, val.CartTax, val.CartTotalDue, val.CartCashTendered,
                    val.CartChange, val.CartClientID, val.UserID, val.CartTransactionDate);

                forms.frmRPTReceipt frmRPTReceipt = new forms.frmRPTReceipt();
                frmRPTReceipt.Show();
            }
        }

        private void cmdAllClear_Click(object sender, EventArgs e)
        {
            cashTendered = "0";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            cashTendered += "0";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
            ComputeChange();
        }

        private void ComputeChange()
        {
            double total = double.Parse(txtTotal.Text);

            txtChange.Text = (double.Parse(cashTendered) - total).ToString("n2");
        }
    }
}
