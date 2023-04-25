namespace Inventory.forms
{
    partial class frmReportDaily
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtDateSelected = new MetroFramework.Controls.MetroDateTime();
            this.cmdSearchDate = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.reports.rptDailySales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 142);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1184, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "SELECT DATE:";
            // 
            // dtDateSelected
            // 
            this.dtDateSelected.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateSelected.Location = new System.Drawing.Point(118, 92);
            this.dtDateSelected.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDateSelected.Name = "dtDateSelected";
            this.dtDateSelected.Size = new System.Drawing.Size(131, 29);
            this.dtDateSelected.TabIndex = 2;
            // 
            // cmdSearchDate
            // 
            this.cmdSearchDate.Location = new System.Drawing.Point(255, 92);
            this.cmdSearchDate.Name = "cmdSearchDate";
            this.cmdSearchDate.Size = new System.Drawing.Size(103, 29);
            this.cmdSearchDate.TabIndex = 3;
            this.cmdSearchDate.Text = "SEARCH";
            this.cmdSearchDate.UseSelectable = true;
            this.cmdSearchDate.Click += new System.EventHandler(this.cmdSearchDate_Click);
            // 
            // frmReportDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 639);
            this.Controls.Add(this.cmdSearchDate);
            this.Controls.Add(this.dtDateSelected);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportDaily";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Daily Sales Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportDaily_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtDateSelected;
        private MetroFramework.Controls.MetroButton cmdSearchDate;
    }
}