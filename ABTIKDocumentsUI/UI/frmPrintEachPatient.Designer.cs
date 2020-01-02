namespace ABTIKDocumentsUI.UI
{
    partial class frmPrintEachPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintEachPatient));
            this.reportViewerPrintEachPatient = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintEachPatient
            // 
            this.reportViewerPrintEachPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintEachPatient.LocalReport.ReportEmbeddedResource = "ABTIKDocumentsUI.Report.rptPrintEachPatient.rdlc";
            this.reportViewerPrintEachPatient.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintEachPatient.Name = "reportViewerPrintEachPatient";
            this.reportViewerPrintEachPatient.Size = new System.Drawing.Size(807, 521);
            this.reportViewerPrintEachPatient.TabIndex = 0;
            // 
            // frmPrintEachPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 521);
            this.Controls.Add(this.reportViewerPrintEachPatient);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrintEachPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Each Patient";
            this.Load += new System.EventHandler(this.frmPrintEachPatient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintEachPatient;
    }
}