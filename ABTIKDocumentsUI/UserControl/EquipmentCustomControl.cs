using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABTIKDocumentsUI.DAL;
using ABTIKDocumentsUI.BLL;
using ABTIKDocumentsUI.UI;

namespace ABTIKDocumentsUI
{
    public partial class EquipmentCustomControl : UserControl
    {
        public EquipmentCustomControl()
        {
            InitializeComponent();

            dgvMotorizedVehicle.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvMotorizedVehicle.EnableHeadersVisualStyles = false;

            dgvGeneratorSet.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvGeneratorSet.EnableHeadersVisualStyles = false;

            cmbBoxEquipment.SelectedIndex = 0;
        }

        private void FillMotorizedVehicleDatagridview()
        {
            VehicleDAL vehicleDAL = new VehicleDAL();

            // View the data from datagridview
            DataTable dt = vehicleDAL.Select();
            dgvMotorizedVehicle.DataSource = dt;

            // Sort
            DataView dv = dt.DefaultView;
            dv.Sort = "vehicle_no";
            DataTable sortedDT = dv.ToTable();

            // Change Header Name of datagridview
            dgvMotorizedVehicle.Columns[0].HeaderText = "id #";
            dgvMotorizedVehicle.Columns[1].HeaderText = "Motorized Vehicle";

            // Total items id to id number
            txtIdMV.Text = txtTotalItemsMV.Text;

            // Bring to front groupbox
            groupBoxMotorizedVehicle.BringToFront();
        }

        private void FillGeneratorSetDatagridview()
        {
            GenSetDAL genSetDAL = new GenSetDAL();

            // View the data from datagridview
            DataTable dt = genSetDAL.Select();
            dgvGeneratorSet.DataSource = dt;

            // Sort
            DataView dv = dt.DefaultView;
            dv.Sort = "genset_no";
            DataTable sortedDT = dv.ToTable();

            // Change Header Name of datagridview
            dgvGeneratorSet.Columns[0].HeaderText = "id #";
            dgvGeneratorSet.Columns[1].HeaderText = "Generator Set";

            // Total items id to id number
            txtIdGenSet.Text = txtTotalItemsGenSet.Text;

            // Bring to front groupbox
            groupBoxGeneratorSet.BringToFront();
        }

        int rowNumMV;
        private void dgvMotorizedVehicle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (DataGridViewRow row in dgvMotorizedVehicle.Rows)
                {
                    txtTotalItemsMV.Text = String.Format("{0}", row.Index + 1);

                    int.TryParse(txtIdMV.Text, out rowNumMV);
                    rowNumMV = row.Index + 2;                    
                }
            }            
        }

        int rowNumGS;
        private void dgvGeneratorSet_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (DataGridViewRow row in dgvGeneratorSet.Rows)
                {
                    txtTotalItemsGenSet.Text = String.Format("{0}", row.Index + 1);

                    int.TryParse(txtIdGenSet.Text, out rowNumGS);
                    rowNumGS = row.Index + 2;
                }
            }
        }

        private void cmbBoxEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxEquipment.SelectedIndex == 0) // Equipment
            {
                pictureBoxEquipment.BringToFront();
            }
            else if (cmbBoxEquipment.SelectedIndex == 1) // Motorized Vehicle
            {
                FillMotorizedVehicleDatagridview();                
            }
            else if (cmbBoxEquipment.SelectedIndex == 2) // Generator Set
            {
                FillGeneratorSetDatagridview();
            }
            else if (cmbBoxEquipment.SelectedIndex == 3) // Water Rescue Kit
            {

            }
            else if (cmbBoxEquipment.SelectedIndex == 4) // Extrication Kit
            {

            }
            else if (cmbBoxEquipment.SelectedIndex == 5) // Personal Protective Gear
            {

            }
            else if (cmbBoxEquipment.SelectedIndex == 6) // First Aid Kit & EMK
            {

            }
            else if (cmbBoxEquipment.SelectedIndex == 7) // Others
            {

            }
            else if (cmbBoxEquipment.SelectedIndex == 8) // Join All Equipment
            {

            }
        }        

        private void txtSearchMV_OnValueChanged(object sender, EventArgs e)
        {
            // Get the keywords
            string keywords = txtSearchMV.Text;

            // Filter the items based on keywords
            if (keywords != null)
            {
                // Use search method to display items
                DataTable dt = vehicleDAL.Search(keywords);
                dgvMotorizedVehicle.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "vehicle_no";
                DataTable sortedDT = dv.ToTable();
            }
            else
            {
                // Use select method to display all items
                DataTable dt = vehicleDAL.Select();
                dgvMotorizedVehicle.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "vehicle_no";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void txtSearchMV_Enter(object sender, EventArgs e)
        {
            this.dgvMotorizedVehicle.Size = new Size(1117, 390);

            ClearMV();
        }

        MotorizedVehicleBLL vehicleBLL = new MotorizedVehicleBLL();
        VehicleDAL vehicleDAL = new VehicleDAL();
        GenSetBLL genSetBLL = new GenSetBLL();
        GenSetDAL genSetDAL = new GenSetDAL();
        WaterRescueKitBLL waterRescueBLL = new WaterRescueKitBLL();
        WaterRescueKitDAL waterRescueDAL = new WaterRescueKitDAL();
        ExtricationKitBLL extricationBLL = new ExtricationKitBLL();
        ExtricationKitDAL extricationDAL = new ExtricationKitDAL();
        PPEBLL ppeBLL = new PPEBLL();
        PPEDAL ppeDAL = new PPEDAL();
        FirstAidKitBLL firstAidKitBLL = new FirstAidKitBLL();
        FirstAidKitDAL firstAidKitDAL = new FirstAidKitDAL();
        OthersBLL othersBLL = new OthersBLL();
        OthersDAL othersDAL = new OthersDAL();
        EquipmentBLL equipmentBLL = new EquipmentBLL();
        EquipmentDAL equipmentDAL = new EquipmentDAL();
        private void btnSaveMV_Click(object sender, EventArgs e)
        {
            if (ValidateFormMV())
            {
                int id;
                int.TryParse(txtIdMV.Text, out id);

                // Getting data from UI
                vehicleBLL.ID = id;
                vehicleBLL.MotorizedVehicle = txtNameMV.Text;
                vehicleBLL.Unit = txtUnitMV.Text;

                genSetBLL.ID = id;
                genSetBLL.Generator_Set = "";
                genSetBLL.Unit = "";

                waterRescueBLL.ID = id;
                waterRescueBLL.WaterRescueKit = "";
                waterRescueBLL.Unit = "";

                extricationBLL.ID = id;
                extricationBLL.ExtricationKit = "";
                extricationBLL.Unit = "";

                ppeBLL.ID = id;
                ppeBLL.PersonalProtectiveGear = "";
                ppeBLL.Unit = "";

                firstAidKitBLL.ID = id;
                firstAidKitBLL.MedicalKit = "";
                firstAidKitBLL.Unit = "";

                othersBLL.ID = id;
                othersBLL.Others = "";
                othersBLL.Unit = "";

                equipmentBLL.Vehicle_no = id;
                equipmentBLL.Genset_no = id;
                equipmentBLL.WaterRescue_no = id;
                equipmentBLL.Extrication_no = id;
                equipmentBLL.PPE_no = id;
                equipmentBLL.FirstAid_no = id;
                equipmentBLL.Others_no = id;

                // Inserting data into Database
                bool success = vehicleDAL.Insert(vehicleBLL);
                genSetDAL.Insert(genSetBLL);
                waterRescueDAL.Insert(waterRescueBLL);
                extricationDAL.Insert(extricationBLL);
                ppeDAL.Insert(ppeBLL);
                firstAidKitDAL.Insert(firstAidKitBLL);
                othersDAL.Insert(othersBLL);
                equipmentDAL.Insert(equipmentBLL);

                // If the data is successfully inserted then the value of success will be true else it will be false
                if (success == true)
                {
                    // Data successfully inserted
                    MessageBox.Show("Motorized Vehicle Information successfully saved.", "Motorized Vehicle Information Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearMV();
                    txtNameMV.Focus();
                }
                else
                {
                    // Failed to insert data
                    MessageBox.Show("Failed to add new motorized vehicle information.", "Motorized Vehicle Information Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Refreshing Data Grid View
                DataTable dt = vehicleDAL.Select();
                dgvMotorizedVehicle.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "vehicle_no";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void btnDeleteMV_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(txtIdMV.Text, out id);

            // Getting User ID from Form
            vehicleBLL.ID = id;

            if (DialogResult.Yes == MessageBox.Show("Are you sure want to delete?", "Delete Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bool success = vehicleDAL.Delete(vehicleBLL);
                success = true;
                ClearMV();
                txtSearchMV.Focus();
            }
            else
            {
                txtSearchMV.Focus();
            }

            // Refresing Data Grid View
            DataTable dt = vehicleDAL.Select();
            dgvMotorizedVehicle.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "vehicle_no";
            DataTable sortedDT = dv.ToTable();
        }

        private void btnUpdateMV_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(txtIdMV.Text, out id);

            // Get the values from User UI
            vehicleBLL.ID = id;
            vehicleBLL.MotorizedVehicle = txtNameMV.Text;
            vehicleBLL.Unit = txtUnitMV.Text;
            

            // Updating data into Database
            bool success = vehicleDAL.Update(vehicleBLL);

            // If data is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                // Data updated successfully 
                MessageBox.Show("Motorized Vehicle Information successfully updated!", "Update Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearMV();
                txtSearchMV.Focus();
            }
            else
            {
                // Failed to update user 
                MessageBox.Show("Failed to update Motorized Vehicle Information!", "Update Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refreshing Data Grid View
            DataTable dt = vehicleDAL.Select();
            dgvMotorizedVehicle.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "vehicle_no";
            DataTable sortedDT = dv.ToTable();
        }        

        private void btnClearMV_Click(object sender, EventArgs e)
        {
            ClearMV();
        }

        private void dgvMotorizedVehicle_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dgvMotorizedVehicle.Size = new Size(1117, 3);

            // Get the index of particular row
            int rowIndex = e.RowIndex;
            txtIdMV.Text = dgvMotorizedVehicle.Rows[rowIndex].Cells[0].Value.ToString();
            txtNameMV.Text = dgvMotorizedVehicle.Rows[rowIndex].Cells[1].Value.ToString();
            txtUnitMV.Text = dgvMotorizedVehicle.Rows[rowIndex].Cells[2].Value.ToString();

            btnUpdateMV.Enabled = true;
            btnDeleteMV.Enabled = true;
            btnSaveMV.Enabled = false;

            txtNameMV.Focus();
        }

        private void btnAddMV_Click(object sender, EventArgs e)
        {
            this.dgvMotorizedVehicle.Size = new Size(1117, 3);

            btnSaveMV.Enabled = true;
            btnUpdateMV.Enabled = false;
            btnDeleteMV.Enabled = false;

            txtNameMV.Focus();

            ClearMV();

            // Total items id to id number
            txtIdMV.Text = Convert.ToString(rowNumMV);
        }

        private void btnPrintAllMV_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrintAllMV frm = new frmPrintAllMV(DateTime.Now.ToString("dddd, MMMM dd, yyyy"));

                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print All Motorized Vehicle Information!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateFormMV()
        {
            bool bStatus = true;

            if (txtNameMV.Text == "")
            {
                errorProviderEquipment.SetError(txtNameMV, "Required Name");
                bStatus = false;
            }
            else if (txtUnitMV.Text == "")
            {
                errorProviderEquipment.SetError(txtUnitMV, "Required Unit");
                bStatus = false;
            }

            return bStatus;
        }

        public void ClearMV()
        {
            txtNameMV.Text = "";
            txtUnitMV.Text = "";
        }
    }
}
