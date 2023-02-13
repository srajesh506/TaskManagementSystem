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
            this.pnlOuter = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpDateTo = new TMS.UI.Utilities.CustomDatetimePicker();
            this.dtpDateFrom = new TMS.UI.Utilities.CustomDatetimePicker();
            this.btnGetRecord = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.grpBoxDataGrid = new System.Windows.Forms.GroupBox();
            this.dView = new System.Windows.Forms.DataGridView();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.pnlOuter.SuspendLayout();
            this.grpBoxDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.White;
            this.pnlOuter.Controls.Add(this.btnPrint);
            this.pnlOuter.Controls.Add(this.dtpDateTo);
            this.pnlOuter.Controls.Add(this.dtpDateFrom);
            this.pnlOuter.Controls.Add(this.btnGetRecord);
            this.pnlOuter.Controls.Add(this.lblEndDate);
            this.pnlOuter.Controls.Add(this.grpBoxDataGrid);
            this.pnlOuter.Controls.Add(this.lblStartDate);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1117, 673);
            this.pnlOuter.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(625, 96);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(121, 31);
            this.btnPrint.TabIndex = 30;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Bordercolor = System.Drawing.Color.Gray;
            this.dtpDateTo.BorderSize = 0;
            this.dtpDateTo.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dtpDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpDateTo.Location = new System.Drawing.Point(498, 55);
            this.dtpDateTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(244, 35);
            this.dtpDateTo.TabIndex = 27;
            this.dtpDateTo.Textcolor = System.Drawing.Color.White;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Bordercolor = System.Drawing.Color.Gray;
            this.dtpDateFrom.BorderSize = 0;
            this.dtpDateFrom.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpDateFrom.Location = new System.Drawing.Point(498, 12);
            this.dtpDateFrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(244, 35);
            this.dtpDateFrom.TabIndex = 26;
            this.dtpDateFrom.Textcolor = System.Drawing.Color.White;
            // 
            // btnGetRecord
            // 
            this.btnGetRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGetRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRecord.ForeColor = System.Drawing.Color.White;
            this.btnGetRecord.Location = new System.Drawing.Point(498, 96);
            this.btnGetRecord.Name = "btnGetRecord";
            this.btnGetRecord.Size = new System.Drawing.Size(121, 31);
            this.btnGetRecord.TabIndex = 25;
            this.btnGetRecord.Text = "Get Report";
            this.btnGetRecord.UseVisualStyleBackColor = false;
            this.btnGetRecord.Click += new System.EventHandler(this.btnGetRecord_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(398, 63);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 19);
            this.lblEndDate.TabIndex = 23;
            this.lblEndDate.Text = "To Date";
            // 
            // grpBoxDataGrid
            // 
            this.grpBoxDataGrid.BackColor = System.Drawing.Color.White;
            this.grpBoxDataGrid.Controls.Add(this.dView);
            this.grpBoxDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDataGrid.Location = new System.Drawing.Point(12, 126);
            this.grpBoxDataGrid.Name = "grpBoxDataGrid";
            this.grpBoxDataGrid.Size = new System.Drawing.Size(1097, 506);
            this.grpBoxDataGrid.TabIndex = 16;
            this.grpBoxDataGrid.TabStop = false;
            this.grpBoxDataGrid.Text = "Task Assignee Based Report";
            // 
            // dView
            // 
            this.dView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dView.GridColor = System.Drawing.Color.Gray;
            this.dView.Location = new System.Drawing.Point(6, 25);
            this.dView.Name = "dView";
            this.dView.Size = new System.Drawing.Size(1083, 472);
            this.dView.TabIndex = 0;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(398, 20);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(88, 19);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "From Date";
            // 
            // TimeBasedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 673);
            this.Controls.Add(this.pnlOuter);
            this.Name = "TimeBasedReport";
            this.Text = "Time Based Report";
            this.Load += new System.EventHandler(this.AssigneeBasedReport_Load);
            this.pnlOuter.ResumeLayout(false);
            this.pnlOuter.PerformLayout();
            this.grpBoxDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnGetRecord;
        private TMS.UI.Utilities.CustomDatetimePicker dtpDateFrom;
        private TMS.UI.Utilities.CustomDatetimePicker dtpDateTo;
        private System.Windows.Forms.GroupBox grpBoxDataGrid;
        private System.Windows.Forms.DataGridView dView;
        private System.Windows.Forms.Button btnPrint;
    }
}