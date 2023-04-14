using MetroFramework.Controls;
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
    public partial class frmAddNewItem : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        functions.Items items = new functions.Items();
        functions.Articles articles = new functions.Articles();
        
        public frmAddNewItem()
        {
            InitializeComponent();
        }

        private void frmAddNewItem_Load(object sender, EventArgs e)
        {
            articles.loadArticleToCombobox(cboFXcontent, "FIRE EXTINGUISHER");
            articles.loadArticleToCombobox(cboFDAStype, "FDAS");
            articles.loadArticleToCombobox(cboRawMaterialName, "RAW MATERIALS");
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtFXprice.Text == "") || (txtFXquantity.Text == ""))
                {
                    MessageBox.Show(this, "Incomplete data. Please do not leave anything blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show(this, "Are you sure all data is correct?",
                   "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int quantity = int.Parse(txtFXquantity.Text);

                        for (int i = 0; i < quantity; i++)
                        {
                            items.AddItemRecord("Fire Extinguisher", cboFXcontent.Text, cboFXtype.Text, cboFXcapacity.Text, "", cboFXproductStatus.Text,
                                dtManufactureDate.Value.Date, double.Parse(txtFXprice.Text), 0);
                        }
                        MessageBox.Show(this, "Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        forms.frmInventory frmInventory = new frmInventory();
                        frmInventory.Refresh();
                        Close();

                    }
                }
                
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SaveItem(string category, MetroTextBox mTxtPrice, MetroTextBox mTxtQuantity, MetroTextBox mTxtDescription, MetroComboBox mCboType)
        {
            try
            {
                if ((mTxtPrice.Text == "") || (mTxtQuantity.Text == "") || (mTxtDescription.Text == ""))
                {
                    MessageBox.Show(this, "Incomplete data. Please do not leave anything blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show(this, "Are you sure all data is correct?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int quantity = int.Parse(mTxtQuantity.Text);

                        for (int i = 0; i < quantity; i++)
                        {
                            DateTime? sqldatenull = null;

                            items.AddItemRecord(category, mCboType.Text, "", "", mTxtDescription.Text, "", sqldatenull, double.Parse(mTxtPrice.Text), 0);
                        }
                        MessageBox.Show(this, "Item added succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmInventory frmInventory = new frmInventory();
                        frmInventory.Refresh();
                        Close();
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        private void cmdFDASsave_Click(object sender, EventArgs e)
        {
            SaveItem("FDAS", txtFDASprice, txtFDASquantity, txtFDASdescription, cboFDAStype);
            //try
            //{
            //    if ((txtFDASprice.Text == "") || (txtFDASquantity.Text == "") || (txtFDASdescription.Text == ""))
            //    {
            //        MessageBox.Show(this, "Incomplete data. Please do not leave anything blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        if (MessageBox.Show(this, "Are you sure all data is correct?",
            //       "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            int quantity = int.Parse(txtFDASquantity.Text);

            //            for (int i = 0; i < quantity; i++)
            //            {
            //                DateTime? sqldatenull = null;

            //                items.AddItemRecord("FDAS", cboFDAStype.Text, "", "", txtFDASdescription.Text, "", sqldatenull, double.Parse(txtFDASprice.Text));
            //            }
            //            MessageBox.Show(this, "Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            forms.frmInventory frmInventory = new frmInventory();
            //            frmInventory.Refresh();
            //            Close();

            //        }
            //    }
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine(error.ToString());
            //}
        }

        private void cmdRawSave_Click(object sender, EventArgs e)
        {
            SaveItem("Raw Materials", txtRawPrice, txtRawQuantity, txtRawDescription, cboRawMaterialName);
        }
        
        private void AddNewArticle_FormClosing(object sender, FormClosingEventArgs e)
        {
            articles.loadArticleToCombobox(cboFXcontent, "FIRE EXTINGUISHER");
            articles.loadArticleToCombobox(cboFDAStype, "FDAS");
            articles.loadArticleToCombobox(cboRawMaterialName, "RAW MATERIALS");
        }

        private void cboFXcontent_SelectedIndexChanged(object sender, EventArgs e)
        {
            addnewproduct(cboFXcontent);   
        }

        private void cboFDAStype_SelectedIndexChanged(object sender, EventArgs e)
        {
            addnewproduct(cboFDAStype);
        }

        private void cboRawMaterialName_SelectedIndexChanged(object sender, EventArgs e)
        {
            addnewproduct(cboRawMaterialName);
        }

        private void addnewproduct (ComboBox mComboBox)
        {
            string selected = mComboBox.GetItemText(mComboBox.SelectedItem);

            if (selected == "...Others (Create)")
            {
                forms.frmAddNewArticle addnew = new forms.frmAddNewArticle();
                addnew.FormClosing += new FormClosingEventHandler(AddNewArticle_FormClosing);
                addnew.ShowDialog();
            }
        }
    }
}
