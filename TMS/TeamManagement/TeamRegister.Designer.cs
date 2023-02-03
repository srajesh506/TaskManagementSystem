﻿namespace TMS.UI{
    partial class FrmTeamRegister
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpBoxEmployeeGridView = new System.Windows.Forms.GroupBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.grpBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpBoxRegistrationForm = new System.Windows.Forms.GroupBox();
            this.pbPwdIcon = new System.Windows.Forms.PictureBox();
            this.pbPic = new TMS.UI.Utilities.RoundPictureBox();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.rtxtRemark = new System.Windows.Forms.RichTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblReg = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.grpBoxEmployeeGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.grpBoxButtons.SuspendLayout();
            this.grpBoxRegistrationForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwdIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.grpBoxEmployeeGridView);
            this.pnlMain.Controls.Add(this.grpBoxButtons);
            this.pnlMain.Controls.Add(this.grpBoxRegistrationForm);
            this.pnlMain.Controls.Add(this.lblReg);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1084, 645);
            this.pnlMain.TabIndex = 0;
            // 
            // grpBoxEmployeeGridView
            // 
            this.grpBoxEmployeeGridView.BackColor = System.Drawing.Color.White;
            this.grpBoxEmployeeGridView.Controls.Add(this.dgView);
            this.grpBoxEmployeeGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxEmployeeGridView.Location = new System.Drawing.Point(6, 358);
            this.grpBoxEmployeeGridView.Name = "grpBoxEmployeeGridView";
            this.grpBoxEmployeeGridView.Size = new System.Drawing.Size(1066, 279);
            this.grpBoxEmployeeGridView.TabIndex = 14;
            this.grpBoxEmployeeGridView.TabStop = false;
            this.grpBoxEmployeeGridView.Text = "Existing Employee";
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(6, 30);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(1054, 243);
            this.dgView.TabIndex = 0;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // grpBoxButtons
            // 
            this.grpBoxButtons.Controls.Add(this.btnSave);
            this.grpBoxButtons.Controls.Add(this.btnModify);
            this.grpBoxButtons.Controls.Add(this.btnCancel);
            this.grpBoxButtons.Controls.Add(this.btnAdd);
            this.grpBoxButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxButtons.Location = new System.Drawing.Point(366, 311);
            this.grpBoxButtons.Name = "grpBoxButtons";
            this.grpBoxButtons.Size = new System.Drawing.Size(316, 48);
            this.grpBoxButtons.TabIndex = 13;
            this.grpBoxButtons.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(159, 11);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(72, 31);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 31);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 31);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpBoxRegistrationForm
            // 
            this.grpBoxRegistrationForm.Controls.Add(this.pbPwdIcon);
            this.grpBoxRegistrationForm.Controls.Add(this.pbPic);
            this.grpBoxRegistrationForm.Controls.Add(this.btnAddRole);
            this.grpBoxRegistrationForm.Controls.Add(this.cmbRole);
            this.grpBoxRegistrationForm.Controls.Add(this.btnUpload);
            this.grpBoxRegistrationForm.Controls.Add(this.chkActive);
            this.grpBoxRegistrationForm.Controls.Add(this.txtPwd);
            this.grpBoxRegistrationForm.Controls.Add(this.lblPwd);
            this.grpBoxRegistrationForm.Controls.Add(this.rtxtRemark);
            this.grpBoxRegistrationForm.Controls.Add(this.lblName);
            this.grpBoxRegistrationForm.Controls.Add(this.lblUserId);
            this.grpBoxRegistrationForm.Controls.Add(this.txtEmail);
            this.grpBoxRegistrationForm.Controls.Add(this.lblRole);
            this.grpBoxRegistrationForm.Controls.Add(this.lblEmail);
            this.grpBoxRegistrationForm.Controls.Add(this.txtName);
            this.grpBoxRegistrationForm.Controls.Add(this.lblRemark);
            this.grpBoxRegistrationForm.Controls.Add(this.txtUserId);
            this.grpBoxRegistrationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBoxRegistrationForm.Location = new System.Drawing.Point(6, 26);
            this.grpBoxRegistrationForm.Name = "grpBoxRegistrationForm";
            this.grpBoxRegistrationForm.Size = new System.Drawing.Size(1066, 283);
            this.grpBoxRegistrationForm.TabIndex = 11;
            this.grpBoxRegistrationForm.TabStop = false;
            this.grpBoxRegistrationForm.Text = "Employee Registeration Form";
            // 
            // pbPwdIcon
            // 
            this.pbPwdIcon.Image = global::TMS.Properties.Resources.hoverIcon;
            this.pbPwdIcon.Location = new System.Drawing.Point(768, 166);
            this.pbPwdIcon.Name = "pbPwdIcon";
            this.pbPwdIcon.Size = new System.Drawing.Size(25, 26);
            this.pbPwdIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPwdIcon.TabIndex = 19;
            this.pbPwdIcon.TabStop = false;
            this.pbPwdIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPwdIcon_MouseDown);
            this.pbPwdIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPwdIcon_MouseUp);
            // 
            // pbPic
            // 
            this.pbPic.Image = global::TMS.Properties.Resources.dp;
            this.pbPic.Location = new System.Drawing.Point(830, 45);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(146, 148);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic.TabIndex = 18;
            this.pbPic.TabStop = false;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(393, 166);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(30, 29);
            this.btnAddRole.TabIndex = 17;
            this.btnAddRole.Text = "+";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(164, 166);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(223, 29);
            this.cmbRole.TabIndex = 3;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(857, 215);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(109, 32);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(39, 228);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(69, 19);
            this.chkActive.TabIndex = 4;
            this.chkActive.Text = "Is Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPwd.Location = new System.Drawing.Point(543, 166);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(223, 27);
            this.txtPwd.TabIndex = 7;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblPwd.Location = new System.Drawing.Point(457, 166);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(80, 19);
            this.lblPwd.TabIndex = 11;
            this.lblPwd.Text = "&Password";
            // 
            // rtxtRemark
            // 
            this.rtxtRemark.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtxtRemark.Location = new System.Drawing.Point(543, 107);
            this.rtxtRemark.Name = "rtxtRemark";
            this.rtxtRemark.Size = new System.Drawing.Size(223, 49);
            this.rtxtRemark.TabIndex = 6;
            this.rtxtRemark.Text = "";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(35, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(35, 48);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(59, 19);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "&User Id";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEmail.Location = new System.Drawing.Point(543, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(35, 166);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 19);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Role";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(457, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 19);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtName.Location = new System.Drawing.Point(164, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 27);
            this.txtName.TabIndex = 2;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblRemark.Location = new System.Drawing.Point(457, 107);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(75, 19);
            this.lblRemark.TabIndex = 5;
            this.lblRemark.Text = "Remarks";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUserId.Location = new System.Drawing.Point(164, 45);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(223, 27);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserId_KeyPress);
            // 
            // lblReg
            // 
            this.lblReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.White;
            this.lblReg.Location = new System.Drawing.Point(1, 4);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(1086, 20);
            this.lblReg.TabIndex = 0;
            // 
            // FrmTeamRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 645);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmTeamRegister";
            this.Text = "Team Management";
            this.Load += new System.EventHandler(this.FrmTeamRegister_Load);
            this.pnlMain.ResumeLayout(false);
            this.grpBoxEmployeeGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.grpBoxButtons.ResumeLayout(false);
            this.grpBoxRegistrationForm.ResumeLayout(false);
            this.grpBoxRegistrationForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwdIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.GroupBox grpBoxButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpBoxRegistrationForm;
        private System.Windows.Forms.RichTextBox rtxtRemark;
        private System.Windows.Forms.GroupBox grpBoxEmployeeGridView;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnAddRole;
        private TMS.UI.Utilities.RoundPictureBox pbPic;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.PictureBox pbPwdIcon;
    }
}