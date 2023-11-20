namespace TMS.UI
{
    partial class AssigneeBasedReport
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
            this.lblAssignee = new System.Windows.Forms.Label();
            this.cmbAssignee = new System.Windows.Forms.ComboBox();
            this.grpBoxGridView = new System.Windows.Forms.GroupBox();
            this.dView = new System.Windows.Forms.DataGridView();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.chkDateAndAssignee = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnGetRecord = new System.Windows.Forms.Button();
            this.grpBoxPaging = new System.Windows.Forms.GroupBox();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblNoOfPages = new System.Windows.Forms.Label();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.cmbNoOfRecordsPerPage = new System.Windows.Forms.ComboBox();
            this.lblNoOfRecordPerPage = new System.Windows.Forms.Label();
            this.pnlOuter = new System.Windows.Forms.Panel();
            this.dtpDateTo = new TMS.UI.Utilities.CustomDatetimePicker();
            this.dtpDateFrom = new TMS.UI.Utilities.CustomDatetimePicker();
            this.grpBoxGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dView)).BeginInit();
            this.grpBoxPaging.SuspendLayout();
            this.pnlOuter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAssignee
            // 
            this.lblAssignee.AutoSize = true;
            this.lblAssignee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignee.Location = new System.Drawing.Point(489, 23);
            this.lblAssignee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignee.Name = "lblAssignee";
            this.lblAssignee.Size = new System.Drawing.Size(195, 28);
            this.lblAssignee.TabIndex = 8;
            this.lblAssignee.Text = "Select Assignee";
            // 
            // cmbAssignee
            // 
            this.cmbAssignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssignee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbAssignee.FormattingEnabled = true;
            this.cmbAssignee.Location = new System.Drawing.Point(686, 23);
            this.cmbAssignee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAssignee.Name = "cmbAssignee";
            this.cmbAssignee.Size = new System.Drawing.Size(442, 38);
            this.cmbAssignee.TabIndex = 9;
            this.cmbAssignee.SelectedIndexChanged += new System.EventHandler(this.cmbAssignee_SelectedIndexChanged);
            // 
            // grpBoxGridView
            // 
            this.grpBoxGridView.BackColor = System.Drawing.Color.White;
            this.grpBoxGridView.Controls.Add(this.dView);
            this.grpBoxGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxGridView.Location = new System.Drawing.Point(18, 194);
            this.grpBoxGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxGridView.Name = "grpBoxGridView";
            this.grpBoxGridView.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxGridView.Size = new System.Drawing.Size(1650, 638);
            this.grpBoxGridView.TabIndex = 16;
            this.grpBoxGridView.TabStop = false;
            this.grpBoxGridView.Text = "Assignee Based Report";
            // 
            // dView
            // 
            this.dView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dView.GridColor = System.Drawing.Color.Gray;
            this.dView.Location = new System.Drawing.Point(9, 38);
            this.dView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dView.Name = "dView";
            this.dView.RowHeadersWidth = 62;
            this.dView.Size = new System.Drawing.Size(1629, 589);
            this.dView.TabIndex = 0;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(489, 80);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(132, 28);
            this.lblStartDate.TabIndex = 30;
            this.lblStartDate.Text = "From Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(489, 142);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(99, 28);
            this.lblEndDate.TabIndex = 31;
            this.lblEndDate.Text = "To Date";
            // 
            // chkDateAndAssignee
            // 
            this.chkDateAndAssignee.AutoSize = true;
            this.chkDateAndAssignee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateAndAssignee.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.chkDateAndAssignee.Location = new System.Drawing.Point(1138, 77);
            this.chkDateAndAssignee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDateAndAssignee.Name = "chkDateAndAssignee";
            this.chkDateAndAssignee.Size = new System.Drawing.Size(322, 33);
            this.chkDateAndAssignee.TabIndex = 34;
            this.chkDateAndAssignee.Text = "Time and Assignee Based";
            this.chkDateAndAssignee.UseVisualStyleBackColor = true;
            this.chkDateAndAssignee.CheckedChanged += new System.EventHandler(this.chkDateAndAssignee_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1329, 149);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(182, 48);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnGetRecord
            // 
            this.btnGetRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGetRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRecord.ForeColor = System.Drawing.Color.White;
            this.btnGetRecord.Location = new System.Drawing.Point(1138, 149);
            this.btnGetRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetRecord.Name = "btnGetRecord";
            this.btnGetRecord.Size = new System.Drawing.Size(182, 48);
            this.btnGetRecord.TabIndex = 26;
            this.btnGetRecord.Text = "Get Report";
            this.btnGetRecord.UseVisualStyleBackColor = false;
            this.btnGetRecord.Click += new System.EventHandler(this.btnGetRecord_Click);
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
            this.grpBoxPaging.Location = new System.Drawing.Point(579, 843);
            this.grpBoxPaging.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPaging.Name = "grpBoxPaging";
            this.grpBoxPaging.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPaging.Size = new System.Drawing.Size(404, 78);
            this.grpBoxPaging.TabIndex = 35;
            this.grpBoxPaging.TabStop = false;
            this.grpBoxPaging.Enter += new System.EventHandler(this.grpBoxPaging_Enter);
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
            // cmbNoOfRecordsPerPage
            // 
            this.cmbNoOfRecordsPerPage.FormattingEnabled = true;
            this.cmbNoOfRecordsPerPage.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.cmbNoOfRecordsPerPage.Location = new System.Drawing.Point(114, 839);
            this.cmbNoOfRecordsPerPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNoOfRecordsPerPage.Name = "cmbNoOfRecordsPerPage";
            this.cmbNoOfRecordsPerPage.Size = new System.Drawing.Size(66, 28);
            this.cmbNoOfRecordsPerPage.TabIndex = 36;
            this.cmbNoOfRecordsPerPage.Text = "5";
            this.cmbNoOfRecordsPerPage.SelectedIndexChanged += new System.EventHandler(this.cmbNoOfRecordsPerPage_SelectedIndexChanged);
            // 
            // lblNoOfRecordPerPage
            // 
            this.lblNoOfRecordPerPage.AutoSize = true;
            this.lblNoOfRecordPerPage.Location = new System.Drawing.Point(22, 843);
            this.lblNoOfRecordPerPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfRecordPerPage.Name = "lblNoOfRecordPerPage";
            this.lblNoOfRecordPerPage.Size = new System.Drawing.Size(81, 20);
            this.lblNoOfRecordPerPage.TabIndex = 37;
            this.lblNoOfRecordPerPage.Text = "Page Size";
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.White;
            this.pnlOuter.Controls.Add(this.lblNoOfRecordPerPage);
            this.pnlOuter.Controls.Add(this.cmbNoOfRecordsPerPage);
            this.pnlOuter.Controls.Add(this.grpBoxPaging);
            this.pnlOuter.Controls.Add(this.dtpDateTo);
            this.pnlOuter.Controls.Add(this.dtpDateFrom);
            this.pnlOuter.Controls.Add(this.btnGetRecord);
            this.pnlOuter.Controls.Add(this.btnPrint);
            this.pnlOuter.Controls.Add(this.chkDateAndAssignee);
            this.pnlOuter.Controls.Add(this.lblEndDate);
            this.pnlOuter.Controls.Add(this.lblStartDate);
            this.pnlOuter.Controls.Add(this.grpBoxGridView);
            this.pnlOuter.Controls.Add(this.cmbAssignee);
            this.pnlOuter.Controls.Add(this.lblAssignee);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1677, 1034);
            this.pnlOuter.TabIndex = 4;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Bordercolor = System.Drawing.Color.Gray;
            this.dtpDateTo.BorderSize = 0;
            this.dtpDateTo.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpDateTo.Location = new System.Drawing.Point(686, 142);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(442, 35);
            this.dtpDateTo.TabIndex = 33;
            this.dtpDateTo.Textcolor = System.Drawing.Color.White;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Bordercolor = System.Drawing.Color.Gray;
            this.dtpDateFrom.BorderSize = 0;
            this.dtpDateFrom.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpDateFrom.Location = new System.Drawing.Point(686, 80);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateFrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(442, 35);
            this.dtpDateFrom.TabIndex = 32;
            this.dtpDateFrom.Textcolor = System.Drawing.Color.White;
            // 
            // AssigneeBasedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1677, 1034);
            this.Controls.Add(this.pnlOuter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AssigneeBasedReport";
            this.Text = "Assignee Based Report";
            this.Load += new System.EventHandler(this.AssigneeBasedReport_Load);
            this.grpBoxGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dView)).EndInit();
            this.grpBoxPaging.ResumeLayout(false);
            this.grpBoxPaging.PerformLayout();
            this.pnlOuter.ResumeLayout(false);
            this.pnlOuter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAssignee;
        private System.Windows.Forms.ComboBox cmbAssignee;
        private System.Windows.Forms.GroupBox grpBoxGridView;
        private System.Windows.Forms.DataGridView dView;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.CheckBox chkDateAndAssignee;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnGetRecord;
        private Utilities.CustomDatetimePicker dtpDateFrom;
        private Utilities.CustomDatetimePicker dtpDateTo;
        private System.Windows.Forms.GroupBox grpBoxPaging;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblNoOfPages;
        private System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ComboBox cmbNoOfRecordsPerPage;
        private System.Windows.Forms.Label lblNoOfRecordPerPage;
        private System.Windows.Forms.Panel pnlOuter;
    }
}