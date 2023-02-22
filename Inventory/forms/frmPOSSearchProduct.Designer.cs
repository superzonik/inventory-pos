namespace Inventory.forms
{
    partial class frmPOSSearchProduct
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
            this.dtgProducts = new MetroFramework.Controls.MetroGrid();
            this.cmdSearch = new MetroFramework.Controls.MetroButton();
            this.txtKeyword = new MetroFramework.Controls.MetroTextBox();
            this.cboColumn = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblRecordCount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmdSelectItem = new MetroFramework.Controls.MetroButton();
            this.cmdCancel = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProducts
            // 
            this.dtgProducts.AllowUserToAddRows = false;
            this.dtgProducts.AllowUserToDeleteRows = false;
            this.dtgProducts.AllowUserToOrderColumns = true;
            this.dtgProducts.AllowUserToResizeRows = false;
            this.dtgProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgProducts.EnableHeadersVisualStyles = false;
            this.dtgProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgProducts.Location = new System.Drawing.Point(23, 159);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.ReadOnly = true;
            this.dtgProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducts.Size = new System.Drawing.Size(475, 383);
            this.dtgProducts.Style = MetroFramework.MetroColorStyle.Red;
            this.dtgProducts.TabIndex = 0;
            this.dtgProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProducts_CellDoubleClick);
            this.dtgProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgProducts_KeyDown);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(404, 124);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(94, 29);
            this.cmdSearch.TabIndex = 15;
            this.cmdSearch.Text = "&SEARCH";
            this.cmdSearch.UseSelectable = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // txtKeyword
            // 
            // 
            // 
            // 
            this.txtKeyword.CustomButton.Image = null;
            this.txtKeyword.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtKeyword.CustomButton.Name = "";
            this.txtKeyword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtKeyword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKeyword.CustomButton.TabIndex = 1;
            this.txtKeyword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKeyword.CustomButton.UseSelectable = true;
            this.txtKeyword.CustomButton.Visible = false;
            this.txtKeyword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtKeyword.Lines = new string[0];
            this.txtKeyword.Location = new System.Drawing.Point(233, 124);
            this.txtKeyword.MaxLength = 32767;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.PasswordChar = '\0';
            this.txtKeyword.PromptText = "Keyword";
            this.txtKeyword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKeyword.SelectedText = "";
            this.txtKeyword.SelectionLength = 0;
            this.txtKeyword.SelectionStart = 0;
            this.txtKeyword.ShortcutsEnabled = true;
            this.txtKeyword.Size = new System.Drawing.Size(165, 29);
            this.txtKeyword.TabIndex = 14;
            this.txtKeyword.UseSelectable = true;
            this.txtKeyword.WaterMark = "Keyword";
            this.txtKeyword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKeyword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            this.txtKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyUp);
            // 
            // cboColumn
            // 
            this.cboColumn.FormattingEnabled = true;
            this.cboColumn.ItemHeight = 23;
            this.cboColumn.Items.AddRange(new object[] {
            "Category",
            "Product Name"});
            this.cboColumn.Location = new System.Drawing.Point(98, 124);
            this.cboColumn.Name = "cboColumn";
            this.cboColumn.Size = new System.Drawing.Size(129, 29);
            this.cboColumn.TabIndex = 13;
            this.cboColumn.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 124);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Search by:";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRecordCount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRecordCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRecordCount.Location = new System.Drawing.Point(122, 561);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(32, 25);
            this.lblRecordCount.TabIndex = 17;
            this.lblRecordCount.Text = "00";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(23, 561);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Record Count:";
            // 
            // cmdSelectItem
            // 
            this.cmdSelectItem.Location = new System.Drawing.Point(311, 548);
            this.cmdSelectItem.Name = "cmdSelectItem";
            this.cmdSelectItem.Size = new System.Drawing.Size(94, 29);
            this.cmdSelectItem.Style = MetroFramework.MetroColorStyle.Green;
            this.cmdSelectItem.TabIndex = 18;
            this.cmdSelectItem.Text = "S&ELECT ITEM";
            this.cmdSelectItem.UseSelectable = true;
            this.cmdSelectItem.Click += new System.EventHandler(this.cmdSelectItem_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(411, 548);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(94, 29);
            this.cmdCancel.TabIndex = 19;
            this.cmdCancel.Text = "C&ANCEL";
            this.cmdCancel.UseSelectable = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmPOSSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(528, 600);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSelectItem);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.cboColumn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtgProducts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPOSSearchProduct";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Search Product";
            this.Load += new System.EventHandler(this.frmPOSSearchProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dtgProducts;
        private MetroFramework.Controls.MetroButton cmdSearch;
        private MetroFramework.Controls.MetroTextBox txtKeyword;
        private MetroFramework.Controls.MetroComboBox cboColumn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblRecordCount;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton cmdSelectItem;
        private MetroFramework.Controls.MetroButton cmdCancel;
    }
}