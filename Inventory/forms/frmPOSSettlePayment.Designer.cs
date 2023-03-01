namespace Inventory.forms
{
    partial class frmPOSSettlePayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.txtCashTendered = new MetroFramework.Controls.MetroTextBox();
            this.txtChange = new MetroFramework.Controls.MetroTextBox();
            this.cmd7 = new MetroFramework.Controls.MetroButton();
            this.cmd8 = new MetroFramework.Controls.MetroButton();
            this.cmd9 = new MetroFramework.Controls.MetroButton();
            this.cmdC = new MetroFramework.Controls.MetroButton();
            this.cmdAllClear = new MetroFramework.Controls.MetroButton();
            this.cmd6 = new MetroFramework.Controls.MetroButton();
            this.cmd5 = new MetroFramework.Controls.MetroButton();
            this.cmd4 = new MetroFramework.Controls.MetroButton();
            this.cmd0 = new MetroFramework.Controls.MetroButton();
            this.cmd3 = new MetroFramework.Controls.MetroButton();
            this.cmd2 = new MetroFramework.Controls.MetroButton();
            this.cmd1 = new MetroFramework.Controls.MetroButton();
            this.cmdEnter = new MetroFramework.Controls.MetroButton();
            this.cmdDecimal = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbltransactionid = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Enabled = false;
            this.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTotal.Lines = new string[] {
        "0"};
            this.txtTotal.Location = new System.Drawing.Point(103, 63);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PromptText = "Total Amount";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(178, 35);
            this.txtTotal.TabIndex = 50;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMark = "Total Amount";
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCashTendered
            // 
            // 
            // 
            // 
            this.txtCashTendered.CustomButton.Image = null;
            this.txtCashTendered.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtCashTendered.CustomButton.Name = "";
            this.txtCashTendered.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtCashTendered.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCashTendered.CustomButton.TabIndex = 1;
            this.txtCashTendered.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCashTendered.CustomButton.UseSelectable = true;
            this.txtCashTendered.CustomButton.Visible = false;
            this.txtCashTendered.Enabled = false;
            this.txtCashTendered.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCashTendered.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCashTendered.Lines = new string[] {
        "0"};
            this.txtCashTendered.Location = new System.Drawing.Point(103, 104);
            this.txtCashTendered.MaxLength = 32767;
            this.txtCashTendered.Multiline = true;
            this.txtCashTendered.Name = "txtCashTendered";
            this.txtCashTendered.PasswordChar = '\0';
            this.txtCashTendered.PromptText = "Cash Tendered";
            this.txtCashTendered.ReadOnly = true;
            this.txtCashTendered.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCashTendered.SelectedText = "";
            this.txtCashTendered.SelectionLength = 0;
            this.txtCashTendered.SelectionStart = 0;
            this.txtCashTendered.ShortcutsEnabled = true;
            this.txtCashTendered.Size = new System.Drawing.Size(178, 35);
            this.txtCashTendered.TabIndex = 0;
            this.txtCashTendered.Text = "0";
            this.txtCashTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCashTendered.UseSelectable = true;
            this.txtCashTendered.WaterMark = "Cash Tendered";
            this.txtCashTendered.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCashTendered.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtChange
            // 
            // 
            // 
            // 
            this.txtChange.CustomButton.Image = null;
            this.txtChange.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtChange.CustomButton.Name = "";
            this.txtChange.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChange.CustomButton.TabIndex = 1;
            this.txtChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChange.CustomButton.UseSelectable = true;
            this.txtChange.CustomButton.Visible = false;
            this.txtChange.Enabled = false;
            this.txtChange.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtChange.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtChange.Lines = new string[] {
        "0"};
            this.txtChange.Location = new System.Drawing.Point(103, 145);
            this.txtChange.MaxLength = 32767;
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.PromptText = "Change";
            this.txtChange.ReadOnly = true;
            this.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChange.SelectedText = "";
            this.txtChange.SelectionLength = 0;
            this.txtChange.SelectionStart = 0;
            this.txtChange.ShortcutsEnabled = true;
            this.txtChange.Size = new System.Drawing.Size(178, 35);
            this.txtChange.TabIndex = 51;
            this.txtChange.Text = "0";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChange.UseSelectable = true;
            this.txtChange.WaterMark = "Change";
            this.txtChange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmd7
            // 
            this.cmd7.BackColor = System.Drawing.Color.Red;
            this.cmd7.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmd7.ForeColor = System.Drawing.Color.White;
            this.cmd7.Location = new System.Drawing.Point(23, 186);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(60, 60);
            this.cmd7.Style = MetroFramework.MetroColorStyle.Red;
            this.cmd7.TabIndex = 4;
            this.cmd7.Text = "7";
            this.cmd7.UseCustomBackColor = true;
            this.cmd7.UseCustomForeColor = true;
            this.cmd7.UseSelectable = true;
            this.cmd7.UseStyleColors = true;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // cmd8
            // 
            this.cmd8.BackColor = System.Drawing.Color.Red;
            this.cmd8.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmd8.ForeColor = System.Drawing.Color.White;
            this.cmd8.Location = new System.Drawing.Point(89, 186);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(60, 60);
            this.cmd8.Style = MetroFramework.MetroColorStyle.Red;
            this.cmd8.TabIndex = 5;
            this.cmd8.Text = "8";
            this.cmd8.UseCustomBackColor = true;
            this.cmd8.UseCustomForeColor = true;
            this.cmd8.UseSelectable = true;
            this.cmd8.UseStyleColors = true;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // cmd9
            // 
            this.cmd9.BackColor = System.Drawing.Color.Red;
            this.cmd9.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmd9.ForeColor = System.Drawing.Color.White;
            this.cmd9.Location = new System.Drawing.Point(155, 186);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(60, 60);
            this.cmd9.Style = MetroFramework.MetroColorStyle.Red;
            this.cmd9.TabIndex = 6;
            this.cmd9.Text = "9";
            this.cmd9.UseCustomBackColor = true;
            this.cmd9.UseCustomForeColor = true;
            this.cmd9.UseSelectable = true;
            this.cmd9.UseStyleColors = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmdC
            // 
            this.cmdC.BackColor = System.Drawing.Color.Red;
            this.cmdC.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmdC.ForeColor = System.Drawing.Color.White;
            this.cmdC.Location = new System.Drawing.Point(221, 186);
            this.cmdC.Name = "cmdC";
            this.cmdC.Size = new System.Drawing.Size(60, 60);
            this.cmdC.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdC.TabIndex = 7;
            this.cmdC.Text = "C";
            this.cmdC.UseCustomBackColor = true;
            this.cmdC.UseCustomForeColor = true;
            this.cmdC.UseSelectable = true;
            this.cmdC.UseStyleColors = true;
            this.cmdC.Click += new System.EventHandler(this.cmdC_Click);
            // 
            // cmdAllClear
            // 
            this.cmdAllClear.BackColor = System.Drawing.Color.Red;
            this.cmdAllClear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmdAllClear.ForeColor = System.Drawing.Color.White;
            this.cmdAllClear.Location = new System.Drawing.Point(221, 252);
            this.cmdAllClear.Name = "cmdAllClear";
            this.cmdAllClear.Size = new System.Drawing.Size(60, 60);
            this.cmdAllClear.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdAllClear.TabIndex = 11;
            this.cmdAllClear.Text = "AC";
            this.cmdAllClear.UseCustomBackColor = true;
            this.cmdAllClear.UseCustomForeColor = true;
            this.cmdAllClear.UseSelectable = true;
            this.cmdAllClear.UseStyleColors = true;
            this.cmdAllClear.Click += new System.EventHandler(this.cmdAllClear_Click);
            // 
            // cmd6
            // 
            this.cmd6.BackColor = System.Drawing.Color.Red;
            this.cmd6.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmd6.ForeColor = System.Drawing.Color.White;
            this.cmd6.Location = new System.Drawing.Point(155, 252);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(60, 60);
            this.cmd6.Style = MetroFramework.MetroColorStyle.Red;
            this.cmd6.TabIndex = 10;
            this.cmd6.Text = "6";
            this.cmd6.UseCustomBackColor = true;
            this.cmd6.UseCustomForeColor = true;
            this.cmd6.UseSelectable = true;
            this.cmd6.UseStyleColors = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd5
            // 
            this.cmd5.BackColor = System.Drawing.Color.Red;
            this.cmd5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmd5.ForeColor = System.Drawing.Color.White;
            this.cmd5.Location = new System.Drawing.Point(89, 252);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(60, 60);
            this.cmd5.Style = MetroFramework.MetroColorStyle.Red;
            this.cmd5.TabIndex = 9;
            this.cmd5.Text = "5";
            this.cmd5.UseCustomBackColor = true;
            this.cmd5.UseCustomForeColor = true;
            this.cmd5.UseSelectable = true;
            this.cmd5.UseStyleColors = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmd4
            // 
            this.cmd4.BackColor = System.Drawing.Color.Red;
            this.cmd4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmd4.ForeColor = System.Drawing.Color.White;
            this.cmd4.Location = new System.Drawing.Point(23, 252);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(60, 60);
            this.cmd4.Style = MetroFramework.MetroColorStyle.Red;
            this.cmd4.TabIndex = 8;
            this.cmd4.Text = "4";
            this.cmd4.UseCustomBackColor = true;
            this.cmd4.UseCustomForeColor = true;
            this.cmd4.UseSelectable = true;
            this.cmd4.UseStyleColors = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd0
            // 
            this.cmd0.BackColor = System.Drawing.Color.Red;
            this.cmd0.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmd0.ForeColor = System.Drawing.Color.White;
            this.cmd0.Location = new System.Drawing.Point(23, 384);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(60, 60);
            this.cmd0.Style = MetroFramework.MetroColorStyle.Red;
            this.cmd0.TabIndex = 15;
            this.cmd0.Text = "0";
            this.cmd0.UseCustomBackColor = true;
            this.cmd0.UseCustomForeColor = true;
            this.cmd0.UseSelectable = true;
            this.cmd0.UseStyleColors = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // cmd3
            // 
            this.cmd3.BackColor = System.Drawing.Color.Red;
            this.cmd3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmd3.ForeColor = System.Drawing.Color.White;
            this.cmd3.Location = new System.Drawing.Point(155, 318);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(60, 60);
            this.cmd3.Style = MetroFramework.MetroColorStyle.Red;
            this.cmd3.TabIndex = 14;
            this.cmd3.Text = "3";
            this.cmd3.UseCustomBackColor = true;
            this.cmd3.UseCustomForeColor = true;
            this.cmd3.UseSelectable = true;
            this.cmd3.UseStyleColors = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd2
            // 
            this.cmd2.BackColor = System.Drawing.Color.Red;
            this.cmd2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmd2.ForeColor = System.Drawing.Color.White;
            this.cmd2.Location = new System.Drawing.Point(89, 318);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(60, 60);
            this.cmd2.Style = MetroFramework.MetroColorStyle.Red;
            this.cmd2.TabIndex = 13;
            this.cmd2.Text = "2";
            this.cmd2.UseCustomBackColor = true;
            this.cmd2.UseCustomForeColor = true;
            this.cmd2.UseSelectable = true;
            this.cmd2.UseStyleColors = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd1
            // 
            this.cmd1.BackColor = System.Drawing.Color.Red;
            this.cmd1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmd1.ForeColor = System.Drawing.Color.White;
            this.cmd1.Location = new System.Drawing.Point(23, 318);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(60, 60);
            this.cmd1.Style = MetroFramework.MetroColorStyle.Red;
            this.cmd1.TabIndex = 12;
            this.cmd1.Text = "1";
            this.cmd1.UseCustomBackColor = true;
            this.cmd1.UseCustomForeColor = true;
            this.cmd1.UseSelectable = true;
            this.cmd1.UseStyleColors = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmdEnter
            // 
            this.cmdEnter.BackColor = System.Drawing.Color.Red;
            this.cmdEnter.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmdEnter.ForeColor = System.Drawing.Color.White;
            this.cmdEnter.Location = new System.Drawing.Point(89, 384);
            this.cmdEnter.Name = "cmdEnter";
            this.cmdEnter.Size = new System.Drawing.Size(192, 60);
            this.cmdEnter.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdEnter.TabIndex = 16;
            this.cmdEnter.Text = "ENTER";
            this.cmdEnter.UseCustomBackColor = true;
            this.cmdEnter.UseCustomForeColor = true;
            this.cmdEnter.UseSelectable = true;
            this.cmdEnter.UseStyleColors = true;
            this.cmdEnter.Click += new System.EventHandler(this.cmdEnter_Click);
            // 
            // cmdDecimal
            // 
            this.cmdDecimal.BackColor = System.Drawing.Color.Red;
            this.cmdDecimal.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmdDecimal.ForeColor = System.Drawing.Color.White;
            this.cmdDecimal.Location = new System.Drawing.Point(221, 318);
            this.cmdDecimal.Name = "cmdDecimal";
            this.cmdDecimal.Size = new System.Drawing.Size(60, 60);
            this.cmdDecimal.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdDecimal.TabIndex = 52;
            this.cmdDecimal.Text = ".";
            this.cmdDecimal.UseCustomBackColor = true;
            this.cmdDecimal.UseCustomForeColor = true;
            this.cmdDecimal.UseSelectable = true;
            this.cmdDecimal.UseStyleColors = true;
            this.cmdDecimal.Click += new System.EventHandler(this.cmdDecimal_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(29, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 15);
            this.metroLabel1.TabIndex = 53;
            this.metroLabel1.Text = "Total Amount";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(23, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 15);
            this.metroLabel2.TabIndex = 54;
            this.metroLabel2.Text = "Cash Tendered";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(58, 145);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 15);
            this.metroLabel3.TabIndex = 55;
            this.metroLabel3.Text = "Change";
            // 
            // lbltransactionid
            // 
            this.lbltransactionid.AutoSize = true;
            this.lbltransactionid.Location = new System.Drawing.Point(198, 41);
            this.lbltransactionid.Name = "lbltransactionid";
            this.lbltransactionid.Size = new System.Drawing.Size(83, 19);
            this.lbltransactionid.TabIndex = 56;
            this.lbltransactionid.Text = "metroLabel4";
            // 
            // frmPOSSettlePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(310, 480);
            this.Controls.Add(this.lbltransactionid);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmdDecimal);
            this.Controls.Add(this.cmdEnter);
            this.Controls.Add(this.cmd0);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.cmdAllClear);
            this.Controls.Add(this.cmd6);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmdC);
            this.Controls.Add(this.cmd9);
            this.Controls.Add(this.cmd8);
            this.Controls.Add(this.cmd7);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtCashTendered);
            this.Controls.Add(this.txtTotal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPOSSettlePayment";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Settle Payment";
            this.Load += new System.EventHandler(this.frmPOSSettlePayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroTextBox txtCashTendered;
        private MetroFramework.Controls.MetroTextBox txtChange;
        private MetroFramework.Controls.MetroButton cmd7;
        private MetroFramework.Controls.MetroButton cmd8;
        private MetroFramework.Controls.MetroButton cmd9;
        private MetroFramework.Controls.MetroButton cmdC;
        private MetroFramework.Controls.MetroButton cmdAllClear;
        private MetroFramework.Controls.MetroButton cmd6;
        private MetroFramework.Controls.MetroButton cmd5;
        private MetroFramework.Controls.MetroButton cmd4;
        private MetroFramework.Controls.MetroButton cmd0;
        private MetroFramework.Controls.MetroButton cmd3;
        private MetroFramework.Controls.MetroButton cmd2;
        private MetroFramework.Controls.MetroButton cmd1;
        private MetroFramework.Controls.MetroButton cmdEnter;
        private MetroFramework.Controls.MetroButton cmdDecimal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lbltransactionid;
    }
}