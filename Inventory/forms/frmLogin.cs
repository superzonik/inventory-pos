using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        components.Connection connection = new components.Connection();
        functions.Login login = new functions.Login();
        functions.MySQL mysql = new functions.MySQL();
        functions.Logs logs = new functions.Logs();
        functions.Transactions transactions = new functions.Transactions();


        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

            bool source_result = mysql.check_connection(connection.conString);
            if (source_result == false)
            {
                lblServerStatus.Text = "OFFLINE";
                lblServerStatus.ForeColor = Color.Red;
            }
            else
            {
                lblServerStatus.Text = "ONLINE";
                lblServerStatus.ForeColor = Color.Green;
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit the program?",
                "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Please contact the developer @ ", "FORGOT PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (login.AuthenticateUser(txtUserName.Text, txtPassword.Text))
            {
                logs.logthis(val.UserName + " logged in the system");
                MessageBox.Show(this, "Login Successful" + val.UserPassword, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                val.AuthorizationToken = 0;
                this.Hide();
                forms.frmDashboard dashboard = new forms.frmDashboard();
                dashboard.FormClosing += new FormClosingEventHandler(Dashboard_FormClosing);
                dashboard.Show();
            }
            else
            {
                MessageBox.Show(this, "Incorrect username or password",
                    "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to logout?",
                "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {

                //LOG USER LOGGING OUT
                logs.logthis(val.UserName + " logged out of the system");

                this.Hide();
                frmLogin login = new frmLogin();
                val.UserName = null;
                login.Show();

            } else
            {
                e.Cancel = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            transactions.GenerateTransactionCode();
            Console.WriteLine(transactions.TransactionCode);
        }

    }
}
