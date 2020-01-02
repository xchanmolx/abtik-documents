namespace ABTIKDocumentsUI.UI
{
    partial class frmPrintAllPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintAllPatient));
            this.reportViewerPrintAllPatient = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintAllPatient
            // 
            this.reportViewerPrintAllPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintAllPatient.LocalReport.ReportEmbeddedResource = "ABTIKDocumentsUI.Report.rptPrintAllPatient.rdlc";
            this.reportViewerPrintAllPatient.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintAllPatient.Name = "reportViewerPrintAllPatient";
            this.reportViewerPrintAllPatient.Size = new System.Drawing.Size(1251, 512);
            this.reportViewerPrintAllPatient.TabIndex = 0;
            // 
            // frmPrintAllPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1251, 512);
            this.Controls.Add(this.reportViewerPrintAllPatient);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrintAllPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print All Patient";
            this.Load += new System.EventHandler(this.frmPrintAllPatient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintAllPatient;
    }
}