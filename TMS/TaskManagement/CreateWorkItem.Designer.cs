namespace TMS.UI
{
    partial class CreateWorkItem
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
            this.grpBoxWorkItemGridView = new System.Windows.Forms.GroupBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.grpBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpBoxAssignTask = new System.Windows.Forms.GroupBox();
            this.cmbSubTask = new System.Windows.Forms.ComboBox();
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.rtxtRemark = new System.Windows.Forms.RichTextBox();
            this.lblSubTaskName = new System.Windows.Forms.Label();
            this.lblSubTaskRemark = new System.Windows.Forms.Label();
            this.pnlOuter.SuspendLayout();
            this.grpBoxWorkItemGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.grpBoxButtons.SuspendLayout();
            this.grpBoxAssignTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.White;
            this.pnlOuter.Controls.Add(this.grpBoxWorkItemGridView);
            this.pnlOuter.Controls.Add(this.grpBoxButtons);
            this.pnlOuter.Controls.Add(this.grpBoxAssignTask);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1100, 597);
            this.pnlOuter.TabIndex = 4;
            // 
            // grpBoxWorkItemGridView
            // 
            this.grpBoxWorkItemGridView.BackColor = System.Drawing.Color.White;
            this.grpBoxWorkItemGridView.Controls.Add(this.dgView);
            this.grpBoxWorkItemGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxWorkItemGridView.Location = new System.Drawing.Point(12, 290);
            this.grpBoxWorkItemGridView.Name = "grpBoxWorkItemGridView";
            this.grpBoxWorkItemGridView.Size = new System.Drawing.Size(1076, 289);
            this.grpBoxWorkItemGridView.TabIndex = 15;
            this.grpBoxWorkItemGridView.TabStop = false;
            this.grpBoxWorkItemGridView.Text = "WorkItems";
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.GridColor = System.Drawing.Color.Gray;
            this.dgView.Location = new System.Drawing.Point(6, 24);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(1054, 248);
            this.dgView.TabIndex = 0;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dview_CellClick);
            // 
            // grpBoxButtons
            // 
            this.grpBoxButtons.Controls.Add(this.btnSave);
            this.grpBoxButtons.Controls.Add(this.btnModify);
            this.grpBoxButtons.Controls.Add(this.btnCancel);
            this.grpBoxButtons.Controls.Add(this.btnAdd);
            this.grpBoxButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxButtons.Location = new System.Drawing.Point(403, 236);
            this.grpBoxButtons.Name = "grpBoxButtons";
            this.grpBoxButtons.Size = new System.Drawing.Size(316, 48);
            this.grpBoxButtons.TabIndex = 14;
            this.grpBoxButtons.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(159, 11);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(72, 31);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 31);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 31);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // grpBoxAssignTask
            // 
            this.grpBoxAssignTask.Controls.Add(this.cmbSubTask);
            this.grpBoxAssignTask.Controls.Add(this.cmbTask);
            this.grpBoxAssignTask.Controls.Add(this.lblTask);
            this.grpBoxAssignTask.Controls.Add(this.cmbActivity);
            this.grpBoxAssignTask.Controls.Add(this.lblActivity);
            this.grpBoxAssignTask.Controls.Add(this.rtxtRemark);
            this.grpBoxAssignTask.Controls.Add(this.lblSubTaskName);
            this.grpBoxAssignTask.Controls.Add(this.lblSubTaskRemark);
            this.grpBoxAssignTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBoxAssignTask.Location = new System.Drawing.Point(12, 2);
            this.grpBoxAssignTask.Name = "grpBoxAssignTask";
            this.grpBoxAssignTask.Size = new System.Drawing.Size(1076, 228);
            this.grpBoxAssignTask.TabIndex = 12;
            this.grpBoxAssignTask.TabStop = false;
            this.grpBoxAssignTask.Text = "Create WorkItem";
            // 
            // cmbSubTask
            // 
            this.cmbSubTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbSubTask.FormattingEnabled = true;
            this.cmbSubTask.Location = new System.Drawing.Point(478, 96);
            this.cmbSubTask.Name = "cmbSubTask";
            this.cmbSubTask.Size = new System.Drawing.Size(296, 29);
            this.cmbSubTask.TabIndex = 14;
            this.cmbSubTask.SelectedIndexChanged += new System.EventHandler(this.cmbSubTask_SelectedIndexChanged);
            // 
            // cmbTask
            // 
            this.cmbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbTask.FormattingEnabled = true;
            this.cmbTask.Location = new System.Drawing.Point(478, 61);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Size = new System.Drawing.Size(296, 29);
            this.cmbTask.TabIndex = 11;
            this.cmbTask.SelectedIndexChanged += new System.EventHandler(this.cmbTask_SelectedIndexChanged);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(315, 61);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(92, 19);
            this.lblTask.TabIndex = 10;
            this.lblTask.Text = "Select Task";
            // 
            // cmbActivity
            // 
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(478, 23);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(296, 29);
            this.cmbActivity.TabIndex = 9;
            this.cmbActivity.SelectedIndexChanged += new System.EventHandler(this.cmbActivity_SelectedIndexChanged);
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(315, 23);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(115, 19);
            this.lblActivity.TabIndex = 8;
            this.lblActivity.Text = "Select Activity";
            // 
            // rtxtRemark
            // 
            this.rtxtRemark.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtxtRemark.Location = new System.Drawing.Point(478, 130);
            this.rtxtRemark.Name = "rtxtRemark";
            this.rtxtRemark.Size = new System.Drawing.Size(296, 62);
            this.rtxtRemark.TabIndex = 6;
            this.rtxtRemark.Text = "";
            // 
            // lblSubTaskName
            // 
            this.lblSubTaskName.AutoSize = true;
            this.lblSubTaskName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTaskName.Location = new System.Drawing.Point(315, 95);
            this.lblSubTaskName.Name = "lblSubTaskName";
            this.lblSubTaskName.Size = new System.Drawing.Size(121, 19);
            this.lblSubTaskName.TabIndex = 1;
            this.lblSubTaskName.Text = "Select SubTask";
            // 
            // lblSubTaskRemark
            // 
            this.lblSubTaskRemark.AutoSize = true;
            this.lblSubTaskRemark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubTaskRemark.Location = new System.Drawing.Point(315, 130);
            this.lblSubTaskRemark.Name = "lblSubTaskRemark";
            this.lblSubTaskRemark.Size = new System.Drawing.Size(94, 19);
            this.lblSubTaskRemark.TabIndex = 5;
            this.lblSubTaskRemark.Text = "Description";
            // 
            // CreateWorkItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 597);
            this.Controls.Add(this.pnlOuter);
            this.Name = "CreateWorkItem";
            this.Text = "Create WorkItem";
            this.Load += new System.EventHandler(this.CreateWorkItem_Load);
            this.pnlOuter.ResumeLayout(false);
            this.grpBoxWorkItemGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.grpBoxButtons.ResumeLayout(false);
            this.grpBoxAssignTask.ResumeLayout(false);
            this.grpBoxAssignTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.GroupBox grpBoxWorkItemGridView;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.GroupBox grpBoxButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpBoxAssignTask;
        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.RichTextBox rtxtRemark;
        private System.Windows.Forms.Label lblSubTaskName;
        private System.Windows.Forms.Label lblSubTaskRemark;
        private System.Windows.Forms.ComboBox cmbSubTask;
    }
}