namespace Inventory.forms
{
    partial class frmInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tileAddNew = new MetroFramework.Controls.MetroTile();
            this.dtgInventory = new MetroFramework.Controls.MetroGrid();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.txtFireExType = new MetroFramework.Controls.MetroTextBox();
            this.txtFireExCapacity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboColumn = new MetroFramework.Controls.MetroComboBox();
            this.txtKeyword = new MetroFramework.Controls.MetroTextBox();
            this.cmdSearch = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblRecordCount = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecordID = new MetroFramework.Controls.MetroLabel();
            this.lblFireExCapacity = new MetroFramework.Controls.MetroLabel();
            this.lblFireExType = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblManufactureDate = new MetroFramework.Controls.MetroLabel();
            this.lblProductStatus = new MetroFramework.Controls.MetroLabel();
            this.lblDescription = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtProductPrice = new MetroFramework.Controls.MetroTextBox();
            this.dtManufactureDate = new MetroFramework.Controls.MetroDateTime();
            this.txtProductStatus = new MetroFramework.Controls.MetroTextBox();
            this.txtCategory = new MetroFramework.Controls.MetroTextBox();
            this.txtProductDescription = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new MetroFramework.Controls.MetroButton();
            this.cmdSave = new MetroFramework.Controls.MetroButton();
            this.cmdUpdate = new MetroFramework.Controls.MetroButton();
            this.cmdExit = new MetroFramework.Controls.MetroTile();
            this.cmdRestock = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileAddNew
            // 
            this.tileAddNew.ActiveControl = null;
            this.tileAddNew.Location = new System.Drawing.Point(60, 93);
            this.tileAddNew.Name = "tileAddNew";
            this.tileAddNew.Size = new System.Drawing.Size(101, 83);
            this.tileAddNew.Style = MetroFramework.MetroColorStyle.Red;
            this.tileAddNew.TabIndex = 0;
            this.tileAddNew.Text = "Add &New...";
            this.tileAddNew.UseSelectable = true;
            this.tileAddNew.Click += new System.EventHandler(this.tileAddNew_Click);
            // 
            // dtgInventory
            // 
            this.dtgInventory.AllowUserToAddRows = false;
            this.dtgInventory.AllowUserToDeleteRows = false;
            this.dtgInventory.AllowUserToResizeRows = false;
            this.dtgInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgInventory.EnableHeadersVisualStyles = false;
            this.dtgInventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgInventory.Location = new System.Drawing.Point(23, 238);
            this.dtgInventory.Name = "dtgInventory";
            this.dtgInventory.ReadOnly = true;
            this.dtgInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInventory.Size = new System.Drawing.Size(823, 491);
            this.dtgInventory.Style = MetroFramework.MetroColorStyle.Red;
            this.dtgInventory.TabIndex = 1;
            this.dtgInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            this.dtgInventory.Sorted += new System.EventHandler(this.dtgInventory_Sorted);
            this.dtgInventory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroGrid1_KeyDown);
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(148, 87);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PromptText = "Product Name";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(313, 33);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMark = "Product Name";
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFireExType
            // 
            // 
            // 
            // 
            this.txtFireExType.CustomButton.Image = null;
            this.txtFireExType.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtFireExType.CustomButton.Name = "";
            this.txtFireExType.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtFireExType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFireExType.CustomButton.TabIndex = 1;
            this.txtFireExType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFireExType.CustomButton.UseSelectable = true;
            this.txtFireExType.CustomButton.Visible = false;
            this.txtFireExType.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFireExType.Lines = new string[0];
            this.txtFireExType.Location = new System.Drawing.Point(148, 126);
            this.txtFireExType.MaxLength = 32767;
            this.txtFireExType.Name = "txtFireExType";
            this.txtFireExType.PasswordChar = '\0';
            this.txtFireExType.PromptText = "Fire Extinguisher Type";
            this.txtFireExType.ReadOnly = true;
            this.txtFireExType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFireExType.SelectedText = "";
            this.txtFireExType.SelectionLength = 0;
            this.txtFireExType.SelectionStart = 0;
            this.txtFireExType.ShortcutsEnabled = true;
            this.txtFireExType.Size = new System.Drawing.Size(128, 33);
            this.txtFireExType.TabIndex = 5;
            this.txtFireExType.UseSelectable = true;
            this.txtFireExType.WaterMark = "Fire Extinguisher Type";
            this.txtFireExType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFireExType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFireExCapacity
            // 
            // 
            // 
            // 
            this.txtFireExCapacity.CustomButton.Image = null;
            this.txtFireExCapacity.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtFireExCapacity.CustomButton.Name = "";
            this.txtFireExCapacity.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtFireExCapacity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFireExCapacity.CustomButton.TabIndex = 1;
            this.txtFireExCapacity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFireExCapacity.CustomButton.UseSelectable = true;
            this.txtFireExCapacity.CustomButton.Visible = false;
            this.txtFireExCapacity.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFireExCapacity.Lines = new string[0];
            this.txtFireExCapacity.Location = new System.Drawing.Point(148, 165);
            this.txtFireExCapacity.MaxLength = 32767;
            this.txtFireExCapacity.Name = "txtFireExCapacity";
            this.txtFireExCapacity.PasswordChar = '\0';
            this.txtFireExCapacity.PromptText = "Fire Extinguisher Capacity";
            this.txtFireExCapacity.ReadOnly = true;
            this.txtFireExCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFireExCapacity.SelectedText = "";
            this.txtFireExCapacity.SelectionLength = 0;
            this.txtFireExCapacity.SelectionStart = 0;
            this.txtFireExCapacity.ShortcutsEnabled = true;
            this.txtFireExCapacity.Size = new System.Drawing.Size(128, 33);
            this.txtFireExCapacity.TabIndex = 6;
            this.txtFireExCapacity.UseSelectable = true;
            this.txtFireExCapacity.WaterMark = "Fire Extinguisher Capacity";
            this.txtFireExCapacity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFireExCapacity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 203);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Search by:";
            // 
            // cboColumn
            // 
            this.cboColumn.FormattingEnabled = true;
            this.cboColumn.ItemHeight = 23;
            this.cboColumn.Items.AddRange(new object[] {
            "Category",
            "Product Name"});
            this.cboColumn.Location = new System.Drawing.Point(98, 203);
            this.cboColumn.Name = "cboColumn";
            this.cboColumn.Size = new System.Drawing.Size(181, 29);
            this.cboColumn.TabIndex = 9;
            this.cboColumn.UseSelectable = true;
            // 
            // txtKeyword
            // 
            // 
            // 
            // 
            this.txtKeyword.CustomButton.Image = null;
            this.txtKeyword.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txtKeyword.CustomButton.Name = "";
            this.txtKeyword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtKeyword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKeyword.CustomButton.TabIndex = 1;
            this.txtKeyword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKeyword.CustomButton.UseSelectable = true;
            this.txtKeyword.CustomButton.Visible = false;
            this.txtKeyword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtKeyword.Lines = new string[0];
            this.txtKeyword.Location = new System.Drawing.Point(285, 203);
            this.txtKeyword.MaxLength = 32767;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.PasswordChar = '\0';
            this.txtKeyword.PromptText = "Keyword";
            this.txtKeyword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKeyword.SelectedText = "";
            this.txtKeyword.SelectionLength = 0;
            this.txtKeyword.SelectionStart = 0;
            this.txtKeyword.ShortcutsEnabled = true;
            this.txtKeyword.Size = new System.Drawing.Size(242, 29);
            this.txtKeyword.TabIndex = 10;
            this.txtKeyword.UseSelectable = true;
            this.txtKeyword.WaterMark = "Keyword";
            this.txtKeyword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKeyword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            this.txtKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyUp);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(533, 203);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(176, 29);
            this.cmdSearch.TabIndex = 11;
            this.cmdSearch.Text = "&SEARCH";
            this.cmdSearch.UseSelectable = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(23, 732);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Record Count:";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRecordCount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRecordCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRecordCount.Location = new System.Drawing.Point(122, 732);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(32, 25);
            this.lblRecordCount.TabIndex = 13;
            this.lblRecordCount.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecordID);
            this.groupBox1.Controls.Add(this.lblFireExCapacity);
            this.groupBox1.Controls.Add(this.lblFireExType);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.lblManufactureDate);
            this.groupBox1.Controls.Add(this.lblProductStatus);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtProductPrice);
            this.groupBox1.Controls.Add(this.dtManufactureDate);
            this.groupBox1.Controls.Add(this.txtProductStatus);
            this.groupBox1.Controls.Add(this.txtCategory);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtFireExType);
            this.groupBox1.Controls.Add(this.txtFireExCapacity);
            this.groupBox1.Controls.Add(this.txtProductDescription);
            this.groupBox1.Location = new System.Drawing.Point(852, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 360);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCT INFORMATION";
            // 
            // lblRecordID
            // 
            this.lblRecordID.AutoSize = true;
            this.lblRecordID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRecordID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRecordID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRecordID.Location = new System.Drawing.Point(6, 16);
            this.lblRecordID.Name = "lblRecordID";
            this.lblRecordID.Size = new System.Drawing.Size(32, 25);
            this.lblRecordID.TabIndex = 19;
            this.lblRecordID.Text = "00";
            // 
            // lblFireExCapacity
            // 
            this.lblFireExCapacity.AutoSize = true;
            this.lblFireExCapacity.Location = new System.Drawing.Point(37, 165);
            this.lblFireExCapacity.Name = "lblFireExCapacity";
            this.lblFireExCapacity.Size = new System.Drawing.Size(105, 19);
            this.lblFireExCapacity.TabIndex = 18;
            this.lblFireExCapacity.Text = "Fire Ex Capacity:";
            // 
            // lblFireExType
            // 
            this.lblFireExType.AutoSize = true;
            this.lblFireExType.Location = new System.Drawing.Point(37, 126);
            this.lblFireExType.Name = "lblFireExType";
            this.lblFireExType.Size = new System.Drawing.Size(82, 19);
            this.lblFireExType.TabIndex = 17;
            this.lblFireExType.Text = "Fire Ex Type:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(26, 278);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Price:";
            // 
            // lblManufactureDate
            // 
            this.lblManufactureDate.AutoSize = true;
            this.lblManufactureDate.Location = new System.Drawing.Point(26, 243);
            this.lblManufactureDate.Name = "lblManufactureDate";
            this.lblManufactureDate.Size = new System.Drawing.Size(116, 19);
            this.lblManufactureDate.TabIndex = 15;
            this.lblManufactureDate.Text = "Manufacture Date:";
            // 
            // lblProductStatus
            // 
            this.lblProductStatus.AutoSize = true;
            this.lblProductStatus.Location = new System.Drawing.Point(26, 204);
            this.lblProductStatus.Name = "lblProductStatus";
            this.lblProductStatus.Size = new System.Drawing.Size(96, 19);
            this.lblProductStatus.TabIndex = 14;
            this.lblProductStatus.Text = "Product Status:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(26, 126);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 19);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 87);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(98, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Product Name:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(26, 49);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 15);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Category:";
            // 
            // txtProductPrice
            // 
            // 
            // 
            // 
            this.txtProductPrice.CustomButton.Image = null;
            this.txtProductPrice.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtProductPrice.CustomButton.Name = "";
            this.txtProductPrice.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtProductPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductPrice.CustomButton.TabIndex = 1;
            this.txtProductPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductPrice.CustomButton.UseSelectable = true;
            this.txtProductPrice.CustomButton.Visible = false;
            this.txtProductPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtProductPrice.Lines = new string[0];
            this.txtProductPrice.Location = new System.Drawing.Point(148, 278);
            this.txtProductPrice.MaxLength = 32767;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.PasswordChar = '\0';
            this.txtProductPrice.PromptText = "Price";
            this.txtProductPrice.ReadOnly = true;
            this.txtProductPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductPrice.SelectedText = "";
            this.txtProductPrice.SelectionLength = 0;
            this.txtProductPrice.SelectionStart = 0;
            this.txtProductPrice.ShortcutsEnabled = true;
            this.txtProductPrice.Size = new System.Drawing.Size(173, 33);
            this.txtProductPrice.TabIndex = 10;
            this.txtProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProductPrice.UseSelectable = true;
            this.txtProductPrice.WaterMark = "Price";
            this.txtProductPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductPrice.Click += new System.EventHandler(this.txtProductPrice_Click);
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);
            // 
            // dtManufactureDate
            // 
            this.dtManufactureDate.Enabled = false;
            this.dtManufactureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtManufactureDate.Location = new System.Drawing.Point(148, 243);
            this.dtManufactureDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtManufactureDate.Name = "dtManufactureDate";
            this.dtManufactureDate.Size = new System.Drawing.Size(173, 29);
            this.dtManufactureDate.TabIndex = 9;
            // 
            // txtProductStatus
            // 
            // 
            // 
            // 
            this.txtProductStatus.CustomButton.Image = null;
            this.txtProductStatus.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtProductStatus.CustomButton.Name = "";
            this.txtProductStatus.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtProductStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductStatus.CustomButton.TabIndex = 1;
            this.txtProductStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductStatus.CustomButton.UseSelectable = true;
            this.txtProductStatus.CustomButton.Visible = false;
            this.txtProductStatus.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtProductStatus.Lines = new string[0];
            this.txtProductStatus.Location = new System.Drawing.Point(148, 204);
            this.txtProductStatus.MaxLength = 32767;
            this.txtProductStatus.Name = "txtProductStatus";
            this.txtProductStatus.PasswordChar = '\0';
            this.txtProductStatus.PromptText = "Product Status";
            this.txtProductStatus.ReadOnly = true;
            this.txtProductStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductStatus.SelectedText = "";
            this.txtProductStatus.SelectionLength = 0;
            this.txtProductStatus.SelectionStart = 0;
            this.txtProductStatus.ShortcutsEnabled = true;
            this.txtProductStatus.Size = new System.Drawing.Size(173, 33);
            this.txtProductStatus.TabIndex = 8;
            this.txtProductStatus.UseSelectable = true;
            this.txtProductStatus.WaterMark = "Product Status";
            this.txtProductStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCategory
            // 
            // 
            // 
            // 
            this.txtCategory.CustomButton.Image = null;
            this.txtCategory.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtCategory.CustomButton.Name = "";
            this.txtCategory.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategory.CustomButton.TabIndex = 1;
            this.txtCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategory.CustomButton.UseSelectable = true;
            this.txtCategory.CustomButton.Visible = false;
            this.txtCategory.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCategory.Lines = new string[0];
            this.txtCategory.Location = new System.Drawing.Point(148, 48);
            this.txtCategory.MaxLength = 32767;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.PromptText = "Category";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategory.SelectedText = "";
            this.txtCategory.SelectionLength = 0;
            this.txtCategory.SelectionStart = 0;
            this.txtCategory.ShortcutsEnabled = true;
            this.txtCategory.Size = new System.Drawing.Size(224, 33);
            this.txtCategory.TabIndex = 2;
            this.txtCategory.UseSelectable = true;
            this.txtCategory.WaterMark = "Category";
            this.txtCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductDescription
            // 
            // 
            // 
            // 
            this.txtProductDescription.CustomButton.Image = null;
            this.txtProductDescription.CustomButton.Location = new System.Drawing.Point(169, 2);
            this.txtProductDescription.CustomButton.Name = "";
            this.txtProductDescription.CustomButton.Size = new System.Drawing.Size(141, 141);
            this.txtProductDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductDescription.CustomButton.TabIndex = 1;
            this.txtProductDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductDescription.CustomButton.UseSelectable = true;
            this.txtProductDescription.CustomButton.Visible = false;
            this.txtProductDescription.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtProductDescription.Lines = new string[0];
            this.txtProductDescription.Location = new System.Drawing.Point(148, 126);
            this.txtProductDescription.MaxLength = 32767;
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.PasswordChar = '\0';
            this.txtProductDescription.PromptText = "Product Description";
            this.txtProductDescription.ReadOnly = true;
            this.txtProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProductDescription.SelectedText = "";
            this.txtProductDescription.SelectionLength = 0;
            this.txtProductDescription.SelectionStart = 0;
            this.txtProductDescription.ShortcutsEnabled = true;
            this.txtProductDescription.Size = new System.Drawing.Size(313, 146);
            this.txtProductDescription.TabIndex = 7;
            this.txtProductDescription.UseSelectable = true;
            this.txtProductDescription.WaterMark = "Product Description";
            this.txtProductDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdRestock);
            this.groupBox2.Controls.Add(this.cmdCancel);
            this.groupBox2.Controls.Add(this.cmdSave);
            this.groupBox2.Controls.Add(this.cmdUpdate);
            this.groupBox2.Location = new System.Drawing.Point(852, 569);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 157);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTROLS";
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackgroundImage = global::Inventory.Properties.Resources.cancel;
            this.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdCancel.Enabled = false;
            this.cmdCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cmdCancel.Location = new System.Drawing.Point(360, 40);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(101, 83);
            this.cmdCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdCancel.TabIndex = 19;
            this.cmdCancel.Text = "CANCEL";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCancel.UseSelectable = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click_1);
            // 
            // cmdSave
            // 
            this.cmdSave.BackgroundImage = global::Inventory.Properties.Resources.save;
            this.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdSave.Enabled = false;
            this.cmdSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cmdSave.Location = new System.Drawing.Point(253, 40);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(101, 83);
            this.cmdSave.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdSave.TabIndex = 18;
            this.cmdSave.Text = "SAVE";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSave.UseSelectable = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.BackgroundImage = global::Inventory.Properties.Resources.edit;
            this.cmdUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdUpdate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cmdUpdate.Location = new System.Drawing.Point(146, 40);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(101, 83);
            this.cmdUpdate.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdUpdate.TabIndex = 17;
            this.cmdUpdate.Text = "UPDATE";
            this.cmdUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdUpdate.UseSelectable = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.ActiveControl = null;
            this.cmdExit.Location = new System.Drawing.Point(1237, 63);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(101, 83);
            this.cmdExit.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdExit.TabIndex = 16;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.TileImage = global::Inventory.Properties.Resources.exit31;
            this.cmdExit.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdExit.UseSelectable = true;
            this.cmdExit.UseTileImage = true;
            this.cmdExit.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // cmdRestock
            // 
            this.cmdRestock.BackgroundImage = global::Inventory.Properties.Resources.add;
            this.cmdRestock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdRestock.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cmdRestock.Location = new System.Drawing.Point(39, 40);
            this.cmdRestock.Name = "cmdRestock";
            this.cmdRestock.Size = new System.Drawing.Size(101, 83);
            this.cmdRestock.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdRestock.TabIndex = 16;
            this.cmdRestock.Text = "RESTOCK";
            this.cmdRestock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdRestock.UseSelectable = true;
            this.cmdRestock.Click += new System.EventHandler(this.cmdRestock_Click);
            // 
            // frmInventory
            // 
            this.AcceptButton = this.cmdSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 808);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.cboColumn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtgInventory);
            this.Controls.Add(this.tileAddNew);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventory";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Product Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileAddNew;
        private MetroFramework.Controls.MetroGrid dtgInventory;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroTextBox txtFireExType;
        private MetroFramework.Controls.MetroTextBox txtFireExCapacity;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboColumn;
        private MetroFramework.Controls.MetroTextBox txtKeyword;
        private MetroFramework.Controls.MetroButton cmdSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblRecordCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile cmdExit;
        private MetroFramework.Controls.MetroTextBox txtCategory;
        private MetroFramework.Controls.MetroTextBox txtProductPrice;
        private MetroFramework.Controls.MetroDateTime dtManufactureDate;
        private MetroFramework.Controls.MetroTextBox txtProductStatus;
        private MetroFramework.Controls.MetroTextBox txtProductDescription;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblManufactureDate;
        private MetroFramework.Controls.MetroLabel lblProductStatus;
        private MetroFramework.Controls.MetroLabel lblDescription;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblFireExCapacity;
        private MetroFramework.Controls.MetroLabel lblFireExType;
        private MetroFramework.Controls.MetroButton cmdUpdate;
        private MetroFramework.Controls.MetroButton cmdCancel;
        private MetroFramework.Controls.MetroButton cmdSave;
        private MetroFramework.Controls.MetroLabel lblRecordID;
        private MetroFramework.Controls.MetroButton cmdRestock;
    }
}