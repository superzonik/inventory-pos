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
    public partial class frmCreateInstallment : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Login login = new functions.Login();
        functions.MySQL mysql = new functions.MySQL();
        functions.Logs logs = new functions.Logs();
        functions.Transactions transactions = new functions.Transactions();
        functions.Items items = new functions.Items();
        functions.Installment installment = new functions.Installment();

        double principal_amount = 0, interest = 0, monthly_due = 0, terms = 0, downpayment = 0, balance = 0;

        public frmCreateInstallment()
        {
            InitializeComponent();
        }

        private void frmCreateInstallment_Load(object sender, EventArgs e)
        {
            txtCustomerName.Text = transactions.ClientName;
            txtAddress.Text = transactions.ClientAddress;
            txtContactPerson.Text = transactions.ClientContact;
            txtPrincipalAmount.Text = val.CartTotalSales.ToString("n2");
            cboTerms.SelectedIndex = 0;

            installment.GenerateInstallmentID();
            lblInstallmentID.Text = installment.InstallmentID.ToString();

        }

        private void cboTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdCompute_Click(sender, e);
        }

        private void txtInterest_KeyUp(object sender, KeyEventArgs e)
        {
            cmdCompute_Click(sender, e);
        }

        private void txtInterest_KeyDown(object sender, KeyEventArgs e)
        {
            cmdCompute_Click(sender, e);
        }

        private void txtDownpayment_KeyUp(object sender, KeyEventArgs e)
        {
            cmdCompute_Click(sender, e);
        }

        private void txtDownpayment_KeyDown(object sender, KeyEventArgs e)
        {
            cmdCompute_Click(sender, e);
        }

        private void txtInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmdCompute_Click(sender, e);
        }

        private void txtDownpayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmdCompute_Click(sender, e);
        }

        private void cmdCompute_Click(object sender, EventArgs e)
        {
            if (txtPrincipalAmount.Text != "")
            {
                
            
                principal_amount = double.Parse(txtPrincipalAmount.Text);
                terms = double.Parse(cboTerms.Text);
                balance = principal_amount;

                if (txtDownpayment.Text == "")
                {
                    downpayment = 0;
                }
                else
                { 
                    downpayment = double.Parse(txtDownpayment.Text);
                }
                

                if (txtInterest.Text == "")
                {
                    balance = principal_amount - downpayment;
                    monthly_due = (balance / terms);
                }
                else
                {
                    interest = double.Parse(txtInterest.Text);
                    balance = principal_amount - downpayment;
                    monthly_due = (balance + (balance * (interest / 100))) / terms;
                }              

                txtMonthyDue.Text = monthly_due.ToString("n2");
                txtBalance.Text = balance.ToString("n2");
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtMonthyDue.Text != "")
            {
                if (MessageBox.Show(this, "Are the data entered correct?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    installment.InstallmentBalance = val.CartTotalDue;
                    installment.InstallmentPrincipalAmount = val.CartTotalDue;
                    installment.InstallmentBalance = balance;

                    System.Windows.Forms.Form frm = System.Windows.Forms.Application.OpenForms["frmPOS"];
                    try
                    {
                        int itemscount = ((frmPOS)frm).dtgCart.Rows.Count;
                        for (int i = 0; i < itemscount; i++)
                        {
                            int itemid = Convert.ToInt32(((frmPOS)frm).dtgCart.Rows[i].Cells["itemid"].Value);
                            int quantity = Convert.ToInt32(((frmPOS)frm).dtgCart.Rows[i].Cells["quantity"].Value);
                            double totalprice = Convert.ToDouble(((frmPOS)frm).dtgCart.Rows[i].Cells["total"].Value);

                            transactions.SaveTransactionDetails(transactions.TransactionCode, itemid, quantity, totalprice);
                        }
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine("Error saving item details: " + error);
                    }

                    val.PaymentReference = int.Parse(lblInstallmentID.Text);

                    val.CartTransactionDate = DateTime.Now;
                    val.CartChange = 0;
                    val.CartCashTendered = downpayment;
                    val.PaymentType = "INSTALLMENT";

                    transactions.SaveTransaction(int.Parse(transactions.TransactionCode.ToString()), "", val.CartTotalSales, val.CartDiscount, val.CartTax,
                        val.CartTotalDue, val.CartCashTendered, val.CartChange, val.CartClientID, val.UserID, val.CartTransactionDate, val.PaymentType, val.PaymentReference);
                    transactions.TransactionSuccess = 1;

                    installment.SaveInstallment(val.PaymentReference, val.CartClientID, installment.InstallmentPrincipalAmount,
                        int.Parse(terms.ToString()), monthly_due, interest, val.UserID, val.CartTransactionDate, txtDueDate.Text,
                        installment.InstallmentPrincipalAmount, downpayment);
                    
                    MessageBox.Show(this, "Installment plan created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    forms.frmRPTInstallmentReceipt frmRPTInstallmentReceipt= new forms.frmRPTInstallmentReceipt();
                    frmRPTInstallmentReceipt.ShowDialog();
                }                
            }
        }
    }
}
