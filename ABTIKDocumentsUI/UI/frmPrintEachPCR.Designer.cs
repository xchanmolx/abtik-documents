namespace ABTIKDocumentsUI.UI
{
    partial class frmPrintEachPCR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintEachPCR));
            this.reportViewerPrintEachPCR = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintEachPCR
            // 
            this.reportViewerPrintEachPCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintEachPCR.LocalReport.ReportEmbeddedResource = "ABTIKDocumentsUI.Report.rptPrintEachPCR.rdlc";
            this.reportViewerPrintEachPCR.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintEachPCR.Name = "reportViewerPrintEachPCR";
            this.reportViewerPrintEachPCR.Size = new System.Drawing.Size(855, 441);
            this.reportViewerPrintEachPCR.TabIndex = 0;
            // 
            // frmPrintEachPCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 441);
            this.Controls.Add(this.reportViewerPrintEachPCR);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintEachPCR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Each for Pre-Hospital Care Report";
            this.Load += new System.EventHandler(this.frmPrintEachPCR_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintEachPCR;
    }
}