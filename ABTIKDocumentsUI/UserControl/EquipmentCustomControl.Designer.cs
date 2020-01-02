namespace ABTIKDocumentsUI
{
    partial class EquipmentCustomControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentCustomControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBoxMotorizedVehicle = new System.Windows.Forms.GroupBox();
            this.dgvMotorizedVehicle = new System.Windows.Forms.DataGridView();
            this.txtTotalItemsMV = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIdMV = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPrintAllMV = new System.Windows.Forms.Button();
            this.btnUpdateMV = new System.Windows.Forms.Button();
            this.btnClearMV = new System.Windows.Forms.Button();
            this.btnDeleteMV = new System.Windows.Forms.Button();
            this.btnSaveMV = new System.Windows.Forms.Button();
            this.txtUnitMV = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNameMV = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSearchMV = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblItemsMV = new System.Windows.Forms.Label();
            this.btnAddMV = new System.Windows.Forms.Button();
            this.errorProviderEquipment = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbBoxEquipment = new System.Windows.Forms.ComboBox();
            this.pictureBoxEquipment = new System.Windows.Forms.PictureBox();
            this.groupBoxGeneratorSet = new System.Windows.Forms.GroupBox();
            this.dgvGeneratorSet = new System.Windows.Forms.DataGridView();
            this.txtTotalItemsGenSet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtIdGenSet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPrintAllGenSet = new System.Windows.Forms.Button();
            this.btnUpdateGenSet = new System.Windows.Forms.Button();
            this.btnClearGenSet = new System.Windows.Forms.Button();
            this.btnDeleteGenSet = new System.Windows.Forms.Button();
            this.btnSaveGenSet = new System.Windows.Forms.Button();
            this.txtUnitGenSet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNameGenSet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSearchGenSet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddGenSet = new System.Windows.Forms.Button();
            this.groupBoxMotorizedVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorizedVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquipment)).BeginInit();
            this.groupBoxGeneratorSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneratorSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.lblHeader.Location = new System.Drawing.Point(364, -4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(101, 23);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "MDRRMO";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.lblMessage.Location = new System.Drawing.Point(343, 14);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(155, 21);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "List of Equipment";
            // 
            // groupBoxMotorizedVehicle
            // 
            this.groupBoxMotorizedVehicle.Controls.Add(this.dgvMotorizedVehicle);
            this.groupBoxMotorizedVehicle.Controls.Add(this.txtTotalItemsMV);
            this.groupBoxMotorizedVehicle.Controls.Add(this.txtIdMV);
            this.groupBoxMotorizedVehicle.Controls.Add(this.btnPrintAllMV);
            this.groupBoxMotorizedVehicle.Controls.Add(this.btnUpdateMV);
            this.groupBoxMotorizedVehicle.Controls.Add(this.btnClearMV);
            this.groupBoxMotorizedVehicle.Controls.Add(this.btnDeleteMV);
            this.groupBoxMotorizedVehicle.Controls.Add(this.btnSaveMV);
            this.groupBoxMotorizedVehicle.Controls.Add(this.txtUnitMV);
            this.groupBoxMotorizedVehicle.Controls.Add(this.txtNameMV);
            this.groupBoxMotorizedVehicle.Controls.Add(this.txtSearchMV);
            this.groupBoxMotorizedVehicle.Controls.Add(this.lblItemsMV);
            this.groupBoxMotorizedVehicle.Controls.Add(this.btnAddMV);
            this.groupBoxMotorizedVehicle.Location = new System.Drawing.Point(3, 38);
            this.groupBoxMotorizedVehicle.Name = "groupBoxMotorizedVehicle";
            this.groupBoxMotorizedVehicle.Size = new System.Drawing.Size(1147, 356);
            this.groupBoxMotorizedVehicle.TabIndex = 12;
            this.groupBoxMotorizedVehicle.TabStop = false;
            this.groupBoxMotorizedVehicle.Text = "Motorized Vehicle";
            // 
            // dgvMotorizedVehicle
            // 
            this.dgvMotorizedVehicle.AllowUserToAddRows = false;
            this.dgvMotorizedVehicle.AllowUserToResizeColumns = false;
            this.dgvMotorizedVehicle.AllowUserToResizeRows = false;
            this.dgvMotorizedVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMotorizedVehicle.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMotorizedVehicle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMotorizedVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMotorizedVehicle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMotorizedVehicle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMotorizedVehicle.Location = new System.Drawing.Point(6, 57);
            this.dgvMotorizedVehicle.Name = "dgvMotorizedVehicle";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMotorizedVehicle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMotorizedVehicle.Size = new System.Drawing.Size(838, 298);
            this.dgvMotorizedVehicle.TabIndex = 59;
            this.dgvMotorizedVehicle.TabStop = false;
            this.dgvMotorizedVehicle.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMotorizedVehicle_RowHeaderMouseClick);
            this.dgvMotorizedVehicle.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMotorizedVehicle_RowsAdded);
            // 
            // txtTotalItemsMV
            // 
            this.txtTotalItemsMV.BackColor = System.Drawing.Color.White;
            this.txtTotalItemsMV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalItemsMV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItemsMV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalItemsMV.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotalItemsMV.HintText = "";
            this.txtTotalItemsMV.isPassword = false;
            this.txtTotalItemsMV.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalItemsMV.LineIdleColor = System.Drawing.Color.Black;
            this.txtTotalItemsMV.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalItemsMV.LineThickness = 1;
            this.txtTotalItemsMV.Location = new System.Drawing.Point(912, 322);
            this.txtTotalItemsMV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalItemsMV.Name = "txtTotalItemsMV";
            this.txtTotalItemsMV.Size = new System.Drawing.Size(59, 33);
            this.txtTotalItemsMV.TabIndex = 66;
            this.txtTotalItemsMV.TabStop = false;
            this.txtTotalItemsMV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtIdMV
            // 
            this.txtIdMV.BackColor = System.Drawing.Color.White;
            this.txtIdMV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdMV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdMV.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdMV.HintText = "id";
            this.txtIdMV.isPassword = false;
            this.txtIdMV.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtIdMV.LineIdleColor = System.Drawing.Color.Black;
            this.txtIdMV.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtIdMV.LineThickness = 1;
            this.txtIdMV.Location = new System.Drawing.Point(29, 74);
            this.txtIdMV.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMV.Name = "txtIdMV";
            this.txtIdMV.Size = new System.Drawing.Size(50, 33);
            this.txtIdMV.TabIndex = 100;
            this.txtIdMV.TabStop = false;
            this.txtIdMV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPrintAllMV
            // 
            this.btnPrintAllMV.BackColor = System.Drawing.Color.White;
            this.btnPrintAllMV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintAllMV.FlatAppearance.BorderSize = 0;
            this.btnPrintAllMV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnPrintAllMV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPrintAllMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAllMV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAllMV.ForeColor = System.Drawing.Color.Black;
            this.btnPrintAllMV.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintAllMV.Image")));
            this.btnPrintAllMV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintAllMV.Location = new System.Drawing.Point(861, 105);
            this.btnPrintAllMV.Name = "btnPrintAllMV";
            this.btnPrintAllMV.Size = new System.Drawing.Size(110, 50);
            this.btnPrintAllMV.TabIndex = 67;
            this.btnPrintAllMV.TabStop = false;
            this.btnPrintAllMV.Text = "Print \r\nLetter size";
            this.btnPrintAllMV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintAllMV.UseVisualStyleBackColor = false;
            this.btnPrintAllMV.Click += new System.EventHandler(this.btnPrintAllMV_Click);
            // 
            // btnUpdateMV
            // 
            this.btnUpdateMV.BackColor = System.Drawing.Color.White;
            this.btnUpdateMV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMV.Enabled = false;
            this.btnUpdateMV.FlatAppearance.BorderSize = 0;
            this.btnUpdateMV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdateMV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnUpdateMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMV.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateMV.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateMV.Image")));
            this.btnUpdateMV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMV.Location = new System.Drawing.Point(199, 136);
            this.btnUpdateMV.Name = "btnUpdateMV";
            this.btnUpdateMV.Size = new System.Drawing.Size(97, 50);
            this.btnUpdateMV.TabIndex = 62;
            this.btnUpdateMV.TabStop = false;
            this.btnUpdateMV.Text = "&Update";
            this.btnUpdateMV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateMV.UseVisualStyleBackColor = false;
            this.btnUpdateMV.Click += new System.EventHandler(this.btnUpdateMV_Click);
            // 
            // btnClearMV
            // 
            this.btnClearMV.BackColor = System.Drawing.Color.White;
            this.btnClearMV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearMV.FlatAppearance.BorderSize = 0;
            this.btnClearMV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearMV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnClearMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMV.ForeColor = System.Drawing.Color.Black;
            this.btnClearMV.Image = ((System.Drawing.Image)(resources.GetObject("btnClearMV.Image")));
            this.btnClearMV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearMV.Location = new System.Drawing.Point(199, 191);
            this.btnClearMV.Name = "btnClearMV";
            this.btnClearMV.Size = new System.Drawing.Size(91, 50);
            this.btnClearMV.TabIndex = 63;
            this.btnClearMV.TabStop = false;
            this.btnClearMV.Text = "&Clear";
            this.btnClearMV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearMV.UseVisualStyleBackColor = false;
            this.btnClearMV.Click += new System.EventHandler(this.btnClearMV_Click);
            // 
            // btnDeleteMV
            // 
            this.btnDeleteMV.BackColor = System.Drawing.Color.White;
            this.btnDeleteMV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMV.Enabled = false;
            this.btnDeleteMV.FlatAppearance.BorderSize = 0;
            this.btnDeleteMV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteMV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnDeleteMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMV.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteMV.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMV.Image")));
            this.btnDeleteMV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMV.Location = new System.Drawing.Point(29, 191);
            this.btnDeleteMV.Name = "btnDeleteMV";
            this.btnDeleteMV.Size = new System.Drawing.Size(92, 50);
            this.btnDeleteMV.TabIndex = 64;
            this.btnDeleteMV.TabStop = false;
            this.btnDeleteMV.Text = "&Delete";
            this.btnDeleteMV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteMV.UseVisualStyleBackColor = false;
            this.btnDeleteMV.Click += new System.EventHandler(this.btnDeleteMV_Click);
            // 
            // btnSaveMV
            // 
            this.btnSaveMV.BackColor = System.Drawing.Color.White;
            this.btnSaveMV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveMV.FlatAppearance.BorderSize = 0;
            this.btnSaveMV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSaveMV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnSaveMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMV.ForeColor = System.Drawing.Color.Black;
            this.btnSaveMV.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveMV.Image")));
            this.btnSaveMV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveMV.Location = new System.Drawing.Point(29, 136);
            this.btnSaveMV.Name = "btnSaveMV";
            this.btnSaveMV.Size = new System.Drawing.Size(83, 50);
            this.btnSaveMV.TabIndex = 65;
            this.btnSaveMV.TabStop = false;
            this.btnSaveMV.Text = "&Save";
            this.btnSaveMV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveMV.UseVisualStyleBackColor = false;
            this.btnSaveMV.Click += new System.EventHandler(this.btnSaveMV_Click);
            // 
            // txtUnitMV
            // 
            this.txtUnitMV.BackColor = System.Drawing.Color.White;
            this.txtUnitMV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitMV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitMV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUnitMV.HintForeColor = System.Drawing.Color.Empty;
            this.txtUnitMV.HintText = "Unit";
            this.txtUnitMV.isPassword = false;
            this.txtUnitMV.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtUnitMV.LineIdleColor = System.Drawing.Color.Black;
            this.txtUnitMV.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtUnitMV.LineThickness = 1;
            this.txtUnitMV.Location = new System.Drawing.Point(246, 74);
            this.txtUnitMV.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitMV.Name = "txtUnitMV";
            this.txtUnitMV.Size = new System.Drawing.Size(50, 33);
            this.txtUnitMV.TabIndex = 2;
            this.txtUnitMV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNameMV
            // 
            this.txtNameMV.BackColor = System.Drawing.Color.White;
            this.txtNameMV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameMV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameMV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNameMV.HintForeColor = System.Drawing.Color.Empty;
            this.txtNameMV.HintText = "Name";
            this.txtNameMV.isPassword = false;
            this.txtNameMV.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtNameMV.LineIdleColor = System.Drawing.Color.Black;
            this.txtNameMV.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtNameMV.LineThickness = 1;
            this.txtNameMV.Location = new System.Drawing.Point(88, 74);
            this.txtNameMV.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameMV.Name = "txtNameMV";
            this.txtNameMV.Size = new System.Drawing.Size(150, 33);
            this.txtNameMV.TabIndex = 1;
            this.txtNameMV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSearchMV
            // 
            this.txtSearchMV.BackColor = System.Drawing.Color.White;
            this.txtSearchMV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchMV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchMV.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchMV.HintText = "Search";
            this.txtSearchMV.isPassword = false;
            this.txtSearchMV.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtSearchMV.LineIdleColor = System.Drawing.Color.Black;
            this.txtSearchMV.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtSearchMV.LineThickness = 1;
            this.txtSearchMV.Location = new System.Drawing.Point(6, 21);
            this.txtSearchMV.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchMV.Name = "txtSearchMV";
            this.txtSearchMV.Size = new System.Drawing.Size(838, 28);
            this.txtSearchMV.TabIndex = 58;
            this.txtSearchMV.TabStop = false;
            this.txtSearchMV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchMV.OnValueChanged += new System.EventHandler(this.txtSearchMV_OnValueChanged);
            this.txtSearchMV.Enter += new System.EventHandler(this.txtSearchMV_Enter);
            // 
            // lblItemsMV
            // 
            this.lblItemsMV.AutoSize = true;
            this.lblItemsMV.BackColor = System.Drawing.Color.White;
            this.lblItemsMV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsMV.ForeColor = System.Drawing.Color.Black;
            this.lblItemsMV.Location = new System.Drawing.Point(858, 339);
            this.lblItemsMV.Name = "lblItemsMV";
            this.lblItemsMV.Size = new System.Drawing.Size(65, 16);
            this.lblItemsMV.TabIndex = 13;
            this.lblItemsMV.Text = " R o w s :";
            // 
            // btnAddMV
            // 
            this.btnAddMV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMV.FlatAppearance.BorderSize = 0;
            this.btnAddMV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddMV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnAddMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMV.ForeColor = System.Drawing.Color.Black;
            this.btnAddMV.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMV.Image")));
            this.btnAddMV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMV.Location = new System.Drawing.Point(861, 57);
            this.btnAddMV.Name = "btnAddMV";
            this.btnAddMV.Size = new System.Drawing.Size(110, 40);
            this.btnAddMV.TabIndex = 68;
            this.btnAddMV.TabStop = false;
            this.btnAddMV.Text = "Add Equipment";
            this.btnAddMV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMV.UseVisualStyleBackColor = true;
            this.btnAddMV.Click += new System.EventHandler(this.btnAddMV_Click);
            // 
            // errorProviderEquipment
            // 
            this.errorProviderEquipment.ContainerControl = this;
            // 
            // cmbBoxEquipment
            // 
            this.cmbBoxEquipment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBoxEquipment.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxEquipment.FormattingEnabled = true;
            this.cmbBoxEquipment.Items.AddRange(new object[] {
            "Select Category (Equipment)",
            "Motorized Vehicle",
            "Generator Set",
            "Water Rescue Kit",
            "Extrication Kit",
            "Personal Protective Gear",
            "First Aid Kit & EMK",
            "Others",
            "All Equipment"});
            this.cmbBoxEquipment.Location = new System.Drawing.Point(9, 3);
            this.cmbBoxEquipment.Name = "cmbBoxEquipment";
            this.cmbBoxEquipment.Size = new System.Drawing.Size(290, 24);
            this.cmbBoxEquipment.TabIndex = 13;
            this.cmbBoxEquipment.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEquipment_SelectedIndexChanged);
            // 
            // pictureBoxEquipment
            // 
            this.pictureBoxEquipment.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEquipment.Image")));
            this.pictureBoxEquipment.Location = new System.Drawing.Point(3, 38);
            this.pictureBoxEquipment.Name = "pictureBoxEquipment";
            this.pictureBoxEquipment.Size = new System.Drawing.Size(978, 361);
            this.pictureBoxEquipment.TabIndex = 102;
            this.pictureBoxEquipment.TabStop = false;
            // 
            // groupBoxGeneratorSet
            // 
            this.groupBoxGeneratorSet.Controls.Add(this.dgvGeneratorSet);
            this.groupBoxGeneratorSet.Controls.Add(this.txtTotalItemsGenSet);
            this.groupBoxGeneratorSet.Controls.Add(this.txtIdGenSet);
            this.groupBoxGeneratorSet.Controls.Add(this.btnPrintAllGenSet);
            this.groupBoxGeneratorSet.Controls.Add(this.btnUpdateGenSet);
            this.groupBoxGeneratorSet.Controls.Add(this.btnClearGenSet);
            this.groupBoxGeneratorSet.Controls.Add(this.btnDeleteGenSet);
            this.groupBoxGeneratorSet.Controls.Add(this.btnSaveGenSet);
            this.groupBoxGeneratorSet.Controls.Add(this.txtUnitGenSet);
            this.groupBoxGeneratorSet.Controls.Add(this.txtNameGenSet);
            this.groupBoxGeneratorSet.Controls.Add(this.txtSearchGenSet);
            this.groupBoxGeneratorSet.Controls.Add(this.label1);
            this.groupBoxGeneratorSet.Controls.Add(this.btnAddGenSet);
            this.groupBoxGeneratorSet.Location = new System.Drawing.Point(3, 38);
            this.groupBoxGeneratorSet.Name = "groupBoxGeneratorSet";
            this.groupBoxGeneratorSet.Size = new System.Drawing.Size(1147, 356);
            this.groupBoxGeneratorSet.TabIndex = 110;
            this.groupBoxGeneratorSet.TabStop = false;
            this.groupBoxGeneratorSet.Text = "Generator Set";
            // 
            // dgvGeneratorSet
            // 
            this.dgvGeneratorSet.AllowUserToAddRows = false;
            this.dgvGeneratorSet.AllowUserToResizeColumns = false;
            this.dgvGeneratorSet.AllowUserToResizeRows = false;
            this.dgvGeneratorSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGeneratorSet.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGeneratorSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGeneratorSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGeneratorSet.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGeneratorSet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGeneratorSet.Location = new System.Drawing.Point(6, 57);
            this.dgvGeneratorSet.Name = "dgvGeneratorSet";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGeneratorSet.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGeneratorSet.Size = new System.Drawing.Size(838, 298);
            this.dgvGeneratorSet.TabIndex = 59;
            this.dgvGeneratorSet.TabStop = false;
            this.dgvGeneratorSet.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvGeneratorSet_RowsAdded);
            // 
            // txtTotalItemsGenSet
            // 
            this.txtTotalItemsGenSet.BackColor = System.Drawing.Color.White;
            this.txtTotalItemsGenSet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalItemsGenSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItemsGenSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalItemsGenSet.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotalItemsGenSet.HintText = "";
            this.txtTotalItemsGenSet.isPassword = false;
            this.txtTotalItemsGenSet.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalItemsGenSet.LineIdleColor = System.Drawing.Color.Black;
            this.txtTotalItemsGenSet.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtTotalItemsGenSet.LineThickness = 1;
            this.txtTotalItemsGenSet.Location = new System.Drawing.Point(912, 322);
            this.txtTotalItemsGenSet.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalItemsGenSet.Name = "txtTotalItemsGenSet";
            this.txtTotalItemsGenSet.Size = new System.Drawing.Size(59, 33);
            this.txtTotalItemsGenSet.TabIndex = 66;
            this.txtTotalItemsGenSet.TabStop = false;
            this.txtTotalItemsGenSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtIdGenSet
            // 
            this.txtIdGenSet.BackColor = System.Drawing.Color.White;
            this.txtIdGenSet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdGenSet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGenSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdGenSet.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdGenSet.HintText = "id";
            this.txtIdGenSet.isPassword = false;
            this.txtIdGenSet.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtIdGenSet.LineIdleColor = System.Drawing.Color.Black;
            this.txtIdGenSet.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtIdGenSet.LineThickness = 1;
            this.txtIdGenSet.Location = new System.Drawing.Point(29, 74);
            this.txtIdGenSet.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdGenSet.Name = "txtIdGenSet";
            this.txtIdGenSet.Size = new System.Drawing.Size(50, 33);
            this.txtIdGenSet.TabIndex = 100;
            this.txtIdGenSet.TabStop = false;
            this.txtIdGenSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPrintAllGenSet
            // 
            this.btnPrintAllGenSet.BackColor = System.Drawing.Color.White;
            this.btnPrintAllGenSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintAllGenSet.FlatAppearance.BorderSize = 0;
            this.btnPrintAllGenSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnPrintAllGenSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPrintAllGenSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAllGenSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAllGenSet.ForeColor = System.Drawing.Color.Black;
            this.btnPrintAllGenSet.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintAllGenSet.Image")));
            this.btnPrintAllGenSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintAllGenSet.Location = new System.Drawing.Point(861, 105);
            this.btnPrintAllGenSet.Name = "btnPrintAllGenSet";
            this.btnPrintAllGenSet.Size = new System.Drawing.Size(110, 50);
            this.btnPrintAllGenSet.TabIndex = 67;
            this.btnPrintAllGenSet.TabStop = false;
            this.btnPrintAllGenSet.Text = "Print \r\nLetter size";
            this.btnPrintAllGenSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintAllGenSet.UseVisualStyleBackColor = false;
            // 
            // btnUpdateGenSet
            // 
            this.btnUpdateGenSet.BackColor = System.Drawing.Color.White;
            this.btnUpdateGenSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateGenSet.Enabled = false;
            this.btnUpdateGenSet.FlatAppearance.BorderSize = 0;
            this.btnUpdateGenSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdateGenSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnUpdateGenSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGenSet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGenSet.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateGenSet.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateGenSet.Image")));
            this.btnUpdateGenSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateGenSet.Location = new System.Drawing.Point(199, 136);
            this.btnUpdateGenSet.Name = "btnUpdateGenSet";
            this.btnUpdateGenSet.Size = new System.Drawing.Size(97, 50);
            this.btnUpdateGenSet.TabIndex = 62;
            this.btnUpdateGenSet.TabStop = false;
            this.btnUpdateGenSet.Text = "&Update";
            this.btnUpdateGenSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateGenSet.UseVisualStyleBackColor = false;
            // 
            // btnClearGenSet
            // 
            this.btnClearGenSet.BackColor = System.Drawing.Color.White;
            this.btnClearGenSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearGenSet.FlatAppearance.BorderSize = 0;
            this.btnClearGenSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearGenSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnClearGenSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearGenSet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGenSet.ForeColor = System.Drawing.Color.Black;
            this.btnClearGenSet.Image = ((System.Drawing.Image)(resources.GetObject("btnClearGenSet.Image")));
            this.btnClearGenSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearGenSet.Location = new System.Drawing.Point(199, 191);
            this.btnClearGenSet.Name = "btnClearGenSet";
            this.btnClearGenSet.Size = new System.Drawing.Size(91, 50);
            this.btnClearGenSet.TabIndex = 63;
            this.btnClearGenSet.TabStop = false;
            this.btnClearGenSet.Text = "&Clear";
            this.btnClearGenSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearGenSet.UseVisualStyleBackColor = false;
            // 
            // btnDeleteGenSet
            // 
            this.btnDeleteGenSet.BackColor = System.Drawing.Color.White;
            this.btnDeleteGenSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGenSet.Enabled = false;
            this.btnDeleteGenSet.FlatAppearance.BorderSize = 0;
            this.btnDeleteGenSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteGenSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnDeleteGenSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGenSet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGenSet.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteGenSet.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteGenSet.Image")));
            this.btnDeleteGenSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteGenSet.Location = new System.Drawing.Point(29, 191);
            this.btnDeleteGenSet.Name = "btnDeleteGenSet";
            this.btnDeleteGenSet.Size = new System.Drawing.Size(92, 50);
            this.btnDeleteGenSet.TabIndex = 64;
            this.btnDeleteGenSet.TabStop = false;
            this.btnDeleteGenSet.Text = "&Delete";
            this.btnDeleteGenSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteGenSet.UseVisualStyleBackColor = false;
            // 
            // btnSaveGenSet
            // 
            this.btnSaveGenSet.BackColor = System.Drawing.Color.White;
            this.btnSaveGenSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveGenSet.FlatAppearance.BorderSize = 0;
            this.btnSaveGenSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSaveGenSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnSaveGenSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGenSet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGenSet.ForeColor = System.Drawing.Color.Black;
            this.btnSaveGenSet.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveGenSet.Image")));
            this.btnSaveGenSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveGenSet.Location = new System.Drawing.Point(29, 136);
            this.btnSaveGenSet.Name = "btnSaveGenSet";
            this.btnSaveGenSet.Size = new System.Drawing.Size(83, 50);
            this.btnSaveGenSet.TabIndex = 65;
            this.btnSaveGenSet.TabStop = false;
            this.btnSaveGenSet.Text = "&Save";
            this.btnSaveGenSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveGenSet.UseVisualStyleBackColor = false;
            // 
            // txtUnitGenSet
            // 
            this.txtUnitGenSet.BackColor = System.Drawing.Color.White;
            this.txtUnitGenSet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitGenSet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitGenSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUnitGenSet.HintForeColor = System.Drawing.Color.Empty;
            this.txtUnitGenSet.HintText = "Unit";
            this.txtUnitGenSet.isPassword = false;
            this.txtUnitGenSet.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtUnitGenSet.LineIdleColor = System.Drawing.Color.Black;
            this.txtUnitGenSet.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtUnitGenSet.LineThickness = 1;
            this.txtUnitGenSet.Location = new System.Drawing.Point(246, 74);
            this.txtUnitGenSet.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitGenSet.Name = "txtUnitGenSet";
            this.txtUnitGenSet.Size = new System.Drawing.Size(50, 33);
            this.txtUnitGenSet.TabIndex = 2;
            this.txtUnitGenSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNameGenSet
            // 
            this.txtNameGenSet.BackColor = System.Drawing.Color.White;
            this.txtNameGenSet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameGenSet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameGenSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNameGenSet.HintForeColor = System.Drawing.Color.Empty;
            this.txtNameGenSet.HintText = "Name";
            this.txtNameGenSet.isPassword = false;
            this.txtNameGenSet.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtNameGenSet.LineIdleColor = System.Drawing.Color.Black;
            this.txtNameGenSet.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtNameGenSet.LineThickness = 1;
            this.txtNameGenSet.Location = new System.Drawing.Point(88, 74);
            this.txtNameGenSet.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameGenSet.Name = "txtNameGenSet";
            this.txtNameGenSet.Size = new System.Drawing.Size(150, 33);
            this.txtNameGenSet.TabIndex = 1;
            this.txtNameGenSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSearchGenSet
            // 
            this.txtSearchGenSet.BackColor = System.Drawing.Color.White;
            this.txtSearchGenSet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchGenSet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchGenSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchGenSet.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchGenSet.HintText = "Search";
            this.txtSearchGenSet.isPassword = false;
            this.txtSearchGenSet.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtSearchGenSet.LineIdleColor = System.Drawing.Color.Black;
            this.txtSearchGenSet.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtSearchGenSet.LineThickness = 1;
            this.txtSearchGenSet.Location = new System.Drawing.Point(6, 21);
            this.txtSearchGenSet.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchGenSet.Name = "txtSearchGenSet";
            this.txtSearchGenSet.Size = new System.Drawing.Size(838, 28);
            this.txtSearchGenSet.TabIndex = 58;
            this.txtSearchGenSet.TabStop = false;
            this.txtSearchGenSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(858, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = " R o w s :";
            // 
            // btnAddGenSet
            // 
            this.btnAddGenSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGenSet.FlatAppearance.BorderSize = 0;
            this.btnAddGenSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddGenSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnAddGenSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGenSet.ForeColor = System.Drawing.Color.Black;
            this.btnAddGenSet.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGenSet.Image")));
            this.btnAddGenSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGenSet.Location = new System.Drawing.Point(861, 57);
            this.btnAddGenSet.Name = "btnAddGenSet";
            this.btnAddGenSet.Size = new System.Drawing.Size(110, 40);
            this.btnAddGenSet.TabIndex = 68;
            this.btnAddGenSet.TabStop = false;
            this.btnAddGenSet.Text = "Add Equipment";
            this.btnAddGenSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddGenSet.UseVisualStyleBackColor = true;
            // 
            // EquipmentCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxGeneratorSet);
            this.Controls.Add(this.cmbBoxEquipment);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBoxMotorizedVehicle);
            this.Controls.Add(this.pictureBoxEquipment);
            this.Name = "EquipmentCustomControl";
            this.Size = new System.Drawing.Size(1312, 527);
            this.groupBoxMotorizedVehicle.ResumeLayout(false);
            this.groupBoxMotorizedVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorizedVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquipment)).EndInit();
            this.groupBoxGeneratorSet.ResumeLayout(false);
            this.groupBoxGeneratorSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneratorSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBoxMotorizedVehicle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUnitMV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameMV;
        public System.Windows.Forms.DataGridView dgvMotorizedVehicle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchMV;
        private System.Windows.Forms.Button btnUpdateMV;
        private System.Windows.Forms.Button btnClearMV;
        private System.Windows.Forms.Button btnDeleteMV;
        private System.Windows.Forms.Button btnSaveMV;
        private System.Windows.Forms.Button btnPrintAllMV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotalItemsMV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIdMV;
        private System.Windows.Forms.Label lblItemsMV;
        private System.Windows.Forms.Button btnAddMV;
        private System.Windows.Forms.ErrorProvider errorProviderEquipment;
        public System.Windows.Forms.ComboBox cmbBoxEquipment;
        private System.Windows.Forms.PictureBox pictureBoxEquipment;
        private System.Windows.Forms.GroupBox groupBoxGeneratorSet;
        public System.Windows.Forms.DataGridView dgvGeneratorSet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotalItemsGenSet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIdGenSet;
        private System.Windows.Forms.Button btnPrintAllGenSet;
        private System.Windows.Forms.Button btnUpdateGenSet;
        private System.Windows.Forms.Button btnClearGenSet;
        private System.Windows.Forms.Button btnDeleteGenSet;
        private System.Windows.Forms.Button btnSaveGenSet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUnitGenSet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameGenSet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchGenSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddGenSet;
    }
}
