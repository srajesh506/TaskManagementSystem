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
            this.grpBoxWorkItemAssignmentGridView = new System.Windows.Forms.GroupBox();
            this.chkFilterActive = new System.Windows.Forms.CheckBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.pnlOuter.SuspendLayout();
            this.grpBoxWorkItemAssignmentGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.White;
            this.pnlOuter.Controls.Add(this.grpBoxWorkItemAssignmentGridView);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1119, 639);
            this.pnlOuter.TabIndex = 4;
            // 
            // grpBoxWorkItemAssignmentGridView
            // 
            this.grpBoxWorkItemAssignmentGridView.BackColor = System.Drawing.Color.White;
            this.grpBoxWorkItemAssignmentGridView.Controls.Add(this.chkFilterActive);
            this.grpBoxWorkItemAssignmentGridView.Controls.Add(this.dgView);
            this.grpBoxWorkItemAssignmentGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxWorkItemAssignmentGridView.Location = new System.Drawing.Point(3, 12);
            this.grpBoxWorkItemAssignmentGridView.Name = "grpBoxWorkItemAssignmentGridView";
            this.grpBoxWorkItemAssignmentGridView.Size = new System.Drawing.Size(1106, 618);
            this.grpBoxWorkItemAssignmentGridView.TabIndex = 15;
            this.grpBoxWorkItemAssignmentGridView.TabStop = false;
            this.grpBoxWorkItemAssignmentGridView.Text = "Assign WorkItems";
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
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dview_CellClick);
            this.dgView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dview_CellFormatting);
            this.dgView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.savetext);
            this.dgView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dview_RowStateChanged);
            // 
            // WorkItemAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 639);
            this.Controls.Add(this.pnlOuter);
            this.Name = "WorkItemAssignments";
            this.Text = "Assign WorkItem";
            this.pnlOuter.ResumeLayout(false);
            this.grpBoxWorkItemAssignmentGridView.ResumeLayout(false);
            this.grpBoxWorkItemAssignmentGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.GroupBox grpBoxWorkItemAssignmentGridView;
        private System.Windows.Forms.DataGridView dgView;
        private CheckBox chkFilterActive;
    }
}