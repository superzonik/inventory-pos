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
    public partial class frmAddNewArticle : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Articles articles = new functions.Articles();

        public frmAddNewArticle()
        {
            InitializeComponent();
        }

        private void frmAddNewArticle_Load(object sender, EventArgs e)
        {

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string article_category = cboCategory.Text;
            string article_name = txtProductName.Text;

            if (MessageBox.Show(this, "Are you sure you want to add " + article_name + " to the list?", "Confirm Add",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                articles.addArticle(article_category, article_name);
                MessageBox.Show(this, "New product name successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
