namespace TMS.UI
{
    partial class DefineTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlOuter = new System.Windows.Forms.Panel();
            this.groupBoxforExistingTask = new System.Windows.Forms.GroupBox();
            this.Dview = new System.Windows.Forms.DataGridView();
            this.groupBoxforbutton = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxTaskManagement = new System.Windows.Forms.GroupBox();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.rtxtRemark = new System.Windows.Forms.RichTextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.pnlOuter.SuspendLayout();
            this.groupBoxforExistingTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dview)).BeginInit();
            this.groupBoxforbutton.SuspendLayout();
            this.gbxTaskManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.White;
            this.pnlOuter.Controls.Add(this.groupBoxforExistingTask);
            this.pnlOuter.Controls.Add(this.groupBoxforbutton);
            this.pnlOuter.Controls.Add(this.gbxTaskManagement);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1097, 636);
            this.pnlOuter.TabIndex = 2;
            // 
            // groupBoxforExistingTask
            // 
            this.groupBoxforExistingTask.BackColor = System.Drawing.Color.White;
            this.groupBoxforExistingTask.Controls.Add(this.Dview);
            this.groupBoxforExistingTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxforExistingTask.Location = new System.Drawing.Point(12, 290);
            this.groupBoxforExistingTask.Name = "groupBoxforExistingTask";
            this.groupBoxforExistingTask.Size = new System.Drawing.Size(1076, 278);
            this.groupBoxforExistingTask.TabIndex = 15;
            this.groupBoxforExistingTask.TabStop = false;
            this.groupBoxforExistingTask.Text = "Existing Task and Description";
            // 
            // Dview
            // 
            this.Dview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dview.GridColor = System.Drawing.Color.Gray;
            this.Dview.Location = new System.Drawing.Point(6, 24);
            this.Dview.Name = "Dview";
            this.Dview.Size = new System.Drawing.Size(1054, 248);
            this.Dview.TabIndex = 0;
            this.Dview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dview_CellClick);
            // 
            // groupBoxforbutton
            // 
            this.groupBoxforbutton.Controls.Add(this.btnSave);
            this.groupBoxforbutton.Controls.Add(this.btnModify);
            this.groupBoxforbutton.Controls.Add(this.btnCancel);
            this.groupBoxforbutton.Controls.Add(this.btnAdd);
            this.groupBoxforbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxforbutton.Location = new System.Drawing.Point(403, 197);
            this.groupBoxforbutton.Name = "groupBoxforbutton";
            this.groupBoxforbutton.Size = new System.Drawing.Size(316, 48);
            this.groupBoxforbutton.TabIndex = 14;
            this.groupBoxforbutton.TabStop = false;
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
            // gbxTaskManagement
            // 
            this.gbxTaskManagement.Controls.Add(this.cmbActivity);
            this.gbxTaskManagement.Controls.Add(this.lblActivity);
            this.gbxTaskManagement.Controls.Add(this.chkActive);
            this.gbxTaskManagement.Controls.Add(this.rtxtRemark);
            this.gbxTaskManagement.Controls.Add(this.lblTaskName);
            this.gbxTaskManagement.Controls.Add(this.lblRemark);
            this.gbxTaskManagement.Controls.Add(this.txtTaskName);
            this.gbxTaskManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxTaskManagement.Location = new System.Drawing.Point(12, 2);
            this.gbxTaskManagement.Name = "gbxTaskManagement";
            this.gbxTaskManagement.Size = new System.Drawing.Size(1076, 191);
            this.gbxTaskManagement.TabIndex = 12;
            this.gbxTaskManagement.TabStop = false;
            this.gbxTaskManagement.Text = "Define Task";
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
            this.cmbActivity.SelectedIndexChanged += new System.EventHandler(this.cmbactivity_SelectedIndexChanged);
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(315, 27);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(115, 19);
            this.lblActivity.TabIndex = 8;
            this.lblActivity.Text = "Select Activity";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(478, 163);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(69, 19);
            this.chkActive.TabIndex = 7;
            this.chkActive.Text = "Is Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // rtxtRemark
            // 
            this.rtxtRemark.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtxtRemark.Location = new System.Drawing.Point(478, 98);
            this.rtxtRemark.Name = "rtxtRemark";
            this.rtxtRemark.Size = new System.Drawing.Size(296, 62);
            this.rtxtRemark.TabIndex = 6;
            this.rtxtRemark.Text = "";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(315, 63);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(95, 19);
            this.lblTaskName.TabIndex = 1;
            this.lblTaskName.Text = "Task Name";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblRemark.Location = new System.Drawing.Point(315, 98);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(131, 19);
            this.lblRemark.TabIndex = 5;
            this.lblRemark.Text = "Task Description";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTaskName.Location = new System.Drawing.Point(478, 63);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(296, 27);
            this.txtTaskName.TabIndex = 1;
            // 
            // DefineTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlOuter);
            this.Name = "DefineTask";
            this.Size = new System.Drawing.Size(1097, 636);
            this.Load += new System.EventHandler(this.DefineTask_Load);
            this.pnlOuter.ResumeLayout(false);
            this.groupBoxforExistingTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dview)).EndInit();
            this.groupBoxforbutton.ResumeLayout(false);
            this.gbxTaskManagement.ResumeLayout(false);
            this.gbxTaskManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.GroupBox groupBoxforExistingTask;
        private System.Windows.Forms.DataGridView Dview;
        private System.Windows.Forms.GroupBox groupBoxforbutton;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxTaskManagement;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.RichTextBox rtxtRemark;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.ComboBox cmbActivity;
    }
}
