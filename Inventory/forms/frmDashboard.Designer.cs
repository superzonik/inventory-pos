namespace Inventory.forms
{
    partial class frmDashboard
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
            this.tilePOS = new MetroFramework.Controls.MetroTile();
            this.tileInventory = new MetroFramework.Controls.MetroTile();
            this.tileDelivery = new MetroFramework.Controls.MetroTile();
            this.tileCollectibles = new MetroFramework.Controls.MetroTile();
            this.tileReports = new MetroFramework.Controls.MetroTile();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tilePOS
            // 
            this.tilePOS.ActiveControl = null;
            this.tilePOS.Location = new System.Drawing.Point(178, 145);
            this.tilePOS.Name = "tilePOS";
            this.tilePOS.Size = new System.Drawing.Size(130, 95);
            this.tilePOS.Style = MetroFramework.MetroColorStyle.Red;
            this.tilePOS.TabIndex = 1;
            this.tilePOS.Text = "POS";
            this.tilePOS.UseSelectable = true;
            this.tilePOS.Click += new System.EventHandler(this.tilePOS_Click);
            // 
            // tileInventory
            // 
            this.tileInventory.ActiveControl = null;
            this.tileInventory.Location = new System.Drawing.Point(42, 145);
            this.tileInventory.Name = "tileInventory";
            this.tileInventory.Size = new System.Drawing.Size(130, 95);
            this.tileInventory.Style = MetroFramework.MetroColorStyle.Red;
            this.tileInventory.TabIndex = 0;
            this.tileInventory.Text = "Product Inventory";
            this.tileInventory.UseSelectable = true;
            this.tileInventory.Click += new System.EventHandler(this.tileInventory_Click);
            // 
            // tileDelivery
            // 
            this.tileDelivery.ActiveControl = null;
            this.tileDelivery.Location = new System.Drawing.Point(314, 145);
            this.tileDelivery.Name = "tileDelivery";
            this.tileDelivery.Size = new System.Drawing.Size(130, 95);
            this.tileDelivery.Style = MetroFramework.MetroColorStyle.Red;
            this.tileDelivery.TabIndex = 2;
            this.tileDelivery.Text = "Delivery";
            this.tileDelivery.UseSelectable = true;
            this.tileDelivery.Click += new System.EventHandler(this.tileDelivery_Click);
            // 
            // tileCollectibles
            // 
            this.tileCollectibles.ActiveControl = null;
            this.tileCollectibles.Location = new System.Drawing.Point(450, 145);
            this.tileCollectibles.Name = "tileCollectibles";
            this.tileCollectibles.Size = new System.Drawing.Size(130, 95);
            this.tileCollectibles.Style = MetroFramework.MetroColorStyle.Red;
            this.tileCollectibles.TabIndex = 3;
            this.tileCollectibles.Text = "Collectibles";
            this.tileCollectibles.UseSelectable = true;
            this.tileCollectibles.Click += new System.EventHandler(this.tileCollectibles_Click);
            // 
            // tileReports
            // 
            this.tileReports.ActiveControl = null;
            this.tileReports.Location = new System.Drawing.Point(586, 145);
            this.tileReports.Name = "tileReports";
            this.tileReports.Size = new System.Drawing.Size(130, 95);
            this.tileReports.Style = MetroFramework.MetroColorStyle.Red;
            this.tileReports.TabIndex = 4;
            this.tileReports.Text = "Reports";
            this.tileReports.UseSelectable = true;
            this.tileReports.Click += new System.EventHandler(this.tileReports_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "L&ogout";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductNameToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // addNewProductNameToolStripMenuItem
            // 
            this.addNewProductNameToolStripMenuItem.Name = "addNewProductNameToolStripMenuItem";
            this.addNewProductNameToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.addNewProductNameToolStripMenuItem.Text = "&Add New Product Name...";
            this.addNewProductNameToolStripMenuItem.Click += new System.EventHandler(this.addNewProductNameToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.tileReports);
            this.Controls.Add(this.tileCollectibles);
            this.Controls.Add(this.tileDelivery);
            this.Controls.Add(this.tileInventory);
            this.Controls.Add(this.tilePOS);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDashboard";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tilePOS;
        private MetroFramework.Controls.MetroTile tileInventory;
        private MetroFramework.Controls.MetroTile tileDelivery;
        private MetroFramework.Controls.MetroTile tileCollectibles;
        private MetroFramework.Controls.MetroTile tileReports;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductNameToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}