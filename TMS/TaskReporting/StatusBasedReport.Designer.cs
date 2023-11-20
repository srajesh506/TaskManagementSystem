namespace TMS.UI
{
    partial class StatusBasedReport
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
            this.btnGetRecord = new System.Windows.Forms.Button();
            this.dtpDateTo = new TMS.UI.Utilities.CustomDatetimePicker();
            this.dtpDateFrom = new TMS.UI.Utilities.CustomDatetimePicker();
            this.chkTimeAndStatus = new System.Windows.Forms.CheckBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpBoxDataGrid = new System.Windows.Forms.GroupBox();
            this.dView = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlOuter.SuspendLayout();
            this.grpBoxPaging.SuspendLayout();
            this.grpBoxDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.White;
            this.pnlOuter.Controls.Add(this.lblNoOfRecordPerPage);
            this.pnlOuter.Controls.Add(this.cmbNoOfRecordsPerPage);
            this.pnlOuter.Controls.Add(this.grpBoxPaging);
            this.pnlOuter.Controls.Add(this.btnGetRecord);
            this.pnlOuter.Controls.Add(this.dtpDateTo);
            this.pnlOuter.Controls.Add(this.dtpDateFrom);
            this.pnlOuter.Controls.Add(this.chkTimeAndStatus);
            this.pnlOuter.Controls.Add(this.lblEndDate);
            this.pnlOuter.Controls.Add(this.lblStartDate);
            this.pnlOuter.Controls.Add(this.btnPrint);
            this.pnlOuter.Controls.Add(this.grpBoxDataGrid);
            this.pnlOuter.Controls.Add(this.cmbStatus);
            this.pnlOuter.Controls.Add(this.lblStatus);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1672, 1040);
            this.pnlOuter.TabIndex = 4;
            // 
            // lblNoOfRecordPerPage
            // 
            this.lblNoOfRecordPerPage.AutoSize = true;
            this.lblNoOfRecordPerPage.Location = new System.Drawing.Point(22, 820);
            this.lblNoOfRecordPerPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfRecordPerPage.Name = "lblNoOfRecordPerPage";
            this.lblNoOfRecordPerPage.Size = new System.Drawing.Size(81, 20);
            this.lblNoOfRecordPerPage.TabIndex = 43;
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
            this.cmbNoOfRecordsPerPage.Location = new System.Drawing.Point(114, 820);
            this.cmbNoOfRecordsPerPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNoOfRecordsPerPage.Name = "cmbNoOfRecordsPerPage";
            this.cmbNoOfRecordsPerPage.Size = new System.Drawing.Size(66, 28);
            this.cmbNoOfRecordsPerPage.TabIndex = 42;
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
            this.grpBoxPaging.Location = new System.Drawing.Point(668, 820);
            this.grpBoxPaging.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPaging.Name = "grpBoxPaging";
            this.grpBoxPaging.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPaging.Size = new System.Drawing.Size(404, 78);
            this.grpBoxPaging.TabIndex = 41;
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
            // btnGetRecord
            // 
            this.btnGetRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGetRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRecord.ForeColor = System.Drawing.Color.White;
            this.btnGetRecord.Location = new System.Drawing.Point(1046, 142);
            this.btnGetRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetRecord.Name = "btnGetRecord";
            this.btnGetRecord.Size = new System.Drawing.Size(182, 48);
            this.btnGetRecord.TabIndex = 40;
            this.btnGetRecord.Text = "Get Report";
            this.btnGetRecord.UseVisualStyleBackColor = false;
            this.btnGetRecord.Click += new System.EventHandler(this.btnGetRecord_Click);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Bordercolor = System.Drawing.Color.Gray;
            this.dtpDateTo.BorderSize = 0;
            this.dtpDateTo.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpDateTo.Location = new System.Drawing.Point(592, 137);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(442, 35);
            this.dtpDateTo.TabIndex = 38;
            this.dtpDateTo.Textcolor = System.Drawing.Color.White;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Bordercolor = System.Drawing.Color.Gray;
            this.dtpDateFrom.BorderSize = 0;
            this.dtpDateFrom.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpDateFrom.Location = new System.Drawing.Point(592, 75);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateFrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(442, 35);
            this.dtpDateFrom.TabIndex = 37;
            this.dtpDateFrom.Textcolor = System.Drawing.Color.White;
            // 
            // chkTimeAndStatus
            // 
            this.chkTimeAndStatus.AutoSize = true;
            this.chkTimeAndStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimeAndStatus.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.chkTimeAndStatus.Location = new System.Drawing.Point(1046, 71);
            this.chkTimeAndStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTimeAndStatus.Name = "chkTimeAndStatus";
            this.chkTimeAndStatus.Size = new System.Drawing.Size(322, 33);
            this.chkTimeAndStatus.TabIndex = 39;
            this.chkTimeAndStatus.Text = "Time and Assignee Based";
            this.chkTimeAndStatus.UseVisualStyleBackColor = true;
            this.chkTimeAndStatus.CheckedChanged += new System.EventHandler(this.chkTimeAndStatus_CheckedChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(396, 149);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(99, 28);
            this.lblEndDate.TabIndex = 36;
            this.lblEndDate.Text = "To Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(396, 88);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(132, 28);
            this.lblStartDate.TabIndex = 35;
            this.lblStartDate.Text = "From Date";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1236, 142);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(182, 48);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpBoxDataGrid
            // 
            this.grpBoxDataGrid.BackColor = System.Drawing.Color.White;
            this.grpBoxDataGrid.Controls.Add(this.dView);
            this.grpBoxDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDataGrid.Location = new System.Drawing.Point(18, 188);
            this.grpBoxDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxDataGrid.Name = "grpBoxDataGrid";
            this.grpBoxDataGrid.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxDataGrid.Size = new System.Drawing.Size(1642, 615);
            this.grpBoxDataGrid.TabIndex = 16;
            this.grpBoxDataGrid.TabStop = false;
            this.grpBoxDataGrid.Text = "Task Status Based Report";
            // 
            // dView
            // 
            this.dView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dView.GridColor = System.Drawing.Color.Gray;
            this.dView.Location = new System.Drawing.Point(9, 38);
            this.dView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dView.Name = "dView";
            this.dView.RowHeadersWidth = 62;
            this.dView.Size = new System.Drawing.Size(1622, 569);
            this.dView.TabIndex = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(592, 22);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(442, 38);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(396, 28);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(156, 28);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Select Status";
            // 
            // StatusBasedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1672, 1040);
            this.Controls.Add(this.pnlOuter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatusBasedReport";
            this.Text = "Status Based Report";
            this.Load += new System.EventHandler(this.StatusBasedReport_Load);
            this.pnlOuter.ResumeLayout(false);
            this.pnlOuter.PerformLayout();
            this.grpBoxPaging.ResumeLayout(false);
            this.grpBoxPaging.PerformLayout();
            this.grpBoxDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.DataGridView dView;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpBoxDataGrid;
        private System.Windows.Forms.Button btnPrint;
        private TMS.UI.Utilities.CustomDatetimePicker dtpDateTo;
        private TMS.UI.Utilities.CustomDatetimePicker dtpDateFrom;
        private System.Windows.Forms.CheckBox chkTimeAndStatus;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnGetRecord;
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