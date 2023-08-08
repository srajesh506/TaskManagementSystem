namespace TMS.WorkitemHistory
{
    partial class FrmWorkItemHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dviewhistory = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblworkitem = new System.Windows.Forms.Label();
            this.lblWorkItemValue = new System.Windows.Forms.Label();
            this.lblOpenDateValue = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.lblCurrentStatusValue = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dviewhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // Dviewhistory
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dviewhistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dviewhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dviewhistory.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dviewhistory.Location = new System.Drawing.Point(12, 131);
            this.Dviewhistory.Name = "Dviewhistory";
            this.Dviewhistory.RowHeadersWidth = 62;
            this.Dviewhistory.RowTemplate.Height = 28;
            this.Dviewhistory.Size = new System.Drawing.Size(1708, 658);
            this.Dviewhistory.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1538, 29);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(182, 48);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblReg
            // 
            this.lblReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.White;
            this.lblReg.Location = new System.Drawing.Point(13, 97);
            this.lblReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(1707, 31);
            this.lblReg.TabIndex = 33;
            this.lblReg.Text = "Work Item Assignment History Page";
            // 
            // lblworkitem
            // 
            this.lblworkitem.AutoSize = true;
            this.lblworkitem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblworkitem.Location = new System.Drawing.Point(13, 55);
            this.lblworkitem.Name = "lblworkitem";
            this.lblworkitem.Size = new System.Drawing.Size(143, 29);
            this.lblworkitem.TabIndex = 34;
            this.lblworkitem.Text = "Work Item :";
            // 
            // lblWorkItemValue
            // 
            this.lblWorkItemValue.AutoSize = true;
            this.lblWorkItemValue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkItemValue.Location = new System.Drawing.Point(165, 55);
            this.lblWorkItemValue.Name = "lblWorkItemValue";
            this.lblWorkItemValue.Size = new System.Drawing.Size(156, 29);
            this.lblWorkItemValue.TabIndex = 35;
            this.lblWorkItemValue.Text = "Work Item Value";
            // 
            // lblOpenDateValue
            // 
            this.lblOpenDateValue.AutoSize = true;
            this.lblOpenDateValue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDateValue.Location = new System.Drawing.Point(627, 55);
            this.lblOpenDateValue.Name = "lblOpenDateValue";
            this.lblOpenDateValue.Size = new System.Drawing.Size(162, 29);
            this.lblOpenDateValue.TabIndex = 37;
            this.lblOpenDateValue.Text = "Open Date Value";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.Location = new System.Drawing.Point(475, 55);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(146, 29);
            this.lblOpenDate.TabIndex = 36;
            this.lblOpenDate.Text = "Open Date :";
            // 
            // lblCurrentStatusValue
            // 
            this.lblCurrentStatusValue.AutoSize = true;
            this.lblCurrentStatusValue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatusValue.Location = new System.Drawing.Point(1124, 55);
            this.lblCurrentStatusValue.Name = "lblCurrentStatusValue";
            this.lblCurrentStatusValue.Size = new System.Drawing.Size(194, 29);
            this.lblCurrentStatusValue.TabIndex = 39;
            this.lblCurrentStatusValue.Text = "Current Status Value";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.Location = new System.Drawing.Point(922, 55);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(193, 29);
            this.lblCurrentStatus.TabIndex = 38;
            this.lblCurrentStatus.Text = "Current Status :";
            // 
            // FrmWorkItemHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 801);
            this.Controls.Add(this.lblCurrentStatusValue);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.lblOpenDateValue);
            this.Controls.Add(this.lblOpenDate);
            this.Controls.Add(this.lblWorkItemValue);
            this.Controls.Add(this.lblworkitem);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.Dviewhistory);
            this.Name = "FrmWorkItemHistory";
            this.Text = "Work Item Assignment History Page";
            this.Load += new System.EventHandler(this.FrmWorkItemHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dviewhistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dviewhistory;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblworkitem;
        private System.Windows.Forms.Label lblWorkItemValue;
        private System.Windows.Forms.Label lblOpenDateValue;
        private System.Windows.Forms.Label lblOpenDate;
        private System.Windows.Forms.Label lblCurrentStatusValue;
        private System.Windows.Forms.Label lblCurrentStatus;
    }
}