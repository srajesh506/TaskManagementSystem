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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssigneeBasedReport));
            this.pnlouter = new System.Windows.Forms.Panel();
            this.dateTo = new TMS.UI.Utilities.CustomDatetimePicker();
            this.datefrom = new TMS.UI.Utilities.CustomDatetimePicker();
            this.btngetrecord = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.chkdateandassignee = new System.Windows.Forms.CheckBox();
            this.lblenddate = new System.Windows.Forms.Label();
            this.lblstartdate = new System.Windows.Forms.Label();
            this.picpdf = new System.Windows.Forms.PictureBox();
            this.picexcel = new System.Windows.Forms.PictureBox();
            this.groupBoxforeTaskBasedReport = new System.Windows.Forms.GroupBox();
            this.dview = new System.Windows.Forms.DataGridView();
            this.cmbassignee = new System.Windows.Forms.ComboBox();
            this.lblassignee = new System.Windows.Forms.Label();
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
            this.pnlouter.Controls.Add(this.dateTo);
            this.pnlouter.Controls.Add(this.datefrom);
            this.pnlouter.Controls.Add(this.btngetrecord);
            this.pnlouter.Controls.Add(this.btnprint);
            this.pnlouter.Controls.Add(this.chkdateandassignee);
            this.pnlouter.Controls.Add(this.lblenddate);
            this.pnlouter.Controls.Add(this.lblstartdate);
            this.pnlouter.Controls.Add(this.picpdf);
            this.pnlouter.Controls.Add(this.picexcel);
            this.pnlouter.Controls.Add(this.groupBoxforeTaskBasedReport);
            this.pnlouter.Controls.Add(this.cmbassignee);
            this.pnlouter.Controls.Add(this.lblassignee);
            this.pnlouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlouter.Location = new System.Drawing.Point(0, 0);
            this.pnlouter.Name = "pnlouter";
            this.pnlouter.Size = new System.Drawing.Size(1118, 672);
            this.pnlouter.TabIndex = 4;
            // 
            // dateTo
            // 
            this.dateTo.Bordercolor = System.Drawing.Color.Gray;
            this.dateTo.BorderSize = 0;
            this.dateTo.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTo.Location = new System.Drawing.Point(457, 92);
            this.dateTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(296, 35);
            this.dateTo.TabIndex = 33;
            this.dateTo.Textcolor = System.Drawing.Color.White;
            // 
            // datefrom
            // 
            this.datefrom.Bordercolor = System.Drawing.Color.Gray;
            this.datefrom.BorderSize = 0;
            this.datefrom.FillColor = System.Drawing.Color.LightSeaGreen;
            this.datefrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datefrom.Location = new System.Drawing.Point(457, 52);
            this.datefrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(296, 35);
            this.datefrom.TabIndex = 32;
            this.datefrom.Textcolor = System.Drawing.Color.White;
            // 
            // btngetrecord
            // 
            this.btngetrecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btngetrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetrecord.ForeColor = System.Drawing.Color.White;
            this.btngetrecord.Location = new System.Drawing.Point(759, 97);
            this.btngetrecord.Name = "btngetrecord";
            this.btngetrecord.Size = new System.Drawing.Size(121, 31);
            this.btngetrecord.TabIndex = 26;
            this.btngetrecord.Text = "Get Report";
            this.btngetrecord.UseVisualStyleBackColor = false;
            this.btngetrecord.Click += new System.EventHandler(this.btngetrecord_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(886, 97);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(121, 31);
            this.btnprint.TabIndex = 29;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // chkdateandassignee
            // 
            this.chkdateandassignee.AutoSize = true;
            this.chkdateandassignee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdateandassignee.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.chkdateandassignee.Location = new System.Drawing.Point(759, 50);
            this.chkdateandassignee.Name = "chkdateandassignee";
            this.chkdateandassignee.Size = new System.Drawing.Size(213, 24);
            this.chkdateandassignee.TabIndex = 34;
            this.chkdateandassignee.Text = "Time and Assignee Based";
            this.chkdateandassignee.UseVisualStyleBackColor = true;
            this.chkdateandassignee.CheckedChanged += new System.EventHandler(this.chkdateandassignee_CheckedChanged);
            // 
            // lblenddate
            // 
            this.lblenddate.AutoSize = true;
            this.lblenddate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenddate.Location = new System.Drawing.Point(326, 92);
            this.lblenddate.Name = "lblenddate";
            this.lblenddate.Size = new System.Drawing.Size(66, 19);
            this.lblenddate.TabIndex = 31;
            this.lblenddate.Text = "To Date";
            // 
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartdate.Location = new System.Drawing.Point(326, 52);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(88, 19);
            this.lblstartdate.TabIndex = 30;
            this.lblstartdate.Text = "From Date";
            // 
            // picpdf
            // 
            this.picpdf.Image = ((System.Drawing.Image)(resources.GetObject("picpdf.Image")));
            this.picpdf.Location = new System.Drawing.Point(61, 636);
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
            this.picexcel.Location = new System.Drawing.Point(18, 639);
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
            this.groupBoxforeTaskBasedReport.Controls.Add(this.dview);
            this.groupBoxforeTaskBasedReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxforeTaskBasedReport.Location = new System.Drawing.Point(12, 126);
            this.groupBoxforeTaskBasedReport.Name = "groupBoxforeTaskBasedReport";
            this.groupBoxforeTaskBasedReport.Size = new System.Drawing.Size(1100, 543);
            this.groupBoxforeTaskBasedReport.TabIndex = 16;
            this.groupBoxforeTaskBasedReport.TabStop = false;
            this.groupBoxforeTaskBasedReport.Text = "Task Assignee Based Report";
            // 
            // dview
            // 
            this.dview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dview.GridColor = System.Drawing.Color.Gray;
            this.dview.Location = new System.Drawing.Point(6, 25);
            this.dview.Name = "dview";
            this.dview.Size = new System.Drawing.Size(1086, 509);
            this.dview.TabIndex = 0;
            // 
            // cmbassignee
            // 
            this.cmbassignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbassignee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbassignee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbassignee.FormattingEnabled = true;
            this.cmbassignee.Location = new System.Drawing.Point(457, 15);
            this.cmbassignee.Name = "cmbassignee";
            this.cmbassignee.Size = new System.Drawing.Size(296, 29);
            this.cmbassignee.TabIndex = 9;
            this.cmbassignee.SelectedIndexChanged += new System.EventHandler(this.cmbassignee_SelectedIndexChanged);
            // 
            // lblassignee
            // 
            this.lblassignee.AutoSize = true;
            this.lblassignee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassignee.Location = new System.Drawing.Point(326, 15);
            this.lblassignee.Name = "lblassignee";
            this.lblassignee.Size = new System.Drawing.Size(128, 19);
            this.lblassignee.TabIndex = 8;
            this.lblassignee.Text = "Select Assignee";
            // 
            // AssigneeBasedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 672);
            this.Controls.Add(this.pnlouter);
            this.Name = "AssigneeBasedReport";
            this.Text = "Assignee Based Report";
            this.Load += new System.EventHandler(this.AssigneeBasedReport_Load);
            this.pnlouter.ResumeLayout(false);
            this.pnlouter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picpdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexcel)).EndInit();
            this.groupBoxforeTaskBasedReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlouter;
        private System.Windows.Forms.DataGridView dview;
        private System.Windows.Forms.ComboBox cmbassignee;
        private System.Windows.Forms.Label lblassignee;
        private System.Windows.Forms.GroupBox groupBoxforeTaskBasedReport;
        private System.Windows.Forms.PictureBox picexcel;
        private System.Windows.Forms.PictureBox picpdf;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.CheckBox chkdateandassignee;
        private System.Windows.Forms.Label lblenddate;
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.Button btngetrecord;
        private TMS.UI.Utilities.CustomDatetimePicker dateTo;
        private TMS.UI.Utilities.CustomDatetimePicker datefrom;
    }
}