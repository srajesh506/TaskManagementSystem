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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusBasedReport));
            this.pnlOuter = new System.Windows.Forms.Panel();
            this.btnGetRecord = new System.Windows.Forms.Button();
            this.dateTo = new TMS.UI.Utilities.CustomDatetimePicker();
            this.dateFrom = new TMS.UI.Utilities.CustomDatetimePicker();
            this.chkDateandAssignee = new System.Windows.Forms.CheckBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.picPdf = new System.Windows.Forms.PictureBox();
            this.picExcel = new System.Windows.Forms.PictureBox();
            this.groupBoxforeTaskBasedReport = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dview = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).BeginInit();
            this.groupBoxforeTaskBasedReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.White;
            this.pnlOuter.Controls.Add(this.btnGetRecord);
            this.pnlOuter.Controls.Add(this.dateTo);
            this.pnlOuter.Controls.Add(this.dateFrom);
            this.pnlOuter.Controls.Add(this.chkDateandAssignee);
            this.pnlOuter.Controls.Add(this.lblEndDate);
            this.pnlOuter.Controls.Add(this.lblStartDate);
            this.pnlOuter.Controls.Add(this.btnPrint);
            this.pnlOuter.Controls.Add(this.picPdf);
            this.pnlOuter.Controls.Add(this.picExcel);
            this.pnlOuter.Controls.Add(this.groupBoxforeTaskBasedReport);
            this.pnlOuter.Controls.Add(this.cmbStatus);
            this.pnlOuter.Controls.Add(this.lblStatus);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1115, 676);
            this.pnlOuter.TabIndex = 4;
            // 
            // btnGetRecord
            // 
            this.btnGetRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGetRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRecord.ForeColor = System.Drawing.Color.White;
            this.btnGetRecord.Location = new System.Drawing.Point(697, 92);
            this.btnGetRecord.Name = "btnGetRecord";
            this.btnGetRecord.Size = new System.Drawing.Size(121, 31);
            this.btnGetRecord.TabIndex = 40;
            this.btnGetRecord.Text = "Get Report";
            this.btnGetRecord.UseVisualStyleBackColor = false;
            this.btnGetRecord.Click += new System.EventHandler(this.btngetrecord_Click);
            // 
            // dateTo
            // 
            this.dateTo.Bordercolor = System.Drawing.Color.Gray;
            this.dateTo.BorderSize = 0;
            this.dateTo.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTo.Location = new System.Drawing.Point(395, 89);
            this.dateTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(296, 35);
            this.dateTo.TabIndex = 38;
            this.dateTo.Textcolor = System.Drawing.Color.White;
            // 
            // dateFrom
            // 
            this.dateFrom.Bordercolor = System.Drawing.Color.Gray;
            this.dateFrom.BorderSize = 0;
            this.dateFrom.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateFrom.Location = new System.Drawing.Point(395, 49);
            this.dateFrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(296, 35);
            this.dateFrom.TabIndex = 37;
            this.dateFrom.Textcolor = System.Drawing.Color.White;
            // 
            // chkDateandAssignee
            // 
            this.chkDateandAssignee.AutoSize = true;
            this.chkDateandAssignee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateandAssignee.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.chkDateandAssignee.Location = new System.Drawing.Point(697, 46);
            this.chkDateandAssignee.Name = "chkDateandAssignee";
            this.chkDateandAssignee.Size = new System.Drawing.Size(213, 24);
            this.chkDateandAssignee.TabIndex = 39;
            this.chkDateandAssignee.Text = "Time and Assignee Based";
            this.chkDateandAssignee.UseVisualStyleBackColor = true;
            this.chkDateandAssignee.CheckedChanged += new System.EventHandler(this.chkdateandassignee_CheckedChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(264, 89);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 19);
            this.lblEndDate.TabIndex = 36;
            this.lblEndDate.Text = "To Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(264, 49);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(88, 19);
            this.lblStartDate.TabIndex = 35;
            this.lblStartDate.Text = "From Date";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(824, 92);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(121, 31);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // picPdf
            // 
            this.picPdf.Image = ((System.Drawing.Image)(resources.GetObject("picPdf.Image")));
            this.picPdf.Location = new System.Drawing.Point(1015, 86);
            this.picPdf.Name = "picPdf";
            this.picPdf.Size = new System.Drawing.Size(37, 33);
            this.picPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPdf.TabIndex = 21;
            this.picPdf.TabStop = false;
            this.picPdf.Visible = false;
            this.picPdf.Click += new System.EventHandler(this.picpdf_Click);
            this.picPdf.MouseHover += new System.EventHandler(this.picpdf_MouseHover);
            // 
            // picExcel
            // 
            this.picExcel.Image = ((System.Drawing.Image)(resources.GetObject("picExcel.Image")));
            this.picExcel.Location = new System.Drawing.Point(959, 86);
            this.picExcel.Name = "picExcel";
            this.picExcel.Size = new System.Drawing.Size(37, 33);
            this.picExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExcel.TabIndex = 19;
            this.picExcel.TabStop = false;
            this.picExcel.Visible = false;
            this.picExcel.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picExcel.MouseHover += new System.EventHandler(this.picexcel_MouseHover);
            // 
            // groupBoxforeTaskBasedReport
            // 
            this.groupBoxforeTaskBasedReport.BackColor = System.Drawing.Color.White;
            this.groupBoxforeTaskBasedReport.Controls.Add(this.label1);
            this.groupBoxforeTaskBasedReport.Controls.Add(this.Dview);
            this.groupBoxforeTaskBasedReport.Controls.Add(this.btnSave);
            this.groupBoxforeTaskBasedReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxforeTaskBasedReport.Location = new System.Drawing.Point(12, 122);
            this.groupBoxforeTaskBasedReport.Name = "groupBoxforeTaskBasedReport";
            this.groupBoxforeTaskBasedReport.Size = new System.Drawing.Size(1095, 507);
            this.groupBoxforeTaskBasedReport.TabIndex = 16;
            this.groupBoxforeTaskBasedReport.TabStop = false;
            this.groupBoxforeTaskBasedReport.Text = "Task Status Based Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // Dview
            // 
            this.Dview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dview.GridColor = System.Drawing.Color.Gray;
            this.Dview.Location = new System.Drawing.Point(6, 25);
            this.Dview.Name = "Dview";
            this.Dview.Size = new System.Drawing.Size(1081, 472);
            this.Dview.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(952, 521);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(395, 14);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(296, 29);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbstatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(264, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(102, 19);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Select Status";
            // 
            // StatusBasedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 676);
            this.Controls.Add(this.pnlOuter);
            this.Name = "StatusBasedReport";
            this.Text = "Status Based Report";
            this.Load += new System.EventHandler(this.StatusBasedReport_Load);
            this.pnlOuter.ResumeLayout(false);
            this.pnlOuter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).EndInit();
            this.groupBoxforeTaskBasedReport.ResumeLayout(false);
            this.groupBoxforeTaskBasedReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.DataGridView Dview;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBoxforeTaskBasedReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picExcel;
        private System.Windows.Forms.PictureBox picPdf;
        private System.Windows.Forms.Button btnPrint;
        private TMS.UI.Utilities.CustomDatetimePicker dateTo;
        private TMS.UI.Utilities.CustomDatetimePicker dateFrom;
        private System.Windows.Forms.CheckBox chkDateandAssignee;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnGetRecord;
    }
}