using System.Drawing;
using System.Windows.Forms;

namespace TMS.UI
{
    partial class WorkItemAssignments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.grpBoxGridView = new System.Windows.Forms.GroupBox();
            this.chkFilterActive = new System.Windows.Forms.CheckBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.pnlOuter.SuspendLayout();
            this.grpBoxPaging.SuspendLayout();
            this.grpBoxGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.White;
            this.pnlOuter.Controls.Add(this.lblNoOfRecordPerPage);
            this.pnlOuter.Controls.Add(this.cmbNoOfRecordsPerPage);
            this.pnlOuter.Controls.Add(this.grpBoxPaging);
            this.pnlOuter.Controls.Add(this.grpBoxGridView);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1678, 979);
            this.pnlOuter.TabIndex = 4;
            // 
            // lblNoOfRecordPerPage
            // 
            this.lblNoOfRecordPerPage.AutoSize = true;
            this.lblNoOfRecordPerPage.Location = new System.Drawing.Point(9, 861);
            this.lblNoOfRecordPerPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfRecordPerPage.Name = "lblNoOfRecordPerPage";
            this.lblNoOfRecordPerPage.Size = new System.Drawing.Size(81, 20);
            this.lblNoOfRecordPerPage.TabIndex = 25;
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
            this.cmbNoOfRecordsPerPage.Location = new System.Drawing.Point(98, 861);
            this.cmbNoOfRecordsPerPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNoOfRecordsPerPage.Name = "cmbNoOfRecordsPerPage";
            this.cmbNoOfRecordsPerPage.Size = new System.Drawing.Size(66, 28);
            this.cmbNoOfRecordsPerPage.TabIndex = 24;
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
            this.grpBoxPaging.Location = new System.Drawing.Point(555, 861);
            this.grpBoxPaging.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPaging.Name = "grpBoxPaging";
            this.grpBoxPaging.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPaging.Size = new System.Drawing.Size(404, 78);
            this.grpBoxPaging.TabIndex = 19;
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
            // grpBoxGridView
            // 
            this.grpBoxGridView.BackColor = System.Drawing.Color.White;
            this.grpBoxGridView.Controls.Add(this.chkFilterActive);
            this.grpBoxGridView.Controls.Add(this.dgView);
            this.grpBoxGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxGridView.Location = new System.Drawing.Point(4, 18);
            this.grpBoxGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxGridView.Name = "grpBoxGridView";
            this.grpBoxGridView.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxGridView.Size = new System.Drawing.Size(1659, 835);
            this.grpBoxGridView.TabIndex = 15;
            this.grpBoxGridView.TabStop = false;
            this.grpBoxGridView.Text = "Assign WorkItems";
            // 
            // chkFilterActive
            // 
            this.chkFilterActive.AutoSize = true;
            this.chkFilterActive.Location = new System.Drawing.Point(1034, 22);
            this.chkFilterActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFilterActive.Name = "chkFilterActive";
            this.chkFilterActive.Size = new System.Drawing.Size(284, 33);
            this.chkFilterActive.TabIndex = 1;
            this.chkFilterActive.Text = "Filter Active Workitems";
            this.chkFilterActive.UseVisualStyleBackColor = true;
            this.chkFilterActive.CheckedChanged += new System.EventHandler(this.chkFilterActive_CheckedChanged);
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgView.GridColor = System.Drawing.Color.Black;
            this.dgView.Location = new System.Drawing.Point(9, 68);
            this.dgView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 62;
            this.dgView.RowTemplate.Height = 30;
            this.dgView.Size = new System.Drawing.Size(1636, 751);
            this.dgView.TabIndex = 0;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            this.dgView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellDoubleClick);
            this.dgView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgView_CellFormatting);
            this.dgView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewSaveText);
            this.dgView.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgView_CellValueNeeded);
            this.dgView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgView_RowStateChanged);
            // 
            // WorkItemAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 979);
            this.Controls.Add(this.pnlOuter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WorkItemAssignments";
            this.Text = "Assign WorkItem";
            this.Load += new System.EventHandler(this.WorkItemAssignments_Load);
            this.pnlOuter.ResumeLayout(false);
            this.pnlOuter.PerformLayout();
            this.grpBoxPaging.ResumeLayout(false);
            this.grpBoxPaging.PerformLayout();
            this.grpBoxGridView.ResumeLayout(false);
            this.grpBoxGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.GroupBox grpBoxGridView;
        private System.Windows.Forms.DataGridView dgView;
        private CheckBox chkFilterActive;
        private GroupBox grpBoxPaging;
        private Button btnLastPage;
        private Button btnFirstPage;
        private Label lblPages;
        private Label lblNoOfPages;
        private Label lblSeperator;
        private Label lblCurrentPage;
        private Button btnNext;
        private Button btnPrevious;
        private Label lblNoOfRecordPerPage;
        private ComboBox cmbNoOfRecordsPerPage;
    }
}