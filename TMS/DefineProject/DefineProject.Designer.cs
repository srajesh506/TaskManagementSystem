namespace TMS.UI{
    partial class FrmAssignProject
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
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.rtxtProjectDescription = new System.Windows.Forms.RichTextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectDescription = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.grpBoxPaging.SuspendLayout();
            this.grpBoxEmployeeGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.grpBoxButtons.SuspendLayout();
            this.grpBoxRegistrationForm.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(1563, 883);
            this.pnlMain.TabIndex = 0;
            // cmbNoOfRecordsPerPage
            // 
            this.cmbNoOfRecordsPerPage.FormattingEnabled = true;
            this.cmbNoOfRecordsPerPage.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.cmbNoOfRecordsPerPage.Location = new System.Drawing.Point(102, 796);
            this.cmbNoOfRecordsPerPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNoOfRecordsPerPage.Name = "cmbNoOfRecordsPerPage";
            this.cmbNoOfRecordsPerPage.Size = new System.Drawing.Size(66, 28);
            this.cmbNoOfRecordsPerPage.TabIndex = 13;
            this.cmbNoOfRecordsPerPage.Text = "5";
            this.cmbNoOfRecordsPerPage.SelectedIndexChanged += new System.EventHandler(this.cmbNoOfRecordsPerPage_SelectedIndexChanged);
            // 
            // lblNoOfRecordPerPage
            // 
            this.lblNoOfRecordPerPage.AutoSize = true;
            this.lblNoOfRecordPerPage.BackColor = System.Drawing.Color.White;
            this.lblNoOfRecordPerPage.Location = new System.Drawing.Point(18, 796);
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
            this.grpBoxPaging.Location = new System.Drawing.Point(575, 796);
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
            this.btnLastPage.TabIndex = 11;
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
            this.btnFirstPage.TabIndex = 12;
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
            this.btnNext.TabIndex = 9;
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
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // grpBoxEmployeeGridView
            // 
            this.grpBoxEmployeeGridView.BackColor = System.Drawing.Color.White;
            this.grpBoxEmployeeGridView.Controls.Add(this.dgView);
            this.grpBoxEmployeeGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxEmployeeGridView.Location = new System.Drawing.Point(9, 402);
            this.grpBoxEmployeeGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxEmployeeGridView.Name = "grpBoxEmployeeGridView";
            this.grpBoxEmployeeGridView.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxEmployeeGridView.Size = new System.Drawing.Size(1536, 381);
            this.grpBoxEmployeeGridView.TabIndex = 14;
            this.grpBoxEmployeeGridView.TabStop = false;
            this.grpBoxEmployeeGridView.Text = "Existing Projects";
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeight = 34;
            this.dgView.Location = new System.Drawing.Point(10, 29);
            this.dgView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 62;
            this.dgView.Size = new System.Drawing.Size(1508, 341);
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
            this.grpBoxButtons.Location = new System.Drawing.Point(549, 310);
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
            this.btnSave.TabIndex = 6;
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
            this.btnModify.TabIndex = 7;
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
            this.btnCancel.TabIndex = 8;
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
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpBoxRegistrationForm
            // 
            this.grpBoxRegistrationForm.Controls.Add(this.chkActive);
            this.grpBoxRegistrationForm.Controls.Add(this.rtxtProjectDescription);
            this.grpBoxRegistrationForm.Controls.Add(this.lblProjectName);
            this.grpBoxRegistrationForm.Controls.Add(this.txtProjectName);
            this.grpBoxRegistrationForm.Controls.Add(this.lblProjectDescription);
            this.grpBoxRegistrationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBoxRegistrationForm.Location = new System.Drawing.Point(9, 6);
            this.grpBoxRegistrationForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxRegistrationForm.Name = "grpBoxRegistrationForm";
            this.grpBoxRegistrationForm.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxRegistrationForm.Size = new System.Drawing.Size(1536, 270);
            this.grpBoxRegistrationForm.TabIndex = 11;
            this.grpBoxRegistrationForm.TabStop = false;
            this.grpBoxRegistrationForm.Text = "Project Registeration Form";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(710, 226);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(103, 26);
            this.chkActive.TabIndex = 4;
            this.chkActive.Text = "Is Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // rtxtProjectDescription
            // 
            this.rtxtProjectDescription.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtxtProjectDescription.Location = new System.Drawing.Point(710, 89);
            this.rtxtProjectDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtProjectDescription.Name = "rtxtProjectDescription";
            this.rtxtProjectDescription.Size = new System.Drawing.Size(332, 124);
            this.rtxtProjectDescription.TabIndex = 3;
            this.rtxtProjectDescription.Text = "";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblProjectName.Location = new System.Drawing.Point(479, 24);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(170, 28);
            this.lblProjectName.TabIndex = 2;
            this.lblProjectName.Text = "Project Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtProjectName.Location = new System.Drawing.Point(710, 24);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(332, 37);
            this.txtProjectName.TabIndex = 2;
            // 
            // lblProjectDescription
            // 
            this.lblProjectDescription.AutoSize = true;
            this.lblProjectDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblProjectDescription.Location = new System.Drawing.Point(479, 93);
            this.lblProjectDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectDescription.Name = "lblProjectDescription";
            this.lblProjectDescription.Size = new System.Drawing.Size(228, 28);
            this.lblProjectDescription.TabIndex = 5;
            this.lblProjectDescription.Text = "Project Description";
            // 
            // FrmAssignProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 883);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAssignProject";
            this.Text = "Project Management";
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblProjectDescription;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.GroupBox grpBoxButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpBoxRegistrationForm;
        private System.Windows.Forms.RichTextBox rtxtProjectDescription;
        private System.Windows.Forms.GroupBox grpBoxEmployeeGridView;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.CheckBox chkActive;
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
    }
}