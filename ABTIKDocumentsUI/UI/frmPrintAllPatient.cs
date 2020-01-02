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
    public partial class frmPrintAllPatient : Form
    {
        string _totalPatient, _date;

        public frmPrintAllPatient(string totalPatient, string date)
        {
            InitializeComponent();

            _totalPatient = totalPatient;
            _date = date;
        }

        private void frmPrintAllPatient_Load(object sender, EventArgs e)
        {
            dsPrintAllPatient dsPAP = new dsPrintAllPatient();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_PCR", conn);
            sda.Fill(dsPAP, dsPAP.Tables[0].TableName);
            dsPAP.Tables[0].DefaultView.Sort = "PatientNumber";
            ReportDataSource rds = new ReportDataSource("dsPrintAllPatient", dsPAP.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintAllPatient.LocalReport.DataSources.Clear();
            this.reportViewerPrintAllPatient.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintAllPatient.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalPatient", _totalPatient),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date)
            };
            this.reportViewerPrintAllPatient.LocalReport.SetParameters(para);
            this.reportViewerPrintAllPatient.RefreshReport();
        }
    }
}
