using ABTIKDocumentsUI.DAL;
using ABTIKDocumentsUI.DataSet;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABTIKDocumentsUI.UI
{
    public partial class frmPrintAllPCR : Form
    {
        string _date, _totalPatients;

        public frmPrintAllPCR(string date, string totalPatients)
        {
            InitializeComponent();

            _date = date;
            _totalPatients = totalPatients;
        }

        private void frmPrintAllPCR_Load(object sender, EventArgs e)
        {
            dsPrintAllPCR dsPAPCR = new dsPrintAllPCR();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_PCR", conn);
            sda.Fill(dsPAPCR, dsPAPCR.Tables[0].TableName);
            dsPAPCR.Tables[0].DefaultView.Sort = "PatientNumber";
            ReportDataSource rds = new ReportDataSource("dsPrintAllPCR", dsPAPCR.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintAllPCR.LocalReport.DataSources.Clear();
            this.reportViewerPrintAllPCR.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintAllPCR.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalPatients", _totalPatients)
            };
            this.reportViewerPrintAllPCR.LocalReport.SetParameters(para);
            this.reportViewerPrintAllPCR.RefreshReport();
        }
    }
}
