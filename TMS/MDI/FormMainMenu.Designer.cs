namespace TMS.MDI
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picemp = new TMS.UI.Utilities.RoundPictureBox();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblWelCome = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.Menubutton = new System.Windows.Forms.PictureBox();
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.panelTC = new System.Windows.Forms.Panel();
            this.btnGroupTask = new System.Windows.Forms.Button();
            this.panelTS = new System.Windows.Forms.Panel();
            this.btnTeamRegister = new System.Windows.Forms.Button();
            this.HomeChildContainer = new System.Windows.Forms.Panel();
            this.btnMasterData = new System.Windows.Forms.Button();
            this.pnlmainworkitm = new System.Windows.Forms.Panel();
            this.btnAssignWorkItem = new System.Windows.Forms.Button();
            this.btnWorkItem = new System.Windows.Forms.Button();
            this.btnAssignTask = new System.Windows.Forms.Button();
            this.panelReportAnalysis = new System.Windows.Forms.Panel();
            this.btnTimeBasedReport = new System.Windows.Forms.Button();
            this.btnAssigneeBasedReport = new System.Windows.Forms.Button();
            this.btnStatusBasedReport = new System.Windows.Forms.Button();
            this.btnReportAnalysis = new System.Windows.Forms.Button();
            this.pnlmainsettings = new System.Windows.Forms.Panel();
            this.btnUpdatePwd = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelTS1 = new System.Windows.Forms.Panel();
            this.btnTaskSheet = new System.Windows.Forms.Button();
            this.panelTC1 = new System.Windows.Forms.Panel();
            this.btnTaskCalender = new System.Windows.Forms.Button();
            this.Sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.paneltitlebar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.ReportTimer = new System.Windows.Forms.Timer(this.components);
            this.SettingTimer = new System.Windows.Forms.Timer(this.components);
            this.WorkItemtimer = new System.Windows.Forms.Timer(this.components);
            this.Sidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menubutton)).BeginInit();
            this.HomeContainer.SuspendLayout();
            this.panelTC.SuspendLayout();
            this.panelTS.SuspendLayout();
            this.HomeChildContainer.SuspendLayout();
            this.pnlmainworkitm.SuspendLayout();
            this.panelReportAnalysis.SuspendLayout();
            this.pnlmainsettings.SuspendLayout();
            this.panelTS1.SuspendLayout();
            this.panelTC1.SuspendLayout();
            this.paneltitlebar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Sidebar.Controls.Add(this.panelLogo);
            this.Sidebar.Controls.Add(this.HomeContainer);
            this.Sidebar.Controls.Add(this.pnlmainworkitm);
            this.Sidebar.Controls.Add(this.panelReportAnalysis);
            this.Sidebar.Controls.Add(this.pnlmainsettings);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.MaximumSize = new System.Drawing.Size(245, 800);
            this.Sidebar.MinimumSize = new System.Drawing.Size(70, 800);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(245, 800);
            this.Sidebar.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picemp);
            this.panelLogo.Controls.Add(this.lblLogOut);
            this.panelLogo.Controls.Add(this.lblWelCome);
            this.panelLogo.Controls.Add(this.lblMenu);
            this.panelLogo.Controls.Add(this.Menubutton);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 140);
            this.panelLogo.TabIndex = 1;
            // 
            // picemp
            // 
            this.picemp.Location = new System.Drawing.Point(3, 6);
            this.picemp.Name = "picemp";
            this.picemp.Size = new System.Drawing.Size(59, 59);
            this.picemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picemp.TabIndex = 5;
            this.picemp.TabStop = false;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lblLogOut.Image")));
            this.lblLogOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblLogOut.Location = new System.Drawing.Point(68, 52);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(86, 21);
            this.lblLogOut.TabIndex = 5;
            this.lblLogOut.Text = "     Logout?";
            this.lblLogOut.Click += new System.EventHandler(this.lbllogout_Click);
            this.lblLogOut.MouseEnter += new System.EventHandler(this.lbllogout_MouseEnter);
            this.lblLogOut.MouseLeave += new System.EventHandler(this.lbllogout_MouseLeave);
            // 
            // lblWelCome
            // 
            this.lblWelCome.AutoSize = true;
            this.lblWelCome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWelCome.ForeColor = System.Drawing.Color.White;
            this.lblWelCome.Location = new System.Drawing.Point(68, 6);
            this.lblWelCome.Name = "lblWelCome";
            this.lblWelCome.Size = new System.Drawing.Size(52, 21);
            this.lblWelCome.TabIndex = 4;
            this.lblWelCome.Text = "label1";
            this.lblWelCome.MouseEnter += new System.EventHandler(this.lblwelcome_MouseEnter);
            this.lblWelCome.MouseLeave += new System.EventHandler(this.lblwelcome_MouseLeave);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(68, 104);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(50, 21);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu";
            this.lblMenu.MouseEnter += new System.EventHandler(this.labelmenu_MouseEnter);
            this.lblMenu.MouseLeave += new System.EventHandler(this.labelmenu_MouseLeave);
            // 
            // Menubutton
            // 
            this.Menubutton.Image = ((System.Drawing.Image)(resources.GetObject("Menubutton.Image")));
            this.Menubutton.Location = new System.Drawing.Point(4, 99);
            this.Menubutton.Name = "Menubutton";
            this.Menubutton.Size = new System.Drawing.Size(48, 30);
            this.Menubutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Menubutton.TabIndex = 1;
            this.Menubutton.TabStop = false;
            this.Menubutton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HomeContainer
            // 
            this.HomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.HomeContainer.Controls.Add(this.panelTC);
            this.HomeContainer.Controls.Add(this.panelTS);
            this.HomeContainer.Controls.Add(this.HomeChildContainer);
            this.HomeContainer.Location = new System.Drawing.Point(3, 149);
            this.HomeContainer.MaximumSize = new System.Drawing.Size(241, 143);
            this.HomeContainer.MinimumSize = new System.Drawing.Size(241, 56);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(241, 56);
            this.HomeContainer.TabIndex = 6;
            // 
            // panelTC
            // 
            this.panelTC.BackColor = System.Drawing.Color.White;
            this.panelTC.Controls.Add(this.btnGroupTask);
            this.panelTC.Location = new System.Drawing.Point(1, 93);
            this.panelTC.MaximumSize = new System.Drawing.Size(241, 92);
            this.panelTC.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelTC.Name = "panelTC";
            this.panelTC.Size = new System.Drawing.Size(241, 50);
            this.panelTC.TabIndex = 8;
            // 
            // btnGroupTask
            // 
            this.btnGroupTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnGroupTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupTask.ForeColor = System.Drawing.Color.White;
            this.btnGroupTask.Image = ((System.Drawing.Image)(resources.GetObject("btnGroupTask.Image")));
            this.btnGroupTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroupTask.Location = new System.Drawing.Point(-1, -1);
            this.btnGroupTask.Name = "btnGroupTask";
            this.btnGroupTask.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGroupTask.Size = new System.Drawing.Size(245, 57);
            this.btnGroupTask.TabIndex = 2;
            this.btnGroupTask.Text = "        Task Management";
            this.btnGroupTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroupTask.UseVisualStyleBackColor = false;
            this.btnGroupTask.Click += new System.EventHandler(this.btngrouptask_Click);
            // 
            // panelTS
            // 
            this.panelTS.BackColor = System.Drawing.Color.White;
            this.panelTS.Controls.Add(this.btnTeamRegister);
            this.panelTS.Location = new System.Drawing.Point(1, 55);
            this.panelTS.MaximumSize = new System.Drawing.Size(241, 92);
            this.panelTS.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelTS.Name = "panelTS";
            this.panelTS.Size = new System.Drawing.Size(241, 50);
            this.panelTS.TabIndex = 7;
            // 
            // btnTeamRegister
            // 
            this.btnTeamRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTeamRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeamRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamRegister.ForeColor = System.Drawing.Color.White;
            this.btnTeamRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnTeamRegister.Image")));
            this.btnTeamRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamRegister.Location = new System.Drawing.Point(-1, -4);
            this.btnTeamRegister.Name = "btnTeamRegister";
            this.btnTeamRegister.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTeamRegister.Size = new System.Drawing.Size(245, 57);
            this.btnTeamRegister.TabIndex = 2;
            this.btnTeamRegister.Text = "        Team Management";
            this.btnTeamRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamRegister.UseVisualStyleBackColor = false;
            this.btnTeamRegister.Click += new System.EventHandler(this.btnteamregister_Click);
            // 
            // HomeChildContainer
            // 
            this.HomeChildContainer.BackColor = System.Drawing.Color.White;
            this.HomeChildContainer.Controls.Add(this.btnMasterData);
            this.HomeChildContainer.Location = new System.Drawing.Point(1, 3);
            this.HomeChildContainer.MaximumSize = new System.Drawing.Size(241, 92);
            this.HomeChildContainer.MinimumSize = new System.Drawing.Size(241, 50);
            this.HomeChildContainer.Name = "HomeChildContainer";
            this.HomeChildContainer.Size = new System.Drawing.Size(241, 50);
            this.HomeChildContainer.TabIndex = 5;
            // 
            // btnMasterData
            // 
            this.btnMasterData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnMasterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterData.ForeColor = System.Drawing.Color.White;
            this.btnMasterData.Image = ((System.Drawing.Image)(resources.GetObject("btnMasterData.Image")));
            this.btnMasterData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterData.Location = new System.Drawing.Point(-1, -1);
            this.btnMasterData.Name = "btnMasterData";
            this.btnMasterData.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMasterData.Size = new System.Drawing.Size(243, 58);
            this.btnMasterData.TabIndex = 2;
            this.btnMasterData.Text = "        Master Data";
            this.btnMasterData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterData.UseVisualStyleBackColor = false;
            this.btnMasterData.Click += new System.EventHandler(this.btnmasterdata_Click);
            // 
            // pnlmainworkitm
            // 
            this.pnlmainworkitm.BackColor = System.Drawing.Color.White;
            this.pnlmainworkitm.Controls.Add(this.btnAssignWorkItem);
            this.pnlmainworkitm.Controls.Add(this.btnWorkItem);
            this.pnlmainworkitm.Controls.Add(this.btnAssignTask);
            this.pnlmainworkitm.ForeColor = System.Drawing.Color.White;
            this.pnlmainworkitm.Location = new System.Drawing.Point(3, 211);
            this.pnlmainworkitm.MaximumSize = new System.Drawing.Size(241, 170);
            this.pnlmainworkitm.MinimumSize = new System.Drawing.Size(241, 50);
            this.pnlmainworkitm.Name = "pnlmainworkitm";
            this.pnlmainworkitm.Size = new System.Drawing.Size(241, 50);
            this.pnlmainworkitm.TabIndex = 8;
            // 
            // btnAssignWorkItem
            // 
            this.btnAssignWorkItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAssignWorkItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignWorkItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignWorkItem.ForeColor = System.Drawing.Color.White;
            this.btnAssignWorkItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignWorkItem.Image")));
            this.btnAssignWorkItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignWorkItem.Location = new System.Drawing.Point(-1, 112);
            this.btnAssignWorkItem.Name = "btnAssignWorkItem";
            this.btnAssignWorkItem.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAssignWorkItem.Size = new System.Drawing.Size(243, 58);
            this.btnAssignWorkItem.TabIndex = 2;
            this.btnAssignWorkItem.Text = "        Assign WorkItem";
            this.btnAssignWorkItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignWorkItem.UseVisualStyleBackColor = false;
            this.btnAssignWorkItem.Click += new System.EventHandler(this.btnassignworkItem_Click);
            // 
            // btnWorkItem
            // 
            this.btnWorkItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnWorkItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkItem.ForeColor = System.Drawing.Color.White;
            this.btnWorkItem.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkItem.Image")));
            this.btnWorkItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkItem.Location = new System.Drawing.Point(-1, -1);
            this.btnWorkItem.Name = "btnWorkItem";
            this.btnWorkItem.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnWorkItem.Size = new System.Drawing.Size(243, 58);
            this.btnWorkItem.TabIndex = 2;
            this.btnWorkItem.Text = "        WorkItem";
            this.btnWorkItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkItem.UseVisualStyleBackColor = false;
            this.btnWorkItem.Click += new System.EventHandler(this.btnworkitem_Click);
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAssignTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTask.ForeColor = System.Drawing.Color.White;
            this.btnAssignTask.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignTask.Image")));
            this.btnAssignTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignTask.Location = new System.Drawing.Point(-1, 56);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAssignTask.Size = new System.Drawing.Size(243, 58);
            this.btnAssignTask.TabIndex = 2;
            this.btnAssignTask.Text = "        Create WorkItem";
            this.btnAssignTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignTask.UseVisualStyleBackColor = false;
            this.btnAssignTask.Click += new System.EventHandler(this.btnassigntask_Click);
            // 
            // panelReportAnalysis
            // 
            this.panelReportAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panelReportAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReportAnalysis.Controls.Add(this.btnTimeBasedReport);
            this.panelReportAnalysis.Controls.Add(this.btnAssigneeBasedReport);
            this.panelReportAnalysis.Controls.Add(this.btnStatusBasedReport);
            this.panelReportAnalysis.Controls.Add(this.btnReportAnalysis);
            this.panelReportAnalysis.Location = new System.Drawing.Point(3, 267);
            this.panelReportAnalysis.MaximumSize = new System.Drawing.Size(241, 219);
            this.panelReportAnalysis.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelReportAnalysis.Name = "panelReportAnalysis";
            this.panelReportAnalysis.Size = new System.Drawing.Size(241, 50);
            this.panelReportAnalysis.TabIndex = 7;
            // 
            // btnTimeBasedReport
            // 
            this.btnTimeBasedReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTimeBasedReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeBasedReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeBasedReport.ForeColor = System.Drawing.Color.White;
            this.btnTimeBasedReport.Image = ((System.Drawing.Image)(resources.GetObject("btnTimeBasedReport.Image")));
            this.btnTimeBasedReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeBasedReport.Location = new System.Drawing.Point(-1, 161);
            this.btnTimeBasedReport.Name = "btnTimeBasedReport";
            this.btnTimeBasedReport.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTimeBasedReport.Size = new System.Drawing.Size(245, 57);
            this.btnTimeBasedReport.TabIndex = 2;
            this.btnTimeBasedReport.Text = "        Time Based Report";
            this.btnTimeBasedReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeBasedReport.UseVisualStyleBackColor = false;
            this.btnTimeBasedReport.Click += new System.EventHandler(this.btnTimeBasedReport_Click);
            // 
            // btnAssigneeBasedReport
            // 
            this.btnAssigneeBasedReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnAssigneeBasedReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssigneeBasedReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssigneeBasedReport.ForeColor = System.Drawing.Color.White;
            this.btnAssigneeBasedReport.Image = ((System.Drawing.Image)(resources.GetObject("btnAssigneeBasedReport.Image")));
            this.btnAssigneeBasedReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssigneeBasedReport.Location = new System.Drawing.Point(-1, 105);
            this.btnAssigneeBasedReport.Name = "btnAssigneeBasedReport";
            this.btnAssigneeBasedReport.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAssigneeBasedReport.Size = new System.Drawing.Size(245, 57);
            this.btnAssigneeBasedReport.TabIndex = 2;
            this.btnAssigneeBasedReport.Text = "        Assignee Based Report";
            this.btnAssigneeBasedReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssigneeBasedReport.UseVisualStyleBackColor = false;
            this.btnAssigneeBasedReport.Click += new System.EventHandler(this.btnAssigneeBaseReport_Click);
            // 
            // btnStatusBasedReport
            // 
            this.btnStatusBasedReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnStatusBasedReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusBasedReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusBasedReport.ForeColor = System.Drawing.Color.White;
            this.btnStatusBasedReport.Image = ((System.Drawing.Image)(resources.GetObject("btnStatusBasedReport.Image")));
            this.btnStatusBasedReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatusBasedReport.Location = new System.Drawing.Point(-1, 50);
            this.btnStatusBasedReport.Name = "btnStatusBasedReport";
            this.btnStatusBasedReport.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnStatusBasedReport.Size = new System.Drawing.Size(245, 57);
            this.btnStatusBasedReport.TabIndex = 2;
            this.btnStatusBasedReport.Text = "        Status Based Report";
            this.btnStatusBasedReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatusBasedReport.UseVisualStyleBackColor = false;
            this.btnStatusBasedReport.Click += new System.EventHandler(this.btnstatusbasedreport_Click);
            // 
            // btnReportAnalysis
            // 
            this.btnReportAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnReportAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnReportAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("btnReportAnalysis.Image")));
            this.btnReportAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportAnalysis.Location = new System.Drawing.Point(-1, -1);
            this.btnReportAnalysis.Name = "btnReportAnalysis";
            this.btnReportAnalysis.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReportAnalysis.Size = new System.Drawing.Size(243, 58);
            this.btnReportAnalysis.TabIndex = 2;
            this.btnReportAnalysis.Text = "        Report Analysis";
            this.btnReportAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportAnalysis.UseVisualStyleBackColor = false;
            this.btnReportAnalysis.Click += new System.EventHandler(this.btnreportanalysis_Click);
            // 
            // pnlmainsettings
            // 
            this.pnlmainsettings.BackColor = System.Drawing.Color.White;
            this.pnlmainsettings.Controls.Add(this.btnUpdatePwd);
            this.pnlmainsettings.Controls.Add(this.btnSettings);
            this.pnlmainsettings.ForeColor = System.Drawing.Color.White;
            this.pnlmainsettings.Location = new System.Drawing.Point(3, 323);
            this.pnlmainsettings.MaximumSize = new System.Drawing.Size(241, 106);
            this.pnlmainsettings.MinimumSize = new System.Drawing.Size(241, 50);
            this.pnlmainsettings.Name = "pnlmainsettings";
            this.pnlmainsettings.Size = new System.Drawing.Size(241, 50);
            this.pnlmainsettings.TabIndex = 7;
            // 
            // btnUpdatePwd
            // 
            this.btnUpdatePwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnUpdatePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePwd.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePwd.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePwd.Image")));
            this.btnUpdatePwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePwd.Location = new System.Drawing.Point(0, 56);
            this.btnUpdatePwd.Name = "btnUpdatePwd";
            this.btnUpdatePwd.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUpdatePwd.Size = new System.Drawing.Size(245, 52);
            this.btnUpdatePwd.TabIndex = 2;
            this.btnUpdatePwd.Text = "        Change Password";
            this.btnUpdatePwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePwd.UseVisualStyleBackColor = false;
            this.btnUpdatePwd.Click += new System.EventHandler(this.btnupdatepwd_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(-1, -1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(243, 58);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "        Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelTS1
            // 
            this.panelTS1.Controls.Add(this.btnTaskSheet);
            this.panelTS1.Location = new System.Drawing.Point(513, 313);
            this.panelTS1.Name = "panelTS1";
            this.panelTS1.Size = new System.Drawing.Size(242, 37);
            this.panelTS1.TabIndex = 4;
            this.panelTS1.Visible = false;
            // 
            // btnTaskSheet
            // 
            this.btnTaskSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskSheet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskSheet.ForeColor = System.Drawing.Color.White;
            this.btnTaskSheet.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskSheet.Image")));
            this.btnTaskSheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaskSheet.Location = new System.Drawing.Point(-1, -8);
            this.btnTaskSheet.Name = "btnTaskSheet";
            this.btnTaskSheet.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTaskSheet.Size = new System.Drawing.Size(243, 58);
            this.btnTaskSheet.TabIndex = 2;
            this.btnTaskSheet.Text = "             Task Sheet";
            this.btnTaskSheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaskSheet.UseVisualStyleBackColor = true;
            // 
            // panelTC1
            // 
            this.panelTC1.Controls.Add(this.btnTaskCalender);
            this.panelTC1.Location = new System.Drawing.Point(513, 356);
            this.panelTC1.Name = "panelTC1";
            this.panelTC1.Size = new System.Drawing.Size(242, 37);
            this.panelTC1.TabIndex = 2;
            this.panelTC1.Visible = false;
            // 
            // btnTaskCalender
            // 
            this.btnTaskCalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskCalender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskCalender.ForeColor = System.Drawing.Color.White;
            this.btnTaskCalender.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskCalender.Image")));
            this.btnTaskCalender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaskCalender.Location = new System.Drawing.Point(-1, -8);
            this.btnTaskCalender.Name = "btnTaskCalender";
            this.btnTaskCalender.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTaskCalender.Size = new System.Drawing.Size(243, 58);
            this.btnTaskCalender.TabIndex = 2;
            this.btnTaskCalender.Text = "             Task Calender";
            this.btnTaskCalender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaskCalender.UseVisualStyleBackColor = true;
            // 
            // Sidebartimer
            // 
            this.Sidebartimer.Interval = 10;
            this.Sidebartimer.Tick += new System.EventHandler(this.Sidebartimer_Tick);
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.paneltitlebar.Controls.Add(this.btnMinimize);
            this.paneltitlebar.Controls.Add(this.btnMaximize);
            this.paneltitlebar.Controls.Add(this.btnClose);
            this.paneltitlebar.Controls.Add(this.btnCloseChildForm);
            this.paneltitlebar.Controls.Add(this.lblTitle);
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(245, 0);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(899, 65);
            this.paneltitlebar.TabIndex = 1;
            this.paneltitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitlebar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(811, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(844, 10);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(18, 15);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(866, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 65);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnclosechildform_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(333, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DASHBOARD";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.panelTS1);
            this.panelDesktopPanel.Controls.Add(this.panelTC1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(245, 65);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(899, 613);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 10;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // ReportTimer
            // 
            this.ReportTimer.Interval = 10;
            this.ReportTimer.Tick += new System.EventHandler(this.ReportTimer_Tick);
            // 
            // SettingTimer
            // 
            this.SettingTimer.Interval = 10;
            this.SettingTimer.Tick += new System.EventHandler(this.SettingTimer_Tick);
            // 
            // WorkItemtimer
            // 
            this.WorkItemtimer.Interval = 10;
            this.WorkItemtimer.Tick += new System.EventHandler(this.WorkITemtimer_Tick);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 678);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.Sidebar);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management System";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.Sidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menubutton)).EndInit();
            this.HomeContainer.ResumeLayout(false);
            this.panelTC.ResumeLayout(false);
            this.panelTS.ResumeLayout(false);
            this.HomeChildContainer.ResumeLayout(false);
            this.pnlmainworkitm.ResumeLayout(false);
            this.panelReportAnalysis.ResumeLayout(false);
            this.pnlmainsettings.ResumeLayout(false);
            this.panelTS1.ResumeLayout(false);
            this.panelTC1.ResumeLayout(false);
            this.paneltitlebar.ResumeLayout(false);
            this.paneltitlebar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnMasterData;
        private System.Windows.Forms.Panel panelTC1;
        private System.Windows.Forms.Button btnTaskCalender;
        private System.Windows.Forms.Panel panelTS1;
        private System.Windows.Forms.Button btnTaskSheet;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox Menubutton;
        private System.Windows.Forms.Timer Sidebartimer;
        private System.Windows.Forms.Panel paneltitlebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Panel panelTS;
        private System.Windows.Forms.Button btnTeamRegister;
        private System.Windows.Forms.Panel HomeChildContainer;
        private System.Windows.Forms.Panel panelTC;
        private System.Windows.Forms.Button btnGroupTask;
        private System.Windows.Forms.Panel panelReportAnalysis;
        private System.Windows.Forms.Button btnTimeBasedReport;
        private System.Windows.Forms.Button btnAssigneeBasedReport;
        private System.Windows.Forms.Button btnStatusBasedReport;
        private System.Windows.Forms.Button btnReportAnalysis;
        private System.Windows.Forms.Timer ReportTimer;
        private System.Windows.Forms.Label lblWelCome;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Panel pnlmainsettings;
        private System.Windows.Forms.Timer SettingTimer;
        private System.Windows.Forms.Button btnUpdatePwd;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAssignTask;
        private System.Windows.Forms.Panel pnlmainworkitm;
        private System.Windows.Forms.Button btnAssignWorkItem;
        private System.Windows.Forms.Button btnWorkItem;
        private System.Windows.Forms.Timer WorkItemtimer;
        private TMS.UI.Utilities.RoundPictureBox picemp;
    }
}