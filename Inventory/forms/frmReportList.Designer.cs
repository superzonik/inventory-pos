namespace Inventory.forms
{
    partial class frmReportList
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
            this.cmdDailySales = new MetroFramework.Controls.MetroTile();
            this.cmdWeeklySales = new MetroFramework.Controls.MetroTile();
            this.cmdMonthlySales = new MetroFramework.Controls.MetroTile();
            this.cmdAnnualSales = new MetroFramework.Controls.MetroTile();
            this.cmExit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmdDailySales
            // 
            this.cmdDailySales.ActiveControl = null;
            this.cmdDailySales.Location = new System.Drawing.Point(5, 63);
            this.cmdDailySales.Name = "cmdDailySales";
            this.cmdDailySales.Size = new System.Drawing.Size(342, 51);
            this.cmdDailySales.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdDailySales.TabIndex = 0;
            this.cmdDailySales.Text = "DAILY SALES";
            this.cmdDailySales.UseSelectable = true;
            this.cmdDailySales.Click += new System.EventHandler(this.cmdDailySales_Click);
            // 
            // cmdWeeklySales
            // 
            this.cmdWeeklySales.ActiveControl = null;
            this.cmdWeeklySales.Location = new System.Drawing.Point(5, 115);
            this.cmdWeeklySales.Name = "cmdWeeklySales";
            this.cmdWeeklySales.Size = new System.Drawing.Size(342, 51);
            this.cmdWeeklySales.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdWeeklySales.TabIndex = 1;
            this.cmdWeeklySales.Text = "WEEKLY SALES";
            this.cmdWeeklySales.UseSelectable = true;
            // 
            // cmdMonthlySales
            // 
            this.cmdMonthlySales.ActiveControl = null;
            this.cmdMonthlySales.Location = new System.Drawing.Point(5, 167);
            this.cmdMonthlySales.Name = "cmdMonthlySales";
            this.cmdMonthlySales.Size = new System.Drawing.Size(342, 51);
            this.cmdMonthlySales.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdMonthlySales.TabIndex = 2;
            this.cmdMonthlySales.Text = "MONTHLY SALES";
            this.cmdMonthlySales.UseSelectable = true;
            // 
            // cmdAnnualSales
            // 
            this.cmdAnnualSales.ActiveControl = null;
            this.cmdAnnualSales.Location = new System.Drawing.Point(5, 219);
            this.cmdAnnualSales.Name = "cmdAnnualSales";
            this.cmdAnnualSales.Size = new System.Drawing.Size(342, 51);
            this.cmdAnnualSales.Style = MetroFramework.MetroColorStyle.Red;
            this.cmdAnnualSales.TabIndex = 3;
            this.cmdAnnualSales.Text = "ANNUAL SALES";
            this.cmdAnnualSales.UseSelectable = true;
            // 
            // cmExit
            // 
            this.cmExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmExit.Location = new System.Drawing.Point(266, 278);
            this.cmExit.Name = "cmExit";
            this.cmExit.Size = new System.Drawing.Size(81, 52);
            this.cmExit.TabIndex = 4;
            this.cmExit.Text = "E&XIT";
            this.cmExit.UseSelectable = true;
            this.cmExit.Click += new System.EventHandler(this.cmExit_Click);
            // 
            // frmReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(352, 353);
            this.Controls.Add(this.cmExit);
            this.Controls.Add(this.cmdAnnualSales);
            this.Controls.Add(this.cmdMonthlySales);
            this.Controls.Add(this.cmdWeeklySales);
            this.Controls.Add(this.cmdDailySales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportList";
            this.Padding = new System.Windows.Forms.Padding(2, 60, 2, 20);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile cmdDailySales;
        private MetroFramework.Controls.MetroTile cmdWeeklySales;
        private MetroFramework.Controls.MetroTile cmdMonthlySales;
        private MetroFramework.Controls.MetroTile cmdAnnualSales;
        private MetroFramework.Controls.MetroButton cmExit;
    }
}