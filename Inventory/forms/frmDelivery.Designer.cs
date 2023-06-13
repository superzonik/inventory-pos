namespace Inventory.forms
{
    partial class frmDelivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgDelivery = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDRNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDeliveredBy = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtRemarks = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmdSave = new MetroFramework.Controls.MetroButton();
            this.cmdPrint = new MetroFramework.Controls.MetroButton();
            this.cmdExit = new MetroFramework.Controls.MetroButton();
            this.dtDeliveryDate = new MetroFramework.Controls.MetroDateTime();
            this.lblDeliveredCount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblDeliveryID = new MetroFramework.Controls.MetroLabel();
            this.cmdCancel = new MetroFramework.Controls.MetroButton();
            this.grpForDelivery = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.grpDeliver = new System.Windows.Forms.GroupBox();
            this.cmdDeliver = new MetroFramework.Controls.MetroButton();
            this.lblTransactionID = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgDelivered = new MetroFramework.Controls.MetroGrid();
            this.lblDeliveryCount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDelivery)).BeginInit();
            this.grpForDelivery.SuspendLayout();
            this.grpDeliver.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDelivered)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDelivery
            // 
            this.dtgDelivery.AllowUserToAddRows = false;
            this.dtgDelivery.AllowUserToDeleteRows = false;
            this.dtgDelivery.AllowUserToResizeRows = false;
            this.dtgDelivery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDelivery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgDelivery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDelivery.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtgDelivery.EnableHeadersVisualStyles = false;
            this.dtgDelivery.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgDelivery.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgDelivery.Location = new System.Drawing.Point(6, 21);
            this.dtgDelivery.Name = "dtgDelivery";
            this.dtgDelivery.ReadOnly = true;
            this.dtgDelivery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDelivery.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgDelivery.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDelivery.Size = new System.Drawing.Size(590, 192);
            this.dtgDelivery.Style = MetroFramework.MetroColorStyle.Red;
            this.dtgDelivery.TabIndex = 8;
            this.dtgDelivery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDelivery_CellClick);
            this.dtgDelivery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgDelivery_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 20);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "DR Number:";
            // 
            // txtDRNum
            // 
            // 
            // 
            // 
            this.txtDRNum.CustomButton.Image = null;
            this.txtDRNum.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.txtDRNum.CustomButton.Name = "";
            this.txtDRNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDRNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDRNum.CustomButton.TabIndex = 1;
            this.txtDRNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDRNum.CustomButton.UseSelectable = true;
            this.txtDRNum.CustomButton.Visible = false;
            this.txtDRNum.Lines = new string[0];
            this.txtDRNum.Location = new System.Drawing.Point(125, 39);
            this.txtDRNum.MaxLength = 32767;
            this.txtDRNum.Name = "txtDRNum";
            this.txtDRNum.PasswordChar = '\0';
            this.txtDRNum.PromptText = "Delivery receipt number";
            this.txtDRNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDRNum.SelectedText = "";
            this.txtDRNum.SelectionLength = 0;
            this.txtDRNum.SelectionStart = 0;
            this.txtDRNum.ShortcutsEnabled = true;
            this.txtDRNum.Size = new System.Drawing.Size(293, 23);
            this.txtDRNum.TabIndex = 10;
            this.txtDRNum.UseSelectable = true;
            this.txtDRNum.WaterMark = "Delivery receipt number";
            this.txtDRNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDRNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 20);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Delivery Date:";
            // 
            // txtDeliveredBy
            // 
            // 
            // 
            // 
            this.txtDeliveredBy.CustomButton.Image = null;
            this.txtDeliveredBy.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.txtDeliveredBy.CustomButton.Name = "";
            this.txtDeliveredBy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeliveredBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeliveredBy.CustomButton.TabIndex = 1;
            this.txtDeliveredBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeliveredBy.CustomButton.UseSelectable = true;
            this.txtDeliveredBy.CustomButton.Visible = false;
            this.txtDeliveredBy.Lines = new string[0];
            this.txtDeliveredBy.Location = new System.Drawing.Point(125, 103);
            this.txtDeliveredBy.MaxLength = 32767;
            this.txtDeliveredBy.Name = "txtDeliveredBy";
            this.txtDeliveredBy.PasswordChar = '\0';
            this.txtDeliveredBy.PromptText = "Delivered by";
            this.txtDeliveredBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeliveredBy.SelectedText = "";
            this.txtDeliveredBy.SelectionLength = 0;
            this.txtDeliveredBy.SelectionStart = 0;
            this.txtDeliveredBy.ShortcutsEnabled = true;
            this.txtDeliveredBy.Size = new System.Drawing.Size(293, 23);
            this.txtDeliveredBy.TabIndex = 12;
            this.txtDeliveredBy.UseSelectable = true;
            this.txtDeliveredBy.WaterMark = "Delivered by";
            this.txtDeliveredBy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeliveredBy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 20);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Delivered by:";
            // 
            // txtRemarks
            // 
            // 
            // 
            // 
            this.txtRemarks.CustomButton.Image = null;
            this.txtRemarks.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtRemarks.CustomButton.Name = "";
            this.txtRemarks.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemarks.CustomButton.TabIndex = 1;
            this.txtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemarks.CustomButton.UseSelectable = true;
            this.txtRemarks.CustomButton.Visible = false;
            this.txtRemarks.Lines = new string[0];
            this.txtRemarks.Location = new System.Drawing.Point(125, 132);
            this.txtRemarks.MaxLength = 32767;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.PromptText = "Remarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.SelectionLength = 0;
            this.txtRemarks.SelectionStart = 0;
            this.txtRemarks.ShortcutsEnabled = true;
            this.txtRemarks.Size = new System.Drawing.Size(293, 31);
            this.txtRemarks.TabIndex = 13;
            this.txtRemarks.UseSelectable = true;
            this.txtRemarks.WaterMark = "Remarks";
            this.txtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 132);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 20);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Remarks:";
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(214, 169);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(64, 60);
            this.cmdSave.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdSave.TabIndex = 19;
            this.cmdSave.Text = "SAVE";
            this.cmdSave.UseSelectable = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(354, 169);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(64, 60);
            this.cmdPrint.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdPrint.TabIndex = 20;
            this.cmdPrint.Text = "PRINT";
            this.cmdPrint.UseSelectable = true;
            this.cmdPrint.Visible = false;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(1116, 570);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(83, 67);
            this.cmdExit.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdExit.TabIndex = 21;
            this.cmdExit.Text = "E&XIT";
            this.cmdExit.UseSelectable = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // dtDeliveryDate
            // 
            this.dtDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDeliveryDate.Location = new System.Drawing.Point(125, 68);
            this.dtDeliveryDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(156, 30);
            this.dtDeliveryDate.TabIndex = 11;
            // 
            // lblDeliveredCount
            // 
            this.lblDeliveredCount.AutoSize = true;
            this.lblDeliveredCount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDeliveredCount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDeliveredCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeliveredCount.Location = new System.Drawing.Point(98, 570);
            this.lblDeliveredCount.Name = "lblDeliveredCount";
            this.lblDeliveredCount.Size = new System.Drawing.Size(23, 25);
            this.lblDeliveredCount.TabIndex = 24;
            this.lblDeliveredCount.Text = "0";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel5.Location = new System.Drawing.Point(20, 575);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 20);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Delivered:";
            // 
            // lblDeliveryID
            // 
            this.lblDeliveryID.AutoSize = true;
            this.lblDeliveryID.Location = new System.Drawing.Point(379, 17);
            this.lblDeliveryID.Name = "lblDeliveryID";
            this.lblDeliveryID.Size = new System.Drawing.Size(39, 20);
            this.lblDeliveryID.TabIndex = 25;
            this.lblDeliveryID.Text = "-----";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Enabled = false;
            this.cmdCancel.Location = new System.Drawing.Point(284, 169);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(64, 60);
            this.cmdCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdCancel.TabIndex = 28;
            this.cmdCancel.Text = "CANCEL";
            this.cmdCancel.UseSelectable = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // grpForDelivery
            // 
            this.grpForDelivery.Controls.Add(this.dtgDelivery);
            this.grpForDelivery.Controls.Add(this.metroLabel6);
            this.grpForDelivery.Location = new System.Drawing.Point(20, 79);
            this.grpForDelivery.Name = "grpForDelivery";
            this.grpForDelivery.Size = new System.Drawing.Size(602, 219);
            this.grpForDelivery.TabIndex = 29;
            this.grpForDelivery.TabStop = false;
            this.grpForDelivery.Text = "FOR DELIVERY";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel6.Location = new System.Drawing.Point(162, 68);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(312, 20);
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "NOTHING FOR DELIVERY AS OF THE MOMENT...";
            // 
            // grpDeliver
            // 
            this.grpDeliver.Controls.Add(this.txtDRNum);
            this.grpDeliver.Controls.Add(this.txtRemarks);
            this.grpDeliver.Controls.Add(this.metroLabel4);
            this.grpDeliver.Controls.Add(this.cmdCancel);
            this.grpDeliver.Controls.Add(this.cmdPrint);
            this.grpDeliver.Controls.Add(this.lblDeliveryID);
            this.grpDeliver.Controls.Add(this.txtDeliveredBy);
            this.grpDeliver.Controls.Add(this.metroLabel3);
            this.grpDeliver.Controls.Add(this.cmdSave);
            this.grpDeliver.Controls.Add(this.metroLabel1);
            this.grpDeliver.Controls.Add(this.metroLabel2);
            this.grpDeliver.Controls.Add(this.dtDeliveryDate);
            this.grpDeliver.Location = new System.Drawing.Point(766, 79);
            this.grpDeliver.Name = "grpDeliver";
            this.grpDeliver.Size = new System.Drawing.Size(428, 241);
            this.grpDeliver.TabIndex = 30;
            this.grpDeliver.TabStop = false;
            this.grpDeliver.Text = "DELIVERY INFORMATION";
            this.grpDeliver.Visible = false;
            // 
            // cmdDeliver
            // 
            this.cmdDeliver.Enabled = false;
            this.cmdDeliver.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cmdDeliver.Location = new System.Drawing.Point(628, 96);
            this.cmdDeliver.Name = "cmdDeliver";
            this.cmdDeliver.Size = new System.Drawing.Size(132, 60);
            this.cmdDeliver.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdDeliver.TabIndex = 31;
            this.cmdDeliver.Text = "DELIVER >>>";
            this.cmdDeliver.UseSelectable = true;
            this.cmdDeliver.Click += new System.EventHandler(this.cmdDeliver_Click);
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Location = new System.Drawing.Point(628, 74);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(39, 20);
            this.lblTransactionID.TabIndex = 29;
            this.lblTransactionID.Text = "-----";
            this.lblTransactionID.TextChanged += new System.EventHandler(this.lblTransactionID_TextChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(539, 570);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(83, 67);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 32;
            this.metroButton1.Text = "E&XIT";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgDelivered);
            this.groupBox2.Location = new System.Drawing.Point(20, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1174, 224);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DELIVERED";
            // 
            // dtgDelivered
            // 
            this.dtgDelivered.AllowUserToAddRows = false;
            this.dtgDelivered.AllowUserToDeleteRows = false;
            this.dtgDelivered.AllowUserToResizeRows = false;
            this.dtgDelivered.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgDelivered.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDelivered.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgDelivered.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDelivered.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgDelivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDelivered.DefaultCellStyle = dataGridViewCellStyle17;
            this.dtgDelivered.EnableHeadersVisualStyles = false;
            this.dtgDelivered.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgDelivered.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgDelivered.Location = new System.Drawing.Point(6, 21);
            this.dtgDelivered.Name = "dtgDelivered";
            this.dtgDelivered.ReadOnly = true;
            this.dtgDelivered.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDelivered.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dtgDelivered.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgDelivered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDelivered.Size = new System.Drawing.Size(1162, 211);
            this.dtgDelivered.Style = MetroFramework.MetroColorStyle.Red;
            this.dtgDelivered.TabIndex = 8;
            // 
            // lblDeliveryCount
            // 
            this.lblDeliveryCount.AutoSize = true;
            this.lblDeliveryCount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDeliveryCount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDeliveryCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeliveryCount.Location = new System.Drawing.Point(114, 301);
            this.lblDeliveryCount.Name = "lblDeliveryCount";
            this.lblDeliveryCount.Size = new System.Drawing.Size(23, 25);
            this.lblDeliveryCount.TabIndex = 35;
            this.lblDeliveryCount.Text = "0";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel7.Location = new System.Drawing.Point(20, 306);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(88, 20);
            this.metroLabel7.TabIndex = 34;
            this.metroLabel7.Text = "For Delivery:";
            // 
            // frmDelivery
            // 
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1222, 660);
            this.Controls.Add(this.lblDeliveryCount);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.cmdDeliver);
            this.Controls.Add(this.grpDeliver);
            this.Controls.Add(this.grpForDelivery);
            this.Controls.Add(this.lblDeliveredCount);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmdExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelivery";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Deliveries";
            this.Load += new System.EventHandler(this.frmDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDelivery)).EndInit();
            this.grpForDelivery.ResumeLayout(false);
            this.grpForDelivery.PerformLayout();
            this.grpDeliver.ResumeLayout(false);
            this.grpDeliver.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDelivered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dtgDelivery;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDRNum;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDeliveredBy;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtRemarks;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton cmdSave;
        private MetroFramework.Controls.MetroButton cmdPrint;
        private MetroFramework.Controls.MetroButton cmdExit;
        private MetroFramework.Controls.MetroDateTime dtDeliveryDate;
        private MetroFramework.Controls.MetroLabel lblDeliveredCount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblDeliveryID;
        private MetroFramework.Controls.MetroButton cmdCancel;
        private System.Windows.Forms.GroupBox grpForDelivery;
        private System.Windows.Forms.GroupBox grpDeliver;
        private MetroFramework.Controls.MetroButton cmdDeliver;
        private MetroFramework.Controls.MetroLabel lblTransactionID;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroGrid dtgDelivered;
        private MetroFramework.Controls.MetroLabel lblDeliveryCount;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}