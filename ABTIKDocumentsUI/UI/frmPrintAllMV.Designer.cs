namespace ABTIKDocumentsUI.UI
{
    partial class frmPrintAllMV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintAllMV));
            this.reportViewerPrintAllMV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPrintAllMV
            // 
            this.reportViewerPrintAllMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPrintAllMV.LocalReport.ReportEmbeddedResource = "ABTIKDocumentsUI.Report.rptPrintAllMotorizedVehicle.rdlc";
            this.reportViewerPrintAllMV.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPrintAllMV.Name = "reportViewerPrintAllMV";
            this.reportViewerPrintAllMV.Size = new System.Drawing.Size(855, 441);
            this.reportViewerPrintAllMV.TabIndex = 0;
            // 
            // frmPrintAllMV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 441);
            this.Controls.Add(this.reportViewerPrintAllMV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintAllMV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print All for Motorized Vehicle";
            this.Load += new System.EventHandler(this.frmPrintAllMV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPrintAllMV;
    }
}