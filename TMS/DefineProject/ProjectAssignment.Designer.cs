namespace TMS.UI{
    partial class ProjectAssignment
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
            this.grpBoxRegistrationForm = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArrowLeft = new System.Windows.Forms.Button();
            this.btnArrowRight = new System.Windows.Forms.Button();
            this.lstAssignedTeamMember = new System.Windows.Forms.ListBox();
            this.lstTeamMembers = new System.Windows.Forms.ListBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpBoxRegistrationForm.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxRegistrationForm
            // 
            this.grpBoxRegistrationForm.Controls.Add(this.label2);
            this.grpBoxRegistrationForm.Controls.Add(this.label1);
            this.grpBoxRegistrationForm.Controls.Add(this.btnArrowLeft);
            this.grpBoxRegistrationForm.Controls.Add(this.btnArrowRight);
            this.grpBoxRegistrationForm.Controls.Add(this.lstAssignedTeamMember);
            this.grpBoxRegistrationForm.Controls.Add(this.lstTeamMembers);
            this.grpBoxRegistrationForm.Controls.Add(this.cmbProject);
            this.grpBoxRegistrationForm.Controls.Add(this.lblProject);
            this.grpBoxRegistrationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBoxRegistrationForm.Location = new System.Drawing.Point(9, 12);
            this.grpBoxRegistrationForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxRegistrationForm.Name = "grpBoxRegistrationForm";
            this.grpBoxRegistrationForm.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxRegistrationForm.Size = new System.Drawing.Size(1599, 908);
            this.grpBoxRegistrationForm.TabIndex = 11;
            this.grpBoxRegistrationForm.TabStop = false;
            this.grpBoxRegistrationForm.Text = "Project Assignment Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(942, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "&Assigned Team Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "&Available Team Member";
            // 
            // btnArrowLeft
            // 
            this.btnArrowLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrowLeft.Location = new System.Drawing.Point(812, 558);
            this.btnArrowLeft.Name = "btnArrowLeft";
            this.btnArrowLeft.Size = new System.Drawing.Size(73, 52);
            this.btnArrowLeft.TabIndex = 11;
            this.btnArrowLeft.Text = "<<";
            this.btnArrowLeft.UseVisualStyleBackColor = true;
            this.btnArrowLeft.Click += new System.EventHandler(this.btnArrowLeft_Click);
            // 
            // btnArrowRight
            // 
            this.btnArrowRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnArrowRight.Location = new System.Drawing.Point(812, 480);
            this.btnArrowRight.Name = "btnArrowRight";
            this.btnArrowRight.Size = new System.Drawing.Size(73, 52);
            this.btnArrowRight.TabIndex = 10;
            this.btnArrowRight.Text = ">>";
            this.btnArrowRight.UseVisualStyleBackColor = true;
            this.btnArrowRight.Click += new System.EventHandler(this.btnArrowRight_Click);
            // 
            // lstAssignedTeamMember
            // 
            this.lstAssignedTeamMember.FormattingEnabled = true;
            this.lstAssignedTeamMember.ItemHeight = 29;
            this.lstAssignedTeamMember.Location = new System.Drawing.Point(947, 221);
            this.lstAssignedTeamMember.Name = "lstAssignedTeamMember";
            this.lstAssignedTeamMember.Size = new System.Drawing.Size(554, 613);
            this.lstAssignedTeamMember.TabIndex = 9;
            // 
            // lstTeamMembers
            // 
            this.lstTeamMembers.FormattingEnabled = true;
            this.lstTeamMembers.ItemHeight = 29;
            this.lstTeamMembers.Location = new System.Drawing.Point(208, 221);
            this.lstTeamMembers.Name = "lstTeamMembers";
            this.lstTeamMembers.Size = new System.Drawing.Size(554, 613);
            this.lstTeamMembers.TabIndex = 8;
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(710, 46);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(332, 38);
            this.cmbProject.TabIndex = 7;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(555, 46);
            this.lblProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(91, 28);
            this.lblProject.TabIndex = 1;
            this.lblProject.Text = "&Project";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.grpBoxRegistrationForm);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1626, 939);
            this.pnlMain.TabIndex = 0;
            // 
            // ProjectAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 939);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProjectAssignment";
            this.Text = "Project Assignment";
            this.Load += new System.EventHandler(this.ProjectAssignment_Load);
            this.grpBoxRegistrationForm.ResumeLayout(false);
            this.grpBoxRegistrationForm.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxRegistrationForm;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListBox lstTeamMembers;
        private System.Windows.Forms.Button btnArrowLeft;
        private System.Windows.Forms.Button btnArrowRight;
        private System.Windows.Forms.ListBox lstAssignedTeamMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}