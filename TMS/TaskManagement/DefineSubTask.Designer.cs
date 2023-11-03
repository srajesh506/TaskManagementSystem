namespace TMS.UI
{
    partial class DefineSubTask
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
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.rtxtSubTaskDescription = new System.Windows.Forms.RichTextBox();
            this.lblSubTaskName = new System.Windows.Forms.Label();
            this.lblSubTaskDescription = new System.Windows.Forms.Label();
            this.txtSubTaskName = new System.Windows.Forms.TextBox();
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
            this.pnlOuter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1646, 875);
            this.pnlOuter.TabIndex = 3;
            // 
            // lblNoOfRecordPerPage
            // 
            this.lblNoOfRecordPerPage.AutoSize = true;
            this.lblNoOfRecordPerPage.Location = new System.Drawing.Point(22, 739);
            this.lblNoOfRecordPerPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfRecordPerPage.Name = "lblNoOfRecordPerPage";
            this.lblNoOfRecordPerPage.Size = new System.Drawing.Size(81, 20);
            this.lblNoOfRecordPerPage.TabIndex = 21;
            this.lblNoOfRecordPerPage.Text = "Page Size";
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
            this.cmbNoOfRecordsPerPage.Location = new System.Drawing.Point(108, 739);
            this.cmbNoOfRecordsPerPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNoOfRecordsPerPage.Name = "cmbNoOfRecordsPerPage";
            this.cmbNoOfRecordsPerPage.Size = new System.Drawing.Size(66, 28);
            this.cmbNoOfRecordsPerPage.TabIndex = 20;
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
            this.grpBoxPaging.Location = new System.Drawing.Point(522, 735);
            this.grpBoxPaging.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPaging.Name = "grpBoxPaging";
            this.grpBoxPaging.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPaging.Size = new System.Drawing.Size(404, 78);
            this.grpBoxPaging.TabIndex = 17;
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
            this.lblPages.Location = new System.Drawing.Point(225, 37);
            this.lblPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(54, 20);
            this.lblPages.TabIndex = 5;
            this.lblPages.Text = "Pages";
            // 
            // lblNoOfPages
            // 
            this.lblNoOfPages.AutoSize = true;
            this.lblNoOfPages.Location = new System.Drawing.Point(195, 37);
            this.lblNoOfPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfPages.Name = "lblNoOfPages";
            this.lblNoOfPages.Size = new System.Drawing.Size(18, 20);
            this.lblNoOfPages.TabIndex = 4;
            this.lblNoOfPages.Text = "n";
            // 
            // lblSeperator
            // 
            this.lblSeperator.AutoSize = true;
            this.lblSeperator.Location = new System.Drawing.Point(168, 37);
            this.lblSeperator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(13, 20);
            this.lblSeperator.TabIndex = 3;
            this.lblSeperator.Text = "/";
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Location = new System.Drawing.Point(140, 37);
            this.lblCurrentPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(17, 20);
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
            // grpBoxDataGrid
            // 
            this.grpBoxDataGrid.BackColor = System.Drawing.Color.White;
            this.grpBoxDataGrid.Controls.Add(this.dView);
            this.grpBoxDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDataGrid.Location = new System.Drawing.Point(18, 425);
            this.grpBoxDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxDataGrid.Name = "grpBoxDataGrid";
            this.grpBoxDataGrid.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxDataGrid.Size = new System.Drawing.Size(1614, 305);
            this.grpBoxDataGrid.TabIndex = 15;
            this.grpBoxDataGrid.TabStop = false;
            this.grpBoxDataGrid.Text = "Existing SubTask and Description";
            // 
            // dView
            // 
            this.dView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dView.GridColor = System.Drawing.Color.Gray;
            this.dView.Location = new System.Drawing.Point(9, 34);
            this.dView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dView.Name = "dView";
            this.dView.RowHeadersWidth = 62;
            this.dView.Size = new System.Drawing.Size(1581, 259);
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
            this.grpBoxButtons.Location = new System.Drawing.Point(604, 344);
            this.grpBoxButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxButtons.Name = "grpBoxButtons";
            this.grpBoxButtons.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxButtons.Size = new System.Drawing.Size(474, 74);
            this.grpBoxButtons.TabIndex = 14;
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
            // grpBoxInputControls
            // 
            this.grpBoxInputControls.Controls.Add(this.cmbTask);
            this.grpBoxInputControls.Controls.Add(this.lblTask);
            this.grpBoxInputControls.Controls.Add(this.cmbActivity);
            this.grpBoxInputControls.Controls.Add(this.lblActivity);
            this.grpBoxInputControls.Controls.Add(this.chkActive);
            this.grpBoxInputControls.Controls.Add(this.rtxtSubTaskDescription);
            this.grpBoxInputControls.Controls.Add(this.lblSubTaskName);
            this.grpBoxInputControls.Controls.Add(this.lblSubTaskDescription);
            this.grpBoxInputControls.Controls.Add(this.txtSubTaskName);
            this.grpBoxInputControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBoxInputControls.Location = new System.Drawing.Point(18, 3);
            this.grpBoxInputControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxInputControls.Name = "grpBoxInputControls";
            this.grpBoxInputControls.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxInputControls.Size = new System.Drawing.Size(1581, 335);
            this.grpBoxInputControls.TabIndex = 12;
            this.grpBoxInputControls.TabStop = false;
            this.grpBoxInputControls.Text = "Define SubTask";
            // 
            // cmbTask
            // 
            this.cmbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbTask.FormattingEnabled = true;
            this.cmbTask.Location = new System.Drawing.Point(717, 94);
            this.cmbTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Size = new System.Drawing.Size(442, 38);
            this.cmbTask.TabIndex = 11;
            this.cmbTask.SelectedIndexChanged += new System.EventHandler(this.cmbTask_SelectedIndexChanged);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(472, 94);
            this.lblTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(140, 28);
            this.lblTask.TabIndex = 10;
            this.lblTask.Text = "Select Task";
            // 
            // cmbActivity
            // 
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(717, 35);
            this.cmbActivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(442, 38);
            this.cmbActivity.TabIndex = 9;
            this.cmbActivity.SelectedIndexChanged += new System.EventHandler(this.cmbActivity_SelectedIndexChanged);
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(472, 35);
            this.lblActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(175, 28);
            this.lblActivity.TabIndex = 8;
            this.lblActivity.Text = "Select Activity";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(717, 300);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(103, 26);
            this.chkActive.TabIndex = 7;
            this.chkActive.Text = "Is Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // rtxtSubTaskDescription
            // 
            this.rtxtSubTaskDescription.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtxtSubTaskDescription.Location = new System.Drawing.Point(717, 200);
            this.rtxtSubTaskDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtSubTaskDescription.Name = "rtxtSubTaskDescription";
            this.rtxtSubTaskDescription.Size = new System.Drawing.Size(442, 93);
            this.rtxtSubTaskDescription.TabIndex = 6;
            this.rtxtSubTaskDescription.Text = "";
            // 
            // lblSubTaskName
            // 
            this.lblSubTaskName.AutoSize = true;
            this.lblSubTaskName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTaskName.Location = new System.Drawing.Point(472, 146);
            this.lblSubTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTaskName.Name = "lblSubTaskName";
            this.lblSubTaskName.Size = new System.Drawing.Size(184, 28);
            this.lblSubTaskName.TabIndex = 1;
            this.lblSubTaskName.Text = "SubTask Name";
            // 
            // lblSubTaskDescription
            // 
            this.lblSubTaskDescription.AutoSize = true;
            this.lblSubTaskDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubTaskDescription.Location = new System.Drawing.Point(472, 200);
            this.lblSubTaskDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTaskDescription.Name = "lblSubTaskDescription";
            this.lblSubTaskDescription.Size = new System.Drawing.Size(242, 28);
            this.lblSubTaskDescription.TabIndex = 5;
            this.lblSubTaskDescription.Text = "SubTask Description";
            // 
            // txtSubTaskName
            // 
            this.txtSubTaskName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSubTaskName.Location = new System.Drawing.Point(717, 146);
            this.txtSubTaskName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubTaskName.Name = "txtSubTaskName";
            this.txtSubTaskName.Size = new System.Drawing.Size(442, 37);
            this.txtSubTaskName.TabIndex = 1;
            // 
            // DefineSubTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlOuter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DefineSubTask";
            this.Size = new System.Drawing.Size(1646, 875);
            this.Load += new System.EventHandler(this.DefineSubTask_Load);
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
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.RichTextBox rtxtSubTaskDescription;
        private System.Windows.Forms.Label lblSubTaskName;
        private System.Windows.Forms.Label lblSubTaskDescription;
        private System.Windows.Forms.TextBox txtSubTaskName;
        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.Label lblTask;
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
