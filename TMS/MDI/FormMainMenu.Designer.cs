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
            this.lbllogout = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lblmenu = new System.Windows.Forms.Label();
            this.Menubutton = new System.Windows.Forms.PictureBox();
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.panelTC = new System.Windows.Forms.Panel();
            this.btngrouptask = new System.Windows.Forms.Button();
            this.panelTS = new System.Windows.Forms.Panel();
            this.btnteamregister = new System.Windows.Forms.Button();
            this.HomeChildContainer = new System.Windows.Forms.Panel();
            this.btnmasterdata = new System.Windows.Forms.Button();
            this.pnlmainworkitm = new System.Windows.Forms.Panel();
            this.btnassignworkItem = new System.Windows.Forms.Button();
            this.btnworkitem = new System.Windows.Forms.Button();
            this.btnassigntask = new System.Windows.Forms.Button();
            this.panelReportAnalysis = new System.Windows.Forms.Panel();
            this.btnTimeBasedReport = new System.Windows.Forms.Button();
            this.btnAssigneeBasedReport = new System.Windows.Forms.Button();
            this.btnstatusbasedreport = new System.Windows.Forms.Button();
            this.btnreportanalysis = new System.Windows.Forms.Button();
            this.pnlmainsettings = new System.Windows.Forms.Panel();
            this.btnupdatepwd = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelTS1 = new System.Windows.Forms.Panel();
            this.btntasksheet = new System.Windows.Forms.Button();
            this.panelTC1 = new System.Windows.Forms.Panel();
            this.btntaskcalender = new System.Windows.Forms.Button();
            this.Sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.paneltitlebar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnclosechildform = new System.Windows.Forms.Button();
            this.labeltitle = new System.Windows.Forms.Label();
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
            this.panelLogo.Controls.Add(this.lbllogout);
            this.panelLogo.Controls.Add(this.lblwelcome);
            this.panelLogo.Controls.Add(this.lblmenu);
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
            // lbllogout
            // 
            this.lbllogout.AutoSize = true;
            this.lbllogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbllogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogout.ForeColor = System.Drawing.Color.White;
            this.lbllogout.Image = ((System.Drawing.Image)(resources.GetObject("lbllogout.Image")));
            this.lbllogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbllogout.Location = new System.Drawing.Point(68, 52);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(86, 21);
            this.lbllogout.TabIndex = 5;
            this.lbllogout.Text = "     Logout?";
            this.lbllogout.Click += new System.EventHandler(this.lbllogout_Click);
            this.lbllogout.MouseEnter += new System.EventHandler(this.lbllogout_MouseEnter);
            this.lbllogout.MouseLeave += new System.EventHandler(this.lbllogout_MouseLeave);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(68, 6);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(52, 21);
            this.lblwelcome.TabIndex = 4;
            this.lblwelcome.Text = "label1";
            this.lblwelcome.MouseEnter += new System.EventHandler(this.lblwelcome_MouseEnter);
            this.lblwelcome.MouseLeave += new System.EventHandler(this.lblwelcome_MouseLeave);
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblmenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenu.ForeColor = System.Drawing.Color.White;
            this.lblmenu.Location = new System.Drawing.Point(68, 104);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(50, 21);
            this.lblmenu.TabIndex = 2;
            this.lblmenu.Text = "Menu";
            this.lblmenu.MouseEnter += new System.EventHandler(this.labelmenu_MouseEnter);
            this.lblmenu.MouseLeave += new System.EventHandler(this.labelmenu_MouseLeave);
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
            this.panelTC.Controls.Add(this.btngrouptask);
            this.panelTC.Location = new System.Drawing.Point(1, 93);
            this.panelTC.MaximumSize = new System.Drawing.Size(241, 92);
            this.panelTC.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelTC.Name = "panelTC";
            this.panelTC.Size = new System.Drawing.Size(241, 50);
            this.panelTC.TabIndex = 8;
            // 
            // btngrouptask
            // 
            this.btngrouptask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btngrouptask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrouptask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrouptask.ForeColor = System.Drawing.Color.White;
            this.btngrouptask.Image = ((System.Drawing.Image)(resources.GetObject("btngrouptask.Image")));
            this.btngrouptask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrouptask.Location = new System.Drawing.Point(-1, -1);
            this.btngrouptask.Name = "btngrouptask";
            this.btngrouptask.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btngrouptask.Size = new System.Drawing.Size(245, 57);
            this.btngrouptask.TabIndex = 2;
            this.btngrouptask.Text = "        Task Management";
            this.btngrouptask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrouptask.UseVisualStyleBackColor = false;
            this.btngrouptask.Click += new System.EventHandler(this.btngrouptask_Click);
            // 
            // panelTS
            // 
            this.panelTS.BackColor = System.Drawing.Color.White;
            this.panelTS.Controls.Add(this.btnteamregister);
            this.panelTS.Location = new System.Drawing.Point(1, 55);
            this.panelTS.MaximumSize = new System.Drawing.Size(241, 92);
            this.panelTS.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelTS.Name = "panelTS";
            this.panelTS.Size = new System.Drawing.Size(241, 50);
            this.panelTS.TabIndex = 7;
            // 
            // btnteamregister
            // 
            this.btnteamregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnteamregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnteamregister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteamregister.ForeColor = System.Drawing.Color.White;
            this.btnteamregister.Image = ((System.Drawing.Image)(resources.GetObject("btnteamregister.Image")));
            this.btnteamregister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteamregister.Location = new System.Drawing.Point(-1, -4);
            this.btnteamregister.Name = "btnteamregister";
            this.btnteamregister.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnteamregister.Size = new System.Drawing.Size(245, 57);
            this.btnteamregister.TabIndex = 2;
            this.btnteamregister.Text = "        Team Management";
            this.btnteamregister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteamregister.UseVisualStyleBackColor = false;
            this.btnteamregister.Click += new System.EventHandler(this.btnteamregister_Click);
            // 
            // HomeChildContainer
            // 
            this.HomeChildContainer.BackColor = System.Drawing.Color.White;
            this.HomeChildContainer.Controls.Add(this.btnmasterdata);
            this.HomeChildContainer.Location = new System.Drawing.Point(1, 3);
            this.HomeChildContainer.MaximumSize = new System.Drawing.Size(241, 92);
            this.HomeChildContainer.MinimumSize = new System.Drawing.Size(241, 50);
            this.HomeChildContainer.Name = "HomeChildContainer";
            this.HomeChildContainer.Size = new System.Drawing.Size(241, 50);
            this.HomeChildContainer.TabIndex = 5;
            // 
            // btnmasterdata
            // 
            this.btnmasterdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnmasterdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmasterdata.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmasterdata.ForeColor = System.Drawing.Color.White;
            this.btnmasterdata.Image = ((System.Drawing.Image)(resources.GetObject("btnmasterdata.Image")));
            this.btnmasterdata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmasterdata.Location = new System.Drawing.Point(-1, -1);
            this.btnmasterdata.Name = "btnmasterdata";
            this.btnmasterdata.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnmasterdata.Size = new System.Drawing.Size(243, 58);
            this.btnmasterdata.TabIndex = 2;
            this.btnmasterdata.Text = "        Master Data";
            this.btnmasterdata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmasterdata.UseVisualStyleBackColor = false;
            this.btnmasterdata.Click += new System.EventHandler(this.btnmasterdata_Click);
            // 
            // pnlmainworkitm
            // 
            this.pnlmainworkitm.BackColor = System.Drawing.Color.White;
            this.pnlmainworkitm.Controls.Add(this.btnassignworkItem);
            this.pnlmainworkitm.Controls.Add(this.btnworkitem);
            this.pnlmainworkitm.Controls.Add(this.btnassigntask);
            this.pnlmainworkitm.ForeColor = System.Drawing.Color.White;
            this.pnlmainworkitm.Location = new System.Drawing.Point(3, 211);
            this.pnlmainworkitm.MaximumSize = new System.Drawing.Size(241, 170);
            this.pnlmainworkitm.MinimumSize = new System.Drawing.Size(241, 50);
            this.pnlmainworkitm.Name = "pnlmainworkitm";
            this.pnlmainworkitm.Size = new System.Drawing.Size(241, 50);
            this.pnlmainworkitm.TabIndex = 8;
            // 
            // btnassignworkItem
            // 
            this.btnassignworkItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnassignworkItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnassignworkItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassignworkItem.ForeColor = System.Drawing.Color.White;
            this.btnassignworkItem.Image = ((System.Drawing.Image)(resources.GetObject("btnassignworkItem.Image")));
            this.btnassignworkItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnassignworkItem.Location = new System.Drawing.Point(-1, 112);
            this.btnassignworkItem.Name = "btnassignworkItem";
            this.btnassignworkItem.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnassignworkItem.Size = new System.Drawing.Size(243, 58);
            this.btnassignworkItem.TabIndex = 2;
            this.btnassignworkItem.Text = "        Assign WorkItem";
            this.btnassignworkItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnassignworkItem.UseVisualStyleBackColor = false;
            this.btnassignworkItem.Click += new System.EventHandler(this.btnassignworkItem_Click);
            // 
            // btnworkitem
            // 
            this.btnworkitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnworkitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnworkitem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnworkitem.ForeColor = System.Drawing.Color.White;
            this.btnworkitem.Image = ((System.Drawing.Image)(resources.GetObject("btnworkitem.Image")));
            this.btnworkitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnworkitem.Location = new System.Drawing.Point(-1, -1);
            this.btnworkitem.Name = "btnworkitem";
            this.btnworkitem.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnworkitem.Size = new System.Drawing.Size(243, 58);
            this.btnworkitem.TabIndex = 2;
            this.btnworkitem.Text = "        WorkItem";
            this.btnworkitem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnworkitem.UseVisualStyleBackColor = false;
            this.btnworkitem.Click += new System.EventHandler(this.btnworkitem_Click);
            // 
            // btnassigntask
            // 
            this.btnassigntask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnassigntask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnassigntask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassigntask.ForeColor = System.Drawing.Color.White;
            this.btnassigntask.Image = ((System.Drawing.Image)(resources.GetObject("btnassigntask.Image")));
            this.btnassigntask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnassigntask.Location = new System.Drawing.Point(-1, 56);
            this.btnassigntask.Name = "btnassigntask";
            this.btnassigntask.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnassigntask.Size = new System.Drawing.Size(243, 58);
            this.btnassigntask.TabIndex = 2;
            this.btnassigntask.Text = "        Create WorkItem";
            this.btnassigntask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnassigntask.UseVisualStyleBackColor = false;
            this.btnassigntask.Click += new System.EventHandler(this.btnassigntask_Click);
            // 
            // panelReportAnalysis
            // 
            this.panelReportAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panelReportAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReportAnalysis.Controls.Add(this.btnTimeBasedReport);
            this.panelReportAnalysis.Controls.Add(this.btnAssigneeBasedReport);
            this.panelReportAnalysis.Controls.Add(this.btnstatusbasedreport);
            this.panelReportAnalysis.Controls.Add(this.btnreportanalysis);
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
            // btnstatusbasedreport
            // 
            this.btnstatusbasedreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnstatusbasedreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstatusbasedreport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstatusbasedreport.ForeColor = System.Drawing.Color.White;
            this.btnstatusbasedreport.Image = ((System.Drawing.Image)(resources.GetObject("btnstatusbasedreport.Image")));
            this.btnstatusbasedreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstatusbasedreport.Location = new System.Drawing.Point(-1, 50);
            this.btnstatusbasedreport.Name = "btnstatusbasedreport";
            this.btnstatusbasedreport.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnstatusbasedreport.Size = new System.Drawing.Size(245, 57);
            this.btnstatusbasedreport.TabIndex = 2;
            this.btnstatusbasedreport.Text = "        Status Based Report";
            this.btnstatusbasedreport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstatusbasedreport.UseVisualStyleBackColor = false;
            this.btnstatusbasedreport.Click += new System.EventHandler(this.btnstatusbasedreport_Click);
            // 
            // btnreportanalysis
            // 
            this.btnreportanalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnreportanalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportanalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportanalysis.ForeColor = System.Drawing.Color.White;
            this.btnreportanalysis.Image = ((System.Drawing.Image)(resources.GetObject("btnreportanalysis.Image")));
            this.btnreportanalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportanalysis.Location = new System.Drawing.Point(-1, -1);
            this.btnreportanalysis.Name = "btnreportanalysis";
            this.btnreportanalysis.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnreportanalysis.Size = new System.Drawing.Size(243, 58);
            this.btnreportanalysis.TabIndex = 2;
            this.btnreportanalysis.Text = "        Report Analysis";
            this.btnreportanalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportanalysis.UseVisualStyleBackColor = false;
            this.btnreportanalysis.Click += new System.EventHandler(this.btnreportanalysis_Click);
            // 
            // pnlmainsettings
            // 
            this.pnlmainsettings.BackColor = System.Drawing.Color.White;
            this.pnlmainsettings.Controls.Add(this.btnupdatepwd);
            this.pnlmainsettings.Controls.Add(this.btnSettings);
            this.pnlmainsettings.ForeColor = System.Drawing.Color.White;
            this.pnlmainsettings.Location = new System.Drawing.Point(3, 323);
            this.pnlmainsettings.MaximumSize = new System.Drawing.Size(241, 106);
            this.pnlmainsettings.MinimumSize = new System.Drawing.Size(241, 50);
            this.pnlmainsettings.Name = "pnlmainsettings";
            this.pnlmainsettings.Size = new System.Drawing.Size(241, 50);
            this.pnlmainsettings.TabIndex = 7;
            // 
            // btnupdatepwd
            // 
            this.btnupdatepwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnupdatepwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdatepwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatepwd.ForeColor = System.Drawing.Color.White;
            this.btnupdatepwd.Image = ((System.Drawing.Image)(resources.GetObject("btnupdatepwd.Image")));
            this.btnupdatepwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdatepwd.Location = new System.Drawing.Point(0, 56);
            this.btnupdatepwd.Name = "btnupdatepwd";
            this.btnupdatepwd.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnupdatepwd.Size = new System.Drawing.Size(245, 52);
            this.btnupdatepwd.TabIndex = 2;
            this.btnupdatepwd.Text = "        Change Password";
            this.btnupdatepwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdatepwd.UseVisualStyleBackColor = false;
            this.btnupdatepwd.Click += new System.EventHandler(this.btnupdatepwd_Click);
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
            this.panelTS1.Controls.Add(this.btntasksheet);
            this.panelTS1.Location = new System.Drawing.Point(513, 313);
            this.panelTS1.Name = "panelTS1";
            this.panelTS1.Size = new System.Drawing.Size(242, 37);
            this.panelTS1.TabIndex = 4;
            this.panelTS1.Visible = false;
            // 
            // btntasksheet
            // 
            this.btntasksheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntasksheet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntasksheet.ForeColor = System.Drawing.Color.White;
            this.btntasksheet.Image = ((System.Drawing.Image)(resources.GetObject("btntasksheet.Image")));
            this.btntasksheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntasksheet.Location = new System.Drawing.Point(-1, -8);
            this.btntasksheet.Name = "btntasksheet";
            this.btntasksheet.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btntasksheet.Size = new System.Drawing.Size(243, 58);
            this.btntasksheet.TabIndex = 2;
            this.btntasksheet.Text = "             Task Sheet";
            this.btntasksheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntasksheet.UseVisualStyleBackColor = true;
            // 
            // panelTC1
            // 
            this.panelTC1.Controls.Add(this.btntaskcalender);
            this.panelTC1.Location = new System.Drawing.Point(513, 356);
            this.panelTC1.Name = "panelTC1";
            this.panelTC1.Size = new System.Drawing.Size(242, 37);
            this.panelTC1.TabIndex = 2;
            this.panelTC1.Visible = false;
            // 
            // btntaskcalender
            // 
            this.btntaskcalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntaskcalender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaskcalender.ForeColor = System.Drawing.Color.White;
            this.btntaskcalender.Image = ((System.Drawing.Image)(resources.GetObject("btntaskcalender.Image")));
            this.btntaskcalender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntaskcalender.Location = new System.Drawing.Point(-1, -8);
            this.btntaskcalender.Name = "btntaskcalender";
            this.btntaskcalender.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btntaskcalender.Size = new System.Drawing.Size(243, 58);
            this.btntaskcalender.TabIndex = 2;
            this.btntaskcalender.Text = "             Task Calender";
            this.btntaskcalender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntaskcalender.UseVisualStyleBackColor = true;
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
            this.paneltitlebar.Controls.Add(this.btnclose);
            this.paneltitlebar.Controls.Add(this.btnclosechildform);
            this.paneltitlebar.Controls.Add(this.labeltitle);
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
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(866, 1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 29);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "x";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnclosechildform
            // 
            this.btnclosechildform.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnclosechildform.FlatAppearance.BorderSize = 0;
            this.btnclosechildform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosechildform.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosechildform.ForeColor = System.Drawing.Color.White;
            this.btnclosechildform.Location = new System.Drawing.Point(0, 0);
            this.btnclosechildform.Name = "btnclosechildform";
            this.btnclosechildform.Size = new System.Drawing.Size(75, 65);
            this.btnclosechildform.TabIndex = 1;
            this.btnclosechildform.Text = "X";
            this.btnclosechildform.UseVisualStyleBackColor = true;
            this.btnclosechildform.Click += new System.EventHandler(this.btnclosechildform_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(333, 19);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(187, 31);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "DASHBOARD";
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
        private System.Windows.Forms.Button btnmasterdata;
        private System.Windows.Forms.Panel panelTC1;
        private System.Windows.Forms.Button btntaskcalender;
        private System.Windows.Forms.Panel panelTS1;
        private System.Windows.Forms.Button btntasksheet;
        private System.Windows.Forms.Label lblmenu;
        private System.Windows.Forms.PictureBox Menubutton;
        private System.Windows.Forms.Timer Sidebartimer;
        private System.Windows.Forms.Panel paneltitlebar;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnclosechildform;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Panel panelTS;
        private System.Windows.Forms.Button btnteamregister;
        private System.Windows.Forms.Panel HomeChildContainer;
        private System.Windows.Forms.Panel panelTC;
        private System.Windows.Forms.Button btngrouptask;
        private System.Windows.Forms.Panel panelReportAnalysis;
        private System.Windows.Forms.Button btnTimeBasedReport;
        private System.Windows.Forms.Button btnAssigneeBasedReport;
        private System.Windows.Forms.Button btnstatusbasedreport;
        private System.Windows.Forms.Button btnreportanalysis;
        private System.Windows.Forms.Timer ReportTimer;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lbllogout;
        private System.Windows.Forms.Panel pnlmainsettings;
        private System.Windows.Forms.Timer SettingTimer;
        private System.Windows.Forms.Button btnupdatepwd;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnassigntask;
        private System.Windows.Forms.Panel pnlmainworkitm;
        private System.Windows.Forms.Button btnassignworkItem;
        private System.Windows.Forms.Button btnworkitem;
        private System.Windows.Forms.Timer WorkItemtimer;
        private TMS.UI.Utilities.RoundPictureBox picemp;
    }
}