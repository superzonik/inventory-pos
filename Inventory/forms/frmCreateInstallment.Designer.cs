namespace Inventory.forms
{
    partial class frmCreateInstallment
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPrincipalAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboTerms = new MetroFramework.Controls.MetroComboBox();
            this.txtMonthyDue = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDueDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtContactPerson = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBalance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtDownpayment = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmdCompute = new MetroFramework.Controls.MetroButton();
            this.txtInterest = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cmdSave = new MetroFramework.Controls.MetroButton();
            this.cmdCancel = new MetroFramework.Controls.MetroButton();
            this.lblInstallmentID = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(18, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Principal Amount";
            // 
            // txtPrincipalAmount
            // 
            // 
            // 
            // 
            this.txtPrincipalAmount.CustomButton.Image = null;
            this.txtPrincipalAmount.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtPrincipalAmount.CustomButton.Name = "";
            this.txtPrincipalAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrincipalAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrincipalAmount.CustomButton.TabIndex = 1;
            this.txtPrincipalAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrincipalAmount.CustomButton.UseSelectable = true;
            this.txtPrincipalAmount.CustomButton.Visible = false;
            this.txtPrincipalAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrincipalAmount.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPrincipalAmount.Lines = new string[0];
            this.txtPrincipalAmount.Location = new System.Drawing.Point(134, 33);
            this.txtPrincipalAmount.MaxLength = 32767;
            this.txtPrincipalAmount.Name = "txtPrincipalAmount";
            this.txtPrincipalAmount.PasswordChar = '\0';
            this.txtPrincipalAmount.PromptText = "Principal amount";
            this.txtPrincipalAmount.ReadOnly = true;
            this.txtPrincipalAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrincipalAmount.SelectedText = "";
            this.txtPrincipalAmount.SelectionLength = 0;
            this.txtPrincipalAmount.SelectionStart = 0;
            this.txtPrincipalAmount.ShortcutsEnabled = true;
            this.txtPrincipalAmount.Size = new System.Drawing.Size(204, 23);
            this.txtPrincipalAmount.TabIndex = 2;
            this.txtPrincipalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrincipalAmount.UseSelectable = true;
            this.txtPrincipalAmount.WaterMark = "Principal amount";
            this.txtPrincipalAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrincipalAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Terms (in Months)";
            // 
            // cboTerms
            // 
            this.cboTerms.FormattingEnabled = true;
            this.cboTerms.ItemHeight = 23;
            this.cboTerms.Items.AddRange(new object[] {
            "3",
            "6",
            "9",
            "12",
            "24",
            "36",
            "48",
            "60"});
            this.cboTerms.Location = new System.Drawing.Point(134, 120);
            this.cboTerms.Name = "cboTerms";
            this.cboTerms.Size = new System.Drawing.Size(98, 29);
            this.cboTerms.TabIndex = 5;
            this.cboTerms.UseSelectable = true;
            this.cboTerms.SelectedIndexChanged += new System.EventHandler(this.cboTerms_SelectedIndexChanged);
            // 
            // txtMonthyDue
            // 
            // 
            // 
            // 
            this.txtMonthyDue.CustomButton.Image = null;
            this.txtMonthyDue.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtMonthyDue.CustomButton.Name = "";
            this.txtMonthyDue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMonthyDue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMonthyDue.CustomButton.TabIndex = 1;
            this.txtMonthyDue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMonthyDue.CustomButton.UseSelectable = true;
            this.txtMonthyDue.CustomButton.Visible = false;
            this.txtMonthyDue.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMonthyDue.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtMonthyDue.Lines = new string[0];
            this.txtMonthyDue.Location = new System.Drawing.Point(134, 184);
            this.txtMonthyDue.MaxLength = 32767;
            this.txtMonthyDue.Name = "txtMonthyDue";
            this.txtMonthyDue.PasswordChar = '\0';
            this.txtMonthyDue.PromptText = "Monthly due";
            this.txtMonthyDue.ReadOnly = true;
            this.txtMonthyDue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMonthyDue.SelectedText = "";
            this.txtMonthyDue.SelectionLength = 0;
            this.txtMonthyDue.SelectionStart = 0;
            this.txtMonthyDue.ShortcutsEnabled = true;
            this.txtMonthyDue.Size = new System.Drawing.Size(204, 23);
            this.txtMonthyDue.TabIndex = 7;
            this.txtMonthyDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonthyDue.UseSelectable = true;
            this.txtMonthyDue.WaterMark = "Monthly due";
            this.txtMonthyDue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMonthyDue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 184);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Monthly Due";
            // 
            // txtDueDate
            // 
            // 
            // 
            // 
            this.txtDueDate.CustomButton.Image = null;
            this.txtDueDate.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtDueDate.CustomButton.Name = "";
            this.txtDueDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDueDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDueDate.CustomButton.TabIndex = 1;
            this.txtDueDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDueDate.CustomButton.UseSelectable = true;
            this.txtDueDate.CustomButton.Visible = false;
            this.txtDueDate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDueDate.Lines = new string[0];
            this.txtDueDate.Location = new System.Drawing.Point(134, 213);
            this.txtDueDate.MaxLength = 32767;
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.PasswordChar = '\0';
            this.txtDueDate.PromptText = "Due date";
            this.txtDueDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDueDate.SelectedText = "";
            this.txtDueDate.SelectionLength = 0;
            this.txtDueDate.SelectionStart = 0;
            this.txtDueDate.ShortcutsEnabled = true;
            this.txtDueDate.Size = new System.Drawing.Size(204, 23);
            this.txtDueDate.TabIndex = 8;
            this.txtDueDate.UseSelectable = true;
            this.txtDueDate.WaterMark = "Due date";
            this.txtDueDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDueDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 213);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Due Date";
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(134, 30);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PromptText = "Customer name";
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(298, 23);
            this.txtCustomerName.TabIndex = 10;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMark = "Customer name";
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(22, 30);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(106, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Customer Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txtContactPerson);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 192);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(21, 146);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Contact Person";
            // 
            // txtContactPerson
            // 
            // 
            // 
            // 
            this.txtContactPerson.CustomButton.Image = null;
            this.txtContactPerson.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtContactPerson.CustomButton.Name = "";
            this.txtContactPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContactPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContactPerson.CustomButton.TabIndex = 1;
            this.txtContactPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContactPerson.CustomButton.UseSelectable = true;
            this.txtContactPerson.CustomButton.Visible = false;
            this.txtContactPerson.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtContactPerson.Lines = new string[0];
            this.txtContactPerson.Location = new System.Drawing.Point(134, 146);
            this.txtContactPerson.MaxLength = 32767;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.PasswordChar = '\0';
            this.txtContactPerson.PromptText = "Contact person";
            this.txtContactPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactPerson.SelectedText = "";
            this.txtContactPerson.SelectionLength = 0;
            this.txtContactPerson.SelectionStart = 0;
            this.txtContactPerson.ShortcutsEnabled = true;
            this.txtContactPerson.Size = new System.Drawing.Size(298, 23);
            this.txtContactPerson.TabIndex = 14;
            this.txtContactPerson.UseSelectable = true;
            this.txtContactPerson.WaterMark = "Contact person";
            this.txtContactPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContactPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(11, 59);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(117, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Customer Address";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(134, 59);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Customer address";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(298, 81);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Customer address";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.txtDownpayment);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.cmdCompute);
            this.groupBox2.Controls.Add(this.txtInterest);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.txtPrincipalAmount);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.txtDueDate);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.cboTerms);
            this.groupBox2.Controls.Add(this.txtMonthyDue);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Location = new System.Drawing.Point(66, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 310);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Installment Information";
            // 
            // txtBalance
            // 
            // 
            // 
            // 
            this.txtBalance.CustomButton.Image = null;
            this.txtBalance.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtBalance.CustomButton.Name = "";
            this.txtBalance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBalance.CustomButton.TabIndex = 1;
            this.txtBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBalance.CustomButton.UseSelectable = true;
            this.txtBalance.CustomButton.Visible = false;
            this.txtBalance.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBalance.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtBalance.Lines = new string[0];
            this.txtBalance.Location = new System.Drawing.Point(134, 91);
            this.txtBalance.MaxLength = 32767;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.PromptText = "Remaining Balance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBalance.SelectedText = "";
            this.txtBalance.SelectionLength = 0;
            this.txtBalance.SelectionStart = 0;
            this.txtBalance.ShortcutsEnabled = true;
            this.txtBalance.Size = new System.Drawing.Size(204, 23);
            this.txtBalance.TabIndex = 4;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBalance.UseSelectable = true;
            this.txtBalance.WaterMark = "Remaining Balance";
            this.txtBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(18, 91);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(54, 19);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Balance";
            // 
            // txtDownpayment
            // 
            // 
            // 
            // 
            this.txtDownpayment.CustomButton.Image = null;
            this.txtDownpayment.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtDownpayment.CustomButton.Name = "";
            this.txtDownpayment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDownpayment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDownpayment.CustomButton.TabIndex = 1;
            this.txtDownpayment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDownpayment.CustomButton.UseSelectable = true;
            this.txtDownpayment.CustomButton.Visible = false;
            this.txtDownpayment.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDownpayment.Lines = new string[0];
            this.txtDownpayment.Location = new System.Drawing.Point(134, 62);
            this.txtDownpayment.MaxLength = 32767;
            this.txtDownpayment.Name = "txtDownpayment";
            this.txtDownpayment.PasswordChar = '\0';
            this.txtDownpayment.PromptText = "Downpayment";
            this.txtDownpayment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDownpayment.SelectedText = "";
            this.txtDownpayment.SelectionLength = 0;
            this.txtDownpayment.SelectionStart = 0;
            this.txtDownpayment.ShortcutsEnabled = true;
            this.txtDownpayment.Size = new System.Drawing.Size(204, 23);
            this.txtDownpayment.TabIndex = 3;
            this.txtDownpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDownpayment.UseSelectable = true;
            this.txtDownpayment.WaterMark = "Downpayment";
            this.txtDownpayment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDownpayment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDownpayment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDownpayment_KeyDown);
            this.txtDownpayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDownpayment_KeyPress);
            this.txtDownpayment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDownpayment_KeyUp);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(18, 62);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(93, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Downpayment";
            // 
            // cmdCompute
            // 
            this.cmdCompute.Location = new System.Drawing.Point(254, 272);
            this.cmdCompute.Name = "cmdCompute";
            this.cmdCompute.Size = new System.Drawing.Size(87, 32);
            this.cmdCompute.TabIndex = 9;
            this.cmdCompute.Text = "&COMPUTE";
            this.cmdCompute.UseSelectable = true;
            this.cmdCompute.Click += new System.EventHandler(this.cmdCompute_Click);
            // 
            // txtInterest
            // 
            // 
            // 
            // 
            this.txtInterest.CustomButton.Image = null;
            this.txtInterest.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txtInterest.CustomButton.Name = "";
            this.txtInterest.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInterest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInterest.CustomButton.TabIndex = 1;
            this.txtInterest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInterest.CustomButton.UseSelectable = true;
            this.txtInterest.CustomButton.Visible = false;
            this.txtInterest.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtInterest.Lines = new string[0];
            this.txtInterest.Location = new System.Drawing.Point(134, 155);
            this.txtInterest.MaxLength = 32767;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.PasswordChar = '\0';
            this.txtInterest.PromptText = "%";
            this.txtInterest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInterest.SelectedText = "";
            this.txtInterest.SelectionLength = 0;
            this.txtInterest.SelectionStart = 0;
            this.txtInterest.ShortcutsEnabled = true;
            this.txtInterest.Size = new System.Drawing.Size(98, 23);
            this.txtInterest.TabIndex = 6;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInterest.UseSelectable = true;
            this.txtInterest.WaterMark = "%";
            this.txtInterest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInterest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInterest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInterest_KeyDown);
            this.txtInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterest_KeyPress);
            this.txtInterest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInterest_KeyUp);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(18, 155);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(74, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Interest (%)";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(318, 581);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(69, 53);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "&SAVE";
            this.cmdSave.UseSelectable = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(393, 581);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(69, 53);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "C&ANCEL";
            this.cmdCancel.UseSelectable = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // lblInstallmentID
            // 
            this.lblInstallmentID.AutoSize = true;
            this.lblInstallmentID.Location = new System.Drawing.Point(23, 618);
            this.lblInstallmentID.Name = "lblInstallmentID";
            this.lblInstallmentID.Size = new System.Drawing.Size(88, 19);
            this.lblInstallmentID.TabIndex = 15;
            this.lblInstallmentID.Text = "installment_id";
            // 
            // frmCreateInstallment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(485, 657);
            this.Controls.Add(this.lblInstallmentID);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateInstallment";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Create Installment Plan";
            this.Load += new System.EventHandler(this.frmCreateInstallment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPrincipalAmount;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboTerms;
        private MetroFramework.Controls.MetroTextBox txtMonthyDue;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDueDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtContactPerson;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton cmdSave;
        private MetroFramework.Controls.MetroButton cmdCancel;
        private MetroFramework.Controls.MetroTextBox txtInterest;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton cmdCompute;
        private MetroFramework.Controls.MetroLabel lblInstallmentID;
        private MetroFramework.Controls.MetroTextBox txtDownpayment;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtBalance;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}