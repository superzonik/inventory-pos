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
    public partial class frmPOS : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Login login = new functions.Login();
        functions.MySQL mysql = new functions.MySQL();
        functions.Logs logs = new functions.Logs();
        functions.Transactions transactions = new functions.Transactions();

        public frmPOS()
        {
            InitializeComponent();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            //SET DATE AND CLOCK
            lblDateNow.Text = DateTime.Today.ToString("d");
            lblFullDate.Text = DateTime.Today.ToString("dddd, dd MMMM yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();

        }



        private void frmPOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (cmdNewTrans.Enabled == true)
                {
                    cmdNewTrans_Click(sender, e);
                }

            }
            if (e.KeyCode == Keys.F2)
            {
                if (cmdSearchProduct.Enabled == true)
                {
                    cmdSearchProduct_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.F3)
            {
                if (cmdAddDiscount.Enabled == true)
                {
                    cmdAddDiscount_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.F4)
            {
                if (cmdSettlePayment.Enabled == true)
                {
                    cmdSettlePayment_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                if (cmdClearCart.Enabled == true)
                {
                    cmdClearCart_Click(sender, e);
                    Console.WriteLine("Clear Cart button pressed");
                }
            }
            if (e.KeyCode == Keys.F6)
            {
                if (cmdDailySales.Enabled == true)
                {
                    cmdDailySales_Click(sender, e);
                    Console.WriteLine("Daily Sales button pressed");
                }
            }
            if (e.KeyCode == Keys.F7)
            {
                if (cmdTransactions.Enabled == true)
                {
                    cmdTransactions_Click(sender, e);
                    Console.WriteLine("Transaction button pressed");
                }
            }
            if (e.KeyCode == Keys.F8)
            {
                if (cmdTransactions.Enabled == true)
                {
                    cmdCancelTransaction_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.F10)
            {
                if (cmdClosePOS.Enabled == true)
                {
                    cmdClosePOS_Click(sender, e);
                }
            }
        }

        private void cmdClosePOS_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdNewTrans_Click(object sender, EventArgs e)
        {
            transactions.GenerateTransactionCode();
            lblTransactionCode.Text = transactions.TransactionCode.ToString();
            grpCustomerInformation.Enabled = true;

            EnableTransactionControls();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void EnableTransactionControls()
        {
            cmdNewTrans.Enabled = false;
            cmdNewTrans.Style = MetroFramework.MetroColorStyle.Silver;
            cmdSearchProduct.Enabled = true;
            cmdSearchProduct.Style = MetroFramework.MetroColorStyle.Green;
            cmdAddDiscount.Enabled = true;
            cmdAddDiscount.Style = MetroFramework.MetroColorStyle.Green;
            cmdSettlePayment.Enabled = true;
            cmdSettlePayment.Style = MetroFramework.MetroColorStyle.Green;
            cmdClearCart.Enabled = true;
            cmdClearCart.Style = MetroFramework.MetroColorStyle.Green;
            cmdDailySales.Enabled = true;
            cmdDailySales.Style = MetroFramework.MetroColorStyle.Green;
            cmdTransactions.Enabled = true;
            cmdTransactions.Style = MetroFramework.MetroColorStyle.Green;
            cmdCancelTransaction.Enabled = true;
            cmdCancelTransaction.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void DisableTransactionControls()
        {
            cmdNewTrans.Enabled = true;
            cmdNewTrans.Style = MetroFramework.MetroColorStyle.Green;
            cmdSearchProduct.Enabled = false;
            cmdSearchProduct.Style = MetroFramework.MetroColorStyle.Silver;
            cmdAddDiscount.Enabled = false;
            cmdAddDiscount.Style = MetroFramework.MetroColorStyle.Silver;
            cmdSettlePayment.Enabled = false;
            cmdSettlePayment.Style = MetroFramework.MetroColorStyle.Silver;
            cmdClearCart.Enabled = false;
            cmdClearCart.Style = MetroFramework.MetroColorStyle.Silver;
            cmdDailySales.Enabled = false;
            cmdDailySales.Style = MetroFramework.MetroColorStyle.Silver;
            cmdTransactions.Enabled = false;
            cmdTransactions.Style = MetroFramework.MetroColorStyle.Silver;
            cmdCancelTransaction.Enabled = false;
            cmdCancelTransaction.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void cmdSearchProduct_Click(object sender, EventArgs e)
        {
            forms.frmPOSSearchProduct searchProduct = new frmPOSSearchProduct();
            searchProduct.FormClosing += new FormClosingEventHandler(SearchProduct_FormClosing);
            searchProduct.ShowDialog();
        }

        private void cmdCancelTransaction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to cancel this transaction?", "Cancel Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DisableTransactionControls();
                lblTransactionCode.Text = "----------------";
                grpCustomerInformation.Enabled = false;
            }
        }

        private void SearchProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ADD ITEM TO CART
            if (val.CartItemDescription != "")
            {
                int n = dtgCart.Rows.Add();

                dtgCart.Rows[n].Cells[0].Value = val.CartItemDescription;
                dtgCart.Rows[n].Cells[1].Value = val.CartItemSerialNumber;
                dtgCart.Rows[n].Cells[2].Value = val.CartItemPrice;
                dtgCart.Rows[n].Cells[3].Value = 1;
                dtgCart.Rows[n].Cells[4].Value = 0;
                dtgCart.Rows[n].Cells[5].Value = 1 * val.CartItemPrice;
                dtgCart.Rows[n].Cells[6].Value = val.CartItemID;


                setRowNumber(dtgCart);

                ComputePrice();

                val.CartItemDescription = "";
            }
        }

        private void setRowNumber (DataGridView dtg)
        {

            foreach (DataGridViewRow row in dtg.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void dtgCart_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == dtgCart.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dtgCart.Columns["removeitem"].Index)
            {
                var image = Properties.Resources.delete2; //An image
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var x = e.CellBounds.Left + (e.CellBounds.Width - image.Width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, new Point(x, y));

                e.Handled = true;
            }
        }

        private void dtgCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == dtgCart.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dtgCart.Columns["removeitem"].Index)
            {
                RemoveItemFromCart();
            }
        }

        private void RemoveItemFromCart()
        {
            if (MessageBox.Show(this, "Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtgCart.Rows.RemoveAt(dtgCart.CurrentRow.Index);
                setRowNumber(dtgCart);
                ComputePrice();
            }
        }

        private void ComputePrice()
        {
            double sum = 0;
            double vatableSale;
            double discount = 0;
            double grandtotal = 0;
            //sum = val.CartItemPrice + double.Parse(lblTopPrice.Text);
            //vatableSale = sum * .12;

            for (int i = 0; i < dtgCart.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dtgCart.Rows[i].Cells[2].Value);
                discount += Convert.ToDouble(dtgCart.Rows[i].Cells[4].Value);
                grandtotal += Convert.ToDouble(dtgCart.Rows[i].Cells[5].Value);
            }

            lblTopPrice.Text = grandtotal.ToString("n2");
            lblSubTotal.Text = sum.ToString("n2");
            lblDiscount.Text = discount.ToString("n2");
            lblGrandTotal.Text = grandtotal.ToString("n2");
            val.CartGrandTotal = grandtotal;
            //lblVatableSales.Text = vatableSale.ToString("n2");
        }

        private void cmdAddDiscount_Click(object sender, EventArgs e)
        {
            string discount = "";

            if (dtgCart.CurrentRow != null)
            {
                int n = dtgCart.CurrentRow.Index;
                double totalPrice = Convert.ToDouble(dtgCart.Rows[n].Cells[2].Value);

                ShowInputDiscountDialog(ref discount);
                dtgCart.Rows[n].Cells[4].Value = discount;
                dtgCart.Rows[n].Cells[5].Value = totalPrice - double.Parse(discount);

                ComputePrice();
            }
            
        }

        private static DialogResult ShowInputDiscountDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Enter Discount Amount";
            inputBox.StartPosition = FormStartPosition.CenterScreen;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 10);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();

            if (result == DialogResult.OK)
            {
                input = textBox.Text;
            }
            else
            {
                input = "";
            }

            return result;

        }

        private void cmdSettlePayment_Click(object sender, EventArgs e)
        {
            forms.frmPOSSettlePayment settlePayment = new frmPOSSettlePayment();
            settlePayment.ShowDialog();
        }

        private void cmdClearCart_Click(object sender, EventArgs e)
        {

        }

        private void cmdDailySales_Click(object sender, EventArgs e)
        {

        }

        private void cmdTransactions_Click(object sender, EventArgs e)
        {

        }
    }
}
