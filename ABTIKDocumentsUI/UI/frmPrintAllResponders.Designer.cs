namespace ABTIKDocumentsUI.UI
{
    partial class frmPrintAllResponders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintAllResponders));
            this.reportViewerPrintAllResponders = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintAllResponders
            // 
            this.reportViewerPrintAllResponders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintAllResponders.LocalReport.ReportEmbeddedResource = "ABTIKDocumentsUI.Report.rptPrintAllResponders.rdlc";
            this.reportViewerPrintAllResponders.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintAllResponders.Name = "reportViewerPrintAllResponders";
            this.reportViewerPrintAllResponders.Size = new System.Drawing.Size(1251, 512);
            this.reportViewerPrintAllResponders.TabIndex = 0;
            // 
            // frmPrintAllResponders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 512);
            this.Controls.Add(this.reportViewerPrintAllResponders);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrintAllResponders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print All for Responders";
            this.Load += new System.EventHandler(this.frmPrintAllResponders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintAllResponders;
    }
}