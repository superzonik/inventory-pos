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
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 1;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.reports.rptDailySales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(27, 74);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Padding = new System.Windows.Forms.Padding(0, 123, 0, 0);
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1586, 687);
            this.reportViewer1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 113);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "SELECT DATE:";
            // 
            // dtDateSelected
            // 
            this.dtDateSelected.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateSelected.Location = new System.Drawing.Point(157, 113);
            this.dtDateSelected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDateSelected.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtDateSelected.Name = "dtDateSelected";
            this.dtDateSelected.Size = new System.Drawing.Size(173, 30);
            this.dtDateSelected.TabIndex = 2;
            // 
            // cmdSearchDate
            // 
            this.cmdSearchDate.Location = new System.Drawing.Point(340, 113);
            this.cmdSearchDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSearchDate.Name = "cmdSearchDate";
            this.cmdSearchDate.Size = new System.Drawing.Size(137, 36);
            this.cmdSearchDate.TabIndex = 3;
            this.cmdSearchDate.Text = "SEARCH";
            this.cmdSearchDate.UseSelectable = true;
            this.cmdSearchDate.Click += new System.EventHandler(this.cmdSearchDate_Click);
            // 
            // frmReportDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 786);
            this.Controls.Add(this.cmdSearchDate);
            this.Controls.Add(this.dtDateSelected);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReportDaily";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Daily Sales Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportDaily_Load);
            this.SizeChanged += new System.EventHandler(this.frmReportDaily_SizeChanged);
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