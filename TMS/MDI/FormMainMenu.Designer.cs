using System.Web.UI.WebControls;

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
            this.pnlSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbUser = new TMS.UI.Utilities.RoundPictureBox();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbMenuButton = new System.Windows.Forms.PictureBox();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProjectManagement = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTeamRegister = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlMasterData = new System.Windows.Forms.Panel();
            this.pnlTaskManagement = new System.Windows.Forms.Panel();
            this.btnTaskManagement = new System.Windows.Forms.Button();
            this.pnlTeamManagement = new System.Windows.Forms.Panel();
            this.btnProjectAssignment = new System.Windows.Forms.Button();
            this.pnlHomeChildContainer = new System.Windows.Forms.Panel();
            this.btnMasterData = new System.Windows.Forms.Button();
            this.pnlWorkItem = new System.Windows.Forms.Panel();
            this.btnAssignWorkItem = new System.Windows.Forms.Button();
            this.btnWorkItem = new System.Windows.Forms.Button();
            this.btnCreateWorkItem = new System.Windows.Forms.Button();
            this.pnlReportAnalysis = new System.Windows.Forms.Panel();
            this.btnTimeBasedReport = new System.Windows.Forms.Button();
            this.btnAssigneeBasedReport = new System.Windows.Forms.Button();
            this.btnStatusBasedReport = new System.Windows.Forms.Button();
            this.btnReportAnalysis = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.cmbprojects = new System.Windows.Forms.ComboBox();
            this.timerExpandCollapse = new System.Windows.Forms.Timer(this.components);
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.lblprojectname = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSideBar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuButton)).BeginInit();
            this.pnlAdmin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlMasterData.SuspendLayout();
            this.pnlTaskManagement.SuspendLayout();
            this.pnlTeamManagement.SuspendLayout();
            this.pnlHomeChildContainer.SuspendLayout();
            this.pnlWorkItem.SuspendLayout();
            this.pnlReportAnalysis.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnltop.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlSideBar.Controls.Add(this.pnlLogo);
            this.pnlSideBar.Controls.Add(this.pnlAdmin);
            this.pnlSideBar.Controls.Add(this.pnlMasterData);
            this.pnlSideBar.Controls.Add(this.pnlWorkItem);
            this.pnlSideBar.Controls.Add(this.pnlReportAnalysis);
            this.pnlSideBar.Controls.Add(this.pnlSettings);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(368, 1231);
            this.pnlSideBar.MinimumSize = new System.Drawing.Size(105, 1231);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(368, 1231);
            this.pnlSideBar.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbUser);
            this.pnlLogo.Controls.Add(this.lblLogOut);
            this.pnlLogo.Controls.Add(this.lblWelcome);
            this.pnlLogo.Controls.Add(this.lblMenu);
            this.pnlLogo.Controls.Add(this.pbMenuButton);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLogo.Location = new System.Drawing.Point(4, 5);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(360, 215);
            this.pnlLogo.TabIndex = 1;
            // 
            // pbUser
            // 
            this.pbUser.Location = new System.Drawing.Point(4, 9);
            this.pbUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(88, 91);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 5;
            this.pbUser.TabStop = false;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lblLogOut.Image")));
            this.lblLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogOut.Location = new System.Drawing.Point(102, 82);
            this.lblLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(99, 28);
            this.lblLogOut.TabIndex = 5;
            this.lblLogOut.Text = "   Logout?";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogOut.MouseEnter += new System.EventHandler(this.lblLogout_MouseEnter);
            this.lblLogOut.MouseLeave += new System.EventHandler(this.lblLogout_MouseLeave);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(102, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(169, 28);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "WelcomeMessage";
            this.lblWelcome.MouseEnter += new System.EventHandler(this.lblWelcome_MouseEnter);
            this.lblWelcome.MouseLeave += new System.EventHandler(this.lblWelcome_MouseLeave);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(65, 163);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(62, 28);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu";
            this.lblMenu.MouseEnter += new System.EventHandler(this.lblMenu_MouseEnter);
            this.lblMenu.MouseLeave += new System.EventHandler(this.lblMenu_MouseLeave);
            // 
            // pbMenuButton
            // 
            this.pbMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("pbMenuButton.Image")));
            this.pbMenuButton.Location = new System.Drawing.Point(9, 160);
            this.pbMenuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbMenuButton.Name = "pbMenuButton";
            this.pbMenuButton.Size = new System.Drawing.Size(56, 36);
            this.pbMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenuButton.TabIndex = 1;
            this.pbMenuButton.TabStop = false;
            this.pbMenuButton.Click += new System.EventHandler(this.pbMenuButton_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.pnlAdmin.Controls.Add(this.panel2);
            this.pnlAdmin.Controls.Add(this.panel3);
            this.pnlAdmin.Controls.Add(this.panel4);
            this.pnlAdmin.Location = new System.Drawing.Point(4, 230);
            this.pnlAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAdmin.MaximumSize = new System.Drawing.Size(362, 220);
            this.pnlAdmin.MinimumSize = new System.Drawing.Size(362, 86);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(362, 86);
            this.pnlAdmin.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnProjectManagement);
            this.panel2.Location = new System.Drawing.Point(2, 143);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.MaximumSize = new System.Drawing.Size(362, 142);
            this.panel2.MinimumSize = new System.Drawing.Size(362, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 77);
            this.panel2.TabIndex = 8;
            // 
            // btnProjectManagement
            // 
            this.btnProjectManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnProjectManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectManagement.ForeColor = System.Drawing.Color.White;
            this.btnProjectManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectManagement.Image")));
            this.btnProjectManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectManagement.Location = new System.Drawing.Point(-2, -2);
            this.btnProjectManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProjectManagement.Name = "btnProjectManagement";
            this.btnProjectManagement.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnProjectManagement.Size = new System.Drawing.Size(368, 88);
            this.btnProjectManagement.TabIndex = 2;
            this.btnProjectManagement.Text = "        Project Management";
            this.btnProjectManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectManagement.UseVisualStyleBackColor = false;
            this.btnProjectManagement.Click += new System.EventHandler(this.btnProjectManagement_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnTeamRegister);
            this.panel3.Location = new System.Drawing.Point(2, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.MaximumSize = new System.Drawing.Size(362, 142);
            this.panel3.MinimumSize = new System.Drawing.Size(362, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 77);
            this.panel3.TabIndex = 7;
            // 
            // btnTeamRegister
            // 
            this.btnTeamRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTeamRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeamRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamRegister.ForeColor = System.Drawing.Color.White;
            this.btnTeamRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnTeamRegister.Image")));
            this.btnTeamRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamRegister.Location = new System.Drawing.Point(-2, -6);
            this.btnTeamRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTeamRegister.Name = "btnTeamRegister";
            this.btnTeamRegister.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnTeamRegister.Size = new System.Drawing.Size(368, 88);
            this.btnTeamRegister.TabIndex = 2;
            this.btnTeamRegister.Text = "        Team Management";
            this.btnTeamRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamRegister.UseVisualStyleBackColor = false;
            this.btnTeamRegister.Click += new System.EventHandler(this.btnTeamRegister_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnAdmin);
            this.panel4.Location = new System.Drawing.Point(2, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.MaximumSize = new System.Drawing.Size(362, 142);
            this.panel4.MinimumSize = new System.Drawing.Size(362, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 77);
            this.panel4.TabIndex = 5;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(-2, -2);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(364, 89);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "        Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pnlMasterData
            // 
            this.pnlMasterData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.pnlMasterData.Controls.Add(this.pnlTaskManagement);
            this.pnlMasterData.Controls.Add(this.pnlTeamManagement);
            this.pnlMasterData.Controls.Add(this.pnlHomeChildContainer);
            this.pnlMasterData.Location = new System.Drawing.Point(4, 326);
            this.pnlMasterData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMasterData.MaximumSize = new System.Drawing.Size(362, 220);
            this.pnlMasterData.MinimumSize = new System.Drawing.Size(362, 86);
            this.pnlMasterData.Name = "pnlMasterData";
            this.pnlMasterData.Size = new System.Drawing.Size(362, 86);
            this.pnlMasterData.TabIndex = 6;
            // 
            // pnlTaskManagement
            // 
            this.pnlTaskManagement.BackColor = System.Drawing.Color.White;
            this.pnlTaskManagement.Controls.Add(this.btnTaskManagement);
            this.pnlTaskManagement.Location = new System.Drawing.Point(2, 143);
            this.pnlTaskManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTaskManagement.MaximumSize = new System.Drawing.Size(362, 142);
            this.pnlTaskManagement.MinimumSize = new System.Drawing.Size(362, 77);
            this.pnlTaskManagement.Name = "pnlTaskManagement";
            this.pnlTaskManagement.Size = new System.Drawing.Size(362, 77);
            this.pnlTaskManagement.TabIndex = 8;
            // 
            // btnTaskManagement
            // 
            this.btnTaskManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTaskManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskManagement.ForeColor = System.Drawing.Color.White;
            this.btnTaskManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskManagement.Image")));
            this.btnTaskManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaskManagement.Location = new System.Drawing.Point(-2, -2);
            this.btnTaskManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaskManagement.Name = "btnTaskManagement";
            this.btnTaskManagement.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnTaskManagement.Size = new System.Drawing.Size(368, 88);
            this.btnTaskManagement.TabIndex = 2;
            this.btnTaskManagement.Text = "        Task Management";
            this.btnTaskManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaskManagement.UseVisualStyleBackColor = false;
            this.btnTaskManagement.Click += new System.EventHandler(this.btnTaskManagement_Click);
            // 
            // pnlTeamManagement
            // 
            this.pnlTeamManagement.BackColor = System.Drawing.Color.White;
            this.pnlTeamManagement.Controls.Add(this.btnProjectAssignment);
            this.pnlTeamManagement.Location = new System.Drawing.Point(2, 85);
            this.pnlTeamManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTeamManagement.MaximumSize = new System.Drawing.Size(362, 142);
            this.pnlTeamManagement.MinimumSize = new System.Drawing.Size(362, 77);
            this.pnlTeamManagement.Name = "pnlTeamManagement";
            this.pnlTeamManagement.Size = new System.Drawing.Size(362, 77);
            this.pnlTeamManagement.TabIndex = 7;
            // 
            // btnProjectAssignment
            // 
            this.btnProjectAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnProjectAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectAssignment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectAssignment.ForeColor = System.Drawing.Color.White;
            this.btnProjectAssignment.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectAssignment.Image")));
            this.btnProjectAssignment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectAssignment.Location = new System.Drawing.Point(-2, -6);
            this.btnProjectAssignment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProjectAssignment.Name = "btnProjectAssignment";
            this.btnProjectAssignment.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnProjectAssignment.Size = new System.Drawing.Size(368, 88);
            this.btnProjectAssignment.TabIndex = 2;
            this.btnProjectAssignment.Text = "        Project Assignment";
            this.btnProjectAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectAssignment.UseVisualStyleBackColor = false;
            this.btnProjectAssignment.Click += new System.EventHandler(this.btnProjectAssignment_Click);
            // 
            // pnlHomeChildContainer
            // 
            this.pnlHomeChildContainer.BackColor = System.Drawing.Color.White;
            this.pnlHomeChildContainer.Controls.Add(this.btnMasterData);
            this.pnlHomeChildContainer.Location = new System.Drawing.Point(2, 5);
            this.pnlHomeChildContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHomeChildContainer.MaximumSize = new System.Drawing.Size(362, 142);
            this.pnlHomeChildContainer.MinimumSize = new System.Drawing.Size(362, 77);
            this.pnlHomeChildContainer.Name = "pnlHomeChildContainer";
            this.pnlHomeChildContainer.Size = new System.Drawing.Size(362, 77);
            this.pnlHomeChildContainer.TabIndex = 5;
            // 
            // btnMasterData
            // 
            this.btnMasterData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnMasterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterData.ForeColor = System.Drawing.Color.White;
            this.btnMasterData.Image = ((System.Drawing.Image)(resources.GetObject("btnMasterData.Image")));
            this.btnMasterData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterData.Location = new System.Drawing.Point(-2, -2);
            this.btnMasterData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMasterData.Name = "btnMasterData";
            this.btnMasterData.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnMasterData.Size = new System.Drawing.Size(364, 89);
            this.btnMasterData.TabIndex = 2;
            this.btnMasterData.Text = "        Master Data";
            this.btnMasterData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterData.UseVisualStyleBackColor = false;
            this.btnMasterData.Click += new System.EventHandler(this.btnMasterData_Click);
            // 
            // pnlWorkItem
            // 
            this.pnlWorkItem.BackColor = System.Drawing.Color.White;
            this.pnlWorkItem.Controls.Add(this.btnAssignWorkItem);
            this.pnlWorkItem.Controls.Add(this.btnWorkItem);
            this.pnlWorkItem.Controls.Add(this.btnCreateWorkItem);
            this.pnlWorkItem.ForeColor = System.Drawing.Color.White;
            this.pnlWorkItem.Location = new System.Drawing.Point(4, 422);
            this.pnlWorkItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlWorkItem.MaximumSize = new System.Drawing.Size(362, 262);
            this.pnlWorkItem.MinimumSize = new System.Drawing.Size(362, 77);
            this.pnlWorkItem.Name = "pnlWorkItem";
            this.pnlWorkItem.Size = new System.Drawing.Size(362, 77);
            this.pnlWorkItem.TabIndex = 8;
            // 
            // btnAssignWorkItem
            // 
            this.btnAssignWorkItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAssignWorkItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignWorkItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignWorkItem.ForeColor = System.Drawing.Color.White;
            this.btnAssignWorkItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignWorkItem.Image")));
            this.btnAssignWorkItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignWorkItem.Location = new System.Drawing.Point(-2, 172);
            this.btnAssignWorkItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssignWorkItem.Name = "btnAssignWorkItem";
            this.btnAssignWorkItem.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnAssignWorkItem.Size = new System.Drawing.Size(364, 89);
            this.btnAssignWorkItem.TabIndex = 2;
            this.btnAssignWorkItem.Text = "        Assign WorkItem";
            this.btnAssignWorkItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignWorkItem.UseVisualStyleBackColor = false;
            this.btnAssignWorkItem.Click += new System.EventHandler(this.btnAssignWorkItem_Click);
            // 
            // btnWorkItem
            // 
            this.btnWorkItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnWorkItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkItem.ForeColor = System.Drawing.Color.White;
            this.btnWorkItem.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkItem.Image")));
            this.btnWorkItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkItem.Location = new System.Drawing.Point(-2, -2);
            this.btnWorkItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWorkItem.Name = "btnWorkItem";
            this.btnWorkItem.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnWorkItem.Size = new System.Drawing.Size(364, 89);
            this.btnWorkItem.TabIndex = 2;
            this.btnWorkItem.Text = "        WorkItem";
            this.btnWorkItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkItem.UseVisualStyleBackColor = false;
            this.btnWorkItem.Click += new System.EventHandler(this.btnWorkItem_Click);
            // 
            // btnCreateWorkItem
            // 
            this.btnCreateWorkItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnCreateWorkItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateWorkItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateWorkItem.ForeColor = System.Drawing.Color.White;
            this.btnCreateWorkItem.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateWorkItem.Image")));
            this.btnCreateWorkItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateWorkItem.Location = new System.Drawing.Point(-2, 86);
            this.btnCreateWorkItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateWorkItem.Name = "btnCreateWorkItem";
            this.btnCreateWorkItem.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnCreateWorkItem.Size = new System.Drawing.Size(364, 89);
            this.btnCreateWorkItem.TabIndex = 2;
            this.btnCreateWorkItem.Text = "        Create WorkItem";
            this.btnCreateWorkItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateWorkItem.UseVisualStyleBackColor = false;
            this.btnCreateWorkItem.Click += new System.EventHandler(this.btnCreateWorkItem_Click);
            // 
            // pnlReportAnalysis
            // 
            this.pnlReportAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.pnlReportAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReportAnalysis.Controls.Add(this.btnTimeBasedReport);
            this.pnlReportAnalysis.Controls.Add(this.btnAssigneeBasedReport);
            this.pnlReportAnalysis.Controls.Add(this.btnStatusBasedReport);
            this.pnlReportAnalysis.Controls.Add(this.btnReportAnalysis);
            this.pnlReportAnalysis.Location = new System.Drawing.Point(4, 509);
            this.pnlReportAnalysis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlReportAnalysis.MaximumSize = new System.Drawing.Size(360, 336);
            this.pnlReportAnalysis.MinimumSize = new System.Drawing.Size(360, 76);
            this.pnlReportAnalysis.Name = "pnlReportAnalysis";
            this.pnlReportAnalysis.Size = new System.Drawing.Size(360, 76);
            this.pnlReportAnalysis.TabIndex = 7;
            // 
            // btnTimeBasedReport
            // 
            this.btnTimeBasedReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTimeBasedReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeBasedReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeBasedReport.ForeColor = System.Drawing.Color.White;
            this.btnTimeBasedReport.Image = ((System.Drawing.Image)(resources.GetObject("btnTimeBasedReport.Image")));
            this.btnTimeBasedReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeBasedReport.Location = new System.Drawing.Point(-2, 248);
            this.btnTimeBasedReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimeBasedReport.Name = "btnTimeBasedReport";
            this.btnTimeBasedReport.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnTimeBasedReport.Size = new System.Drawing.Size(368, 88);
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
            this.btnAssigneeBasedReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssigneeBasedReport.ForeColor = System.Drawing.Color.White;
            this.btnAssigneeBasedReport.Image = ((System.Drawing.Image)(resources.GetObject("btnAssigneeBasedReport.Image")));
            this.btnAssigneeBasedReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssigneeBasedReport.Location = new System.Drawing.Point(-2, 162);
            this.btnAssigneeBasedReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssigneeBasedReport.Name = "btnAssigneeBasedReport";
            this.btnAssigneeBasedReport.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnAssigneeBasedReport.Size = new System.Drawing.Size(368, 88);
            this.btnAssigneeBasedReport.TabIndex = 2;
            this.btnAssigneeBasedReport.Text = "        Assignee Based Report";
            this.btnAssigneeBasedReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssigneeBasedReport.UseVisualStyleBackColor = false;
            this.btnAssigneeBasedReport.Click += new System.EventHandler(this.btnAssigneeBasedReport_Click);
            // 
            // btnStatusBasedReport
            // 
            this.btnStatusBasedReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnStatusBasedReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusBasedReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusBasedReport.ForeColor = System.Drawing.Color.White;
            this.btnStatusBasedReport.Image = ((System.Drawing.Image)(resources.GetObject("btnStatusBasedReport.Image")));
            this.btnStatusBasedReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatusBasedReport.Location = new System.Drawing.Point(-2, 77);
            this.btnStatusBasedReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStatusBasedReport.Name = "btnStatusBasedReport";
            this.btnStatusBasedReport.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnStatusBasedReport.Size = new System.Drawing.Size(368, 88);
            this.btnStatusBasedReport.TabIndex = 2;
            this.btnStatusBasedReport.Text = "        Status Based Report";
            this.btnStatusBasedReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatusBasedReport.UseVisualStyleBackColor = false;
            this.btnStatusBasedReport.Click += new System.EventHandler(this.btnStatusBasedReport_Click);
            // 
            // btnReportAnalysis
            // 
            this.btnReportAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnReportAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportAnalysis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnReportAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("btnReportAnalysis.Image")));
            this.btnReportAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportAnalysis.Location = new System.Drawing.Point(-2, -2);
            this.btnReportAnalysis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportAnalysis.Name = "btnReportAnalysis";
            this.btnReportAnalysis.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnReportAnalysis.Size = new System.Drawing.Size(364, 89);
            this.btnReportAnalysis.TabIndex = 2;
            this.btnReportAnalysis.Text = "        Report Analysis";
            this.btnReportAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportAnalysis.UseVisualStyleBackColor = false;
            this.btnReportAnalysis.Click += new System.EventHandler(this.btnReportAnalysis_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.White;
            this.pnlSettings.Controls.Add(this.btnChangePassword);
            this.pnlSettings.Controls.Add(this.btnSettings);
            this.pnlSettings.ForeColor = System.Drawing.Color.White;
            this.pnlSettings.Location = new System.Drawing.Point(4, 595);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSettings.MaximumSize = new System.Drawing.Size(362, 163);
            this.pnlSettings.MinimumSize = new System.Drawing.Size(362, 77);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(362, 77);
            this.pnlSettings.TabIndex = 7;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 86);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(368, 80);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "        Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(-2, -2);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(364, 89);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "        Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cmbprojects
            // 
            this.cmbprojects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprojects.FormattingEnabled = true;
            this.cmbprojects.Location = new System.Drawing.Point(198, 22);
            this.cmbprojects.Name = "cmbprojects";
            this.cmbprojects.Size = new System.Drawing.Size(307, 28);
            this.cmbprojects.TabIndex = 6;
            this.cmbprojects.SelectedIndexChanged += new System.EventHandler(this.cmbprojects_SelectedIndexChanged);
            // 
            // timerExpandCollapse
            // 
            this.timerExpandCollapse.Interval = 10;
            this.timerExpandCollapse.Tick += new System.EventHandler(this.timerExpandCollapse_Tick);
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnltop.Controls.Add(this.btnMinimize);
            this.pnltop.Controls.Add(this.btnMaximize);
            this.pnltop.Controls.Add(this.lblprojectname);
            this.pnltop.Controls.Add(this.cmbprojects);
            this.pnltop.Controls.Add(this.btnClose);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(368, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1348, 73);
            this.pnltop.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1211, 16);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 46);
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
            this.btnMaximize.Location = new System.Drawing.Point(1261, 27);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(27, 23);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // lblprojectname
            // 
            this.lblprojectname.AutoSize = true;
            this.lblprojectname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lblprojectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprojectname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblprojectname.Location = new System.Drawing.Point(12, 22);
            this.lblprojectname.Name = "lblprojectname";
            this.lblprojectname.Size = new System.Drawing.Size(146, 25);
            this.lblprojectname.TabIndex = 7;
            this.lblprojectname.Text = "Select Project";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1299, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitleBar.Controls.Add(this.btnCloseChildForm);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(368, 73);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1348, 56);
            this.pnlTitleBar.TabIndex = 4;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(112, 56);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(459, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(419, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TASK MANAGEMENT SYSTEM";
            // 
            // pnlDesktopPanel
            // 
            this.pnlDesktopPanel.Controls.Add(this.pictureBox1);
            this.pnlDesktopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDesktopPanel.Location = new System.Drawing.Point(368, 129);
            this.pnlDesktopPanel.Name = "pnlDesktopPanel";
            this.pnlDesktopPanel.Size = new System.Drawing.Size(1348, 968);
            this.pnlDesktopPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1348, 968);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1716, 1043);
            this.Controls.Add(this.pnlDesktopPanel);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlSideBar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1489, 893);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuButton)).EndInit();
            this.pnlAdmin.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlMasterData.ResumeLayout(false);
            this.pnlTaskManagement.ResumeLayout(false);
            this.pnlTeamManagement.ResumeLayout(false);
            this.pnlHomeChildContainer.ResumeLayout(false);
            this.pnlWorkItem.ResumeLayout(false);
            this.pnlReportAnalysis.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlSideBar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnMasterData;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pbMenuButton;
        private System.Windows.Forms.Panel pnlMasterData;
        private System.Windows.Forms.Panel pnlTeamManagement;
        private System.Windows.Forms.Button btnProjectAssignment;
        private System.Windows.Forms.Panel pnlHomeChildContainer;
        private System.Windows.Forms.Panel pnlTaskManagement;
        private System.Windows.Forms.Button btnTaskManagement;
        private System.Windows.Forms.Panel pnlReportAnalysis;
        private System.Windows.Forms.Button btnTimeBasedReport;
        private System.Windows.Forms.Button btnAssigneeBasedReport;
        private System.Windows.Forms.Button btnStatusBasedReport;
        private System.Windows.Forms.Button btnReportAnalysis;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCreateWorkItem;
        private System.Windows.Forms.Panel pnlWorkItem;
        private System.Windows.Forms.Button btnAssignWorkItem;
        private System.Windows.Forms.Button btnWorkItem;
        private System.Windows.Forms.Timer timerExpandCollapse;
        private TMS.UI.Utilities.RoundPictureBox pbUser;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProjectManagement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTeamRegister;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.ComboBox cmbprojects;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lblprojectname;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDesktopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}