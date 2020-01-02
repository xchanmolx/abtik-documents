using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABTIKDocumentsUI.BLL;
using ABTIKDocumentsUI.DAL;
using System.IO;
using System.Diagnostics;
using ABTIKDocumentsUI.UI;

namespace ABTIKDocumentsUI
{
    public partial class RespondersCustomControl : UserControl
    {
        public RespondersCustomControl()
        {
            InitializeComponent();

            dgvResponders.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            dgvResponders.EnableHeadersVisualStyles = false;
        }

        OpenFileDialog ofd = new OpenFileDialog();
        RespondersBLL resp = new RespondersBLL();
        RespondersDAL dal = new RespondersDAL();
        int id = 1;

        private void btnRegistrationOfResponder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Documents\Registration-of-ABTIK-Responder.docx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration of Responder Form Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Clear()
        {
            txtIDNumber.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            txtPosition.Text = "";
            txtQualifications.Text = "";
            txtBirthdate.Text = "";
            txtRemarks.Text = "";

            pctrBoxImage.Image = null;

            txtSearch.Text = "";

            id = 1;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            errorProviderResponders.Clear();
        }

        private bool ValidateForm()
        {
            bool bStatus = true;

            if (txtIDNumber.Text == "")
            {
                errorProviderResponders.SetError(txtIDNumber, "Required ID Number");
                bStatus = false;
            }
            else if (txtName.Text == "")
            {
                errorProviderResponders.SetError(txtName, "Required Name");
                bStatus = false;
            }
            else if (txtAddress.Text == "")
            {
                errorProviderResponders.SetError(txtAddress, "Required Address");
                bStatus = false;
            }
            else if (txtContact.Text == "")
            {
                errorProviderResponders.SetError(txtContact, "Required Contact");
                bStatus = false;
            }
            else if (txtGender.Text == "")
            {
                errorProviderResponders.SetError(txtGender, "Required Gender");
                bStatus = false;
            }
            else if (txtPosition.Text == "")
            {
                errorProviderResponders.SetError(txtPosition, "Required Position");
                bStatus = false;
            }
            else if (txtQualifications.Text == "")
            {
                errorProviderResponders.SetError(txtQualifications, "Required Qualifications");
                bStatus = false;
            }
            else if (txtBirthdate.Text == "")
            {
                errorProviderResponders.SetError(txtBirthdate, "Required Birthdate");
                bStatus = false;
            }

            return bStatus;
        }

        private void dgvResponders_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (DataGridViewRow row in dgvResponders.Rows)
                {
                    txtTotalResponders.Text = String.Format("Responders: {0:N0}", row.Index + 1);
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
                dgvResponders.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "IDNumber";
                DataTable sortedDT = dv.ToTable();
            }
            else
            {
                // Use select method to display all items
                DataTable dt = dal.Select();
                dgvResponders.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "IDNumber";
                DataTable sortedDT = dv.ToTable();
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

        private void ShowLabelsAndOthers_dgvResponders_RowHeaderMC()
        {
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnSave.Visible = false;
            btnClear.Visible = false;

            lblGender.Visible = true;
            lblIDNumber.Visible = true;
            lblAddress.Visible = true;
            lblContact.Visible = true;
            lblName.Visible = true;
            lblAge.Visible = true;
            lblBirthdate.Visible = true;
            lblEmail.Visible = true;
            lblPosition.Visible = true;
            lblQualifications.Visible = true;
            lblRemarks.Visible = true;
        }

        private void dgvResponders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dgvResponders.Size = new Size(1140, 3);

            ShowLabelsAndOthers_dgvResponders_RowHeaderMC();

            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            try
            {
                // Get the index of particular row
                int rowIndex = e.RowIndex;
                id = Convert.ToInt32(dgvResponders.Rows[rowIndex].Cells[0].Value.ToString());
                txtIDNumber.Text = dgvResponders.Rows[rowIndex].Cells[1].Value.ToString();
                txtName.Text = dgvResponders.Rows[rowIndex].Cells[2].Value.ToString();
                txtAddress.Text = dgvResponders.Rows[rowIndex].Cells[3].Value.ToString();
                txtContact.Text = dgvResponders.Rows[rowIndex].Cells[4].Value.ToString();
                txtEmail.Text = dgvResponders.Rows[rowIndex].Cells[5].Value.ToString();
                txtAge.Text = dgvResponders.Rows[rowIndex].Cells[6].Value.ToString();
                txtGender.Text = dgvResponders.Rows[rowIndex].Cells[7].Value.ToString();
                txtPosition.Text = dgvResponders.Rows[rowIndex].Cells[8].Value.ToString();
                txtQualifications.Text = dgvResponders.Rows[rowIndex].Cells[9].Value.ToString();
                txtBirthdate.Text = dgvResponders.Rows[rowIndex].Cells[10].Value.ToString();
                txtRemarks.Text = dgvResponders.Rows[rowIndex].Cells[11].Value.ToString();
                txtPathImage.Text = dgvResponders.Rows[rowIndex].Cells[12].Value.ToString();
                pctrBoxImage.Image = Image.FromFile(paths + dgvResponders.Rows[rowIndex].Cells[12].Value.ToString());

                txtBirthdate.Text = txtBirthdate.Text.Insert(4, "-");
                txtBirthdate.Text = txtBirthdate.Text.Insert(7, "-");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RowHeaderMouseClick Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            imageUrl = txtImageFileName.Text;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            txtAge.Visible = true;

            txtName.Focus();
        }

        private bool btnBrowseWasClick = false;
        string imageUrl = null;
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            btnBrowseWasClick = true;

            try
            {
                //ofd.InitialDirectory = "C:\\";
                ofd.Filter = "Image Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    if (ofd.CheckFileExists)
                    {
                        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        string correctFileName = Path.GetFileName(ofd.FileName);
                        File.Copy(ofd.FileName, paths + @"\Images\Responders\" + correctFileName, true);

                        imageUrl = ofd.FileName;
                        pctrBoxImage.Image = Image.FromFile(ofd.FileName);
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Browse Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtBirthdate.Text = txtBirthdate.Text.Remove(4, 1);
            txtBirthdate.Text = txtBirthdate.Text.Remove(6, 1);

            string dateOfBirth = txtBirthdate.Text;

            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dateOfBirth);
            int age = (now - dob) / 10000;

            string correctFileName = Path.GetFileName(ofd.FileName);

            // Get the values from User UI
            resp.ID = id;
            resp.IDNumber = txtIDNumber.Text;
            resp.Name = txtName.Text;
            resp.Address = txtAddress.Text;
            resp.Contact = txtContact.Text;
            resp.Email = txtEmail.Text;
            resp.Age = age;
            resp.Gender = txtGender.Text;
            resp.Position = txtPosition.Text;
            resp.Qualifications = txtQualifications.Text;
            resp.Birthdate = txtBirthdate.Text;
            resp.Remarks = txtRemarks.Text;

            if (btnBrowseWasClick == true)
            {
                resp.PathImage = correctFileName;
            }
            else if(btnBrowseWasClick == false)
            {
                resp.PathImage = imageUrl;
            }
            btnBrowseWasClick = false;

            // Updating data into Database
            bool success = dal.Update(resp);

            // If data is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                // Data updated successfully 
                MessageBox.Show("Responder successfully updated!", "Update Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtSearch.Focus();
            }
            else
            {
                // Failed to update user 
                MessageBox.Show("Failed to update responder Information!", "Update Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvResponders.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "IDNumber";
            DataTable sortedDT = dv.ToTable();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //int age;
                //int.TryParse(txtAge.Text, out age);

                string dateOfBirth = txtBirthdate.Text;

                int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int dob = int.Parse(dateOfBirth);
                int age = (now - dob) / 10000;


                string correctFileName = Path.GetFileName(ofd.FileName);

                // Getting data from UI
                resp.IDNumber = txtIDNumber.Text;
                resp.Name = txtName.Text;
                resp.Address = txtAddress.Text;
                resp.Contact = txtContact.Text;
                resp.Email = txtEmail.Text;
                resp.Age = age;
                resp.Gender = txtGender.Text;
                resp.Position = txtPosition.Text;
                resp.Qualifications = txtQualifications.Text;
                resp.Birthdate = txtBirthdate.Text;
                resp.Remarks = txtRemarks.Text;

                if (btnBrowseWasClick == true)
                {
                    resp.PathImage = correctFileName;
                }
                else if(btnBrowseWasClick == false)
                {
                    resp.PathImage = "default-image.jpg";
                }
                btnBrowseWasClick = false;

                // Inserting data into Database
                bool success = dal.Insert(resp);

                // If the data is successfully inserted then the value of success will be true else it will be false
                if (success == true)
                {
                    // Data successfully inserted
                    MessageBox.Show("Responder successfully saved.", "PCR Information Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    txtName.Focus();
                }
                else
                {
                    // Failed to insert data
                    MessageBox.Show("Failed to add new responder.", "Responder Information Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Refreshing Data Grid View
                DataTable dt = dal.Select();
                dgvResponders.DataSource = dt;

                DataView dv = dt.DefaultView;
                dv.Sort = "IDNumber";
                DataTable sortedDT = dv.ToTable();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Getting User ID from Form
            resp.ID = id;

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete?", "Delete Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bool success = dal.Delete(resp);
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
            dgvResponders.DataSource = dt;

            DataView dv = dt.DefaultView;
            dv.Sort = "IDNumber";
            DataTable sortedDT = dv.ToTable();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void HideLabelsAndOthers_dgvResponders_RowHeaderMC()
        {
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = true;
            btnClear.Visible = true;

            lblGender.Visible = false;
            lblIDNumber.Visible = false;
            lblAddress.Visible = false;
            lblContact.Visible = false;
            lblName.Visible = false;
            lblAge.Visible = false;
            lblBirthdate.Visible = false;
            lblEmail.Visible = false;
            lblPosition.Visible = false;
            lblQualifications.Visible = false;
            lblRemarks.Visible = false;
        }

        private void btnAddResponder_Click(object sender, EventArgs e)
        {
            this.dgvResponders.Size = new Size(1139, 3);

            HideLabelsAndOthers_dgvResponders_RowHeaderMC();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtAge.Visible = false;

            txtName.Focus();

            Clear();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.dgvResponders.Size = new Size(1139, 425);

            Clear();    
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            errorProviderResponders.Clear();
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrintAllResponders frm = new frmPrintAllResponders(DateTime.Now.ToString("dddd, MMMM dd, yyyy"), string.Format("{0}", txtTotalResponders.Text));

                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print All Responders Information!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrintEach_Click(object sender, EventArgs e)
        {
            try
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                using (frmPrintEachResponder frm = new frmPrintEachResponder(paths + @"\Images\Responders\" + imageUrl, txtName.Text, txtIDNumber.Text, txtAddress.Text, txtContact.Text, txtEmail.Text, txtAge.Text, txtGender.Text, txtBirthdate.Text, txtPosition.Text, txtQualifications.Text, txtRemarks.Text))
                    {
                        frm.ShowDialog();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Print Each Responder Information!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPathImage_OnValueChanged(object sender, EventArgs e)
        {
            txtImageFileName.Text = txtPathImage.Text.Substring(19);
        }

        private void txtBirthdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProviderResponders.SetError(txtBirthdate, "Birthdate (yyyyMMdd), please input only numbers.");
            }
        }
    }
}
