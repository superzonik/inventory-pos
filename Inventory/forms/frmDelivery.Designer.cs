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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgDelivery = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDRNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDeliveredBy = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtRemarks = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmdAdd = new MetroFramework.Controls.MetroButton();
            this.cmdEdit = new MetroFramework.Controls.MetroButton();
            this.cmdSave = new MetroFramework.Controls.MetroButton();
            this.cmdPrint = new MetroFramework.Controls.MetroButton();
            this.cmdExit = new MetroFramework.Controls.MetroButton();
            this.dtDeliveryDate = new MetroFramework.Controls.MetroDateTime();
            this.lblRecordCount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblDeliveryID = new MetroFramework.Controls.MetroLabel();
            this.panelControls = new MetroFramework.Controls.MetroPanel();
            this.cmdDelete = new MetroFramework.Controls.MetroButton();
            this.cmdCancel = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDelivery)).BeginInit();
            this.panelControls.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDelivery.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgDelivery.EnableHeadersVisualStyles = false;
            this.dtgDelivery.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgDelivery.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgDelivery.Location = new System.Drawing.Point(23, 63);
            this.dtgDelivery.Name = "dtgDelivery";
            this.dtgDelivery.ReadOnly = true;
            this.dtgDelivery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDelivery.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgDelivery.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDelivery.Size = new System.Drawing.Size(791, 522);
            this.dtgDelivery.Style = MetroFramework.MetroColorStyle.Red;
            this.dtgDelivery.TabIndex = 8;
            this.dtgDelivery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDelivery_CellClick);
            this.dtgDelivery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgDelivery_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "DR Number:";
            // 
            // txtDRNum
            // 
            // 
            // 
            // 
            this.txtDRNum.CustomButton.Image = null;
            this.txtDRNum.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtDRNum.CustomButton.Name = "";
            this.txtDRNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDRNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDRNum.CustomButton.TabIndex = 1;
            this.txtDRNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDRNum.CustomButton.UseSelectable = true;
            this.txtDRNum.CustomButton.Visible = false;
            this.txtDRNum.Lines = new string[0];
            this.txtDRNum.Location = new System.Drawing.Point(144, 37);
            this.txtDRNum.MaxLength = 32767;
            this.txtDRNum.Name = "txtDRNum";
            this.txtDRNum.PasswordChar = '\0';
            this.txtDRNum.PromptText = "Delivery receipt number";
            this.txtDRNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDRNum.SelectedText = "";
            this.txtDRNum.SelectionLength = 0;
            this.txtDRNum.SelectionStart = 0;
            this.txtDRNum.ShortcutsEnabled = true;
            this.txtDRNum.Size = new System.Drawing.Size(264, 23);
            this.txtDRNum.TabIndex = 10;
            this.txtDRNum.UseSelectable = true;
            this.txtDRNum.WaterMark = "Delivery receipt number";
            this.txtDRNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDRNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Delivery Date:";
            // 
            // txtDeliveredBy
            // 
            // 
            // 
            // 
            this.txtDeliveredBy.CustomButton.Image = null;
            this.txtDeliveredBy.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtDeliveredBy.CustomButton.Name = "";
            this.txtDeliveredBy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeliveredBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeliveredBy.CustomButton.TabIndex = 1;
            this.txtDeliveredBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeliveredBy.CustomButton.UseSelectable = true;
            this.txtDeliveredBy.CustomButton.Visible = false;
            this.txtDeliveredBy.Lines = new string[0];
            this.txtDeliveredBy.Location = new System.Drawing.Point(144, 101);
            this.txtDeliveredBy.MaxLength = 32767;
            this.txtDeliveredBy.Name = "txtDeliveredBy";
            this.txtDeliveredBy.PasswordChar = '\0';
            this.txtDeliveredBy.PromptText = "Delivered by";
            this.txtDeliveredBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeliveredBy.SelectedText = "";
            this.txtDeliveredBy.SelectionLength = 0;
            this.txtDeliveredBy.SelectionStart = 0;
            this.txtDeliveredBy.ShortcutsEnabled = true;
            this.txtDeliveredBy.Size = new System.Drawing.Size(264, 23);
            this.txtDeliveredBy.TabIndex = 12;
            this.txtDeliveredBy.UseSelectable = true;
            this.txtDeliveredBy.WaterMark = "Delivered by";
            this.txtDeliveredBy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeliveredBy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 101);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Delivered by:";
            // 
            // txtRemarks
            // 
            // 
            // 
            // 
            this.txtRemarks.CustomButton.Image = null;
            this.txtRemarks.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtRemarks.CustomButton.Name = "";
            this.txtRemarks.CustomButton.Size = new System.Drawing.Size(143, 143);
            this.txtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemarks.CustomButton.TabIndex = 1;
            this.txtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemarks.CustomButton.UseSelectable = true;
            this.txtRemarks.CustomButton.Visible = false;
            this.txtRemarks.Lines = new string[0];
            this.txtRemarks.Location = new System.Drawing.Point(144, 130);
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
            this.txtRemarks.Size = new System.Drawing.Size(264, 145);
            this.txtRemarks.TabIndex = 13;
            this.txtRemarks.UseSelectable = true;
            this.txtRemarks.WaterMark = "Remarks";
            this.txtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 130);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Remarks:";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(820, 367);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(64, 60);
            this.cmdAdd.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdAdd.TabIndex = 17;
            this.cmdAdd.Text = "&ADD";
            this.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdAdd.UseSelectable = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Location = new System.Drawing.Point(891, 367);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(64, 60);
            this.cmdEdit.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdEdit.TabIndex = 18;
            this.cmdEdit.Text = "EDIT";
            this.cmdEdit.UseSelectable = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(1031, 367);
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
            this.cmdPrint.Location = new System.Drawing.Point(1171, 367);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(89, 76);
            this.cmdPrint.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdPrint.TabIndex = 20;
            this.cmdPrint.Text = "PRINT";
            this.cmdPrint.UseSelectable = true;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(1178, 543);
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
            this.dtDeliveryDate.Location = new System.Drawing.Point(144, 66);
            this.dtDeliveryDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(127, 29);
            this.dtDeliveryDate.TabIndex = 11;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRecordCount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRecordCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRecordCount.Location = new System.Drawing.Point(122, 588);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(22, 25);
            this.lblRecordCount.TabIndex = 24;
            this.lblRecordCount.Text = "0";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel5.Location = new System.Drawing.Point(23, 588);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Record Count:";
            // 
            // lblDeliveryID
            // 
            this.lblDeliveryID.AutoSize = true;
            this.lblDeliveryID.Location = new System.Drawing.Point(316, 15);
            this.lblDeliveryID.Name = "lblDeliveryID";
            this.lblDeliveryID.Size = new System.Drawing.Size(39, 19);
            this.lblDeliveryID.TabIndex = 25;
            this.lblDeliveryID.Text = "-----";
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.lblDeliveryID);
            this.panelControls.Controls.Add(this.metroLabel1);
            this.panelControls.Controls.Add(this.txtDRNum);
            this.panelControls.Controls.Add(this.dtDeliveryDate);
            this.panelControls.Controls.Add(this.metroLabel2);
            this.panelControls.Controls.Add(this.metroLabel3);
            this.panelControls.Controls.Add(this.txtDeliveredBy);
            this.panelControls.Controls.Add(this.metroLabel4);
            this.panelControls.Controls.Add(this.txtRemarks);
            this.panelControls.Enabled = false;
            this.panelControls.HorizontalScrollbarBarColor = true;
            this.panelControls.HorizontalScrollbarHighlightOnWheel = false;
            this.panelControls.HorizontalScrollbarSize = 10;
            this.panelControls.Location = new System.Drawing.Point(820, 63);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(441, 298);
            this.panelControls.TabIndex = 26;
            this.panelControls.VerticalScrollbarBarColor = true;
            this.panelControls.VerticalScrollbarHighlightOnWheel = false;
            this.panelControls.VerticalScrollbarSize = 10;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(961, 367);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(64, 60);
            this.cmdDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdDelete.TabIndex = 27;
            this.cmdDelete.Text = "DELETE";
            this.cmdDelete.UseSelectable = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Enabled = false;
            this.cmdCancel.Location = new System.Drawing.Point(1101, 367);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(64, 60);
            this.cmdCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdCancel.TabIndex = 28;
            this.cmdCancel.Text = "CANCEL";
            this.cmdCancel.UseSelectable = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmDelivery
            // 
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1284, 633);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.dtgDelivery);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdPrint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelivery";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Deliveries";
            this.Load += new System.EventHandler(this.frmDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDelivery)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
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
        private MetroFramework.Controls.MetroButton cmdAdd;
        private MetroFramework.Controls.MetroButton cmdEdit;
        private MetroFramework.Controls.MetroButton cmdSave;
        private MetroFramework.Controls.MetroButton cmdPrint;
        private MetroFramework.Controls.MetroButton cmdExit;
        private MetroFramework.Controls.MetroDateTime dtDeliveryDate;
        private MetroFramework.Controls.MetroLabel lblRecordCount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblDeliveryID;
        private MetroFramework.Controls.MetroPanel panelControls;
        private MetroFramework.Controls.MetroButton cmdDelete;
        private MetroFramework.Controls.MetroButton cmdCancel;
    }
}