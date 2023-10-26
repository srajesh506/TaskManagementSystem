namespace TMS.UI{
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
            this.cmbNoOfRecordsPerPage = new System.Windows.Forms.ComboBox();
            this.lblNoOfRecordPerPage = new System.Windows.Forms.Label();
            this.grpBoxPaging = new System.Windows.Forms.GroupBox();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblNoOfPages = new System.Windows.Forms.Label();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.grpBoxEmployeeGridView = new System.Windows.Forms.GroupBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.grpBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpBoxRegistrationForm = new System.Windows.Forms.GroupBox();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblSelectProject = new System.Windows.Forms.Label();
            this.chklstbxProject = new System.Windows.Forms.CheckedListBox();
            this.pbPwdIcon = new System.Windows.Forms.PictureBox();
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
            this.pbPic = new TMS.UI.Utilities.RoundPictureBox();
            this.pnlMain.SuspendLayout();
            this.grpBoxPaging.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.cmbNoOfRecordsPerPage);
            this.pnlMain.Controls.Add(this.lblNoOfRecordPerPage);
            this.pnlMain.Controls.Add(this.grpBoxPaging);
            this.pnlMain.Controls.Add(this.grpBoxEmployeeGridView);
            this.pnlMain.Controls.Add(this.grpBoxButtons);
            this.pnlMain.Controls.Add(this.grpBoxRegistrationForm);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1578, 961);
            this.pnlMain.TabIndex = 0;
            // 
            // cmbNoOfRecordsPerPage
            // 
            this.cmbNoOfRecordsPerPage.FormattingEnabled = true;
            this.cmbNoOfRecordsPerPage.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.cmbNoOfRecordsPerPage.Location = new System.Drawing.Point(102, 875);
            this.cmbNoOfRecordsPerPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNoOfRecordsPerPage.Name = "cmbNoOfRecordsPerPage";
            this.cmbNoOfRecordsPerPage.Size = new System.Drawing.Size(66, 28);
            this.cmbNoOfRecordsPerPage.TabIndex = 23;
            this.cmbNoOfRecordsPerPage.Text = "5";
            this.cmbNoOfRecordsPerPage.SelectedIndexChanged += new System.EventHandler(this.cmbNoOfRecordsPerPage_SelectedIndexChanged);
            // 
            // lblNoOfRecordPerPage
            // 
            this.lblNoOfRecordPerPage.AutoSize = true;
            this.lblNoOfRecordPerPage.BackColor = System.Drawing.Color.White;
            this.lblNoOfRecordPerPage.Location = new System.Drawing.Point(18, 875);
            this.lblNoOfRecordPerPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfRecordPerPage.Name = "lblNoOfRecordPerPage";
            this.lblNoOfRecordPerPage.Size = new System.Drawing.Size(81, 20);
            this.lblNoOfRecordPerPage.TabIndex = 17;
            this.lblNoOfRecordPerPage.Text = "Page Size";
            // 
            // grpBoxPaging
            // 
            this.grpBoxPaging.BackColor = System.Drawing.Color.White;
            this.grpBoxPaging.Controls.Add(this.btnLastPage);
            this.grpBoxPaging.Controls.Add(this.btnFirstPage);
            this.grpBoxPaging.Controls.Add(this.lblPages);
            this.grpBoxPaging.Controls.Add(this.lblNoOfPages);
            this.grpBoxPaging.Controls.Add(this.lblSeperator);
            this.grpBoxPaging.Controls.Add(this.lblCurrentPage);
            this.grpBoxPaging.Controls.Add(this.btnNext);
            this.grpBoxPaging.Controls.Add(this.btnPrevious);
            this.grpBoxPaging.Location = new System.Drawing.Point(575, 875);
            this.grpBoxPaging.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPaging.Name = "grpBoxPaging";
            this.grpBoxPaging.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPaging.Size = new System.Drawing.Size(412, 78);
            this.grpBoxPaging.TabIndex = 15;
            this.grpBoxPaging.TabStop = false;
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.Location = new System.Drawing.Point(346, 29);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(46, 35);
            this.btnLastPage.TabIndex = 7;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.Location = new System.Drawing.Point(10, 29);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(52, 35);
            this.btnFirstPage.TabIndex = 6;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(225, 37);
            this.lblPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(61, 22);
            this.lblPages.TabIndex = 5;
            this.lblPages.Text = "Pages";
            // 
            // lblNoOfPages
            // 
            this.lblNoOfPages.AutoSize = true;
            this.lblNoOfPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfPages.Location = new System.Drawing.Point(195, 37);
            this.lblNoOfPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfPages.Name = "lblNoOfPages";
            this.lblNoOfPages.Size = new System.Drawing.Size(20, 22);
            this.lblNoOfPages.TabIndex = 4;
            this.lblNoOfPages.Text = "n";
            // 
            // lblSeperator
            // 
            this.lblSeperator.AutoSize = true;
            this.lblSeperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeperator.Location = new System.Drawing.Point(168, 37);
            this.lblSeperator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(15, 22);
            this.lblSeperator.TabIndex = 3;
            this.lblSeperator.Text = "/";
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPage.Location = new System.Drawing.Point(140, 37);
            this.lblCurrentPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(19, 22);
            this.lblCurrentPage.TabIndex = 2;
            this.lblCurrentPage.Text = "c";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(290, 29);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(48, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(72, 29);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(58, 35);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // grpBoxEmployeeGridView
            // 
            this.grpBoxEmployeeGridView.BackColor = System.Drawing.Color.White;
            this.grpBoxEmployeeGridView.Controls.Add(this.dgView);
            this.grpBoxEmployeeGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxEmployeeGridView.Location = new System.Drawing.Point(9, 492);
            this.grpBoxEmployeeGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxEmployeeGridView.Name = "grpBoxEmployeeGridView";
            this.grpBoxEmployeeGridView.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxEmployeeGridView.Size = new System.Drawing.Size(1554, 374);
            this.grpBoxEmployeeGridView.TabIndex = 14;
            this.grpBoxEmployeeGridView.TabStop = false;
            this.grpBoxEmployeeGridView.Text = "Existing Employee";
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(9, 46);
            this.dgView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 62;
            this.dgView.Size = new System.Drawing.Size(1525, 321);
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
            this.grpBoxButtons.Location = new System.Drawing.Point(549, 411);
            this.grpBoxButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxButtons.Name = "grpBoxButtons";
            this.grpBoxButtons.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxButtons.Size = new System.Drawing.Size(474, 74);
            this.grpBoxButtons.TabIndex = 13;
            this.grpBoxButtons.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 17);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 48);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(238, 17);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(108, 48);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(356, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 48);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 48);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpBoxRegistrationForm
            // 
            this.grpBoxRegistrationForm.Controls.Add(this.chkSelectAll);
            this.grpBoxRegistrationForm.Controls.Add(this.txtsearch);
            this.grpBoxRegistrationForm.Controls.Add(this.lblSelectProject);
            this.grpBoxRegistrationForm.Controls.Add(this.chklstbxProject);
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
            this.grpBoxRegistrationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRegistrationForm.Location = new System.Drawing.Point(9, 1);
            this.grpBoxRegistrationForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxRegistrationForm.Name = "grpBoxRegistrationForm";
            this.grpBoxRegistrationForm.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxRegistrationForm.Size = new System.Drawing.Size(1554, 400);
            this.grpBoxRegistrationForm.TabIndex = 11;
            this.grpBoxRegistrationForm.TabStop = false;
            this.grpBoxRegistrationForm.Text = "Employee Registeration Form";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(1035, 107);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(185, 29);
            this.chkSelectAll.TabIndex = 23;
            this.chkSelectAll.Text = "Select All Project";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtsearch.Location = new System.Drawing.Point(1035, 63);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(251, 37);
            this.txtsearch.TabIndex = 22;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblSelectProject
            // 
            this.lblSelectProject.AutoSize = true;
            this.lblSelectProject.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProject.Location = new System.Drawing.Point(1035, 35);
            this.lblSelectProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectProject.Name = "lblSelectProject";
            this.lblSelectProject.Size = new System.Drawing.Size(150, 23);
            this.lblSelectProject.TabIndex = 21;
            this.lblSelectProject.Text = "&Search Project";
            // 
            // chklstbxProject
            // 
            this.chklstbxProject.CheckOnClick = true;
            this.chklstbxProject.FormattingEnabled = true;
            this.chklstbxProject.Location = new System.Drawing.Point(1035, 140);
            this.chklstbxProject.Name = "chklstbxProject";
            this.chklstbxProject.Size = new System.Drawing.Size(251, 247);
            this.chklstbxProject.TabIndex = 20;
            this.chklstbxProject.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstbxProject_ItemCheck);
            // 
            // pbPwdIcon
            // 
            this.pbPwdIcon.Image = global::TMS.Properties.Resources.hoverIcon;
            this.pbPwdIcon.Location = new System.Drawing.Point(952, 255);
            this.pbPwdIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPwdIcon.Name = "pbPwdIcon";
            this.pbPwdIcon.Size = new System.Drawing.Size(38, 37);
            this.pbPwdIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPwdIcon.TabIndex = 19;
            this.pbPwdIcon.TabStop = false;
            this.pbPwdIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPwdIcon_MouseDown);
            this.pbPwdIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPwdIcon_MouseUp);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(444, 254);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(43, 41);
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
            this.cmbRole.Location = new System.Drawing.Point(106, 255);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(332, 38);
            this.cmbRole.TabIndex = 3;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(1368, 273);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(112, 41);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(25, 351);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(103, 26);
            this.chkActive.TabIndex = 4;
            this.chkActive.Text = "Is Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPwd.Location = new System.Drawing.Point(613, 255);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(332, 37);
            this.txtPwd.TabIndex = 7;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(505, 255);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(100, 23);
            this.lblPwd.TabIndex = 11;
            this.lblPwd.Text = "&Password";
            // 
            // rtxtRemark
            // 
            this.rtxtRemark.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtxtRemark.Location = new System.Drawing.Point(613, 165);
            this.rtxtRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtRemark.Name = "rtxtRemark";
            this.rtxtRemark.Size = new System.Drawing.Size(332, 73);
            this.rtxtRemark.TabIndex = 6;
            this.rtxtRemark.Text = "";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(19, 165);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(19, 74);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(76, 23);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "&User Id";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEmail.Location = new System.Drawing.Point(613, 69);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(332, 37);
            this.txtEmail.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(19, 255);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(53, 23);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Role";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(505, 69);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtName.Location = new System.Drawing.Point(106, 165);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(332, 37);
            this.txtName.TabIndex = 2;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.Location = new System.Drawing.Point(505, 165);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(94, 23);
            this.lblRemark.TabIndex = 5;
            this.lblRemark.Text = "Remarks";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUserId.Location = new System.Drawing.Point(106, 69);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(332, 37);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserId_KeyPress);
            // 
            // pbPic
            // 
            this.pbPic.Image = global::TMS.Properties.Resources.dp;
            this.pbPic.Location = new System.Drawing.Point(1336, 65);
            this.pbPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(173, 186);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic.TabIndex = 18;
            this.pbPic.TabStop = false;
            // 
            // FrmTeamRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 961);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTeamRegister";
            this.Text = "Team Management";
            this.Load += new System.EventHandler(this.FrmTeamRegister_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.grpBoxPaging.ResumeLayout(false);
            this.grpBoxPaging.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpBoxPaging;
        private System.Windows.Forms.Label lblNoOfPages;
        private System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblNoOfRecordPerPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.ComboBox cmbNoOfRecordsPerPage;
        private System.Windows.Forms.CheckedListBox chklstbxProject;
        private System.Windows.Forms.Label lblSelectProject;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.CheckBox chkSelectAll;
    }
}