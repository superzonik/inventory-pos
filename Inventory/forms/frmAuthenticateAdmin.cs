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
    public partial class frmAuthenticateAdmin : MetroFramework.Forms.MetroForm
    {

        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Login login = new functions.Login();
        functions.MySQL mysql = new functions.MySQL();
        functions.Logs logs = new functions.Logs();

        public frmAuthenticateAdmin()
        {
            InitializeComponent();
        }

        private void frmAuthenticateAdmin_Load(object sender, EventArgs e)
        {

        }

        private void cmdAuthorize_Click(object sender, EventArgs e)
        {
            if (login.AuthenticateAdmin(txtUserName.Text, txtPassword.Text))
            {
                val.AuthorizationToken = 1;
                MessageBox.Show(this, "Authorization Successful!", "Authorization", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Incorrect admin username or password!",
                    "Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                val.AuthorizationToken = 0;
                this.Close();
            }

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
