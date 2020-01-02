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
    public partial class frmPrintAllMV : Form
    {
        string _date;

        public frmPrintAllMV(string date)
        {
            InitializeComponent();

            _date = date;
        }

        private void frmPrintAllMV_Load(object sender, EventArgs e)
        {           
            dsPrintAllMV dsPAMV = new dsPrintAllMV();
            SqlConnection conn = new SqlConnection(UserDAL.myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Vehicle", conn);
            sda.Fill(dsPAMV, dsPAMV.Tables[0].TableName);
            dsPAMV.Tables[0].DefaultView.Sort = "vehicle_no";
            ReportDataSource rds = new ReportDataSource("dsPrintAllMV", dsPAMV.Tables[0].DefaultView.ToTable());
            this.reportViewerPrintAllMV.LocalReport.DataSources.Clear();
            this.reportViewerPrintAllMV.LocalReport.DataSources.Add(rds);
            this.reportViewerPrintAllMV.LocalReport.Refresh();

            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("pDate", _date)
            };
            this.reportViewerPrintAllMV.LocalReport.SetParameters(para);
            this.reportViewerPrintAllMV.RefreshReport();
        }
    }
}
