namespace TMS.UI
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.lblChangeYourPwd = new System.Windows.Forms.Label();
            this.grpBoxChangePwd = new System.Windows.Forms.GroupBox();
            this.pnlOldPwd = new System.Windows.Forms.Panel();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.pbOldPwd = new System.Windows.Forms.PictureBox();
            this.pnlNewPwd = new System.Windows.Forms.Panel();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.pbNewPwd = new System.Windows.Forms.PictureBox();
            this.pnlConfirmPwd = new System.Windows.Forms.Panel();
            this.txtNewConfirmPwd = new System.Windows.Forms.TextBox();
            this.pbNewConfirmPwd = new System.Windows.Forms.PictureBox();
            this.pnlAccount.SuspendLayout();
            this.grpBoxChangePwd.SuspendLayout();
            this.pnlOldPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOldPwd)).BeginInit();
            this.pnlNewPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPwd)).BeginInit();
            this.pnlConfirmPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewConfirmPwd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.lblInstruction);
            this.pnlAccount.Controls.Add(this.btnChangePwd);
            this.pnlAccount.Controls.Add(this.lblChangeYourPwd);
            this.pnlAccount.Controls.Add(this.grpBoxChangePwd);
            this.pnlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccount.Location = new System.Drawing.Point(0, 0);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(1174, 505);
            this.pnlAccount.TabIndex = 11;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(359, 108);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(427, 16);
            this.lblInstruction.TabIndex = 13;
            this.lblInstruction.Text = "A strong password helps prevent unauthorized access to your software.";
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.btnChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePwd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePwd.ForeColor = System.Drawing.Color.White;
            this.btnChangePwd.Location = new System.Drawing.Point(649, 435);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(148, 35);
            this.btnChangePwd.TabIndex = 12;
            this.btnChangePwd.Text = "Change Password";
            this.btnChangePwd.UseVisualStyleBackColor = false;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // lblChangeYourPwd
            // 
            this.lblChangeYourPwd.AutoSize = true;
            this.lblChangeYourPwd.BackColor = System.Drawing.Color.White;
            this.lblChangeYourPwd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeYourPwd.ForeColor = System.Drawing.Color.Black;
            this.lblChangeYourPwd.Location = new System.Drawing.Point(357, 72);
            this.lblChangeYourPwd.Name = "lblChangeYourPwd";
            this.lblChangeYourPwd.Size = new System.Drawing.Size(248, 25);
            this.lblChangeYourPwd.TabIndex = 11;
            this.lblChangeYourPwd.Text = "Change Your Password";
            // 
            // grpBoxChangePwd
            // 
            this.grpBoxChangePwd.Controls.Add(this.pnlOldPwd);
            this.grpBoxChangePwd.Controls.Add(this.pnlNewPwd);
            this.grpBoxChangePwd.Controls.Add(this.pnlConfirmPwd);
            this.grpBoxChangePwd.Location = new System.Drawing.Point(334, 142);
            this.grpBoxChangePwd.Name = "grpBoxChangePwd";
            this.grpBoxChangePwd.Size = new System.Drawing.Size(476, 275);
            this.grpBoxChangePwd.TabIndex = 14;
            this.grpBoxChangePwd.TabStop = false;
            // 
            // pnlOldPwd
            // 
            this.pnlOldPwd.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOldPwd.Controls.Add(this.txtOldPwd);
            this.pnlOldPwd.Controls.Add(this.pbOldPwd);
            this.pnlOldPwd.Location = new System.Drawing.Point(13, 19);
            this.pnlOldPwd.Name = "pnlOldPwd";
            this.pnlOldPwd.Size = new System.Drawing.Size(450, 48);
            this.pnlOldPwd.TabIndex = 6;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.BackColor = System.Drawing.SystemColors.Control;
            this.txtOldPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldPwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.txtOldPwd.Location = new System.Drawing.Point(55, 11);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(370, 20);
            this.txtOldPwd.TabIndex = 6;
            this.txtOldPwd.Text = "Type your old Password";
            this.txtOldPwd.MouseEnter += new System.EventHandler(this.txtOldPwd_MouseEnter);
            this.txtOldPwd.MouseLeave += new System.EventHandler(this.txtOldPwd_MouseLeave);
            // 
            // pbOldPwd
            // 
            this.pbOldPwd.Image = ((System.Drawing.Image)(resources.GetObject("pbOldPwd.Image")));
            this.pbOldPwd.Location = new System.Drawing.Point(7, 5);
            this.pbOldPwd.Name = "pbOldPwd";
            this.pbOldPwd.Size = new System.Drawing.Size(38, 38);
            this.pbOldPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOldPwd.TabIndex = 5;
            this.pbOldPwd.TabStop = false;
            this.pbOldPwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picOldPwd_MouseDown);
            this.pbOldPwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picOldPwd_MouseUp);
            // 
            // pnlNewPwd
            // 
            this.pnlNewPwd.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNewPwd.Controls.Add(this.txtNewPwd);
            this.pnlNewPwd.Controls.Add(this.pbNewPwd);
            this.pnlNewPwd.Location = new System.Drawing.Point(13, 106);
            this.pnlNewPwd.Name = "pnlNewPwd";
            this.pnlNewPwd.Size = new System.Drawing.Size(450, 48);
            this.pnlNewPwd.TabIndex = 7;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.txtNewPwd.Location = new System.Drawing.Point(55, 11);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(370, 20);
            this.txtNewPwd.TabIndex = 6;
            this.txtNewPwd.Text = "Type your New Password";
            this.txtNewPwd.MouseEnter += new System.EventHandler(this.txtNewPwd_MouseEnter);
            this.txtNewPwd.MouseLeave += new System.EventHandler(this.txtNewPwd_MouseLeave);
            // 
            // pbNewPwd
            // 
            this.pbNewPwd.Image = ((System.Drawing.Image)(resources.GetObject("pbNewPwd.Image")));
            this.pbNewPwd.Location = new System.Drawing.Point(7, 5);
            this.pbNewPwd.Name = "pbNewPwd";
            this.pbNewPwd.Size = new System.Drawing.Size(38, 38);
            this.pbNewPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewPwd.TabIndex = 5;
            this.pbNewPwd.TabStop = false;
            this.pbNewPwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNewPwd_MouseDown);
            this.pbNewPwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNewPwd_MouseUp);
            // 
            // pnlConfirmPwd
            // 
            this.pnlConfirmPwd.BackColor = System.Drawing.SystemColors.Control;
            this.pnlConfirmPwd.Controls.Add(this.txtNewConfirmPwd);
            this.pnlConfirmPwd.Controls.Add(this.pbNewConfirmPwd);
            this.pnlConfirmPwd.Location = new System.Drawing.Point(13, 194);
            this.pnlConfirmPwd.Name = "pnlConfirmPwd";
            this.pnlConfirmPwd.Size = new System.Drawing.Size(450, 48);
            this.pnlConfirmPwd.TabIndex = 8;
            // 
            // txtNewConfirmPwd
            // 
            this.txtNewConfirmPwd.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewConfirmPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewConfirmPwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewConfirmPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.txtNewConfirmPwd.Location = new System.Drawing.Point(55, 11);
            this.txtNewConfirmPwd.Name = "txtNewConfirmPwd";
            this.txtNewConfirmPwd.Size = new System.Drawing.Size(370, 20);
            this.txtNewConfirmPwd.TabIndex = 6;
            this.txtNewConfirmPwd.Text = "Type your Confirm Password";
            this.txtNewConfirmPwd.MouseEnter += new System.EventHandler(this.txtNewConfirmPwd_MouseEnter);
            this.txtNewConfirmPwd.MouseLeave += new System.EventHandler(this.txtNewConfirmPwd_MouseLeave);
            // 
            // pbNewConfirmPwd
            // 
            this.pbNewConfirmPwd.Image = ((System.Drawing.Image)(resources.GetObject("pbNewConfirmPwd.Image")));
            this.pbNewConfirmPwd.Location = new System.Drawing.Point(7, 5);
            this.pbNewConfirmPwd.Name = "pbNewConfirmPwd";
            this.pbNewConfirmPwd.Size = new System.Drawing.Size(38, 38);
            this.pbNewConfirmPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewConfirmPwd.TabIndex = 5;
            this.pbNewConfirmPwd.TabStop = false;
            this.pbNewConfirmPwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNewConfirmPwd_MouseDown);
            this.pbNewConfirmPwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNewConfirmPwd_MouseUp);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 505);
            this.Controls.Add(this.pnlAccount);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.grpBoxChangePwd.ResumeLayout(false);
            this.pnlOldPwd.ResumeLayout(false);
            this.pnlOldPwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOldPwd)).EndInit();
            this.pnlNewPwd.ResumeLayout(false);
            this.pnlNewPwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPwd)).EndInit();
            this.pnlConfirmPwd.ResumeLayout(false);
            this.pnlConfirmPwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewConfirmPwd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.Label lblChangeYourPwd;
        private System.Windows.Forms.GroupBox grpBoxChangePwd;
        private System.Windows.Forms.Panel pnlOldPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.PictureBox pbOldPwd;
        private System.Windows.Forms.Panel pnlNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.PictureBox pbNewPwd;
        private System.Windows.Forms.Panel pnlConfirmPwd;
        private System.Windows.Forms.TextBox txtNewConfirmPwd;
        private System.Windows.Forms.PictureBox pbNewConfirmPwd;
    }
}