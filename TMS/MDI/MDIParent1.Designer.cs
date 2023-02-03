namespace TMS.MDI
{
    partial class MDIMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskReportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskCalenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.taskReportingToolStripMenuItem,
            this.taskCalenderToolStripMenuItem,
            this.reportAnalysisToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(826, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamToolStripMenuItem,
            this.taskToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.adminToolStripMenuItem.Text = "Master Data";
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamRegistrationToolStripMenuItem,
            this.manageTeamToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskRegisterToolStripMenuItem,
            this.manageTaskToolStripMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // taskRegisterToolStripMenuItem
            // 
            this.taskRegisterToolStripMenuItem.Name = "taskRegisterToolStripMenuItem";
            this.taskRegisterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.taskRegisterToolStripMenuItem.Text = "Group Task";
            // 
            // manageTaskToolStripMenuItem
            // 
            this.manageTaskToolStripMenuItem.Name = "manageTaskToolStripMenuItem";
            this.manageTaskToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manageTaskToolStripMenuItem.Text = "Manage Task";
            // 
            // taskReportingToolStripMenuItem
            // 
            this.taskReportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskSheetToolStripMenuItem});
            this.taskReportingToolStripMenuItem.Name = "taskReportingToolStripMenuItem";
            this.taskReportingToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.taskReportingToolStripMenuItem.Text = "Task Sheet";
            // 
            // taskSheetToolStripMenuItem
            // 
            this.taskSheetToolStripMenuItem.Name = "taskSheetToolStripMenuItem";
            this.taskSheetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.taskSheetToolStripMenuItem.Text = "Task Sheet";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 555);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(826, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // taskCalenderToolStripMenuItem
            // 
            this.taskCalenderToolStripMenuItem.Name = "taskCalenderToolStripMenuItem";
            this.taskCalenderToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.taskCalenderToolStripMenuItem.Text = "Task Calender";
            // 
            // reportAnalysisToolStripMenuItem
            // 
            this.reportAnalysisToolStripMenuItem.Name = "reportAnalysisToolStripMenuItem";
            this.reportAnalysisToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.reportAnalysisToolStripMenuItem.Text = "Report & Analysis";
            // 
            // teamRegistrationToolStripMenuItem
            // 
            this.teamRegistrationToolStripMenuItem.Name = "teamRegistrationToolStripMenuItem";
            this.teamRegistrationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.teamRegistrationToolStripMenuItem.Text = "Team Registration";
            // 
            // manageTeamToolStripMenuItem
            // 
            this.manageTeamToolStripMenuItem.Name = "manageTeamToolStripMenuItem";
            this.manageTeamToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.manageTeamToolStripMenuItem.Text = "Manage Team";
            // 
            // MDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(826, 577);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIMain";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskReportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskCalenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTeamToolStripMenuItem;
    }
}



