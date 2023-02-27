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
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1119, 690);
            this.pnlOuter.TabIndex = 4;
            // 
            // lblNoOfRecordPerPage
            // 
            this.lblNoOfRecordPerPage.AutoSize = true;
            this.lblNoOfRecordPerPage.Location = new System.Drawing.Point(645, 653);
            this.lblNoOfRecordPerPage.Name = "lblNoOfRecordPerPage";
            this.lblNoOfRecordPerPage.Size = new System.Drawing.Size(125, 13);
            this.lblNoOfRecordPerPage.TabIndex = 25;
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
            this.cmbNoOfRecordsPerPage.Location = new System.Drawing.Point(773, 649);
            this.cmbNoOfRecordsPerPage.Name = "cmbNoOfRecordsPerPage";
            this.cmbNoOfRecordsPerPage.Size = new System.Drawing.Size(45, 21);
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
            this.grpBoxPaging.Location = new System.Drawing.Point(370, 634);
            this.grpBoxPaging.Name = "grpBoxPaging";
            this.grpBoxPaging.Size = new System.Drawing.Size(269, 51);
            this.grpBoxPaging.TabIndex = 19;
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
            // grpBoxGridView
            // 
            this.grpBoxGridView.BackColor = System.Drawing.Color.White;
            this.grpBoxGridView.Controls.Add(this.chkFilterActive);
            this.grpBoxGridView.Controls.Add(this.dgView);
            this.grpBoxGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxGridView.Location = new System.Drawing.Point(3, 12);
            this.grpBoxGridView.Name = "grpBoxGridView";
            this.grpBoxGridView.Size = new System.Drawing.Size(1106, 618);
            this.grpBoxGridView.TabIndex = 15;
            this.grpBoxGridView.TabStop = false;
            this.grpBoxGridView.Text = "Assign WorkItems";
            // 
            // chkFilterActive
            // 
            this.chkFilterActive.AutoSize = true;
            this.chkFilterActive.Location = new System.Drawing.Point(689, 14);
            this.chkFilterActive.Name = "chkFilterActive";
            this.chkFilterActive.Size = new System.Drawing.Size(189, 24);
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
            this.dgView.Location = new System.Drawing.Point(6, 44);
            this.dgView.Name = "dgView";
            this.dgView.RowTemplate.Height = 30;
            this.dgView.Size = new System.Drawing.Size(1091, 565);
            this.dgView.TabIndex = 0;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            this.dgView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgView_CellFormatting);
            this.dgView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewSaveText);
            this.dgView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgView_RowStateChanged);
            // 
            // WorkItemAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 690);
            this.Controls.Add(this.pnlOuter);
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