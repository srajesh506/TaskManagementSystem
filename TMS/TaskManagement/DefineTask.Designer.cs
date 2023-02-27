namespace TMS.UI
{
    partial class DefineTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlOuter = new System.Windows.Forms.Panel();
            this.lblNoOfRecordPerPage = new System.Windows.Forms.Label();
            this.cmbNoOfRecordsPerPage = new System.Windows.Forms.ComboBox();
            this.grpBoxPaging = new System.Windows.Forms.GroupBox();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblNoOfPages = new System.Windows.Forms.Label();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.grpBoxDataGrid = new System.Windows.Forms.GroupBox();
            this.dView = new System.Windows.Forms.DataGridView();
            this.grpBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpBoxInputControls = new System.Windows.Forms.GroupBox();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.rtxtTaskDescription = new System.Windows.Forms.RichTextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.pnlOuter.SuspendLayout();
            this.grpBoxPaging.SuspendLayout();
            this.grpBoxDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dView)).BeginInit();
            this.grpBoxButtons.SuspendLayout();
            this.grpBoxInputControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.White;
            this.pnlOuter.Controls.Add(this.lblNoOfRecordPerPage);
            this.pnlOuter.Controls.Add(this.cmbNoOfRecordsPerPage);
            this.pnlOuter.Controls.Add(this.grpBoxPaging);
            this.pnlOuter.Controls.Add(this.grpBoxDataGrid);
            this.pnlOuter.Controls.Add(this.grpBoxButtons);
            this.pnlOuter.Controls.Add(this.grpBoxInputControls);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1097, 636);
            this.pnlOuter.TabIndex = 2;
            // 
            // lblNoOfRecordPerPage
            // 
            this.lblNoOfRecordPerPage.AutoSize = true;
            this.lblNoOfRecordPerPage.Location = new System.Drawing.Point(641, 573);
            this.lblNoOfRecordPerPage.Name = "lblNoOfRecordPerPage";
            this.lblNoOfRecordPerPage.Size = new System.Drawing.Size(125, 13);
            this.lblNoOfRecordPerPage.TabIndex = 23;
            this.lblNoOfRecordPerPage.Text = "No Of Records Per Page";
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
            this.cmbNoOfRecordsPerPage.Location = new System.Drawing.Point(769, 569);
            this.cmbNoOfRecordsPerPage.Name = "cmbNoOfRecordsPerPage";
            this.cmbNoOfRecordsPerPage.Size = new System.Drawing.Size(45, 21);
            this.cmbNoOfRecordsPerPage.TabIndex = 22;
            this.cmbNoOfRecordsPerPage.Text = "5";
            this.cmbNoOfRecordsPerPage.SelectedIndexChanged += new System.EventHandler(this.cmbNoOfRecordsPerPage_SelectedIndexChanged);
            // 
            // grpBoxPaging
            // 
            this.grpBoxPaging.Controls.Add(this.btnLastPage);
            this.grpBoxPaging.Controls.Add(this.btnFirstPage);
            this.grpBoxPaging.Controls.Add(this.lblPages);
            this.grpBoxPaging.Controls.Add(this.lblNoOfPages);
            this.grpBoxPaging.Controls.Add(this.lblSeperator);
            this.grpBoxPaging.Controls.Add(this.lblCurrentPage);
            this.grpBoxPaging.Controls.Add(this.btnNext);
            this.grpBoxPaging.Controls.Add(this.btnPrevious);
            this.grpBoxPaging.Location = new System.Drawing.Point(365, 554);
            this.grpBoxPaging.Name = "grpBoxPaging";
            this.grpBoxPaging.Size = new System.Drawing.Size(269, 51);
            this.grpBoxPaging.TabIndex = 18;
            this.grpBoxPaging.TabStop = false;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(231, 19);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(31, 23);
            this.btnLastPage.TabIndex = 7;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(7, 19);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(35, 23);
            this.btnFirstPage.TabIndex = 6;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(150, 24);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(37, 13);
            this.lblPages.TabIndex = 5;
            this.lblPages.Text = "Pages";
            // 
            // lblNoOfPages
            // 
            this.lblNoOfPages.AutoSize = true;
            this.lblNoOfPages.Location = new System.Drawing.Point(130, 24);
            this.lblNoOfPages.Name = "lblNoOfPages";
            this.lblNoOfPages.Size = new System.Drawing.Size(13, 13);
            this.lblNoOfPages.TabIndex = 4;
            this.lblNoOfPages.Text = "n";
            // 
            // lblSeperator
            // 
            this.lblSeperator.AutoSize = true;
            this.lblSeperator.Location = new System.Drawing.Point(112, 24);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(12, 13);
            this.lblSeperator.TabIndex = 3;
            this.lblSeperator.Text = "/";
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Location = new System.Drawing.Point(93, 24);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentPage.TabIndex = 2;
            this.lblCurrentPage.Text = "c";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(193, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(48, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(39, 23);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // grpBoxDataGrid
            // 
            this.grpBoxDataGrid.BackColor = System.Drawing.Color.White;
            this.grpBoxDataGrid.Controls.Add(this.dView);
            this.grpBoxDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDataGrid.Location = new System.Drawing.Point(12, 290);
            this.grpBoxDataGrid.Name = "grpBoxDataGrid";
            this.grpBoxDataGrid.Size = new System.Drawing.Size(1076, 262);
            this.grpBoxDataGrid.TabIndex = 15;
            this.grpBoxDataGrid.TabStop = false;
            this.grpBoxDataGrid.Text = "Existing Task and Description";
            // 
            // dView
            // 
            this.dView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dView.GridColor = System.Drawing.Color.Gray;
            this.dView.Location = new System.Drawing.Point(6, 24);
            this.dView.Name = "dView";
            this.dView.Size = new System.Drawing.Size(1054, 230);
            this.dView.TabIndex = 0;
            this.dView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dView_CellClick);
            // 
            // grpBoxButtons
            // 
            this.grpBoxButtons.Controls.Add(this.btnSave);
            this.grpBoxButtons.Controls.Add(this.btnModify);
            this.grpBoxButtons.Controls.Add(this.btnCancel);
            this.grpBoxButtons.Controls.Add(this.btnAdd);
            this.grpBoxButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxButtons.Location = new System.Drawing.Point(403, 197);
            this.grpBoxButtons.Name = "grpBoxButtons";
            this.grpBoxButtons.Size = new System.Drawing.Size(316, 48);
            this.grpBoxButtons.TabIndex = 14;
            this.grpBoxButtons.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(159, 11);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(72, 31);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 31);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 31);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpBoxInputControls
            // 
            this.grpBoxInputControls.Controls.Add(this.cmbActivity);
            this.grpBoxInputControls.Controls.Add(this.lblActivity);
            this.grpBoxInputControls.Controls.Add(this.chkActive);
            this.grpBoxInputControls.Controls.Add(this.rtxtTaskDescription);
            this.grpBoxInputControls.Controls.Add(this.lblTaskName);
            this.grpBoxInputControls.Controls.Add(this.lblTaskDescription);
            this.grpBoxInputControls.Controls.Add(this.txtTaskName);
            this.grpBoxInputControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBoxInputControls.Location = new System.Drawing.Point(12, 2);
            this.grpBoxInputControls.Name = "grpBoxInputControls";
            this.grpBoxInputControls.Size = new System.Drawing.Size(1076, 191);
            this.grpBoxInputControls.TabIndex = 12;
            this.grpBoxInputControls.TabStop = false;
            this.grpBoxInputControls.Text = "Define Task";
            // 
            // cmbActivity
            // 
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(478, 23);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(296, 29);
            this.cmbActivity.TabIndex = 9;
            this.cmbActivity.SelectedIndexChanged += new System.EventHandler(this.cmbActivity_SelectedIndexChanged);
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(315, 27);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(115, 19);
            this.lblActivity.TabIndex = 8;
            this.lblActivity.Text = "Select Activity";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(478, 163);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(69, 19);
            this.chkActive.TabIndex = 7;
            this.chkActive.Text = "Is Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // rtxtTaskDescription
            // 
            this.rtxtTaskDescription.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtxtTaskDescription.Location = new System.Drawing.Point(478, 98);
            this.rtxtTaskDescription.Name = "rtxtTaskDescription";
            this.rtxtTaskDescription.Size = new System.Drawing.Size(296, 62);
            this.rtxtTaskDescription.TabIndex = 6;
            this.rtxtTaskDescription.Text = "";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(315, 63);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(95, 19);
            this.lblTaskName.TabIndex = 1;
            this.lblTaskName.Text = "Task Name";
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTaskDescription.Location = new System.Drawing.Point(315, 98);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(131, 19);
            this.lblTaskDescription.TabIndex = 5;
            this.lblTaskDescription.Text = "Task Description";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTaskName.Location = new System.Drawing.Point(478, 63);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(296, 27);
            this.txtTaskName.TabIndex = 1;
            // 
            // DefineTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlOuter);
            this.Name = "DefineTask";
            this.Size = new System.Drawing.Size(1097, 636);
            this.Load += new System.EventHandler(this.DefineTask_Load);
            this.pnlOuter.ResumeLayout(false);
            this.pnlOuter.PerformLayout();
            this.grpBoxPaging.ResumeLayout(false);
            this.grpBoxPaging.PerformLayout();
            this.grpBoxDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dView)).EndInit();
            this.grpBoxButtons.ResumeLayout(false);
            this.grpBoxInputControls.ResumeLayout(false);
            this.grpBoxInputControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.GroupBox grpBoxDataGrid;
        private System.Windows.Forms.DataGridView dView;
        private System.Windows.Forms.GroupBox grpBoxButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpBoxInputControls;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.RichTextBox rtxtTaskDescription;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.GroupBox grpBoxPaging;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblNoOfPages;
        private System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblNoOfRecordPerPage;
        private System.Windows.Forms.ComboBox cmbNoOfRecordsPerPage;
    }
}
