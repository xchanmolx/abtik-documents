using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ABTIKDocumentsUI.BLL;
using ABTIKDocumentsUI.DAL;
using ABTIKDocumentsUI.UI;

namespace ABTIKDocumentsUI
{
    public partial class PCRCustomControl : UserControl
    {
        public PCRCustomControl()
        {
            InitializeComponent();

            dgvPCR.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvPCR.EnableHeadersVisualStyles = false;
        }

        private void btnPCR_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\PRE-HOSPITAL-CARE-REPORT.xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PCR Form Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWaiver_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\WAIVER.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WAIVER Form Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        PCRBLL pcr = new PCRBLL();
        PCRDAL dal = new PCRDAL();
        int id = 1;

        private void Clear()
        {
            txtPatientNo.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            cmbBoxSex.Text = "Gender";
            txtAddress.Text = "";
            txtPlaceOfIncident.Text = "";
            txtTypeOfIncident.Text = "";
            txtDate.Text = "";
            txtChiefComplaints.Text = "";
            txtOxygen.Text = "";
            txtBloodPressure.Text = "";
            txtRespiratoryRate.Text = "";
            txtTemperature.Text = "";
            txtPulseRate.Text = "";
            txtPupil.Text = "";
            txtPastMedicalHistory.Text = "";
            txtSAMPLE.Text = "";
            txtPhysicalFindings.Text = "";
            txtTreatment.Text = "";
            txtOtherPersonsInvolved.Text = "";
            txtCallerInformation.Text = "";
            txtMaterialsUsed.Text = "";
            txtTransportedToNameOfHospitalOrResidence.Text = "";
            txtEndorsedTo.Text = "";
            txtEmergencyResponseTeam.Text = "";
            txtAmbulanceBodyNoAndPlateNo.Text = "";
            txtWAIVER.Text = "";

            txtSearch.Text = "";

            id = 1;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            errorProviderPCR.Clear();
        }

        private bool ValidateForm()
        {
            bool bStatus = true;

            if (txtPatientNo.Text == "")
            {
                errorProviderPCR.SetError(txtPatientNo, "Required Patient No.");
                bStatus = false;
            }
            else if (txtName.Text == "")
            {
                errorProviderPCR.SetError(txtName, "Required Name");
                bStatus = false;
            }
            else if (txtAge.Text == "")
            {
                errorProviderPCR.SetError(txtAge, "Required Age");
                bStatus = false;
            }
            else if (cmbBoxSex.Text == "Gender")
            {
                errorProviderPCR.SetError(cmbBoxSex, "Required Gender");
                bStatus = false;
            }
            else if (txtAddress.Text == "")
            {
                errorProviderPCR.SetError(txtAddress, "Required Address");
                bStatus = false;
            }
            else if (txtPlaceOfIncident.Text == "")
            {
                errorProviderPCR.SetError(txtPlaceOfIncident, "Required Place of Incident");
                bStatus = false;
            }
            else if (txtTypeOfIncident.Text == "")
            {
                errorProviderPCR.SetError(txtTypeOfIncident, "Required Type of Incident");
                bStatus = false;
            }
            else if (txtDate.Text == "")
            {
                errorProviderPCR.SetError(txtDate, "Required Date");
                bStatus = false;
            }

            return bStatus;
        }

        private void dgvPCR_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (DataGridViewRow row in dgvPCR.Rows)
                {
                    txtTotalIncidents.Text = String.Format("Patients: {0:N0}", row.Index + 1);
                }
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            // Get the keywords
            string keywords = txtSearch.Text;

            // Filter the items based on keywords
            if (keywords != null)
            {
                // Use search method to display items
                DataTable dt = dal.Search(keywords);
                dgvPCR.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "PatientNumber";
                DataTable sortedDT = dv.ToTable();
            }
            else
            {
                // Use select method to display all items
                DataTable dt = dal.Select();
                dgvPCR.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "PatientNumber";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderPCR.SetError(txtAge, "Please enter only numbers.");
            }
        }        

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnUpdate.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dgvPCR_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dgvPCR.Size = new Size(1140, 3);

            // Get the index of particular row
            int rowIndex = e.RowIndex;
            id = Convert.ToInt32(dgvPCR.Rows[rowIndex].Cells[0].Value.ToString());
            txtPatientNo.Text = dgvPCR.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvPCR.Rows[rowIndex].Cells[2].Value.ToString();
            txtAge.Text = dgvPCR.Rows[rowIndex].Cells[3].Value.ToString();
            cmbBoxSex.Text = dgvPCR.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvPCR.Rows[rowIndex].Cells[5].Value.ToString();
            txtPlaceOfIncident.Text = dgvPCR.Rows[rowIndex].Cells[6].Value.ToString();
            txtTypeOfIncident.Text = dgvPCR.Rows[rowIndex].Cells[7].Value.ToString();
            txtDate.Text = dgvPCR.Rows[rowIndex].Cells[8].Value.ToString();
            txtChiefComplaints.Text = dgvPCR.Rows[rowIndex].Cells[9].Value.ToString();
            txtOxygen.Text = dgvPCR.Rows[rowIndex].Cells[10].Value.ToString();
            txtBloodPressure.Text = dgvPCR.Rows[rowIndex].Cells[11].Value.ToString();
            txtRespiratoryRate.Text = dgvPCR.Rows[rowIndex].Cells[12].Value.ToString();
            txtTemperature.Text = dgvPCR.Rows[rowIndex].Cells[13].Value.ToString();
            txtPulseRate.Text = dgvPCR.Rows[rowIndex].Cells[14].Value.ToString();
            txtPupil.Text = dgvPCR.Rows[rowIndex].Cells[15].Value.ToString();
            txtPastMedicalHistory.Text = dgvPCR.Rows[rowIndex].Cells[16].Value.ToString();
            txtSAMPLE.Text = dgvPCR.Rows[rowIndex].Cells[17].Value.ToString();
            txtPhysicalFindings.Text = dgvPCR.Rows[rowIndex].Cells[18].Value.ToString();
            txtTreatment.Text = dgvPCR.Rows[rowIndex].Cells[19].Value.ToString();
            txtOtherPersonsInvolved.Text = dgvPCR.Rows[rowIndex].Cells[20].Value.ToString();
            txtCallerInformation.Text = dgvPCR.Rows[rowIndex].Cells[21].Value.ToString();
            txtMaterialsUsed.Text = dgvPCR.Rows[rowIndex].Cells[22].Value.ToString();
            txtTransportedToNameOfHospitalOrResidence.Text = dgvPCR.Rows[rowIndex].Cells[23].Value.ToString();
            txtEndorsedTo.Text = dgvPCR.Rows[rowIndex].Cells[24].Value.ToString();
            txtEmergencyResponseTeam.Text = dgvPCR.Rows[rowIndex].Cells[25].Value.ToString();
            txtAmbulanceBodyNoAndPlateNo.Text = dgvPCR.Rows[rowIndex].Cells[26].Value.ToString();
            txtWAIVER.Text = dgvPCR.Rows[rowIndex].Cells[27].Value.ToString();

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            txtPatientNo.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                int age;
                int.TryParse(txtAge.Text, out age);

                // Getting data from UI
                pcr.PatientNumber = txtPatientNo.Text;
                pcr.Name = txtName.Text;
                pcr.Age = age;
                pcr.Sex = cmbBoxSex.Text;
                pcr.Address = txtAddress.Text;
                pcr.PlaceOfIncident = txtPlaceOfIncident.Text;
                pcr.TypeOfIncident = txtTypeOfIncident.Text;
                pcr.Date = txtDate.Text;
                pcr.ChiefComplaints = txtChiefComplaints.Text;
                pcr.Oxygen = txtOxygen.Text;
                pcr.BloodPressure = txtBloodPressure.Text;
                pcr.RespiratoryRate = txtRespiratoryRate.Text;
                pcr.Temperature = txtTemperature.Text;
                pcr.PulseRate = txtPulseRate.Text;
                pcr.Pupil = txtPupil.Text;
                pcr.PastMedicalHistory = txtPastMedicalHistory.Text;
                pcr.SAMPLE = txtSAMPLE.Text;
                pcr.PhysicalFindings = txtPhysicalFindings.Text;
                pcr.Treatment = txtTreatment.Text;
                pcr.OtherPersonsInvolved = txtOtherPersonsInvolved.Text;
                pcr.CallerInformation = txtCallerInformation.Text;
                pcr.MaterialsUsed = txtMaterialsUsed.Text;
                pcr.TransportedToNameOfHospitalOrResidence = txtTransportedToNameOfHospitalOrResidence.Text;
                pcr.EndorsedTo = txtEndorsedTo.Text;
                pcr.EmergencyResponseTeam = txtEmergencyResponseTeam.Text;
                pcr.AmbulanceBodyNoAndPlateNo = txtAmbulanceBodyNoAndPlateNo.Text;
                pcr.WAIVER = txtWAIVER.Text;

                // Inserting data into Database
                bool success = dal.Insert(pcr);

                // If the data is successfully inserted then the value of success will be true else it will be false
                if (success == true)
                {
                    // Data successfully inserted
                    MessageBox.Show("PCR Information successfully saved.", "PCR Information Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    txtPatientNo.Focus();
                }
                else
                {
                    // Failed to insert data
                    MessageBox.Show("Failed to add new pcr information.", "PCR Information Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Refreshing Data Grid View
                DataTable dt = dal.Select();
                dgvPCR.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "PatientNumber";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Getting User ID from Form
            pcr.ID = id;

            if (DialogResult.Yes == MessageBox.Show("Are you sure want to delete?", "Delete Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bool success = dal.Delete(pcr);
                success = true;
                Clear();
                txtSearch.Focus();
            }
            else
            {
                Clear();
            }

            // Refresing Data Grid View
            DataTable dt = dal.Select();
            dgvPCR.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "PatientNumber";
            DataTable sortedDT = dv.ToTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the values from User UI
            pcr.ID = id;
            pcr.PatientNumber = txtPatientNo.Text;
            pcr.Name = txtName.Text;
            pcr.Age = Convert.ToInt32(txtAge.Text);
            pcr.Sex = cmbBoxSex.Text;
            pcr.Address = txtAddress.Text;
            pcr.PlaceOfIncident = txtPlaceOfIncident.Text;
            pcr.TypeOfIncident = txtTypeOfIncident.Text;
            pcr.Date = txtDate.Text;
            pcr.ChiefComplaints = txtChiefComplaints.Text;
            pcr.Oxygen = txtOxygen.Text;
            pcr.BloodPressure = txtBloodPressure.Text;
            pcr.RespiratoryRate = txtRespiratoryRate.Text;
            pcr.Temperature = txtTemperature.Text;
            pcr.PulseRate = txtPulseRate.Text;
            pcr.Pupil = txtPupil.Text;
            pcr.PastMedicalHistory = txtPastMedicalHistory.Text;
            pcr.SAMPLE = txtSAMPLE.Text;
            pcr.PhysicalFindings = txtPhysicalFindings.Text;
            pcr.Treatment = txtTreatment.Text;
            pcr.OtherPersonsInvolved = txtOtherPersonsInvolved.Text;
            pcr.CallerInformation = txtCallerInformation.Text;
            pcr.MaterialsUsed = txtMaterialsUsed.Text;
            pcr.TransportedToNameOfHospitalOrResidence = txtTransportedToNameOfHospitalOrResidence.Text;
            pcr.EndorsedTo = txtEndorsedTo.Text;
            pcr.EmergencyResponseTeam = txtEmergencyResponseTeam.Text;
            pcr.AmbulanceBodyNoAndPlateNo = txtAmbulanceBodyNoAndPlateNo.Text;
            pcr.WAIVER = txtWAIVER.Text;

            // Updating data into Database
            bool success = dal.Update(pcr);

            // If data is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                // Data updated successfully 
                MessageBox.Show("PCR Information successfully updated!", "Update Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtSearch.Focus();
            }
            else
            {
                // Failed to update user 
                MessageBox.Show("Failed to update PCR Information!", "Update Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvPCR.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "PatientNumber";
            DataTable sortedDT = dv.ToTable();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddPCRInformation_Click(object sender, EventArgs e)
        {
            this.dgvPCR.Size = new Size(1139, 3);

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtPatientNo.Focus();

            Clear();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.dgvPCR.Size = new Size(1139, 425);

            Clear();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            errorProviderPCR.Clear();
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrintAllPCR frm = new frmPrintAllPCR(DateTime.Now.ToString("dddd, MMMM dd, yyyy"), string.Format("{0}", txtTotalIncidents.Text));

                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print All PCR Information!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrintEach_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrintEachPCR frm = new frmPrintEachPCR(DateTime.Now.ToString("dddd, MMMM dd, yyyy"), string.Format("{0}", txtDate.Text), string.Format("{0}", txtPatientNo.Text), string.Format("{0}", txtPlaceOfIncident.Text), string.Format("{0}", txtName.Text), string.Format("{0}", txtAge.Text), string.Format("{0}", cmbBoxSex.Text), string.Format("{0}", txtAddress.Text), string.Format("{0}", txtTypeOfIncident.Text), string.Format("{0}", txtChiefComplaints.Text), string.Format("{0}", txtPastMedicalHistory.Text), string.Format("{0}", txtSAMPLE.Text), string.Format("{0}", txtOxygen.Text), string.Format("{0}", txtBloodPressure.Text), string.Format("{0}", txtRespiratoryRate.Text), string.Format("{0}", txtTemperature.Text), string.Format("{0}", txtPulseRate.Text), string.Format("{0}", txtPupil.Text), string.Format("{0}", txtPhysicalFindings.Text), string.Format("{0}", txtOtherPersonsInvolved.Text), string.Format("{0}", txtCallerInformation.Text), string.Format("{0}", txtTreatment.Text), string.Format("{0}", txtMaterialsUsed.Text), string.Format("{0}", txtTransportedToNameOfHospitalOrResidence.Text), string.Format("{0}", txtEndorsedTo.Text), string.Format("{0}", txtEmergencyResponseTeam.Text), string.Format("{0}", txtAmbulanceBodyNoAndPlateNo.Text));

                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print Each PCR Information!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
