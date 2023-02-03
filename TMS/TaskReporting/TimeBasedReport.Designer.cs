namespace TMS.UI
{
    partial class TimeBasedReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeBasedReport));
            this.pnlouter = new System.Windows.Forms.Panel();
            this.btnprint = new System.Windows.Forms.Button();
            this.dateTo = new TMS.UI.Utilities.CustomDatetimePicker();
            this.datefrom = new TMS.UI.Utilities.CustomDatetimePicker();
            this.btngetrecord = new System.Windows.Forms.Button();
            this.lblenddate = new System.Windows.Forms.Label();
            this.picpdf = new System.Windows.Forms.PictureBox();
            this.picexcel = new System.Windows.Forms.PictureBox();
            this.groupBoxforeTaskBasedReport = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dview = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblstartdate = new System.Windows.Forms.Label();
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
            this.pnlouter.Controls.Add(this.btnprint);
            this.pnlouter.Controls.Add(this.dateTo);
            this.pnlouter.Controls.Add(this.datefrom);
            this.pnlouter.Controls.Add(this.btngetrecord);
            this.pnlouter.Controls.Add(this.lblenddate);
            this.pnlouter.Controls.Add(this.picpdf);
            this.pnlouter.Controls.Add(this.picexcel);
            this.pnlouter.Controls.Add(this.groupBoxforeTaskBasedReport);
            this.pnlouter.Controls.Add(this.lblstartdate);
            this.pnlouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlouter.Location = new System.Drawing.Point(0, 0);
            this.pnlouter.Name = "pnlouter";
            this.pnlouter.Size = new System.Drawing.Size(1117, 673);
            this.pnlouter.TabIndex = 4;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(625, 96);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(121, 31);
            this.btnprint.TabIndex = 30;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // dateTo
            // 
            this.dateTo.Bordercolor = System.Drawing.Color.Gray;
            this.dateTo.BorderSize = 0;
            this.dateTo.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateTo.Location = new System.Drawing.Point(498, 55);
            this.dateTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(244, 35);
            this.dateTo.TabIndex = 27;
            this.dateTo.Textcolor = System.Drawing.Color.White;
            // 
            // datefrom
            // 
            this.datefrom.Bordercolor = System.Drawing.Color.Gray;
            this.datefrom.BorderSize = 0;
            this.datefrom.FillColor = System.Drawing.Color.LightSeaGreen;
            this.datefrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datefrom.Location = new System.Drawing.Point(498, 12);
            this.datefrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(244, 35);
            this.datefrom.TabIndex = 26;
            this.datefrom.Textcolor = System.Drawing.Color.White;
            // 
            // btngetrecord
            // 
            this.btngetrecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btngetrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetrecord.ForeColor = System.Drawing.Color.White;
            this.btngetrecord.Location = new System.Drawing.Point(498, 96);
            this.btngetrecord.Name = "btngetrecord";
            this.btngetrecord.Size = new System.Drawing.Size(121, 31);
            this.btngetrecord.TabIndex = 25;
            this.btngetrecord.Text = "Get Report";
            this.btngetrecord.UseVisualStyleBackColor = false;
            this.btngetrecord.Click += new System.EventHandler(this.btngetrecord_Click);
            // 
            // lblenddate
            // 
            this.lblenddate.AutoSize = true;
            this.lblenddate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenddate.Location = new System.Drawing.Point(398, 63);
            this.lblenddate.Name = "lblenddate";
            this.lblenddate.Size = new System.Drawing.Size(66, 19);
            this.lblenddate.TabIndex = 23;
            this.lblenddate.Text = "To Date";
            // 
            // picpdf
            // 
            this.picpdf.Image = ((System.Drawing.Image)(resources.GetObject("picpdf.Image")));
            this.picpdf.Location = new System.Drawing.Point(964, 88);
            this.picpdf.Name = "picpdf";
            this.picpdf.Size = new System.Drawing.Size(37, 33);
            this.picpdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picpdf.TabIndex = 21;
            this.picpdf.TabStop = false;
            this.picpdf.Click += new System.EventHandler(this.picpdf_Click);
            this.picpdf.MouseHover += new System.EventHandler(this.picpdf_MouseHover);
            // 
            // picexcel
            // 
            this.picexcel.Image = ((System.Drawing.Image)(resources.GetObject("picexcel.Image")));
            this.picexcel.Location = new System.Drawing.Point(908, 88);
            this.picexcel.Name = "picexcel";
            this.picexcel.Size = new System.Drawing.Size(37, 33);
            this.picexcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picexcel.TabIndex = 19;
            this.picexcel.TabStop = false;
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
            this.groupBoxforeTaskBasedReport.Location = new System.Drawing.Point(12, 126);
            this.groupBoxforeTaskBasedReport.Name = "groupBoxforeTaskBasedReport";
            this.groupBoxforeTaskBasedReport.Size = new System.Drawing.Size(1097, 506);
            this.groupBoxforeTaskBasedReport.TabIndex = 16;
            this.groupBoxforeTaskBasedReport.TabStop = false;
            this.groupBoxforeTaskBasedReport.Text = "Task Assignee Based Report";
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
            this.dview.Size = new System.Drawing.Size(1083, 472);
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
            // lblstartdate
            // 
            this.lblstartdate.AutoSize = true;
            this.lblstartdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartdate.Location = new System.Drawing.Point(398, 20);
            this.lblstartdate.Name = "lblstartdate";
            this.lblstartdate.Size = new System.Drawing.Size(88, 19);
            this.lblstartdate.TabIndex = 8;
            this.lblstartdate.Text = "From Date";
            // 
            // TimeBasedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 673);
            this.Controls.Add(this.pnlouter);
            this.Name = "TimeBasedReport";
            this.Text = "Time Based Report";
            this.Load += new System.EventHandler(this.AssigneeBasedReport_Load);
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
        private System.Windows.Forms.Label lblstartdate;
        private System.Windows.Forms.PictureBox picexcel;
        private System.Windows.Forms.PictureBox picpdf;
        private System.Windows.Forms.Label lblenddate;
        private System.Windows.Forms.Button btngetrecord;
        private TMS.UI.Utilities.CustomDatetimePicker datefrom;
        private TMS.UI.Utilities.CustomDatetimePicker dateTo;
        private System.Windows.Forms.GroupBox groupBoxforeTaskBasedReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dview;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnprint;
    }
}