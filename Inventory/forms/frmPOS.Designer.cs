﻿namespace Inventory.forms
{
    partial class frmPOS
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblTransactionCode = new MetroFramework.Controls.MetroLabel();
            this.lblDateNow = new MetroFramework.Controls.MetroLabel();
            this.dtgCart = new MetroFramework.Controls.MetroGrid();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnminus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnadd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.instock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeitem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmdCancelTransaction = new MetroFramework.Controls.MetroTile();
            this.cmdClosePOS = new MetroFramework.Controls.MetroTile();
            this.cmdTransactions = new MetroFramework.Controls.MetroTile();
            this.cmdSettlePaymentInstallment = new MetroFramework.Controls.MetroTile();
            this.cmdClearCart = new MetroFramework.Controls.MetroTile();
            this.cmdSettlePayment = new MetroFramework.Controls.MetroTile();
            this.cmdAddDiscount = new MetroFramework.Controls.MetroTile();
            this.cmdSearchProduct = new MetroFramework.Controls.MetroTile();
            this.cmdNewTrans = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblSubTotal = new MetroFramework.Controls.MetroLabel();
            this.lblDiscount = new MetroFramework.Controls.MetroLabel();
            this.lblVatableSales = new MetroFramework.Controls.MetroLabel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFullDate = new System.Windows.Forms.Label();
            this.lblTopPrice = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtClientSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmdSelect = new MetroFramework.Controls.MetroButton();
            this.lblRecordCount = new MetroFramework.Controls.MetroLabel();
            this.lblClientID = new MetroFramework.Controls.MetroLabel();
            this.cmdAddClient = new MetroFramework.Controls.MetroButton();
            this.dtgClients = new MetroFramework.Controls.MetroGrid();
            this.txtTIN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtSalesAgent = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtContactPerson = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lblGrandTotal = new MetroFramework.Controls.MetroLabel();
            this.lblVAT = new MetroFramework.Controls.MetroTextBox();
            this.txtRemarks = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCart)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.grpCustomerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClients)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 15);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "TRANSACTION NO:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(23, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 15);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "TRANSACTION DATE:";
            // 
            // lblTransactionCode
            // 
            this.lblTransactionCode.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTransactionCode.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTransactionCode.Location = new System.Drawing.Point(156, 60);
            this.lblTransactionCode.Name = "lblTransactionCode";
            this.lblTransactionCode.Size = new System.Drawing.Size(442, 19);
            this.lblTransactionCode.TabIndex = 3;
            this.lblTransactionCode.Text = "------------";
            // 
            // lblDateNow
            // 
            this.lblDateNow.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDateNow.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDateNow.Location = new System.Drawing.Point(156, 79);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(442, 19);
            this.lblDateNow.TabIndex = 4;
            this.lblDateNow.Text = "Sunday, January 1, 2023";
            // 
            // dtgCart
            // 
            this.dtgCart.AllowUserToAddRows = false;
            this.dtgCart.AllowUserToResizeRows = false;
            this.dtgCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dtgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.serialnumber,
            this.price,
            this.btnminus,
            this.quantity,
            this.btnadd,
            this.instock,
            this.discount,
            this.total,
            this.removeitem,
            this.itemid,
            this.itemname,
            this.category});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCart.DefaultCellStyle = dataGridViewCellStyle36;
            this.dtgCart.EnableHeadersVisualStyles = false;
            this.dtgCart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgCart.Location = new System.Drawing.Point(23, 313);
            this.dtgCart.Name = "dtgCart";
            this.dtgCart.ReadOnly = true;
            this.dtgCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dtgCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCart.Size = new System.Drawing.Size(1009, 244);
            this.dtgCart.Style = MetroFramework.MetroColorStyle.Red;
            this.dtgCart.TabIndex = 7;
            this.dtgCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCart_CellClick);
            this.dtgCart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCart_CellDoubleClick);
            this.dtgCart.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgCart_CellPainting);
            // 
            // description
            // 
            this.description.HeaderText = "DESCRIPTION";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 350;
            // 
            // serialnumber
            // 
            this.serialnumber.HeaderText = "SERIAL NUMBER";
            this.serialnumber.Name = "serialnumber";
            this.serialnumber.ReadOnly = true;
            this.serialnumber.Width = 150;
            // 
            // price
            // 
            dataGridViewCellStyle32.Format = "n2";
            this.price.DefaultCellStyle = dataGridViewCellStyle32;
            this.price.HeaderText = "PRICE";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // btnminus
            // 
            this.btnminus.HeaderText = "-";
            this.btnminus.Name = "btnminus";
            this.btnminus.ReadOnly = true;
            this.btnminus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnminus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnminus.Width = 20;
            // 
            // quantity
            // 
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle33;
            this.quantity.HeaderText = "QTY";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 40;
            // 
            // btnadd
            // 
            this.btnadd.HeaderText = "+";
            this.btnadd.Name = "btnadd";
            this.btnadd.ReadOnly = true;
            this.btnadd.Width = 20;
            // 
            // instock
            // 
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.instock.DefaultCellStyle = dataGridViewCellStyle34;
            this.instock.HeaderText = "IN STOCK";
            this.instock.Name = "instock";
            this.instock.ReadOnly = true;
            this.instock.Width = 60;
            // 
            // discount
            // 
            this.discount.HeaderText = "DISCOUNT";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // total
            // 
            dataGridViewCellStyle35.Format = "n2";
            this.total.DefaultCellStyle = dataGridViewCellStyle35;
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // removeitem
            // 
            this.removeitem.HeaderText = "";
            this.removeitem.Name = "removeitem";
            this.removeitem.ReadOnly = true;
            this.removeitem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.removeitem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.removeitem.Width = 20;
            // 
            // itemid
            // 
            this.itemid.HeaderText = "ITEM ID";
            this.itemid.Name = "itemid";
            this.itemid.ReadOnly = true;
            this.itemid.Visible = false;
            // 
            // itemname
            // 
            this.itemname.HeaderText = "ITEM NAME";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            this.itemname.Visible = false;
            // 
            // category
            // 
            this.category.HeaderText = "CATEGORY";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.cmdCancelTransaction);
            this.metroPanel1.Controls.Add(this.cmdClosePOS);
            this.metroPanel1.Controls.Add(this.cmdTransactions);
            this.metroPanel1.Controls.Add(this.cmdSettlePaymentInstallment);
            this.metroPanel1.Controls.Add(this.cmdClearCart);
            this.metroPanel1.Controls.Add(this.cmdSettlePayment);
            this.metroPanel1.Controls.Add(this.cmdAddDiscount);
            this.metroPanel1.Controls.Add(this.cmdSearchProduct);
            this.metroPanel1.Controls.Add(this.cmdNewTrans);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1038, 102);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(252, 588);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmdCancelTransaction
            // 
            this.cmdCancelTransaction.ActiveControl = null;
            this.cmdCancelTransaction.Enabled = false;
            this.cmdCancelTransaction.Location = new System.Drawing.Point(3, 402);
            this.cmdCancelTransaction.Name = "cmdCancelTransaction";
            this.cmdCancelTransaction.Size = new System.Drawing.Size(245, 51);
            this.cmdCancelTransaction.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmdCancelTransaction.TabIndex = 10;
            this.cmdCancelTransaction.Text = "[F8] CANCEL TRANSACTION";
            this.cmdCancelTransaction.UseSelectable = true;
            this.cmdCancelTransaction.Click += new System.EventHandler(this.cmdCancelTransaction_Click);
            // 
            // cmdClosePOS
            // 
            this.cmdClosePOS.ActiveControl = null;
            this.cmdClosePOS.Location = new System.Drawing.Point(3, 532);
            this.cmdClosePOS.Name = "cmdClosePOS";
            this.cmdClosePOS.Size = new System.Drawing.Size(245, 51);
            this.cmdClosePOS.TabIndex = 9;
            this.cmdClosePOS.Text = "[F10] CLOSE POS";
            this.cmdClosePOS.UseSelectable = true;
            this.cmdClosePOS.Click += new System.EventHandler(this.cmdClosePOS_Click);
            // 
            // cmdTransactions
            // 
            this.cmdTransactions.ActiveControl = null;
            this.cmdTransactions.Enabled = false;
            this.cmdTransactions.Location = new System.Drawing.Point(3, 345);
            this.cmdTransactions.Name = "cmdTransactions";
            this.cmdTransactions.Size = new System.Drawing.Size(245, 51);
            this.cmdTransactions.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmdTransactions.TabIndex = 8;
            this.cmdTransactions.Text = "[F7] TRANSACTION";
            this.cmdTransactions.UseSelectable = true;
            this.cmdTransactions.Click += new System.EventHandler(this.cmdTransactions_Click);
            // 
            // cmdSettlePaymentInstallment
            // 
            this.cmdSettlePaymentInstallment.ActiveControl = null;
            this.cmdSettlePaymentInstallment.Enabled = false;
            this.cmdSettlePaymentInstallment.Location = new System.Drawing.Point(3, 231);
            this.cmdSettlePaymentInstallment.Name = "cmdSettlePaymentInstallment";
            this.cmdSettlePaymentInstallment.Size = new System.Drawing.Size(245, 51);
            this.cmdSettlePaymentInstallment.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmdSettlePaymentInstallment.TabIndex = 6;
            this.cmdSettlePaymentInstallment.Text = "[F5] SETTLE PAYMENT [INSTALLMENT]";
            this.cmdSettlePaymentInstallment.UseSelectable = true;
            this.cmdSettlePaymentInstallment.Click += new System.EventHandler(this.cmdSettlePaymentInstallment_Click);
            // 
            // cmdClearCart
            // 
            this.cmdClearCart.ActiveControl = null;
            this.cmdClearCart.Enabled = false;
            this.cmdClearCart.Location = new System.Drawing.Point(3, 288);
            this.cmdClearCart.Name = "cmdClearCart";
            this.cmdClearCart.Size = new System.Drawing.Size(245, 51);
            this.cmdClearCart.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmdClearCart.TabIndex = 7;
            this.cmdClearCart.Text = "[F6] CLEAR CART";
            this.cmdClearCart.UseSelectable = true;
            this.cmdClearCart.Click += new System.EventHandler(this.cmdClearCart_Click);
            // 
            // cmdSettlePayment
            // 
            this.cmdSettlePayment.ActiveControl = null;
            this.cmdSettlePayment.Enabled = false;
            this.cmdSettlePayment.Location = new System.Drawing.Point(3, 174);
            this.cmdSettlePayment.Name = "cmdSettlePayment";
            this.cmdSettlePayment.Size = new System.Drawing.Size(245, 51);
            this.cmdSettlePayment.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmdSettlePayment.TabIndex = 5;
            this.cmdSettlePayment.Text = "[F4] SETTLE PAYMENT";
            this.cmdSettlePayment.UseSelectable = true;
            this.cmdSettlePayment.Click += new System.EventHandler(this.cmdSettlePayment_Click);
            // 
            // cmdAddDiscount
            // 
            this.cmdAddDiscount.ActiveControl = null;
            this.cmdAddDiscount.Enabled = false;
            this.cmdAddDiscount.Location = new System.Drawing.Point(3, 117);
            this.cmdAddDiscount.Name = "cmdAddDiscount";
            this.cmdAddDiscount.Size = new System.Drawing.Size(245, 51);
            this.cmdAddDiscount.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmdAddDiscount.TabIndex = 4;
            this.cmdAddDiscount.Text = "[F3] ADD DISCOUNT";
            this.cmdAddDiscount.UseSelectable = true;
            this.cmdAddDiscount.Click += new System.EventHandler(this.cmdAddDiscount_Click);
            // 
            // cmdSearchProduct
            // 
            this.cmdSearchProduct.ActiveControl = null;
            this.cmdSearchProduct.Enabled = false;
            this.cmdSearchProduct.Location = new System.Drawing.Point(3, 60);
            this.cmdSearchProduct.Name = "cmdSearchProduct";
            this.cmdSearchProduct.Size = new System.Drawing.Size(245, 51);
            this.cmdSearchProduct.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmdSearchProduct.TabIndex = 3;
            this.cmdSearchProduct.Text = "[F2] SEARCH PRODUCT";
            this.cmdSearchProduct.UseSelectable = true;
            this.cmdSearchProduct.Click += new System.EventHandler(this.cmdSearchProduct_Click);
            // 
            // cmdNewTrans
            // 
            this.cmdNewTrans.ActiveControl = null;
            this.cmdNewTrans.Location = new System.Drawing.Point(3, 3);
            this.cmdNewTrans.Name = "cmdNewTrans";
            this.cmdNewTrans.Size = new System.Drawing.Size(245, 51);
            this.cmdNewTrans.Style = MetroFramework.MetroColorStyle.Green;
            this.cmdNewTrans.TabIndex = 2;
            this.cmdNewTrans.Text = "[F1] NEW TRANSACTION";
            this.cmdNewTrans.UseSelectable = true;
            this.cmdNewTrans.Click += new System.EventHandler(this.cmdNewTrans_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(650, 560);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 25);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "SUB TOTAL";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(650, 591);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(74, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "DISCOUNT";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(650, 616);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(30, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "VAT";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(650, 641);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(98, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "VATABLE SALES";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSubTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSubTotal.Location = new System.Drawing.Point(795, 560);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(171, 25);
            this.lblSubTotal.TabIndex = 13;
            this.lblSubTotal.Text = "0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDiscount.Location = new System.Drawing.Point(795, 585);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(171, 25);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVatableSales
            // 
            this.lblVatableSales.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblVatableSales.Location = new System.Drawing.Point(795, 635);
            this.lblVatableSales.Name = "lblVatableSales";
            this.lblVatableSales.Size = new System.Drawing.Size(171, 25);
            this.lblVatableSales.TabIndex = 16;
            this.lblVatableSales.Text = "0.00";
            this.lblVatableSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(20, 593);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(308, 55);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "11:45:49 PM";
            // 
            // lblFullDate
            // 
            this.lblFullDate.AutoSize = true;
            this.lblFullDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullDate.Location = new System.Drawing.Point(27, 648);
            this.lblFullDate.Name = "lblFullDate";
            this.lblFullDate.Size = new System.Drawing.Size(207, 20);
            this.lblFullDate.TabIndex = 18;
            this.lblFullDate.Text = "Sunday, January 1, 2023";
            // 
            // lblTopPrice
            // 
            this.lblTopPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPrice.ForeColor = System.Drawing.Color.Green;
            this.lblTopPrice.Location = new System.Drawing.Point(822, 43);
            this.lblTopPrice.Name = "lblTopPrice";
            this.lblTopPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTopPrice.Size = new System.Drawing.Size(466, 55);
            this.lblTopPrice.TabIndex = 19;
            this.lblTopPrice.Text = "0.00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Controls.Add(this.txtRemarks);
            this.grpCustomerInformation.Controls.Add(this.metroLabel12);
            this.grpCustomerInformation.Controls.Add(this.txtClientSearch);
            this.grpCustomerInformation.Controls.Add(this.metroLabel11);
            this.grpCustomerInformation.Controls.Add(this.cmdSelect);
            this.grpCustomerInformation.Controls.Add(this.lblRecordCount);
            this.grpCustomerInformation.Controls.Add(this.lblClientID);
            this.grpCustomerInformation.Controls.Add(this.cmdAddClient);
            this.grpCustomerInformation.Controls.Add(this.dtgClients);
            this.grpCustomerInformation.Controls.Add(this.txtTIN);
            this.grpCustomerInformation.Controls.Add(this.metroLabel15);
            this.grpCustomerInformation.Controls.Add(this.txtSalesAgent);
            this.grpCustomerInformation.Controls.Add(this.metroLabel14);
            this.grpCustomerInformation.Controls.Add(this.txtContactPerson);
            this.grpCustomerInformation.Controls.Add(this.metroLabel5);
            this.grpCustomerInformation.Controls.Add(this.txtCustomerAddress);
            this.grpCustomerInformation.Controls.Add(this.metroLabel4);
            this.grpCustomerInformation.Controls.Add(this.txtCustomerName);
            this.grpCustomerInformation.Controls.Add(this.metroLabel3);
            this.grpCustomerInformation.Enabled = false;
            this.grpCustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerInformation.Location = new System.Drawing.Point(23, 101);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(1009, 206);
            this.grpCustomerInformation.TabIndex = 20;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
            // 
            // txtClientSearch
            // 
            // 
            // 
            // 
            this.txtClientSearch.CustomButton.Image = null;
            this.txtClientSearch.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtClientSearch.CustomButton.Name = "";
            this.txtClientSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClientSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClientSearch.CustomButton.TabIndex = 1;
            this.txtClientSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClientSearch.CustomButton.UseSelectable = true;
            this.txtClientSearch.CustomButton.Visible = false;
            this.txtClientSearch.Lines = new string[0];
            this.txtClientSearch.Location = new System.Drawing.Point(102, 22);
            this.txtClientSearch.MaxLength = 32767;
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.PasswordChar = '\0';
            this.txtClientSearch.PromptText = "Client/Company Name";
            this.txtClientSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClientSearch.SelectedText = "";
            this.txtClientSearch.SelectionLength = 0;
            this.txtClientSearch.SelectionStart = 0;
            this.txtClientSearch.ShortcutsEnabled = true;
            this.txtClientSearch.Size = new System.Drawing.Size(220, 23);
            this.txtClientSearch.TabIndex = 16;
            this.txtClientSearch.UseSelectable = true;
            this.txtClientSearch.WaterMark = "Client/Company Name";
            this.txtClientSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClientSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtClientSearch.TextChanged += new System.EventHandler(this.txtClientSearch_TextChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(8, 22);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(88, 19);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Search Client:";
            // 
            // cmdSelect
            // 
            this.cmdSelect.Location = new System.Drawing.Point(328, 90);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(100, 57);
            this.cmdSelect.Style = MetroFramework.MetroColorStyle.Green;
            this.cmdSelect.TabIndex = 14;
            this.cmdSelect.Text = "Select Client >>";
            this.cmdSelect.UseSelectable = true;
            this.cmdSelect.UseStyleColors = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRecordCount.Location = new System.Drawing.Point(6, 184);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(49, 19);
            this.lblRecordCount.TabIndex = 13;
            this.lblRecordCount.Text = "00000";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(64, 184);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(54, 19);
            this.lblClientID.TabIndex = 12;
            this.lblClientID.Text = "client id";
            this.lblClientID.Visible = false;
            // 
            // cmdAddClient
            // 
            this.cmdAddClient.Location = new System.Drawing.Point(328, 51);
            this.cmdAddClient.Name = "cmdAddClient";
            this.cmdAddClient.Size = new System.Drawing.Size(100, 33);
            this.cmdAddClient.TabIndex = 11;
            this.cmdAddClient.Text = "New Client...";
            this.cmdAddClient.UseSelectable = true;
            this.cmdAddClient.Click += new System.EventHandler(this.cmdAddClient_Click);
            // 
            // dtgClients
            // 
            this.dtgClients.AllowUserToAddRows = false;
            this.dtgClients.AllowUserToDeleteRows = false;
            this.dtgClients.AllowUserToResizeRows = false;
            this.dtgClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dtgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgClients.DefaultCellStyle = dataGridViewCellStyle39;
            this.dtgClients.EnableHeadersVisualStyles = false;
            this.dtgClients.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgClients.Location = new System.Drawing.Point(6, 51);
            this.dtgClients.Name = "dtgClients";
            this.dtgClients.ReadOnly = true;
            this.dtgClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dtgClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClients.Size = new System.Drawing.Size(316, 130);
            this.dtgClients.TabIndex = 10;
            this.dtgClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClients_CellClick);
            this.dtgClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClients_CellContentClick);
            this.dtgClients.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgClients_KeyDown);
            // 
            // txtTIN
            // 
            // 
            // 
            // 
            this.txtTIN.CustomButton.Image = null;
            this.txtTIN.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.txtTIN.CustomButton.Name = "";
            this.txtTIN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTIN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTIN.CustomButton.TabIndex = 1;
            this.txtTIN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTIN.CustomButton.UseSelectable = true;
            this.txtTIN.CustomButton.Visible = false;
            this.txtTIN.Lines = new string[0];
            this.txtTIN.Location = new System.Drawing.Point(566, 136);
            this.txtTIN.MaxLength = 32767;
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.PasswordChar = '\0';
            this.txtTIN.PromptText = "TIN number";
            this.txtTIN.ReadOnly = true;
            this.txtTIN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTIN.SelectedText = "";
            this.txtTIN.SelectionLength = 0;
            this.txtTIN.SelectionStart = 0;
            this.txtTIN.ShortcutsEnabled = true;
            this.txtTIN.Size = new System.Drawing.Size(423, 23);
            this.txtTIN.TabIndex = 9;
            this.txtTIN.UseSelectable = true;
            this.txtTIN.WaterMark = "TIN number";
            this.txtTIN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTIN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(434, 136);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(32, 19);
            this.metroLabel15.TabIndex = 8;
            this.metroLabel15.Text = "TIN:";
            // 
            // txtSalesAgent
            // 
            // 
            // 
            // 
            this.txtSalesAgent.CustomButton.Image = null;
            this.txtSalesAgent.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.txtSalesAgent.CustomButton.Name = "";
            this.txtSalesAgent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalesAgent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalesAgent.CustomButton.TabIndex = 1;
            this.txtSalesAgent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalesAgent.CustomButton.UseSelectable = true;
            this.txtSalesAgent.CustomButton.Visible = false;
            this.txtSalesAgent.Lines = new string[0];
            this.txtSalesAgent.Location = new System.Drawing.Point(566, 107);
            this.txtSalesAgent.MaxLength = 32767;
            this.txtSalesAgent.Name = "txtSalesAgent";
            this.txtSalesAgent.PasswordChar = '\0';
            this.txtSalesAgent.PromptText = "Sales Agent";
            this.txtSalesAgent.ReadOnly = true;
            this.txtSalesAgent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalesAgent.SelectedText = "";
            this.txtSalesAgent.SelectionLength = 0;
            this.txtSalesAgent.SelectionStart = 0;
            this.txtSalesAgent.ShortcutsEnabled = true;
            this.txtSalesAgent.Size = new System.Drawing.Size(423, 23);
            this.txtSalesAgent.TabIndex = 7;
            this.txtSalesAgent.UseSelectable = true;
            this.txtSalesAgent.WaterMark = "Sales Agent";
            this.txtSalesAgent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalesAgent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(434, 106);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(80, 19);
            this.metroLabel14.TabIndex = 6;
            this.metroLabel14.Text = "Sales Agent:";
            // 
            // txtContactPerson
            // 
            // 
            // 
            // 
            this.txtContactPerson.CustomButton.Image = null;
            this.txtContactPerson.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.txtContactPerson.CustomButton.Name = "";
            this.txtContactPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContactPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContactPerson.CustomButton.TabIndex = 1;
            this.txtContactPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContactPerson.CustomButton.UseSelectable = true;
            this.txtContactPerson.CustomButton.Visible = false;
            this.txtContactPerson.Lines = new string[0];
            this.txtContactPerson.Location = new System.Drawing.Point(566, 78);
            this.txtContactPerson.MaxLength = 32767;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.PasswordChar = '\0';
            this.txtContactPerson.PromptText = "Contact Person";
            this.txtContactPerson.ReadOnly = true;
            this.txtContactPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactPerson.SelectedText = "";
            this.txtContactPerson.SelectionLength = 0;
            this.txtContactPerson.SelectionStart = 0;
            this.txtContactPerson.ShortcutsEnabled = true;
            this.txtContactPerson.Size = new System.Drawing.Size(423, 23);
            this.txtContactPerson.TabIndex = 5;
            this.txtContactPerson.UseSelectable = true;
            this.txtContactPerson.WaterMark = "Contact Person";
            this.txtContactPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContactPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(434, 77);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Contact Person:";
            // 
            // txtCustomerAddress
            // 
            // 
            // 
            // 
            this.txtCustomerAddress.CustomButton.Image = null;
            this.txtCustomerAddress.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.txtCustomerAddress.CustomButton.Name = "";
            this.txtCustomerAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerAddress.CustomButton.TabIndex = 1;
            this.txtCustomerAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerAddress.CustomButton.UseSelectable = true;
            this.txtCustomerAddress.CustomButton.Visible = false;
            this.txtCustomerAddress.Lines = new string[0];
            this.txtCustomerAddress.Location = new System.Drawing.Point(566, 49);
            this.txtCustomerAddress.MaxLength = 32767;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.PasswordChar = '\0';
            this.txtCustomerAddress.PromptText = "Customer Address";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerAddress.SelectedText = "";
            this.txtCustomerAddress.SelectionLength = 0;
            this.txtCustomerAddress.SelectionStart = 0;
            this.txtCustomerAddress.ShortcutsEnabled = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(423, 23);
            this.txtCustomerAddress.TabIndex = 3;
            this.txtCustomerAddress.UseSelectable = true;
            this.txtCustomerAddress.WaterMark = "Customer Address";
            this.txtCustomerAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(434, 48);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Address:";
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(566, 22);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PromptText = "Customer Name / Company Name";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(423, 23);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMark = "Customer Name / Company Name";
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(434, 22);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(126, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Name of Customer:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(650, 660);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(67, 25);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "TOTAL";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGrandTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblGrandTotal.Location = new System.Drawing.Point(795, 660);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(171, 25);
            this.lblGrandTotal.TabIndex = 22;
            this.lblGrandTotal.Text = "0.00";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVAT
            // 
            // 
            // 
            // 
            this.lblVAT.CustomButton.Image = null;
            this.lblVAT.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.lblVAT.CustomButton.Name = "";
            this.lblVAT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblVAT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVAT.CustomButton.TabIndex = 1;
            this.lblVAT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVAT.CustomButton.UseSelectable = true;
            this.lblVAT.CustomButton.Visible = false;
            this.lblVAT.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.lblVAT.Lines = new string[0];
            this.lblVAT.Location = new System.Drawing.Point(845, 613);
            this.lblVAT.MaxLength = 32767;
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.PasswordChar = '\0';
            this.lblVAT.PromptText = "%";
            this.lblVAT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblVAT.SelectedText = "";
            this.lblVAT.SelectionLength = 0;
            this.lblVAT.SelectionStart = 0;
            this.lblVAT.ShortcutsEnabled = true;
            this.lblVAT.Size = new System.Drawing.Size(121, 23);
            this.lblVAT.TabIndex = 23;
            this.lblVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lblVAT.UseSelectable = true;
            this.lblVAT.WaterMark = "%";
            this.lblVAT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblVAT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.lblVAT.TextChanged += new System.EventHandler(this.lblVAT_TextChanged);
            this.lblVAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lblVAT_KeyPress);
            // 
            // txtRemarks
            // 
            // 
            // 
            // 
            this.txtRemarks.CustomButton.Image = null;
            this.txtRemarks.CustomButton.Location = new System.Drawing.Point(401, 1);
            this.txtRemarks.CustomButton.Name = "";
            this.txtRemarks.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemarks.CustomButton.TabIndex = 1;
            this.txtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemarks.CustomButton.UseSelectable = true;
            this.txtRemarks.CustomButton.Visible = false;
            this.txtRemarks.Lines = new string[0];
            this.txtRemarks.Location = new System.Drawing.Point(566, 165);
            this.txtRemarks.MaxLength = 32767;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.PromptText = "Remarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.SelectionLength = 0;
            this.txtRemarks.SelectionStart = 0;
            this.txtRemarks.ShortcutsEnabled = true;
            this.txtRemarks.Size = new System.Drawing.Size(423, 23);
            this.txtRemarks.TabIndex = 10;
            this.txtRemarks.UseSelectable = true;
            this.txtRemarks.WaterMark = "Remarks";
            this.txtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(434, 164);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(62, 19);
            this.metroLabel12.TabIndex = 17;
            this.metroLabel12.Text = "Remarks:";
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 713);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.grpCustomerInformation);
            this.Controls.Add(this.lblTopPrice);
            this.Controls.Add(this.lblFullDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblVatableSales);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dtgCart);
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.lblTransactionCode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPOS";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Buy-All Enterprises";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPOS_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCart)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblTransactionCode;
        private MetroFramework.Controls.MetroLabel lblDateNow;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile cmdClosePOS;
        private MetroFramework.Controls.MetroTile cmdTransactions;
        private MetroFramework.Controls.MetroTile cmdSettlePaymentInstallment;
        private MetroFramework.Controls.MetroTile cmdClearCart;
        private MetroFramework.Controls.MetroTile cmdSettlePayment;
        private MetroFramework.Controls.MetroTile cmdAddDiscount;
        private MetroFramework.Controls.MetroTile cmdSearchProduct;
        private MetroFramework.Controls.MetroTile cmdNewTrans;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lblSubTotal;
        private MetroFramework.Controls.MetroLabel lblDiscount;
        private MetroFramework.Controls.MetroLabel lblVatableSales;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFullDate;
        private System.Windows.Forms.Label lblTopPrice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpCustomerInformation;
        private MetroFramework.Controls.MetroTextBox txtTIN;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtSalesAgent;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtContactPerson;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtCustomerAddress;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile cmdCancelTransaction;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel lblGrandTotal;
        private MetroFramework.Controls.MetroLabel lblClientID;
        private MetroFramework.Controls.MetroButton cmdAddClient;
        private MetroFramework.Controls.MetroGrid dtgClients;
        private MetroFramework.Controls.MetroLabel lblRecordCount;
        private MetroFramework.Controls.MetroButton cmdSelect;
        public MetroFramework.Controls.MetroGrid dtgCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn btnminus;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewButtonColumn btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn instock;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn removeitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private MetroFramework.Controls.MetroTextBox lblVAT;
        private MetroFramework.Controls.MetroTextBox txtClientSearch;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtRemarks;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}