﻿namespace TMS.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlOuter = new System.Windows.Forms.Panel();
            this.lblTaskManagement = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbLoginIcon = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnForgotPwd = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlPwd = new System.Windows.Forms.Panel();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.pbPwdIcon = new System.Windows.Forms.PictureBox();
            this.pnlUsrName = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pbUsrNameIcon = new System.Windows.Forms.PictureBox();
            this.lblLoginToAccount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.timerLoginPage = new System.Windows.Forms.Timer(this.components);
            this.pnlOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwdIcon)).BeginInit();
            this.pnlUsrName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsrNameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.pnlOuter.Controls.Add(this.lblTaskManagement);
            this.pnlOuter.Controls.Add(this.lblSystem);
            this.pnlOuter.Controls.Add(this.lblWelcome);
            this.pnlOuter.Controls.Add(this.pbLoginIcon);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1125, 815);
            this.pnlOuter.TabIndex = 0;
            // 
            // lblTaskManagement
            // 
            this.lblTaskManagement.AutoSize = true;
            this.lblTaskManagement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskManagement.ForeColor = System.Drawing.Color.White;
            this.lblTaskManagement.Location = new System.Drawing.Point(105, 426);
            this.lblTaskManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskManagement.Name = "lblTaskManagement";
            this.lblTaskManagement.Size = new System.Drawing.Size(306, 39);
            this.lblTaskManagement.TabIndex = 2;
            this.lblTaskManagement.Text = "Task Management";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.White;
            this.lblSystem.Location = new System.Drawing.Point(285, 462);
            this.lblSystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(123, 39);
            this.lblSystem.TabIndex = 1;
            this.lblSystem.Text = "System";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(136, 395);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(276, 39);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the ";
            // 
            // pbLoginIcon
            // 
            this.pbLoginIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbLoginIcon.Image")));
            this.pbLoginIcon.Location = new System.Drawing.Point(76, 48);
            this.pbLoginIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbLoginIcon.Name = "pbLoginIcon";
            this.pbLoginIcon.Size = new System.Drawing.Size(292, 265);
            this.pbLoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoginIcon.TabIndex = 0;
            this.pbLoginIcon.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnForgotPwd);
            this.pnlMain.Controls.Add(this.btnLogin);
            this.pnlMain.Controls.Add(this.pnlPwd);
            this.pnlMain.Controls.Add(this.pnlUsrName);
            this.pnlMain.Controls.Add(this.lblLoginToAccount);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlMain.Location = new System.Drawing.Point(450, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(675, 815);
            this.pnlMain.TabIndex = 1;
            // 
            // btnForgotPwd
            // 
            this.btnForgotPwd.BackColor = System.Drawing.SystemColors.Control;
            this.btnForgotPwd.FlatAppearance.BorderSize = 0;
            this.btnForgotPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPwd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnForgotPwd.Location = new System.Drawing.Point(296, 494);
            this.btnForgotPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnForgotPwd.Name = "btnForgotPwd";
            this.btnForgotPwd.Size = new System.Drawing.Size(180, 38);
            this.btnForgotPwd.TabIndex = 5;
            this.btnForgotPwd.Text = "Forget Password ?";
            this.btnForgotPwd.UseVisualStyleBackColor = false;
            this.btnForgotPwd.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(51, 485);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(222, 54);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlPwd
            // 
            this.pnlPwd.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPwd.Controls.Add(this.txtPwd);
            this.pnlPwd.Controls.Add(this.pbPwdIcon);
            this.pnlPwd.Location = new System.Drawing.Point(-2, 365);
            this.pnlPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPwd.Name = "pnlPwd";
            this.pnlPwd.Size = new System.Drawing.Size(675, 74);
            this.pnlPwd.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.SystemColors.Control;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.txtPwd.Location = new System.Drawing.Point(82, 17);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(555, 30);
            this.txtPwd.TabIndex = 6;
            this.txtPwd.Text = "ashish@123";
            this.txtPwd.UseSystemPasswordChar = true;
            this.txtPwd.Click += new System.EventHandler(this.txtPwd_Click);
            // 
            // pbPwdIcon
            // 
            this.pbPwdIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbPwdIcon.Image")));
            this.pbPwdIcon.Location = new System.Drawing.Point(10, 8);
            this.pbPwdIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPwdIcon.Name = "pbPwdIcon";
            this.pbPwdIcon.Size = new System.Drawing.Size(57, 58);
            this.pbPwdIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPwdIcon.TabIndex = 5;
            this.pbPwdIcon.TabStop = false;
            this.pbPwdIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPwdIcon_MouseDown);
            this.pbPwdIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPwdIcon_MouseUp);
            // 
            // pnlUsrName
            // 
            this.pnlUsrName.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUsrName.Controls.Add(this.txtUserName);
            this.pnlUsrName.Controls.Add(this.pbUsrNameIcon);
            this.pnlUsrName.Location = new System.Drawing.Point(0, 285);
            this.pnlUsrName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlUsrName.Name = "pnlUsrName";
            this.pnlUsrName.Size = new System.Drawing.Size(674, 74);
            this.pnlUsrName.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.txtUserName.Location = new System.Drawing.Point(82, 20);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(555, 30);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Text = "ashish123";
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // pbUsrNameIcon
            // 
            this.pbUsrNameIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbUsrNameIcon.Image")));
            this.pbUsrNameIcon.Location = new System.Drawing.Point(9, 6);
            this.pbUsrNameIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbUsrNameIcon.Name = "pbUsrNameIcon";
            this.pbUsrNameIcon.Size = new System.Drawing.Size(57, 58);
            this.pbUsrNameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsrNameIcon.TabIndex = 4;
            this.pbUsrNameIcon.TabStop = false;
            // 
            // lblLoginToAccount
            // 
            this.lblLoginToAccount.AutoSize = true;
            this.lblLoginToAccount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginToAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.lblLoginToAccount.Location = new System.Drawing.Point(57, 189);
            this.lblLoginToAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginToAccount.Name = "lblLoginToAccount";
            this.lblLoginToAccount.Size = new System.Drawing.Size(353, 38);
            this.lblLoginToAccount.TabIndex = 1;
            this.lblLoginToAccount.Text = "Login to your account";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClose.Location = new System.Drawing.Point(609, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 815);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlOuter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlOuter.ResumeLayout(false);
            this.pnlOuter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginIcon)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlPwd.ResumeLayout(false);
            this.pnlPwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPwdIcon)).EndInit();
            this.pnlUsrName.ResumeLayout(false);
            this.pnlUsrName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsrNameIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.Label lblTaskManagement;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbLoginIcon;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlUsrName;
        private System.Windows.Forms.Label lblLoginToAccount;
        private System.Windows.Forms.Panel pnlPwd;
        private System.Windows.Forms.PictureBox pbPwdIcon;
        private System.Windows.Forms.PictureBox pbUsrNameIcon;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnForgotPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer timerLoginPage;
    }
}