namespace Inventory.forms
{
    partial class frmAddNewItem
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
            this.cmdCancel = new MetroFramework.Controls.MetroButton();
            this.cmdFDASsave = new MetroFramework.Controls.MetroButton();
            this.txtFDASquantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtFDASprice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtFDASdescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cboFDAStype = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.cmdRawSave = new MetroFramework.Controls.MetroButton();
            this.txtRawQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtRawPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtRawDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.cboRawMaterialName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.dtManufactureDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtFXquantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cboFXcontent = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cboFXcapacity = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboFXtype = new MetroFramework.Controls.MetroComboBox();
            this.cmdFXsave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFXprice = new MetroFramework.Controls.MetroTextBox();
            this.cboFXproductStatus = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(537, 710);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(104, 70);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "E&xit";
            this.cmdCancel.UseSelectable = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdFDASsave
            // 
            this.cmdFDASsave.Location = new System.Drawing.Point(440, 452);
            this.cmdFDASsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdFDASsave.Name = "cmdFDASsave";
            this.cmdFDASsave.Size = new System.Drawing.Size(104, 70);
            this.cmdFDASsave.TabIndex = 19;
            this.cmdFDASsave.Text = "&Save";
            this.cmdFDASsave.UseSelectable = true;
            this.cmdFDASsave.Click += new System.EventHandler(this.cmdFDASsave_Click);
            // 
            // txtFDASquantity
            // 
            // 
            // 
            // 
            this.txtFDASquantity.CustomButton.Image = null;
            this.txtFDASquantity.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtFDASquantity.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFDASquantity.CustomButton.Name = "";
            this.txtFDASquantity.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtFDASquantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFDASquantity.CustomButton.TabIndex = 1;
            this.txtFDASquantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFDASquantity.CustomButton.UseSelectable = true;
            this.txtFDASquantity.CustomButton.Visible = false;
            this.txtFDASquantity.Lines = new string[0];
            this.txtFDASquantity.Location = new System.Drawing.Point(200, 399);
            this.txtFDASquantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFDASquantity.MaxLength = 32767;
            this.txtFDASquantity.Name = "txtFDASquantity";
            this.txtFDASquantity.PasswordChar = '\0';
            this.txtFDASquantity.PromptText = "Quantity";
            this.txtFDASquantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFDASquantity.SelectedText = "";
            this.txtFDASquantity.SelectionLength = 0;
            this.txtFDASquantity.SelectionStart = 0;
            this.txtFDASquantity.ShortcutsEnabled = true;
            this.txtFDASquantity.Size = new System.Drawing.Size(215, 28);
            this.txtFDASquantity.TabIndex = 17;
            this.txtFDASquantity.UseSelectable = true;
            this.txtFDASquantity.WaterMark = "Quantity";
            this.txtFDASquantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFDASquantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(51, 399);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(64, 20);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Quantity:";
            // 
            // txtFDASprice
            // 
            // 
            // 
            // 
            this.txtFDASprice.CustomButton.Image = null;
            this.txtFDASprice.CustomButton.Location = new System.Drawing.Point(424, 2);
            this.txtFDASprice.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFDASprice.CustomButton.Name = "";
            this.txtFDASprice.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtFDASprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFDASprice.CustomButton.TabIndex = 1;
            this.txtFDASprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFDASprice.CustomButton.UseSelectable = true;
            this.txtFDASprice.CustomButton.Visible = false;
            this.txtFDASprice.Lines = new string[0];
            this.txtFDASprice.Location = new System.Drawing.Point(200, 363);
            this.txtFDASprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFDASprice.MaxLength = 32767;
            this.txtFDASprice.Name = "txtFDASprice";
            this.txtFDASprice.PasswordChar = '\0';
            this.txtFDASprice.PromptText = "Price";
            this.txtFDASprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFDASprice.SelectedText = "";
            this.txtFDASprice.SelectionLength = 0;
            this.txtFDASprice.SelectionStart = 0;
            this.txtFDASprice.ShortcutsEnabled = true;
            this.txtFDASprice.Size = new System.Drawing.Size(344, 28);
            this.txtFDASprice.TabIndex = 16;
            this.txtFDASprice.UseSelectable = true;
            this.txtFDASprice.WaterMark = "Price";
            this.txtFDASprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFDASprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(51, 363);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(43, 20);
            this.metroLabel10.TabIndex = 15;
            this.metroLabel10.Text = "Price:";
            // 
            // txtFDASdescription
            // 
            // 
            // 
            // 
            this.txtFDASdescription.CustomButton.Image = null;
            this.txtFDASdescription.CustomButton.Location = new System.Drawing.Point(248, 2);
            this.txtFDASdescription.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFDASdescription.CustomButton.Name = "";
            this.txtFDASdescription.CustomButton.Size = new System.Drawing.Size(207, 191);
            this.txtFDASdescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFDASdescription.CustomButton.TabIndex = 1;
            this.txtFDASdescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFDASdescription.CustomButton.UseSelectable = true;
            this.txtFDASdescription.CustomButton.Visible = false;
            this.txtFDASdescription.Lines = new string[0];
            this.txtFDASdescription.Location = new System.Drawing.Point(200, 196);
            this.txtFDASdescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFDASdescription.MaxLength = 32767;
            this.txtFDASdescription.Multiline = true;
            this.txtFDASdescription.Name = "txtFDASdescription";
            this.txtFDASdescription.PasswordChar = '\0';
            this.txtFDASdescription.PromptText = "Description";
            this.txtFDASdescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFDASdescription.SelectedText = "";
            this.txtFDASdescription.SelectionLength = 0;
            this.txtFDASdescription.SelectionStart = 0;
            this.txtFDASdescription.ShortcutsEnabled = true;
            this.txtFDASdescription.Size = new System.Drawing.Size(344, 160);
            this.txtFDASdescription.TabIndex = 9;
            this.txtFDASdescription.UseSelectable = true;
            this.txtFDASdescription.WaterMark = "Description";
            this.txtFDASdescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFDASdescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(51, 196);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(82, 20);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Description:";
            // 
            // cboFDAStype
            // 
            this.cboFDAStype.FormattingEnabled = true;
            this.cboFDAStype.ItemHeight = 23;
            this.cboFDAStype.Items.AddRange(new object[] {
            "EMERGENCY LIGHT",
            "FIRE ALARM BELL",
            "FIRE HOSE CABINET",
            "Others..(Create FDAS)",
            "SMOKE DETECTOR"});
            this.cboFDAStype.Location = new System.Drawing.Point(200, 153);
            this.cboFDAStype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFDAStype.Name = "cboFDAStype";
            this.cboFDAStype.Size = new System.Drawing.Size(343, 29);
            this.cboFDAStype.Sorted = true;
            this.cboFDAStype.TabIndex = 7;
            this.cboFDAStype.UseSelectable = true;
            this.cboFDAStype.SelectedIndexChanged += new System.EventHandler(this.cboFDAStype_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(51, 153);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 20);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Name:";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage3.Controls.Add(this.metroTile1);
            this.metroTabPage3.Controls.Add(this.cmdRawSave);
            this.metroTabPage3.Controls.Add(this.txtRawQuantity);
            this.metroTabPage3.Controls.Add(this.metroLabel12);
            this.metroTabPage3.Controls.Add(this.txtRawPrice);
            this.metroTabPage3.Controls.Add(this.metroLabel13);
            this.metroTabPage3.Controls.Add(this.txtRawDescription);
            this.metroTabPage3.Controls.Add(this.metroLabel14);
            this.metroTabPage3.Controls.Add(this.cboRawMaterialName);
            this.metroTabPage3.Controls.Add(this.metroLabel15);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 12;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(608, 558);
            this.metroTabPage3.TabIndex = 1;
            this.metroTabPage3.Text = "Raw Materials";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 13;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(4, 4);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(595, 118);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 28;
            this.metroTile1.Text = "RAW MATERIALS";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // cmdRawSave
            // 
            this.cmdRawSave.Location = new System.Drawing.Point(439, 454);
            this.cmdRawSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRawSave.Name = "cmdRawSave";
            this.cmdRawSave.Size = new System.Drawing.Size(104, 70);
            this.cmdRawSave.TabIndex = 27;
            this.cmdRawSave.Text = "&Save";
            this.cmdRawSave.UseSelectable = true;
            this.cmdRawSave.Click += new System.EventHandler(this.cmdRawSave_Click);
            // 
            // txtRawQuantity
            // 
            // 
            // 
            // 
            this.txtRawQuantity.CustomButton.Image = null;
            this.txtRawQuantity.CustomButton.Location = new System.Drawing.Point(244, 2);
            this.txtRawQuantity.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRawQuantity.CustomButton.Name = "";
            this.txtRawQuantity.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtRawQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRawQuantity.CustomButton.TabIndex = 1;
            this.txtRawQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRawQuantity.CustomButton.UseSelectable = true;
            this.txtRawQuantity.CustomButton.Visible = false;
            this.txtRawQuantity.Lines = new string[0];
            this.txtRawQuantity.Location = new System.Drawing.Point(204, 409);
            this.txtRawQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRawQuantity.MaxLength = 32767;
            this.txtRawQuantity.Name = "txtRawQuantity";
            this.txtRawQuantity.PasswordChar = '\0';
            this.txtRawQuantity.PromptText = "Quantity";
            this.txtRawQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRawQuantity.SelectedText = "";
            this.txtRawQuantity.SelectionLength = 0;
            this.txtRawQuantity.SelectionStart = 0;
            this.txtRawQuantity.ShortcutsEnabled = true;
            this.txtRawQuantity.Size = new System.Drawing.Size(209, 28);
            this.txtRawQuantity.TabIndex = 25;
            this.txtRawQuantity.UseSelectable = true;
            this.txtRawQuantity.WaterMark = "Quantity";
            this.txtRawQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRawQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(55, 409);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(64, 20);
            this.metroLabel12.TabIndex = 26;
            this.metroLabel12.Text = "Quantity:";
            // 
            // txtRawPrice
            // 
            // 
            // 
            // 
            this.txtRawPrice.CustomButton.Image = null;
            this.txtRawPrice.CustomButton.Location = new System.Drawing.Point(417, 2);
            this.txtRawPrice.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRawPrice.CustomButton.Name = "";
            this.txtRawPrice.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtRawPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRawPrice.CustomButton.TabIndex = 1;
            this.txtRawPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRawPrice.CustomButton.UseSelectable = true;
            this.txtRawPrice.CustomButton.Visible = false;
            this.txtRawPrice.Lines = new string[0];
            this.txtRawPrice.Location = new System.Drawing.Point(204, 373);
            this.txtRawPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRawPrice.MaxLength = 32767;
            this.txtRawPrice.Name = "txtRawPrice";
            this.txtRawPrice.PasswordChar = '\0';
            this.txtRawPrice.PromptText = "Price";
            this.txtRawPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRawPrice.SelectedText = "";
            this.txtRawPrice.SelectionLength = 0;
            this.txtRawPrice.SelectionStart = 0;
            this.txtRawPrice.ShortcutsEnabled = true;
            this.txtRawPrice.Size = new System.Drawing.Size(339, 28);
            this.txtRawPrice.TabIndex = 24;
            this.txtRawPrice.UseSelectable = true;
            this.txtRawPrice.WaterMark = "Price";
            this.txtRawPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRawPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(55, 373);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(43, 20);
            this.metroLabel13.TabIndex = 23;
            this.metroLabel13.Text = "Price:";
            // 
            // txtRawDescription
            // 
            // 
            // 
            // 
            this.txtRawDescription.CustomButton.Image = null;
            this.txtRawDescription.CustomButton.Location = new System.Drawing.Point(241, 2);
            this.txtRawDescription.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRawDescription.CustomButton.Name = "";
            this.txtRawDescription.CustomButton.Size = new System.Drawing.Size(207, 191);
            this.txtRawDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRawDescription.CustomButton.TabIndex = 1;
            this.txtRawDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRawDescription.CustomButton.UseSelectable = true;
            this.txtRawDescription.CustomButton.Visible = false;
            this.txtRawDescription.Lines = new string[0];
            this.txtRawDescription.Location = new System.Drawing.Point(204, 206);
            this.txtRawDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRawDescription.MaxLength = 32767;
            this.txtRawDescription.Multiline = true;
            this.txtRawDescription.Name = "txtRawDescription";
            this.txtRawDescription.PasswordChar = '\0';
            this.txtRawDescription.PromptText = "Description";
            this.txtRawDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRawDescription.SelectedText = "";
            this.txtRawDescription.SelectionLength = 0;
            this.txtRawDescription.SelectionStart = 0;
            this.txtRawDescription.ShortcutsEnabled = true;
            this.txtRawDescription.Size = new System.Drawing.Size(339, 160);
            this.txtRawDescription.TabIndex = 22;
            this.txtRawDescription.UseSelectable = true;
            this.txtRawDescription.WaterMark = "Description";
            this.txtRawDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRawDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(55, 206);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(82, 20);
            this.metroLabel14.TabIndex = 21;
            this.metroLabel14.Text = "Description:";
            // 
            // cboRawMaterialName
            // 
            this.cboRawMaterialName.FormattingEnabled = true;
            this.cboRawMaterialName.ItemHeight = 23;
            this.cboRawMaterialName.Items.AddRange(new object[] {
            "EMERGENCY LIGHT",
            "FIRE ALARM BELL",
            "FIRE HOSE CABINET",
            "Others..(Create FDAS)",
            "SMOKE DETECTOR"});
            this.cboRawMaterialName.Location = new System.Drawing.Point(204, 162);
            this.cboRawMaterialName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboRawMaterialName.Name = "cboRawMaterialName";
            this.cboRawMaterialName.Size = new System.Drawing.Size(337, 29);
            this.cboRawMaterialName.Sorted = true;
            this.cboRawMaterialName.TabIndex = 20;
            this.cboRawMaterialName.UseSelectable = true;
            this.cboRawMaterialName.SelectedIndexChanged += new System.EventHandler(this.cboRawMaterialName_SelectedIndexChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(55, 162);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(103, 20);
            this.metroLabel15.TabIndex = 19;
            this.metroLabel15.Text = "Material Name:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage2.Controls.Add(this.metroTile2);
            this.metroTabPage2.Controls.Add(this.cmdFDASsave);
            this.metroTabPage2.Controls.Add(this.txtFDASquantity);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.txtFDASprice);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.txtFDASdescription);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.cboFDAStype);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 12;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(608, 558);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Fire Detection and Alarm System";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 13;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(4, 4);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(595, 118);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 29;
            this.metroTile2.Text = "FIRE DETECTION AND ALARM SYSTEM (FDAS)";
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage1.Controls.Add(this.metroTile3);
            this.metroTabPage1.Controls.Add(this.dtManufactureDate);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.txtFXquantity);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.cboFXcontent);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.cboFXcapacity);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.cboFXtype);
            this.metroTabPage1.Controls.Add(this.cmdFXsave);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.txtFXprice);
            this.metroTabPage1.Controls.Add(this.cboFXproductStatus);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 12;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(608, 558);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Fire Extinguisher";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 13;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(4, 4);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(595, 118);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 30;
            this.metroTile3.Text = "FIRE EXTINGUISHER";
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            // 
            // dtManufactureDate
            // 
            this.dtManufactureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtManufactureDate.Location = new System.Drawing.Point(225, 322);
            this.dtManufactureDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtManufactureDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtManufactureDate.Name = "dtManufactureDate";
            this.dtManufactureDate.Size = new System.Drawing.Size(176, 30);
            this.dtManufactureDate.TabIndex = 10;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(63, 322);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(123, 20);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Manufacture Date:";
            // 
            // txtFXquantity
            // 
            // 
            // 
            // 
            this.txtFXquantity.CustomButton.Image = null;
            this.txtFXquantity.CustomButton.Location = new System.Drawing.Point(137, 2);
            this.txtFXquantity.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFXquantity.CustomButton.Name = "";
            this.txtFXquantity.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtFXquantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFXquantity.CustomButton.TabIndex = 1;
            this.txtFXquantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFXquantity.CustomButton.UseSelectable = true;
            this.txtFXquantity.CustomButton.Visible = false;
            this.txtFXquantity.Lines = new string[0];
            this.txtFXquantity.Location = new System.Drawing.Point(225, 401);
            this.txtFXquantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFXquantity.MaxLength = 32767;
            this.txtFXquantity.Name = "txtFXquantity";
            this.txtFXquantity.PasswordChar = '\0';
            this.txtFXquantity.PromptText = "Quantity";
            this.txtFXquantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFXquantity.SelectedText = "";
            this.txtFXquantity.SelectionLength = 0;
            this.txtFXquantity.SelectionStart = 0;
            this.txtFXquantity.ShortcutsEnabled = true;
            this.txtFXquantity.Size = new System.Drawing.Size(129, 28);
            this.txtFXquantity.TabIndex = 12;
            this.txtFXquantity.UseSelectable = true;
            this.txtFXquantity.WaterMark = "Quantity";
            this.txtFXquantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFXquantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(63, 399);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 20);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Quantity:";
            // 
            // cboFXcontent
            // 
            this.cboFXcontent.FormattingEnabled = true;
            this.cboFXcontent.ItemHeight = 24;
            this.cboFXcontent.Items.AddRange(new object[] {
            "...Others (Create)"});
            this.cboFXcontent.Location = new System.Drawing.Point(225, 150);
            this.cboFXcontent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFXcontent.Name = "cboFXcontent";
            this.cboFXcontent.Size = new System.Drawing.Size(305, 30);
            this.cboFXcontent.Sorted = true;
            this.cboFXcontent.TabIndex = 6;
            this.cboFXcontent.UseSelectable = true;
            this.cboFXcontent.SelectedIndexChanged += new System.EventHandler(this.cboFXcontent_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(63, 155);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(103, 20);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Content Name:";
            // 
            // cboFXcapacity
            // 
            this.cboFXcapacity.FormattingEnabled = true;
            this.cboFXcapacity.ItemHeight = 24;
            this.cboFXcapacity.Items.AddRange(new object[] {
            "1lb",
            "3lbs",
            "5lbs",
            "10lbs",
            "20lbs",
            "50lbs",
            "100lbs",
            "200lbs",
            "300lbs",
            "400lbs",
            "500lbs"});
            this.cboFXcapacity.Location = new System.Drawing.Point(225, 236);
            this.cboFXcapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFXcapacity.Name = "cboFXcapacity";
            this.cboFXcapacity.Size = new System.Drawing.Size(305, 30);
            this.cboFXcapacity.TabIndex = 8;
            this.cboFXcapacity.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(63, 234);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 20);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Capacity:";
            // 
            // cboFXtype
            // 
            this.cboFXtype.FormattingEnabled = true;
            this.cboFXtype.ItemHeight = 24;
            this.cboFXtype.Items.AddRange(new object[] {
            "Ceiling",
            "Portable"});
            this.cboFXtype.Location = new System.Drawing.Point(225, 193);
            this.cboFXtype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFXtype.Name = "cboFXtype";
            this.cboFXtype.Size = new System.Drawing.Size(305, 30);
            this.cboFXtype.TabIndex = 7;
            this.cboFXtype.UseSelectable = true;
            // 
            // cmdFXsave
            // 
            this.cmdFXsave.Location = new System.Drawing.Point(428, 447);
            this.cmdFXsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdFXsave.Name = "cmdFXsave";
            this.cmdFXsave.Size = new System.Drawing.Size(104, 70);
            this.cmdFXsave.TabIndex = 13;
            this.cmdFXsave.Text = "&Save";
            this.cmdFXsave.UseSelectable = true;
            this.cmdFXsave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 191);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Type:";
            // 
            // txtFXprice
            // 
            // 
            // 
            // 
            this.txtFXprice.CustomButton.Image = null;
            this.txtFXprice.CustomButton.Location = new System.Drawing.Point(375, 2);
            this.txtFXprice.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFXprice.CustomButton.Name = "";
            this.txtFXprice.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtFXprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFXprice.CustomButton.TabIndex = 1;
            this.txtFXprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFXprice.CustomButton.UseSelectable = true;
            this.txtFXprice.CustomButton.Visible = false;
            this.txtFXprice.Lines = new string[0];
            this.txtFXprice.Location = new System.Drawing.Point(225, 366);
            this.txtFXprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFXprice.MaxLength = 32767;
            this.txtFXprice.Name = "txtFXprice";
            this.txtFXprice.PasswordChar = '\0';
            this.txtFXprice.PromptText = "Price";
            this.txtFXprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFXprice.SelectedText = "";
            this.txtFXprice.SelectionLength = 0;
            this.txtFXprice.SelectionStart = 0;
            this.txtFXprice.ShortcutsEnabled = true;
            this.txtFXprice.Size = new System.Drawing.Size(307, 28);
            this.txtFXprice.TabIndex = 11;
            this.txtFXprice.UseSelectable = true;
            this.txtFXprice.WaterMark = "Price";
            this.txtFXprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFXprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboFXproductStatus
            // 
            this.cboFXproductStatus.FormattingEnabled = true;
            this.cboFXproductStatus.ItemHeight = 24;
            this.cboFXproductStatus.Items.AddRange(new object[] {
            "Brand New",
            "Refill"});
            this.cboFXproductStatus.Location = new System.Drawing.Point(225, 279);
            this.cboFXproductStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFXproductStatus.Name = "cboFXproductStatus";
            this.cboFXproductStatus.Size = new System.Drawing.Size(305, 30);
            this.cboFXproductStatus.TabIndex = 9;
            this.cboFXproductStatus.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(63, 277);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Status:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(63, 363);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 20);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Price:";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(31, 100);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(616, 603);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.metroTabControl1_Selected);
            // 
            // frmAddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(691, 809);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.cmdCancel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNewItem";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Add New Item";
            this.Load += new System.EventHandler(this.frmAddNewItem_Load);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton cmdCancel;
        private MetroFramework.Controls.MetroButton cmdFDASsave;
        private MetroFramework.Controls.MetroTextBox txtFDASquantity;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtFDASprice;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtFDASdescription;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cboFDAStype;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroDateTime dtManufactureDate;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtFXquantity;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cboFXcontent;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cboFXcapacity;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboFXtype;
        private MetroFramework.Controls.MetroButton cmdFXsave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtFXprice;
        private MetroFramework.Controls.MetroComboBox cboFXproductStatus;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroButton cmdRawSave;
        private MetroFramework.Controls.MetroTextBox txtRawQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtRawPrice;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtRawDescription;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroComboBox cboRawMaterialName;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}