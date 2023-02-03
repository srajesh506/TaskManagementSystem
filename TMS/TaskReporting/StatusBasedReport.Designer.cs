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
            this.pnlouter = new System.Windows.Forms.Panel();
            this.btngetrecord = new System.Windows.Forms.Button();
            this.dateTo = new TMS.UI.Utilities.CustomDatetimePicker();
            this.datefrom = new TMS.UI.Utilities.CustomDatetimePicker();
            this.chkdateandassignee = new System.Windows.Forms.CheckBox();
            this.lblenddate = new System.Windows.Forms.Label();
            this.lblstartdate = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.picpdf = new System.Windows.Forms.PictureBox();
            this.picexcel = new System.Windows.Forms.PictureBox();
            this.groupBoxforeTaskBasedReport = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dview = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.pnlouter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picpdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexcel)).BeginInit();
            this.groupBoxforeTaskBasedReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlouter
            // 
            this.pnlouter.BackColor = System.Drawing.Color.White;
            this.pnlouter.Controls.Add(this.btngetrecord);
            this.pnlouter.Controls.Add(this.dateTo);
            this.pnlouter.Controls.Add(this.datefrom);
            this.pnlouter.Controls.Add(this.chkdateandassignee);
            this.pnlouter.Controls.Add(this.lblenddate);
            this.pnlouter.Controls.Add(this.lblstartdate);
            this.pnlouter.Controls.Add(this.btnprint);
            this.pnlouter.Controls.Add(this.picpdf);
            this.pnlouter.Controls.Add(this.picexcel);
            this.pnlouter.Controls.Add(this.groupBoxforeTaskBasedReport);
            this.pnlouter.Controls.Add(this.cmbstatus);
            this.pnlouter.Controls.Add(this.lblstatus);
            this.pnlouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlouter.Location = new System.Drawing.Point(0, 0);
            this.pnlouter.Name = "pnlouter";
            this.pnlouter.Size = new System.Drawing.Size(1115, 676);
            this.pnlouter.TabIndex = 4;
            // 
            // btngetrecord
            // 
            this.btngetrecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btngetrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetrecord.ForeColor = System.Drawing.Color.White;
            this.btngetrecord.Location = new System.Drawing.Point(697, 92);
            this.btngetrecord.Name = "btngetrecord";
            this.btngetrecord.Size = new System.Drawing.Size(121, 31);
            this.btngetrecord.TabIndex = 40;
            this.btngetrecord.Text = "Get Report";
            this.btngetrecord.UseVisualStyleBackColor = false;
            this.btngetrecord.Click += new System.EventHandler(this.btngetrecord_Click);
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
            // datefrom
            // 
            this.datefrom.Bordercolor = System.Drawing.Color.Gray;
            this.datefrom.BorderSize = 0;
            this.datefrom.FillColor = System.Drawing.Color.LightSeaGreen;
            this.datefrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datefrom.Location = new System.Drawing.Point(395, 49);
            this.datefrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(296, 35);
            this.datefrom.TabIndex = 37;
            this.datefrom.Textcolor = System.Drawing.Color.White;
            // 
            // chkdateandassignee
            // 
            this.chkdateandassignee.AutoSize = true;
            this.chkdateandassignee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdateandassignee.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.chkdateandassignee.Location = new System.Drawing.Point(697, 46);
            this.chkdateandassignee.Name = "chkdateandassignee";
            this.chkdateandassignee.Size = new System.Drawing.Size(213, 24);
            this.chkdateandassignee.TabIndex = 39;
            this.chkdateandassignee.Text = "Time and Assignee Based";
            this.chkdateandassignee.UseVisualStyleBackColor = true;
            this.chkdateandassignee.CheckedChanged += new System.EventHandler(this.chkdateandassignee_CheckedChanged);
            // 
            // lblenddate
            // 
            this.lblenddate.AutoSize = true;
            this.lblenddate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenddate.Location = new System.Drawing.Point(264, 89);
            this.lblenddate.Name = "lblenddate";
            this.lblenddate.Size = new System.Drawing.Size(66, 19);
            this.lblenddate.TabIndex = 36;
            this.lblenddate.Text = "To Date";
            // 
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartdate.Location = new System.Drawing.Point(264, 49);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(88, 19);
            this.lblstartdate.TabIndex = 35;
            this.lblstartdate.Text = "From Date";
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(824, 92);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(121, 31);
            this.btnprint.TabIndex = 31;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // picpdf
            // 
            this.picpdf.Image = ((System.Drawing.Image)(resources.GetObject("picpdf.Image")));
            this.picpdf.Location = new System.Drawing.Point(1015, 86);
            this.picpdf.Name = "picpdf";
            this.picpdf.Size = new System.Drawing.Size(37, 33);
            this.picpdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picpdf.TabIndex = 21;
            this.picpdf.TabStop = false;
            this.picpdf.Visible = false;
            this.picpdf.Click += new System.EventHandler(this.picpdf_Click);
            this.picpdf.MouseHover += new System.EventHandler(this.picpdf_MouseHover);
            // 
            // picexcel
            // 
            this.picexcel.Image = ((System.Drawing.Image)(resources.GetObject("picexcel.Image")));
            this.picexcel.Location = new System.Drawing.Point(959, 86);
            this.picexcel.Name = "picexcel";
            this.picexcel.Size = new System.Drawing.Size(37, 33);
            this.picexcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picexcel.TabIndex = 19;
            this.picexcel.TabStop = false;
            this.picexcel.Visible = false;
            this.picexcel.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picexcel.MouseHover += new System.EventHandler(this.picexcel_MouseHover);
            // 
            // groupBoxforeTaskBasedReport
            // 
            this.groupBoxforeTaskBasedReport.BackColor = System.Drawing.Color.White;
            this.groupBoxforeTaskBasedReport.Controls.Add(this.label1);
            this.groupBoxforeTaskBasedReport.Controls.Add(this.dview);
            this.groupBoxforeTaskBasedReport.Controls.Add(this.btnsave);
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
            // dview
            // 
            this.dview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dview.GridColor = System.Drawing.Color.Gray;
            this.dview.Location = new System.Drawing.Point(6, 25);
            this.dview.Name = "dview";
            this.dview.Size = new System.Drawing.Size(1081, 472);
            this.dview.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(952, 521);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(108, 31);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // cmbstatus
            // 
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Location = new System.Drawing.Point(395, 14);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(296, 29);
            this.cmbstatus.TabIndex = 9;
            this.cmbstatus.SelectedIndexChanged += new System.EventHandler(this.cmbstatus_SelectedIndexChanged);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(264, 14);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(102, 19);
            this.lblstatus.TabIndex = 8;
            this.lblstatus.Text = "Select Status";
            // 
            // StatusBasedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 676);
            this.Controls.Add(this.pnlouter);
            this.Name = "StatusBasedReport";
            this.Text = "Status Based Report";
            this.Load += new System.EventHandler(this.StatusBasedReport_Load);
            this.pnlouter.ResumeLayout(false);
            this.pnlouter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picpdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexcel)).EndInit();
            this.groupBoxforeTaskBasedReport.ResumeLayout(false);
            this.groupBoxforeTaskBasedReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlouter;
        private System.Windows.Forms.DataGridView dview;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.GroupBox groupBoxforeTaskBasedReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox picexcel;
        private System.Windows.Forms.PictureBox picpdf;
        private System.Windows.Forms.Button btnprint;
        private TMS.UI.Utilities.CustomDatetimePicker dateTo;
        private TMS.UI.Utilities.CustomDatetimePicker datefrom;
        private System.Windows.Forms.CheckBox chkdateandassignee;
        private System.Windows.Forms.Label lblenddate;
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.Button btngetrecord;
    }
}