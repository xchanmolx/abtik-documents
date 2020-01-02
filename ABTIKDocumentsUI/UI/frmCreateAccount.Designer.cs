namespace ABTIKDocumentsUI.UI
{
    partial class frmCreateAccount
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAccount));
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerShutdown = new System.Windows.Forms.Timer(this.components);
            this.errorProviderCreateAccount = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pctrBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelHeaderABTIKLogo = new System.Windows.Forms.Panel();
            this.pctrBoxABTIKLogo = new System.Windows.Forms.PictureBox();
            this.lblABTIK = new System.Windows.Forms.Label();
            this.panelHeaderEMSLogo = new System.Windows.Forms.Panel();
            this.pctrBoxEMSLogo = new System.Windows.Forms.PictureBox();
            this.lblEMS = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.cmbBoxGender = new System.Windows.Forms.ComboBox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtContact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCreateAccount)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxLogo)).BeginInit();
            this.panelHeaderABTIKLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxABTIKLogo)).BeginInit();
            this.panelHeaderEMSLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxEMSLogo)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 25;
            this.bunifuElipse.TargetControl = this;
            // 
            // timerShutdown
            // 
            this.timerShutdown.Tick += new System.EventHandler(this.timerShutdown_Tick);
            // 
            // errorProviderCreateAccount
            // 
            this.errorProviderCreateAccount.ContainerControl = this;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.panelLeft.Controls.Add(this.panelHeaderEMSLogo);
            this.panelLeft.Controls.Add(this.panelHeaderABTIKLogo);
            this.panelLeft.Controls.Add(this.pctrBoxLogo);
            this.panelLeft.Controls.Add(this.lblHeader);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(294, 532);
            this.panelLeft.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(49, 121);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(200, 60);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = "Republic of the Philippines\r\n       Province of Cebu\r\nMunicipality of Aloguinsan";
            // 
            // pctrBoxLogo
            // 
            this.pctrBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxLogo.Image")));
            this.pctrBoxLogo.Location = new System.Drawing.Point(70, 6);
            this.pctrBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pctrBoxLogo.Name = "pctrBoxLogo";
            this.pctrBoxLogo.Size = new System.Drawing.Size(159, 118);
            this.pctrBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBoxLogo.TabIndex = 13;
            this.pctrBoxLogo.TabStop = false;
            // 
            // panelHeaderABTIKLogo
            // 
            this.panelHeaderABTIKLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.panelHeaderABTIKLogo.Controls.Add(this.pctrBoxABTIKLogo);
            this.panelHeaderABTIKLogo.Controls.Add(this.lblABTIK);
            this.panelHeaderABTIKLogo.Location = new System.Drawing.Point(70, 185);
            this.panelHeaderABTIKLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeaderABTIKLogo.Name = "panelHeaderABTIKLogo";
            this.panelHeaderABTIKLogo.Size = new System.Drawing.Size(159, 166);
            this.panelHeaderABTIKLogo.TabIndex = 15;
            // 
            // pctrBoxABTIKLogo
            // 
            this.pctrBoxABTIKLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxABTIKLogo.Image")));
            this.pctrBoxABTIKLogo.Location = new System.Drawing.Point(1, 16);
            this.pctrBoxABTIKLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pctrBoxABTIKLogo.Name = "pctrBoxABTIKLogo";
            this.pctrBoxABTIKLogo.Size = new System.Drawing.Size(159, 118);
            this.pctrBoxABTIKLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBoxABTIKLogo.TabIndex = 0;
            this.pctrBoxABTIKLogo.TabStop = false;
            // 
            // lblABTIK
            // 
            this.lblABTIK.AutoSize = true;
            this.lblABTIK.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABTIK.ForeColor = System.Drawing.Color.White;
            this.lblABTIK.Location = new System.Drawing.Point(37, 134);
            this.lblABTIK.Name = "lblABTIK";
            this.lblABTIK.Size = new System.Drawing.Size(87, 32);
            this.lblABTIK.TabIndex = 9;
            this.lblABTIK.Text = "ABTIK";
            // 
            // panelHeaderEMSLogo
            // 
            this.panelHeaderEMSLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.panelHeaderEMSLogo.Controls.Add(this.pctrBoxEMSLogo);
            this.panelHeaderEMSLogo.Controls.Add(this.lblEMS);
            this.panelHeaderEMSLogo.Location = new System.Drawing.Point(71, 359);
            this.panelHeaderEMSLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeaderEMSLogo.Name = "panelHeaderEMSLogo";
            this.panelHeaderEMSLogo.Size = new System.Drawing.Size(159, 166);
            this.panelHeaderEMSLogo.TabIndex = 16;
            // 
            // pctrBoxEMSLogo
            // 
            this.pctrBoxEMSLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctrBoxEMSLogo.Image")));
            this.pctrBoxEMSLogo.Location = new System.Drawing.Point(1, 16);
            this.pctrBoxEMSLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pctrBoxEMSLogo.Name = "pctrBoxEMSLogo";
            this.pctrBoxEMSLogo.Size = new System.Drawing.Size(159, 118);
            this.pctrBoxEMSLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBoxEMSLogo.TabIndex = 0;
            this.pctrBoxEMSLogo.TabStop = false;
            // 
            // lblEMS
            // 
            this.lblEMS.AutoSize = true;
            this.lblEMS.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMS.ForeColor = System.Drawing.Color.White;
            this.lblEMS.Location = new System.Drawing.Point(48, 133);
            this.lblEMS.Name = "lblEMS";
            this.lblEMS.Size = new System.Drawing.Size(67, 32);
            this.lblEMS.TabIndex = 7;
            this.lblEMS.Text = "EMS";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.btnCreateAccount);
            this.panelRight.Controls.Add(this.cmbBoxGender);
            this.panelRight.Controls.Add(this.txtAddress);
            this.panelRight.Controls.Add(this.txtContact);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.txtUsername);
            this.panelRight.Controls.Add(this.txtEmail);
            this.panelRight.Controls.Add(this.txtLastName);
            this.panelRight.Controls.Add(this.txtFirstName);
            this.panelRight.Controls.Add(this.btnShutdown);
            this.panelRight.Controls.Add(this.lblCreateAccount);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(294, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(318, 532);
            this.panelRight.TabIndex = 1;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(11, 481);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(270, 33);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.cmbBoxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxGender.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxGender.FormattingEnabled = true;
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Gender",
            "Male",
            "Female",
            "Not_Specified"});
            this.cmbBoxGender.Location = new System.Drawing.Point(11, 427);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(270, 24);
            this.cmbBoxGender.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "Address";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAddress.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtAddress.LineThickness = 3;
            this.txtAddress.Location = new System.Drawing.Point(11, 369);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(270, 33);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContact.HintForeColor = System.Drawing.Color.Empty;
            this.txtContact.HintText = "Mobile Number";
            this.txtContact.isPassword = false;
            this.txtContact.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtContact.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtContact.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtContact.LineThickness = 3;
            this.txtContact.Location = new System.Drawing.Point(11, 317);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(270, 33);
            this.txtContact.TabIndex = 5;
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(11, 265);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(270, 33);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "Username";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(11, 213);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(270, 33);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "Email";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(11, 161);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 33);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.HintForeColor = System.Drawing.Color.Empty;
            this.txtLastName.HintText = "Last Name";
            this.txtLastName.isPassword = false;
            this.txtLastName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtLastName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtLastName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtLastName.LineThickness = 3;
            this.txtLastName.Location = new System.Drawing.Point(11, 109);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(270, 33);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.HintForeColor = System.Drawing.Color.Empty;
            this.txtFirstName.HintText = "First Name";
            this.txtFirstName.isPassword = false;
            this.txtFirstName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtFirstName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtFirstName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.txtFirstName.LineThickness = 3;
            this.txtFirstName.Location = new System.Drawing.Point(11, 57);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(270, 33);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShutdown.FlatAppearance.BorderSize = 0;
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.Color.White;
            this.btnShutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdown.Image")));
            this.btnShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown.Location = new System.Drawing.Point(281, 2);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(37, 31);
            this.btnShutdown.TabIndex = 6;
            this.btnShutdown.TabStop = false;
            this.btnShutdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.lblCreateAccount.Location = new System.Drawing.Point(6, 9);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(206, 30);
            this.lblCreateAccount.TabIndex = 0;
            this.lblCreateAccount.Text = "Create Account";
            // 
            // frmCreateAccount
            // 
            this.AcceptButton = this.btnCreateAccount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnShutdown;
            this.ClientSize = new System.Drawing.Size(612, 532);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCreateAccount)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxLogo)).EndInit();
            this.panelHeaderABTIKLogo.ResumeLayout(false);
            this.panelHeaderABTIKLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxABTIKLogo)).EndInit();
            this.panelHeaderEMSLogo.ResumeLayout(false);
            this.panelHeaderEMSLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxEMSLogo)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pctrBoxLogo;
        private System.Windows.Forms.Timer timerShutdown;
        private System.Windows.Forms.ErrorProvider errorProviderCreateAccount;
        private System.Windows.Forms.Panel panelHeaderABTIKLogo;
        private System.Windows.Forms.PictureBox pctrBoxABTIKLogo;
        private System.Windows.Forms.Label lblABTIK;
        private System.Windows.Forms.Panel panelHeaderEMSLogo;
        private System.Windows.Forms.PictureBox pctrBoxEMSLogo;
        private System.Windows.Forms.Label lblEMS;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.ComboBox cmbBoxGender;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContact;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFirstName;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Label lblCreateAccount;
    }
}