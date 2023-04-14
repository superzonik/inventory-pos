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
    public partial class frmCollectibleSettlePayment : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Logs logs = new functions.Logs();
        functions.Installment installment = new functions.Installment();
        functions.Items items = new functions.Items();
        functions.Transactions transactions = new functions.Transactions();

        string cashTendered = "";

        public frmCollectibleSettlePayment()
        {
            InitializeComponent();
        }

        private void frmCollectibleSettlePayment_Load(object sender, EventArgs e)
        {
            lbltransactionid.Text = transactions.TransactionCode.ToString();
            txtTotal.Text = val.CartTotalDue.ToString("n2");
            rdoCash.Checked = true;
            val.PaymentType = "CASH";
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            cashTendered += "7";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            cashTendered += "8";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            cashTendered += "9";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmdC_Click(object sender, EventArgs e)
        {
            if (cashTendered.Length > 1)
            {
                cashTendered = cashTendered.Substring(0, cashTendered.Length - 1);
            }
            else
            {
                cashTendered = "0";
            }

            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            cashTendered += "4";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            cashTendered += "5";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            cashTendered += "6";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmdAllClear_Click(object sender, EventArgs e)
        {
            cashTendered = "0";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            cashTendered += "1";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            cashTendered += "2";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            cashTendered += "3";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
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
            if (double.Parse(txtCashTendered.Text) > 0)
            {
                if (txtORnumber.Text != "")
                {
                    if (rdoCash.Checked == true)
                    {
                        ProcessPayment();
                    }
                    else if (rdoCheck.Checked == true)
                    {
                        if (txtCheckNumber.Text != "")
                        {
                            ProcessPayment();
                        }
                        else
                        {
                            MessageBox.Show(this, "Please provide check number for check payments", "Input Check Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Please provide a valid OR number", "Input OR Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void ProcessPayment()
        {
            if (MessageBox.Show(this, "Are the data entered correct?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                if (txtCheckNumber.Text == "")
                {
                    val.PaymentReference = 0;
                }
                else
                {
                    val.PaymentReference = int.Parse(txtCheckNumber.Text);
                }
                val.CartTransactionDate = DateTime.Now;
                val.CartChange = 0;
                val.CartCashTendered = double.Parse(txtCashTendered.Text);

                transactions.SaveTransaction(int.Parse(transactions.TransactionCode.ToString()), txtORnumber.Text, val.CartTotalSales, val.CartDiscount, val.CartTax,
                    val.CartTotalDue, val.CartCashTendered, val.CartChange, val.CartClientID, val.UserID, val.CartTransactionDate, val.PaymentType, val.PaymentReference);

                transactions.TransactionSuccess = 1;

                forms.frmRPTReceipt frmRPTReceipt = new forms.frmRPTReceipt();
                frmRPTReceipt.ShowDialog();
            }
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            cashTendered += "0";
            txtCashTendered.Text = double.Parse(cashTendered).ToString("n2");
        }
    }
}
