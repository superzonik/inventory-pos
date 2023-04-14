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
        functions.Items items = new functions.Items();

        string cashTendered = "";

        public frmPOSSettlePayment()
        {
            InitializeComponent();
        }

        private void frmPOSSettlePayment_Load(object sender, EventArgs e)
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
            if (double.Parse(txtCashTendered.Text) > 0)
            {
                if (double.Parse(txtChange.Text) >= 0)
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
        }

        private void ProcessPayment()
        {
            if (MessageBox.Show(this, "Are the data entered correct?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Windows.Forms.Form frm = System.Windows.Forms.Application.OpenForms["frmPOS"];

                try
                {
                    int itemscount = ((frmPOS)frm).dtgCart.Rows.Count;
                    for (int i = 0; i < itemscount; i++)
                    {
                        int itemid = Convert.ToInt32(((frmPOS)frm).dtgCart.Rows[i].Cells["itemid"].Value);
                        int quantity = Convert.ToInt32(((frmPOS)frm).dtgCart.Rows[i].Cells["quantity"].Value);
                        double totalprice = Convert.ToDouble(((frmPOS)frm).dtgCart.Rows[i].Cells["total"].Value);
                        string serialnumber = ((frmPOS)frm).dtgCart.Rows[i].Cells["serialnumber"].Value.ToString();
                        string itemname = ((frmPOS)frm).dtgCart.Rows[i].Cells["itemname"].Value.ToString();
                        string itemcategory = ((frmPOS)frm).dtgCart.Rows[i].Cells["category"].Value.ToString();

                        transactions.SaveTransactionDetails(transactions.TransactionCode, itemid, quantity, totalprice);
                        
                        //UPDATE ITEM 
                        //CHECK IF PRODUCT IS NOT FIRE EXTINGUISHER
                        if (itemcategory == "FDAS" || itemcategory == "Raw Materials")
                        {
                            // I-count ko tani kung pila kabilog gin add nya sa cart nga FDAS or Raw Materials, then i-filter ko sa database tnan nga available sa stock,
                            // tapos kwaon ko dayon ang itemid sang mga item nga na query kag i-update ko sa tblitems nga gin-bakal na ang amo na nga item.

                        }
                        items.updateItemStatus(itemid, serialnumber);

                    }

                    if (txtCheckNumber.Text == "")
                    {
                        val.PaymentReference = 0;
                    }
                    else
                    {
                        val.PaymentReference = int.Parse(txtCheckNumber.Text);
                    }

                    val.CartTransactionDate = DateTime.Now;
                    val.CartChange = double.Parse(txtChange.Text);
                    val.CartCashTendered = double.Parse(txtCashTendered.Text);

                    transactions.SaveTransaction(int.Parse(transactions.TransactionCode.ToString()), txtORnumber.Text, val.CartTotalSales, val.CartDiscount, val.CartTax,
                        val.CartTotalDue, val.CartCashTendered, val.CartChange, val.CartClientID, val.UserID, val.CartTransactionDate, val.PaymentType, val.PaymentReference);

                    transactions.TransactionSuccess = 1;

                    forms.frmRPTReceipt frmRPTReceipt = new forms.frmRPTReceipt();
                    frmRPTReceipt.ShowDialog();

                }
                catch (Exception error)
                {
                    Console.WriteLine("Error saving item details: " + error);
                }
            }
        }

        private void cmdAllClear_Click(object sender, EventArgs e)
        {
            cashTendered = "0";
            txtChange.Text = "0";
            ComputeChange();
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

        private void frmPOSSettlePayment_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                {
                    cmd0_Click(sender, e);
                }
            
                else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                {
                    cmd1_Click(sender, e);
                }
                else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                {
                    cmd2_Click(sender, e);
                }
                else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                {
                    cmd3_Click(sender, e);
                }
                else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                {
                    cmd4_Click(sender, e);
                }
                else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                {
                    cmd5_Click(sender, e);
                }
                else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                {
                    cmd6_Click(sender, e);
                }
                else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                {
                    cmd7_Click(sender, e);
                }
                else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                {
                    cmd8_Click(sender, e);
                }
                else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                {
                    cmd9_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmdC_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    cmdEnter_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
                {
                    cmdDecimal_Click(sender, e);
                }
        }

        private void frmPOSSettlePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPOS frmPOS = new frmPOS();
            frmPOS.Refresh();
        }

        private void rdoCheck_CheckedChanged(object sender, EventArgs e)
        {
            val.PaymentType = "CHECK";
            lblCheckNumber.Visible = true;
            txtCheckNumber.Visible = true;
            txtCheckNumber.Text = "";
        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            val.PaymentType = "CASH";
            lblCheckNumber.Visible = false;
            txtCheckNumber.Visible = false;
            txtCheckNumber.Text = "";
        }

        private void txtORnumber_Enter(object sender, EventArgs e)
        {
            KeyPreview = false;
        }

        private void txtORnumber_Leave(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void txtCheckNumber_Enter(object sender, EventArgs e)
        {
            KeyPreview = false;
        }

        private void txtCheckNumber_Leave(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void txtCheckNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
