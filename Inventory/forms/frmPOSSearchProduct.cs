using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Inventory.forms
{
    public partial class frmPOSSearchProduct : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Items items = new functions.Items();
        functions.Login login = new functions.Login();
        functions.MySQL mysql = new functions.MySQL();
        functions.Logs logs = new functions.Logs();
        functions.Transactions transactions = new functions.Transactions();

        public frmPOSSearchProduct()
        {
            InitializeComponent();
        }

        private void frmPOSSearchProduct_Load(object sender, EventArgs e)
        {
            items.loadItemData(dtgProducts, lblRecordCount);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            val.CartItemDescription = "";
            Close();
        }

        private void cmdSelectItem_Click(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if ((txtKeyword.Text == "") || (cboColumn.Text == ""))
            {
                items.loadItemData(dtgProducts, lblRecordCount);
            }
            else
            {
                items.searchItem(cboColumn.Text, txtKeyword.Text, dtgProducts, lblRecordCount);
            }
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmdSearch_Click(sender, e);
        }

        private void txtKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            cmdSearch_Click(sender, e);
        }


        private void dtgProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectItem();
        }

        private void SelectItem()
        {
            if (dtgProducts.CurrentRow != null)
            {

                int i = dtgProducts.CurrentRow.Index;

                String serialnumber = "";
                String itemCategory = (string)dtgProducts["category", i].Value.ToString();
                String itemName = (string)dtgProducts["productname", i].Value.ToString();
                String fxtype = (string)dtgProducts["fxtype", i].Value.ToString();
                String fxcapacity = (string)dtgProducts["fxcapacity", i].Value.ToString();
                String itemDescription = (string)dtgProducts["productdescription", i].Value.ToString();
                double itemPrice = (double)dtgProducts["productprice", i].Value;
                int itemID = (int)dtgProducts["itemid", i].Value;

                String productCartDecription = itemCategory + ", " + itemName + " (" + itemDescription + " " + fxcapacity + " " + fxtype + ")";

                if (itemCategory == "Fire Extinguisher")
                {
                    ShowInputSerialDialog(ref serialnumber);
                    
                    if (serialnumber == "")
                    {
                        MessageBox.Show(this, "Serial Number Required for Fire Extinguishers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        val.CartItemDescription = productCartDecription;
                        val.CartItemID = itemID;
                        val.CartItemSerialNumber = serialnumber;
                        val.CartItemPrice = itemPrice;
                        Close();
                    }
                }
                else
                {
                    val.CartItemDescription = productCartDecription;
                    val.CartItemID = (int)dtgProducts["itemid", i].Value;
                    val.CartItemSerialNumber = "";
                    val.CartItemPrice = itemPrice;
                    Close();
                }

            }
        }

        private static DialogResult ShowInputSerialDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(300, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Enter Serial Number";
            inputBox.StartPosition = FormStartPosition.CenterScreen;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 50);
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

        private void dtgProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectItem();
            }
        }
    }
}