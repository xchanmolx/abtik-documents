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
    public partial class frmPrintAllResponders : Form
    {
        string _date, _totalResponder;

        public frmPrintAllResponders(string date, string totalResponder)
        {
            InitializeComponent();

            _date = date;
            _totalResponder = totalResponder;
        }

        private void frmPrintAllResponders_Load(object sender, EventArgs e)
        {
            dsPrintAllResponders dsPAR = new dsPrintAllResponders();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Responders", conn);
            sda.Fill(dsPAR, dsPAR.Tables[0].TableName);
            dsPAR.Tables[0].DefaultView.Sort = "IDNumber";
            ReportDataSource rds = new ReportDataSource("dsPrintAllResponders", dsPAR.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintAllResponders.LocalReport.DataSources.Clear();
            this.reportViewerPrintAllResponders.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintAllResponders.LocalReport.Refresh();

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", _date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalResponder", _totalResponder)
            };
            this.reportViewerPrintAllResponders.LocalReport.SetParameters(para);
            this.reportViewerPrintAllResponders.RefreshReport();
        }
    }
}
