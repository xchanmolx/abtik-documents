using ABTIKDocumentsUI.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABTIKDocumentsUI
{
    public partial class frmMainABTIKDocuments : Form
    {
        int panelWidth;
        bool Hidden;

        public frmMainABTIKDocuments()
        {
            InitializeComponent();
            panelWidth = panelSlider.Width;
            Hidden = false;

            panelSide.Height = btnHome.Height;
            panelSide.Top = btnHome.Top;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerSlider.Start();
        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelSlider.Width = panelSlider.Width - 10;
                if (panelSlider.Width <= panelWidth)
                {
                    timerSlider.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlider.Width = panelSlider.Width + 10;
                if (panelSlider.Width >= 218)
                {
                    timerSlider.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void frmMainABTIKDocuments_Load(object sender, EventArgs e)
        {
            homeCustomControl1.BringToFront();

            txtDateTime.Text = DateTime.Now.ToString("ddddd, MMMM dd, yyyy");
        }

        #region Menu Buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnHome.Height;
            panelSide.Top = btnHome.Top;
            homeCustomControl1.BringToFront();
        }

        private void FillPCRDatagridview()
        {
            PCRDAL dal = new PCRDAL();

            // View the data from datagridview
            DataTable dt = dal.Select();
            pcrCustomControl1.dgvPCR.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "PatientNumber";
            DataTable sortedDT = dv.ToTable();

            pcrCustomControl1.dgvPCR.Columns[0].Visible = false;
            pcrCustomControl1.cmbBoxSex.SelectedIndex = 0;

            // Change Header Name of datagridview
            pcrCustomControl1.dgvPCR.Columns[1].HeaderText = "Patient #";
            pcrCustomControl1.dgvPCR.Columns[6].HeaderText = "Place of Incident";
            pcrCustomControl1.dgvPCR.Columns[7].HeaderText = "Type of Incident";
            pcrCustomControl1.dgvPCR.Columns[9].HeaderText = "Chief Complaints";
            pcrCustomControl1.dgvPCR.Columns[11].HeaderText = "Blood Pressure";
            pcrCustomControl1.dgvPCR.Columns[12].HeaderText = "Respiratory Rate";
            pcrCustomControl1.dgvPCR.Columns[14].HeaderText = "Pulse Rate";
            pcrCustomControl1.dgvPCR.Columns[16].HeaderText = "Past Medical History";
            pcrCustomControl1.dgvPCR.Columns[18].HeaderText = "Physical Findings";
            pcrCustomControl1.dgvPCR.Columns[20].HeaderText = "Other Persons Involved";
            pcrCustomControl1.dgvPCR.Columns[21].HeaderText = "Caller Information";
            pcrCustomControl1.dgvPCR.Columns[22].HeaderText = "Materials Used";
            pcrCustomControl1.dgvPCR.Columns[23].HeaderText = "Transported To (Name of Hospital or Residence)";
            pcrCustomControl1.dgvPCR.Columns[24].HeaderText = "Endorsed To";
            pcrCustomControl1.dgvPCR.Columns[25].HeaderText = "Emergency Response Team";
            pcrCustomControl1.dgvPCR.Columns[26].HeaderText = "Ambulance Body No. or Plate No.";
        }

        private void btnPCR_Click(object sender, EventArgs e)
        {           
            panelSide.Height = btnPCR.Height;
            panelSide.Top = btnPCR.Top;
            pcrCustomControl1.BringToFront();

            FillPCRDatagridview();
        }

        private void btnAngilan_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnMDRRMOEquipment.Height;
            panelSide.Top = btnMDRRMOEquipment.Top;
            angilanCustomControl1.BringToFront();
        }

        private void btnBojo_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnEvacuation.Height;
            panelSide.Top = btnEvacuation.Top;
            bojoCustomControl1.BringToFront();
        }        

        private void FillRespondersDatagridview()
        {
            RespondersDAL dal = new RespondersDAL();

            // View the data from datagridview
            DataTable dt = dal.Select();
            respondersCustomControl1.dgvResponders.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "IDNumber";
            DataTable sortedDT = dv.ToTable();

            respondersCustomControl1.dgvResponders.Columns[0].Visible = false;
            respondersCustomControl1.dgvResponders.Columns[12].Visible = false;

            // Change Header Name of datagridview
            respondersCustomControl1.dgvResponders.Columns[1].HeaderText = "ID Number";
            respondersCustomControl1.dgvResponders.Columns[10].HeaderText = "Birthdate (yyyy-MM-dd)";
        }

        private void btnResponders_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnResponders.Height;
            panelSide.Top = btnResponders.Top;
            respondersCustomControl1.BringToFront();

            FillRespondersDatagridview();
        }

        private void btnEsperanza_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnEsperanza.Height;
            panelSide.Top = btnEsperanza.Top;
            esperanzaCustomControl1.BringToFront();
        }

        private void btnKandingan_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnKandingan.Height;
            panelSide.Top = btnKandingan.Top;
            kandinganCustomControl1.BringToFront();
        }

        private void btnKantabogon_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnKantabogon.Height;
            panelSide.Top = btnKantabogon.Top;
            kantabogonCustomControl1.BringToFront();
        }

        private void btnKawasan_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnKawasan.Height;
            panelSide.Top = btnKawasan.Top;
            kawasanCustomControl1.BringToFront();
        }

        private void btnOlango_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnOlango.Height;
            panelSide.Top = btnOlango.Top;
            olangoCustomControl1.BringToFront();
        }

        private void btnPoblacion_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnPoblacion.Height;
            panelSide.Top = btnPoblacion.Top;
            poblacionCustomControl1.BringToFront();
        }

        private void btnPunay_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnPunay.Height;
            panelSide.Top = btnPunay.Top;
            punayCustomControl1.BringToFront();
        }

        private void btnRosario_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnRosario.Height;
            panelSide.Top = btnRosario.Top;
            rosarioCustomControl1.BringToFront();
        }

        private void btnSaksak_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnSaksak.Height;
            panelSide.Top = btnSaksak.Top;
            saksakCustomControl1.BringToFront();
        }

        private void btnTampaan_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnTampaan.Height;
            panelSide.Top = btnTampaan.Top;
            tampaanCustomControl1.BringToFront();
        }

        private void btnTuyokon_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnTuyokon.Height;
            panelSide.Top = btnTuyokon.Top;
            tuyokonCustomControl1.BringToFront();
        }

        private void btnZaragosa_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnZaragosa.Height;
            panelSide.Top = btnZaragosa.Top;
            zaragosaCustomControl1.BringToFront();
        }
        #endregion

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure want to exit?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                timerShutdown.Start();
            }
        }

        private void timerShutdown_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.3;
            }
            else
            {
                timerShutdown.Stop();
                Application.Exit();
            }
        }        
    }
}
