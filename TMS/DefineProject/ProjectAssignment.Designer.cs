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
            this.grpBoxProjectAssignmentForm = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAssignedTeamMember = new System.Windows.Forms.Label();
            this.lblAvailableTeamMember = new System.Windows.Forms.Label();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.lstAssignedTeamMember = new System.Windows.Forms.ListBox();
            this.lstTeamMembers = new System.Windows.Forms.ListBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpBoxProjectAssignmentForm.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxProjectAssignmentForm
            // 
            this.grpBoxProjectAssignmentForm.Controls.Add(this.btnSave);
            this.grpBoxProjectAssignmentForm.Controls.Add(this.btnCancel);
            this.grpBoxProjectAssignmentForm.Controls.Add(this.lblAssignedTeamMember);
            this.grpBoxProjectAssignmentForm.Controls.Add(this.lblAvailableTeamMember);
            this.grpBoxProjectAssignmentForm.Controls.Add(this.btnRemoveItems);
            this.grpBoxProjectAssignmentForm.Controls.Add(this.btnAddItems);
            this.grpBoxProjectAssignmentForm.Controls.Add(this.lstAssignedTeamMember);
            this.grpBoxProjectAssignmentForm.Controls.Add(this.lstTeamMembers);
            this.grpBoxProjectAssignmentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBoxProjectAssignmentForm.Location = new System.Drawing.Point(9, 12);
            this.grpBoxProjectAssignmentForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxProjectAssignmentForm.Name = "grpBoxProjectAssignmentForm";
            this.grpBoxProjectAssignmentForm.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxProjectAssignmentForm.Size = new System.Drawing.Size(1599, 908);
            this.grpBoxProjectAssignmentForm.TabIndex = 11;
            this.grpBoxProjectAssignmentForm.TabStop = false;
            this.grpBoxProjectAssignmentForm.Text = "Project Assignment Form";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(898, 807);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 50);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(756, 807);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 50);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAssignedTeamMember
            // 
            this.lblAssignedTeamMember.AutoSize = true;
            this.lblAssignedTeamMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedTeamMember.Location = new System.Drawing.Point(897, 121);
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
            this.lblAvailableTeamMember.Location = new System.Drawing.Point(114, 121);
            this.lblAvailableTeamMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableTeamMember.Name = "lblAvailableTeamMember";
            this.lblAvailableTeamMember.Size = new System.Drawing.Size(310, 30);
            this.lblAvailableTeamMember.TabIndex = 12;
            this.lblAvailableTeamMember.Text = "&Available Team Member";
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.Location = new System.Drawing.Point(702, 437);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(159, 52);
            this.btnRemoveItems.TabIndex = 11;
            this.btnRemoveItems.Text = "<<";
            this.btnRemoveItems.UseVisualStyleBackColor = true;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddItems.Location = new System.Drawing.Point(702, 369);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(159, 52);
            this.btnAddItems.TabIndex = 10;
            this.btnAddItems.Text = ">>";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // lstAssignedTeamMember
            // 
            this.lstAssignedTeamMember.FormattingEnabled = true;
            this.lstAssignedTeamMember.ItemHeight = 29;
            this.lstAssignedTeamMember.Location = new System.Drawing.Point(898, 159);
            this.lstAssignedTeamMember.Name = "lstAssignedTeamMember";
            this.lstAssignedTeamMember.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAssignedTeamMember.Size = new System.Drawing.Size(554, 613);
            this.lstAssignedTeamMember.TabIndex = 9;
            // 
            // lstTeamMembers
            // 
            this.lstTeamMembers.FormattingEnabled = true;
            this.lstTeamMembers.ItemHeight = 29;
            this.lstTeamMembers.Location = new System.Drawing.Point(117, 159);
            this.lstTeamMembers.Name = "lstTeamMembers";
            this.lstTeamMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTeamMembers.Size = new System.Drawing.Size(554, 613);
            this.lstTeamMembers.TabIndex = 8;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.grpBoxProjectAssignmentForm);
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
            this.grpBoxProjectAssignmentForm.ResumeLayout(false);
            this.grpBoxProjectAssignmentForm.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxProjectAssignmentForm;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListBox lstTeamMembers;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.ListBox lstAssignedTeamMember;
        private System.Windows.Forms.Label lblAssignedTeamMember;
        private System.Windows.Forms.Label lblAvailableTeamMember;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}