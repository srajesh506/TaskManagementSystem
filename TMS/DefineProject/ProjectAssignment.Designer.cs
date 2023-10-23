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
            this.lblAssignedTeamMember = new System.Windows.Forms.Label();
            this.lblAvailableTeamMember = new System.Windows.Forms.Label();
            this.btnArrowLeft = new System.Windows.Forms.Button();
            this.btnArrowRight = new System.Windows.Forms.Button();
            this.lstAssignedTeamMember = new System.Windows.Forms.ListBox();
            this.lstTeamMembers = new System.Windows.Forms.ListBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpBoxRegistrationForm.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxRegistrationForm
            // 
            this.grpBoxRegistrationForm.Controls.Add(this.lblAssignedTeamMember);
            this.grpBoxRegistrationForm.Controls.Add(this.lblAvailableTeamMember);
            this.grpBoxRegistrationForm.Controls.Add(this.btnArrowLeft);
            this.grpBoxRegistrationForm.Controls.Add(this.btnArrowRight);
            this.grpBoxRegistrationForm.Controls.Add(this.lstAssignedTeamMember);
            this.grpBoxRegistrationForm.Controls.Add(this.lstTeamMembers);
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
            // lblAssignedTeamMember
            // 
            this.lblAssignedTeamMember.AutoSize = true;
            this.lblAssignedTeamMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedTeamMember.Location = new System.Drawing.Point(942, 121);
            this.lblAssignedTeamMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignedTeamMember.Name = "lblAssignedTeamMember";
            this.lblAssignedTeamMember.Size = new System.Drawing.Size(302, 30);
            this.lblAssignedTeamMember.TabIndex = 13;
            this.lblAssignedTeamMember.Text = "&Assigned Team Member";
            // 
            // lblAvailableTeamMember
            // 
            this.lblAvailableTeamMember.AutoSize = true;
            this.lblAvailableTeamMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableTeamMember.Location = new System.Drawing.Point(203, 121);
            this.lblAvailableTeamMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableTeamMember.Name = "lblAvailableTeamMember";
            this.lblAvailableTeamMember.Size = new System.Drawing.Size(310, 30);
            this.lblAvailableTeamMember.TabIndex = 12;
            this.lblAvailableTeamMember.Text = "&Available Team Member";
            // 
            // btnArrowLeft
            // 
            this.btnArrowLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrowLeft.Location = new System.Drawing.Point(812, 496);
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
            this.btnArrowRight.Location = new System.Drawing.Point(812, 418);
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
            this.lstAssignedTeamMember.Location = new System.Drawing.Point(947, 159);
            this.lstAssignedTeamMember.Name = "lstAssignedTeamMember";
            this.lstAssignedTeamMember.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAssignedTeamMember.Size = new System.Drawing.Size(554, 613);
            this.lstAssignedTeamMember.TabIndex = 9;
            // 
            // lstTeamMembers
            // 
            this.lstTeamMembers.FormattingEnabled = true;
            this.lstTeamMembers.ItemHeight = 29;
            this.lstTeamMembers.Location = new System.Drawing.Point(208, 159);
            this.lstTeamMembers.Name = "lstTeamMembers";
            this.lstTeamMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTeamMembers.Size = new System.Drawing.Size(554, 613);
            this.lstTeamMembers.TabIndex = 8;
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
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListBox lstTeamMembers;
        private System.Windows.Forms.Button btnArrowLeft;
        private System.Windows.Forms.Button btnArrowRight;
        private System.Windows.Forms.ListBox lstAssignedTeamMember;
        private System.Windows.Forms.Label lblAssignedTeamMember;
        private System.Windows.Forms.Label lblAvailableTeamMember;
    }
}