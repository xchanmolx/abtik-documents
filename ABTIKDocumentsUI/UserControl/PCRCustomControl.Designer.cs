namespace ABTIKDocumentsUI
{
    partial class PCRCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCRCustomControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnWaiver = new System.Windows.Forms.Button();
            this.btnPCR = new System.Windows.Forms.Button();
            this.btnAddPCRInformation = new System.Windows.Forms.Button();
            this.lblDocuments = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvPCR = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotalIncidents = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbBoxSex = new System.Windows.Forms.ComboBox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPatientNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPlaceOfIncident = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTypeOfIncident = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtChiefComplaints = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOxygen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBloodPressure = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRespiratoryRate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTemperature = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPulseRate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPupil = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPastMedicalHistory = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSAMPLE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPhysicalFindings = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTreatment = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOtherPersonsInvolved = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCallerInformation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMaterialsUsed = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTransportedToNameOfHospitalOrResidence = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEndorsedTo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmergencyResponseTeam = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAmbulanceBodyNoAndPlateNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtWAIVER = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProviderPCR = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnPrintEach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPCR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.lblHeader.Location = new System.Drawing.Point(294, -4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(310, 23);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Pre-Hospital Care Report (PCR)";
            // 
            // btnWaiver
            // 
            this.btnWaiver.BackColor = System.Drawing.Color.White;
            this.btnWaiver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWaiver.FlatAppearance.BorderSize = 0;
            this.btnWaiver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnWaiver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnWaiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaiver.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaiver.ForeColor = System.Drawing.Color.Black;
            this.btnWaiver.Image = ((System.Drawing.Image)(resources.GetObject("btnWaiver.Image")));
            this.btnWaiver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWaiver.Location = new System.Drawing.Point(644, -8);
            this.btnWaiver.Name = "btnWaiver";
            this.btnWaiver.Size = new System.Drawing.Size(113, 50);
            this.btnWaiver.TabIndex = 17;
            this.btnWaiver.TabStop = false;
            this.btnWaiver.Text = "WAIVER";
            this.btnWaiver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWaiver.UseVisualStyleBackColor = false;
            this.btnWaiver.Click += new System.EventHandler(this.btnWaiver_Click);
            // 
            // btnPCR
            // 
            this.btnPCR.BackColor = System.Drawing.Color.White;
            this.btnPCR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPCR.FlatAppearance.BorderSize = 0;
            this.btnPCR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPCR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnPCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCR.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCR.ForeColor = System.Drawing.Color.Black;
            this.btnPCR.Image = ((System.Drawing.Image)(resources.GetObject("btnPCR.Image")));
            this.btnPCR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPCR.Location = new System.Drawing.Point(567, -8);
            this.btnPCR.Name = "btnPCR";
            this.btnPCR.Size = new System.Drawing.Size(82, 50);
            this.btnPCR.TabIndex = 18;
            this.btnPCR.TabStop = false;
            this.btnPCR.Text = "PCR";
            this.btnPCR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPCR.UseVisualStyleBackColor = false;
            this.btnPCR.Click += new System.EventHandler(this.btnPCR_Click);
            // 
            // btnAddPCRInformation
            // 
            this.btnAddPCRInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPCRInformation.FlatAppearance.BorderSize = 0;
            this.btnAddPCRInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddPCRInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnAddPCRInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPCRInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPCRInformation.ForeColor = System.Drawing.Color.Black;
            this.btnAddPCRInformation.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPCRInformation.Image")));
            this.btnAddPCRInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPCRInformation.Location = new System.Drawing.Point(119, -6);
            this.btnAddPCRInformation.Name = "btnAddPCRInformation";
            this.btnAddPCRInformation.Size = new System.Drawing.Size(144, 40);
            this.btnAddPCRInformation.TabIndex = 54;
            this.btnAddPCRInformation.TabStop = false;
            this.btnAddPCRInformation.Text = "&Add PCR Information";
            this.btnAddPCRInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPCRInformation.UseVisualStyleBackColor = true;
            this.btnAddPCRInformation.Click += new System.EventHandler(this.btnAddPCRInformation_Click);
            // 
            // lblDocuments
            // 
            this.lblDocuments.AutoSize = true;
            this.lblDocuments.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.lblDocuments.Location = new System.Drawing.Point(367, 15);
            this.lblDocuments.Name = "lblDocuments";
            this.lblDocuments.Size = new System.Drawing.Size(106, 21);
            this.lblDocuments.TabIndex = 55;
            this.lblDocuments.Text = "Documents";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "Search";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtSearch.LineIdleColor = System.Drawing.Color.Black;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtSearch.LineThickness = 1;
            this.txtSearch.Location = new System.Drawing.Point(3, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(854, 39);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.txtSearch_OnValueChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            // 
            // dgvPCR
            // 
            this.dgvPCR.AllowUserToAddRows = false;
            this.dgvPCR.AllowUserToResizeColumns = false;
            this.dgvPCR.AllowUserToResizeRows = false;
            this.dgvPCR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPCR.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPCR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPCR.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPCR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPCR.Location = new System.Drawing.Point(3, 76);
            this.dgvPCR.Name = "dgvPCR";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPCR.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPCR.Size = new System.Drawing.Size(854, 325);
            this.dgvPCR.TabIndex = 57;
            this.dgvPCR.TabStop = false;
            this.dgvPCR.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPCR_RowHeaderMouseClick);
            this.dgvPCR.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPCR_RowsAdded);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(766, 78);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 50);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(766, 133);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 50);
            this.btnClear.TabIndex = 59;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "&Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(677, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 50);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(677, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 50);
            this.btnSave.TabIndex = 61;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotalIncidents
            // 
            this.txtTotalIncidents.BackColor = System.Drawing.Color.White;
            this.txtTotalIncidents.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIncidents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalIncidents.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotalIncidents.HintText = "";
            this.txtTotalIncidents.isPassword = false;
            this.txtTotalIncidents.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalIncidents.LineIdleColor = System.Drawing.Color.Black;
            this.txtTotalIncidents.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalIncidents.LineThickness = 1;
            this.txtTotalIncidents.Location = new System.Drawing.Point(864, 368);
            this.txtTotalIncidents.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalIncidents.Name = "txtTotalIncidents";
            this.txtTotalIncidents.Size = new System.Drawing.Size(116, 33);
            this.txtTotalIncidents.TabIndex = 62;
            this.txtTotalIncidents.TabStop = false;
            this.txtTotalIncidents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbBoxSex
            // 
            this.cmbBoxSex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBoxSex.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxSex.FormattingEnabled = true;
            this.cmbBoxSex.Items.AddRange(new object[] {
            "Gender",
            "Male",
            "Female",
            "NotSpecified"});
            this.cmbBoxSex.Location = new System.Drawing.Point(84, 174);
            this.cmbBoxSex.Name = "cmbBoxSex";
            this.cmbBoxSex.Size = new System.Drawing.Size(85, 24);
            this.cmbBoxSex.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "Name";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtName.LineIdleColor = System.Drawing.Color.Black;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtName.LineThickness = 1;
            this.txtName.Location = new System.Drawing.Point(4, 118);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 33);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPatientNo
            // 
            this.txtPatientNo.BackColor = System.Drawing.Color.White;
            this.txtPatientNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientNo.HintForeColor = System.Drawing.Color.Empty;
            this.txtPatientNo.HintText = "Patient No.";
            this.txtPatientNo.isPassword = false;
            this.txtPatientNo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPatientNo.LineIdleColor = System.Drawing.Color.Black;
            this.txtPatientNo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPatientNo.LineThickness = 1;
            this.txtPatientNo.Location = new System.Drawing.Point(4, 77);
            this.txtPatientNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientNo.Name = "txtPatientNo";
            this.txtPatientNo.Size = new System.Drawing.Size(165, 33);
            this.txtPatientNo.TabIndex = 0;
            this.txtPatientNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAge.HintForeColor = System.Drawing.Color.Empty;
            this.txtAge.HintText = "Age";
            this.txtAge.isPassword = false;
            this.txtAge.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAge.LineIdleColor = System.Drawing.Color.Black;
            this.txtAge.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAge.LineThickness = 1;
            this.txtAge.Location = new System.Drawing.Point(4, 159);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(73, 33);
            this.txtAge.TabIndex = 2;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "Address";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAddress.LineIdleColor = System.Drawing.Color.Black;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAddress.LineThickness = 1;
            this.txtAddress.Location = new System.Drawing.Point(4, 200);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(165, 33);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPlaceOfIncident
            // 
            this.txtPlaceOfIncident.BackColor = System.Drawing.Color.White;
            this.txtPlaceOfIncident.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlaceOfIncident.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceOfIncident.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPlaceOfIncident.HintForeColor = System.Drawing.Color.Empty;
            this.txtPlaceOfIncident.HintText = "Place of Incident";
            this.txtPlaceOfIncident.isPassword = false;
            this.txtPlaceOfIncident.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPlaceOfIncident.LineIdleColor = System.Drawing.Color.Black;
            this.txtPlaceOfIncident.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPlaceOfIncident.LineThickness = 1;
            this.txtPlaceOfIncident.Location = new System.Drawing.Point(4, 241);
            this.txtPlaceOfIncident.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaceOfIncident.Name = "txtPlaceOfIncident";
            this.txtPlaceOfIncident.Size = new System.Drawing.Size(165, 33);
            this.txtPlaceOfIncident.TabIndex = 5;
            this.txtPlaceOfIncident.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTypeOfIncident
            // 
            this.txtTypeOfIncident.BackColor = System.Drawing.Color.White;
            this.txtTypeOfIncident.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTypeOfIncident.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeOfIncident.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTypeOfIncident.HintForeColor = System.Drawing.Color.Empty;
            this.txtTypeOfIncident.HintText = "Type of Incident";
            this.txtTypeOfIncident.isPassword = false;
            this.txtTypeOfIncident.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTypeOfIncident.LineIdleColor = System.Drawing.Color.Black;
            this.txtTypeOfIncident.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTypeOfIncident.LineThickness = 1;
            this.txtTypeOfIncident.Location = new System.Drawing.Point(4, 282);
            this.txtTypeOfIncident.Margin = new System.Windows.Forms.Padding(4);
            this.txtTypeOfIncident.Name = "txtTypeOfIncident";
            this.txtTypeOfIncident.Size = new System.Drawing.Size(165, 33);
            this.txtTypeOfIncident.TabIndex = 6;
            this.txtTypeOfIncident.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDate.HintForeColor = System.Drawing.Color.Empty;
            this.txtDate.HintText = "Date";
            this.txtDate.isPassword = false;
            this.txtDate.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtDate.LineIdleColor = System.Drawing.Color.Black;
            this.txtDate.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtDate.LineThickness = 1;
            this.txtDate.Location = new System.Drawing.Point(4, 323);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(165, 33);
            this.txtDate.TabIndex = 7;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtChiefComplaints
            // 
            this.txtChiefComplaints.BackColor = System.Drawing.Color.White;
            this.txtChiefComplaints.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChiefComplaints.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiefComplaints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChiefComplaints.HintForeColor = System.Drawing.Color.Empty;
            this.txtChiefComplaints.HintText = "Chief Complaints";
            this.txtChiefComplaints.isPassword = false;
            this.txtChiefComplaints.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtChiefComplaints.LineIdleColor = System.Drawing.Color.Black;
            this.txtChiefComplaints.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtChiefComplaints.LineThickness = 1;
            this.txtChiefComplaints.Location = new System.Drawing.Point(4, 364);
            this.txtChiefComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.txtChiefComplaints.Name = "txtChiefComplaints";
            this.txtChiefComplaints.Size = new System.Drawing.Size(165, 33);
            this.txtChiefComplaints.TabIndex = 8;
            this.txtChiefComplaints.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOxygen
            // 
            this.txtOxygen.BackColor = System.Drawing.Color.White;
            this.txtOxygen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOxygen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOxygen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOxygen.HintForeColor = System.Drawing.Color.Empty;
            this.txtOxygen.HintText = "Oxygen";
            this.txtOxygen.isPassword = false;
            this.txtOxygen.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtOxygen.LineIdleColor = System.Drawing.Color.Black;
            this.txtOxygen.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtOxygen.LineThickness = 1;
            this.txtOxygen.Location = new System.Drawing.Point(177, 77);
            this.txtOxygen.Margin = new System.Windows.Forms.Padding(4);
            this.txtOxygen.Name = "txtOxygen";
            this.txtOxygen.Size = new System.Drawing.Size(165, 33);
            this.txtOxygen.TabIndex = 9;
            this.txtOxygen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBloodPressure
            // 
            this.txtBloodPressure.BackColor = System.Drawing.Color.White;
            this.txtBloodPressure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBloodPressure.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBloodPressure.HintForeColor = System.Drawing.Color.Empty;
            this.txtBloodPressure.HintText = "Blood Pressure";
            this.txtBloodPressure.isPassword = false;
            this.txtBloodPressure.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtBloodPressure.LineIdleColor = System.Drawing.Color.Black;
            this.txtBloodPressure.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtBloodPressure.LineThickness = 1;
            this.txtBloodPressure.Location = new System.Drawing.Point(177, 118);
            this.txtBloodPressure.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloodPressure.Name = "txtBloodPressure";
            this.txtBloodPressure.Size = new System.Drawing.Size(165, 33);
            this.txtBloodPressure.TabIndex = 10;
            this.txtBloodPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRespiratoryRate
            // 
            this.txtRespiratoryRate.BackColor = System.Drawing.Color.White;
            this.txtRespiratoryRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRespiratoryRate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespiratoryRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRespiratoryRate.HintForeColor = System.Drawing.Color.Empty;
            this.txtRespiratoryRate.HintText = "Respiratory Rate";
            this.txtRespiratoryRate.isPassword = false;
            this.txtRespiratoryRate.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtRespiratoryRate.LineIdleColor = System.Drawing.Color.Black;
            this.txtRespiratoryRate.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtRespiratoryRate.LineThickness = 1;
            this.txtRespiratoryRate.Location = new System.Drawing.Point(177, 159);
            this.txtRespiratoryRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespiratoryRate.Name = "txtRespiratoryRate";
            this.txtRespiratoryRate.Size = new System.Drawing.Size(165, 33);
            this.txtRespiratoryRate.TabIndex = 11;
            this.txtRespiratoryRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTemperature
            // 
            this.txtTemperature.BackColor = System.Drawing.Color.White;
            this.txtTemperature.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTemperature.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTemperature.HintForeColor = System.Drawing.Color.Empty;
            this.txtTemperature.HintText = "Temperature";
            this.txtTemperature.isPassword = false;
            this.txtTemperature.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTemperature.LineIdleColor = System.Drawing.Color.Black;
            this.txtTemperature.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTemperature.LineThickness = 1;
            this.txtTemperature.Location = new System.Drawing.Point(177, 200);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(4);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(165, 33);
            this.txtTemperature.TabIndex = 12;
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPulseRate
            // 
            this.txtPulseRate.BackColor = System.Drawing.Color.White;
            this.txtPulseRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPulseRate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPulseRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPulseRate.HintForeColor = System.Drawing.Color.Empty;
            this.txtPulseRate.HintText = "Pulse Rate";
            this.txtPulseRate.isPassword = false;
            this.txtPulseRate.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPulseRate.LineIdleColor = System.Drawing.Color.Black;
            this.txtPulseRate.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPulseRate.LineThickness = 1;
            this.txtPulseRate.Location = new System.Drawing.Point(177, 241);
            this.txtPulseRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPulseRate.Name = "txtPulseRate";
            this.txtPulseRate.Size = new System.Drawing.Size(165, 33);
            this.txtPulseRate.TabIndex = 13;
            this.txtPulseRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPupil
            // 
            this.txtPupil.BackColor = System.Drawing.Color.White;
            this.txtPupil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPupil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPupil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPupil.HintForeColor = System.Drawing.Color.Empty;
            this.txtPupil.HintText = "Pupil";
            this.txtPupil.isPassword = false;
            this.txtPupil.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPupil.LineIdleColor = System.Drawing.Color.Black;
            this.txtPupil.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPupil.LineThickness = 1;
            this.txtPupil.Location = new System.Drawing.Point(177, 282);
            this.txtPupil.Margin = new System.Windows.Forms.Padding(4);
            this.txtPupil.Name = "txtPupil";
            this.txtPupil.Size = new System.Drawing.Size(165, 33);
            this.txtPupil.TabIndex = 14;
            this.txtPupil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPastMedicalHistory
            // 
            this.txtPastMedicalHistory.BackColor = System.Drawing.Color.White;
            this.txtPastMedicalHistory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPastMedicalHistory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPastMedicalHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPastMedicalHistory.HintForeColor = System.Drawing.Color.Empty;
            this.txtPastMedicalHistory.HintText = "Past Medical History";
            this.txtPastMedicalHistory.isPassword = false;
            this.txtPastMedicalHistory.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPastMedicalHistory.LineIdleColor = System.Drawing.Color.Black;
            this.txtPastMedicalHistory.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPastMedicalHistory.LineThickness = 1;
            this.txtPastMedicalHistory.Location = new System.Drawing.Point(177, 323);
            this.txtPastMedicalHistory.Margin = new System.Windows.Forms.Padding(4);
            this.txtPastMedicalHistory.Name = "txtPastMedicalHistory";
            this.txtPastMedicalHistory.Size = new System.Drawing.Size(165, 33);
            this.txtPastMedicalHistory.TabIndex = 15;
            this.txtPastMedicalHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSAMPLE
            // 
            this.txtSAMPLE.BackColor = System.Drawing.Color.White;
            this.txtSAMPLE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSAMPLE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSAMPLE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSAMPLE.HintForeColor = System.Drawing.Color.Empty;
            this.txtSAMPLE.HintText = "SAMPLE";
            this.txtSAMPLE.isPassword = false;
            this.txtSAMPLE.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtSAMPLE.LineIdleColor = System.Drawing.Color.Black;
            this.txtSAMPLE.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtSAMPLE.LineThickness = 1;
            this.txtSAMPLE.Location = new System.Drawing.Point(177, 364);
            this.txtSAMPLE.Margin = new System.Windows.Forms.Padding(4);
            this.txtSAMPLE.Name = "txtSAMPLE";
            this.txtSAMPLE.Size = new System.Drawing.Size(165, 33);
            this.txtSAMPLE.TabIndex = 16;
            this.txtSAMPLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPhysicalFindings
            // 
            this.txtPhysicalFindings.BackColor = System.Drawing.Color.White;
            this.txtPhysicalFindings.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhysicalFindings.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhysicalFindings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhysicalFindings.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhysicalFindings.HintText = "Physical Findings";
            this.txtPhysicalFindings.isPassword = false;
            this.txtPhysicalFindings.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPhysicalFindings.LineIdleColor = System.Drawing.Color.Black;
            this.txtPhysicalFindings.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPhysicalFindings.LineThickness = 1;
            this.txtPhysicalFindings.Location = new System.Drawing.Point(350, 77);
            this.txtPhysicalFindings.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhysicalFindings.Name = "txtPhysicalFindings";
            this.txtPhysicalFindings.Size = new System.Drawing.Size(194, 33);
            this.txtPhysicalFindings.TabIndex = 17;
            this.txtPhysicalFindings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTreatment
            // 
            this.txtTreatment.BackColor = System.Drawing.Color.White;
            this.txtTreatment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTreatment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreatment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTreatment.HintForeColor = System.Drawing.Color.Empty;
            this.txtTreatment.HintText = "Treatment";
            this.txtTreatment.isPassword = false;
            this.txtTreatment.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTreatment.LineIdleColor = System.Drawing.Color.Black;
            this.txtTreatment.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTreatment.LineThickness = 1;
            this.txtTreatment.Location = new System.Drawing.Point(350, 118);
            this.txtTreatment.Margin = new System.Windows.Forms.Padding(4);
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(194, 33);
            this.txtTreatment.TabIndex = 18;
            this.txtTreatment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOtherPersonsInvolved
            // 
            this.txtOtherPersonsInvolved.BackColor = System.Drawing.Color.White;
            this.txtOtherPersonsInvolved.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOtherPersonsInvolved.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherPersonsInvolved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOtherPersonsInvolved.HintForeColor = System.Drawing.Color.Empty;
            this.txtOtherPersonsInvolved.HintText = "Other Persons Involved";
            this.txtOtherPersonsInvolved.isPassword = false;
            this.txtOtherPersonsInvolved.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtOtherPersonsInvolved.LineIdleColor = System.Drawing.Color.Black;
            this.txtOtherPersonsInvolved.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtOtherPersonsInvolved.LineThickness = 1;
            this.txtOtherPersonsInvolved.Location = new System.Drawing.Point(350, 159);
            this.txtOtherPersonsInvolved.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtherPersonsInvolved.Name = "txtOtherPersonsInvolved";
            this.txtOtherPersonsInvolved.Size = new System.Drawing.Size(194, 33);
            this.txtOtherPersonsInvolved.TabIndex = 19;
            this.txtOtherPersonsInvolved.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCallerInformation
            // 
            this.txtCallerInformation.BackColor = System.Drawing.Color.White;
            this.txtCallerInformation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCallerInformation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallerInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCallerInformation.HintForeColor = System.Drawing.Color.Empty;
            this.txtCallerInformation.HintText = "Caller Information";
            this.txtCallerInformation.isPassword = false;
            this.txtCallerInformation.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCallerInformation.LineIdleColor = System.Drawing.Color.Black;
            this.txtCallerInformation.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtCallerInformation.LineThickness = 1;
            this.txtCallerInformation.Location = new System.Drawing.Point(350, 200);
            this.txtCallerInformation.Margin = new System.Windows.Forms.Padding(4);
            this.txtCallerInformation.Name = "txtCallerInformation";
            this.txtCallerInformation.Size = new System.Drawing.Size(194, 33);
            this.txtCallerInformation.TabIndex = 20;
            this.txtCallerInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMaterialsUsed
            // 
            this.txtMaterialsUsed.BackColor = System.Drawing.Color.White;
            this.txtMaterialsUsed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaterialsUsed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialsUsed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaterialsUsed.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaterialsUsed.HintText = "Materials Used";
            this.txtMaterialsUsed.isPassword = false;
            this.txtMaterialsUsed.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtMaterialsUsed.LineIdleColor = System.Drawing.Color.Black;
            this.txtMaterialsUsed.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtMaterialsUsed.LineThickness = 1;
            this.txtMaterialsUsed.Location = new System.Drawing.Point(350, 241);
            this.txtMaterialsUsed.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaterialsUsed.Name = "txtMaterialsUsed";
            this.txtMaterialsUsed.Size = new System.Drawing.Size(194, 33);
            this.txtMaterialsUsed.TabIndex = 21;
            this.txtMaterialsUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTransportedToNameOfHospitalOrResidence
            // 
            this.txtTransportedToNameOfHospitalOrResidence.BackColor = System.Drawing.Color.White;
            this.txtTransportedToNameOfHospitalOrResidence.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransportedToNameOfHospitalOrResidence.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransportedToNameOfHospitalOrResidence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTransportedToNameOfHospitalOrResidence.HintForeColor = System.Drawing.Color.Empty;
            this.txtTransportedToNameOfHospitalOrResidence.HintText = "Transported To (Name of Hospital or Residence)";
            this.txtTransportedToNameOfHospitalOrResidence.isPassword = false;
            this.txtTransportedToNameOfHospitalOrResidence.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTransportedToNameOfHospitalOrResidence.LineIdleColor = System.Drawing.Color.Black;
            this.txtTransportedToNameOfHospitalOrResidence.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTransportedToNameOfHospitalOrResidence.LineThickness = 1;
            this.txtTransportedToNameOfHospitalOrResidence.Location = new System.Drawing.Point(552, 200);
            this.txtTransportedToNameOfHospitalOrResidence.Margin = new System.Windows.Forms.Padding(4);
            this.txtTransportedToNameOfHospitalOrResidence.Name = "txtTransportedToNameOfHospitalOrResidence";
            this.txtTransportedToNameOfHospitalOrResidence.Size = new System.Drawing.Size(290, 33);
            this.txtTransportedToNameOfHospitalOrResidence.TabIndex = 25;
            this.txtTransportedToNameOfHospitalOrResidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEndorsedTo
            // 
            this.txtEndorsedTo.BackColor = System.Drawing.Color.White;
            this.txtEndorsedTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndorsedTo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndorsedTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEndorsedTo.HintForeColor = System.Drawing.Color.Empty;
            this.txtEndorsedTo.HintText = "Endorsed To";
            this.txtEndorsedTo.isPassword = false;
            this.txtEndorsedTo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtEndorsedTo.LineIdleColor = System.Drawing.Color.Black;
            this.txtEndorsedTo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtEndorsedTo.LineThickness = 1;
            this.txtEndorsedTo.Location = new System.Drawing.Point(350, 282);
            this.txtEndorsedTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndorsedTo.Name = "txtEndorsedTo";
            this.txtEndorsedTo.Size = new System.Drawing.Size(194, 33);
            this.txtEndorsedTo.TabIndex = 22;
            this.txtEndorsedTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmergencyResponseTeam
            // 
            this.txtEmergencyResponseTeam.BackColor = System.Drawing.Color.White;
            this.txtEmergencyResponseTeam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmergencyResponseTeam.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyResponseTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmergencyResponseTeam.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmergencyResponseTeam.HintText = "Emergency Response Team";
            this.txtEmergencyResponseTeam.isPassword = false;
            this.txtEmergencyResponseTeam.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtEmergencyResponseTeam.LineIdleColor = System.Drawing.Color.Black;
            this.txtEmergencyResponseTeam.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtEmergencyResponseTeam.LineThickness = 1;
            this.txtEmergencyResponseTeam.Location = new System.Drawing.Point(350, 323);
            this.txtEmergencyResponseTeam.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmergencyResponseTeam.Name = "txtEmergencyResponseTeam";
            this.txtEmergencyResponseTeam.Size = new System.Drawing.Size(194, 33);
            this.txtEmergencyResponseTeam.TabIndex = 23;
            this.txtEmergencyResponseTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAmbulanceBodyNoAndPlateNo
            // 
            this.txtAmbulanceBodyNoAndPlateNo.BackColor = System.Drawing.Color.White;
            this.txtAmbulanceBodyNoAndPlateNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmbulanceBodyNoAndPlateNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmbulanceBodyNoAndPlateNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmbulanceBodyNoAndPlateNo.HintForeColor = System.Drawing.Color.Empty;
            this.txtAmbulanceBodyNoAndPlateNo.HintText = "Ambulance Body No / Plate No";
            this.txtAmbulanceBodyNoAndPlateNo.isPassword = false;
            this.txtAmbulanceBodyNoAndPlateNo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAmbulanceBodyNoAndPlateNo.LineIdleColor = System.Drawing.Color.Black;
            this.txtAmbulanceBodyNoAndPlateNo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAmbulanceBodyNoAndPlateNo.LineThickness = 1;
            this.txtAmbulanceBodyNoAndPlateNo.Location = new System.Drawing.Point(350, 364);
            this.txtAmbulanceBodyNoAndPlateNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmbulanceBodyNoAndPlateNo.Name = "txtAmbulanceBodyNoAndPlateNo";
            this.txtAmbulanceBodyNoAndPlateNo.Size = new System.Drawing.Size(194, 33);
            this.txtAmbulanceBodyNoAndPlateNo.TabIndex = 24;
            this.txtAmbulanceBodyNoAndPlateNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtWAIVER
            // 
            this.txtWAIVER.BackColor = System.Drawing.Color.White;
            this.txtWAIVER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWAIVER.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWAIVER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWAIVER.HintForeColor = System.Drawing.Color.Empty;
            this.txtWAIVER.HintText = "WAIVER";
            this.txtWAIVER.isPassword = false;
            this.txtWAIVER.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtWAIVER.LineIdleColor = System.Drawing.Color.Black;
            this.txtWAIVER.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtWAIVER.LineThickness = 1;
            this.txtWAIVER.Location = new System.Drawing.Point(552, 241);
            this.txtWAIVER.Margin = new System.Windows.Forms.Padding(4);
            this.txtWAIVER.Name = "txtWAIVER";
            this.txtWAIVER.Size = new System.Drawing.Size(290, 33);
            this.txtWAIVER.TabIndex = 63;
            this.txtWAIVER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // errorProviderPCR
            // 
            this.errorProviderPCR.ContainerControl = this;
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.BackColor = System.Drawing.Color.White;
            this.btnPrintAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintAll.FlatAppearance.BorderSize = 0;
            this.btnPrintAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnPrintAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAll.ForeColor = System.Drawing.Color.Black;
            this.btnPrintAll.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintAll.Image")));
            this.btnPrintAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintAll.Location = new System.Drawing.Point(864, 76);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(116, 50);
            this.btnPrintAll.TabIndex = 64;
            this.btnPrintAll.TabStop = false;
            this.btnPrintAll.Text = "Print All\r\nLegal size";
            this.btnPrintAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintAll.UseVisualStyleBackColor = false;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnPrintEach
            // 
            this.btnPrintEach.BackColor = System.Drawing.Color.White;
            this.btnPrintEach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintEach.FlatAppearance.BorderSize = 0;
            this.btnPrintEach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnPrintEach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPrintEach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintEach.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintEach.ForeColor = System.Drawing.Color.Black;
            this.btnPrintEach.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintEach.Image")));
            this.btnPrintEach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintEach.Location = new System.Drawing.Point(864, 132);
            this.btnPrintEach.Name = "btnPrintEach";
            this.btnPrintEach.Size = new System.Drawing.Size(131, 50);
            this.btnPrintEach.TabIndex = 65;
            this.btnPrintEach.TabStop = false;
            this.btnPrintEach.Text = "Print Each\r\nLegal size";
            this.btnPrintEach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintEach.UseVisualStyleBackColor = false;
            this.btnPrintEach.Click += new System.EventHandler(this.btnPrintEach_Click);
            // 
            // PCRCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvPCR);
            this.Controls.Add(this.btnPrintEach);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.txtWAIVER);
            this.Controls.Add(this.txtTotalIncidents);
            this.Controls.Add(this.cmbBoxSex);
            this.Controls.Add(this.txtAmbulanceBodyNoAndPlateNo);
            this.Controls.Add(this.txtEmergencyResponseTeam);
            this.Controls.Add(this.txtEndorsedTo);
            this.Controls.Add(this.txtTransportedToNameOfHospitalOrResidence);
            this.Controls.Add(this.txtMaterialsUsed);
            this.Controls.Add(this.txtCallerInformation);
            this.Controls.Add(this.txtOtherPersonsInvolved);
            this.Controls.Add(this.txtTreatment);
            this.Controls.Add(this.txtPhysicalFindings);
            this.Controls.Add(this.txtSAMPLE);
            this.Controls.Add(this.txtPastMedicalHistory);
            this.Controls.Add(this.txtPupil);
            this.Controls.Add(this.txtPulseRate);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtRespiratoryRate);
            this.Controls.Add(this.txtBloodPressure);
            this.Controls.Add(this.txtOxygen);
            this.Controls.Add(this.txtChiefComplaints);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTypeOfIncident);
            this.Controls.Add(this.txtPlaceOfIncident);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPatientNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddPCRInformation);
            this.Controls.Add(this.btnWaiver);
            this.Controls.Add(this.btnPCR);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblDocuments);
            this.Controls.Add(this.txtSearch);
            this.Name = "PCRCustomControl";
            this.Size = new System.Drawing.Size(1312, 527);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPCR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnWaiver;
        private System.Windows.Forms.Button btnPCR;
        private System.Windows.Forms.Button btnAddPCRInformation;
        private System.Windows.Forms.Label lblDocuments;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        public System.Windows.Forms.DataGridView dgvPCR;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotalIncidents;
        public System.Windows.Forms.ComboBox cmbBoxSex;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPatientNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAge;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPlaceOfIncident;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTypeOfIncident;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtChiefComplaints;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOxygen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBloodPressure;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRespiratoryRate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTemperature;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPulseRate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPupil;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPastMedicalHistory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSAMPLE;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhysicalFindings;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTreatment;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOtherPersonsInvolved;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCallerInformation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaterialsUsed;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTransportedToNameOfHospitalOrResidence;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEndorsedTo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmergencyResponseTeam;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAmbulanceBodyNoAndPlateNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtWAIVER;
        private System.Windows.Forms.ErrorProvider errorProviderPCR;
        private System.Windows.Forms.Button btnPrintEach;
        private System.Windows.Forms.Button btnPrintAll;
    }
}
