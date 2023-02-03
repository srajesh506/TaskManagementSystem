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
            this.pnlouter = new System.Windows.Forms.Panel();
            this.groupBoxforexistingemployee = new System.Windows.Forms.GroupBox();
            this.dview = new System.Windows.Forms.DataGridView();
            this.groupBoxforbutton = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.gbxtaskmanagement = new System.Windows.Forms.GroupBox();
            this.cmbactivity = new System.Windows.Forms.ComboBox();
            this.lblactivity = new System.Windows.Forms.Label();
            this.chkactive = new System.Windows.Forms.CheckBox();
            this.rtxtremark = new System.Windows.Forms.RichTextBox();
            this.lbltaskname = new System.Windows.Forms.Label();
            this.lblremark = new System.Windows.Forms.Label();
            this.txttaskName = new System.Windows.Forms.TextBox();
            this.pnlouter.SuspendLayout();
            this.groupBoxforexistingemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dview)).BeginInit();
            this.groupBoxforbutton.SuspendLayout();
            this.gbxtaskmanagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlouter
            // 
            this.pnlouter.BackColor = System.Drawing.Color.White;
            this.pnlouter.Controls.Add(this.groupBoxforexistingemployee);
            this.pnlouter.Controls.Add(this.groupBoxforbutton);
            this.pnlouter.Controls.Add(this.gbxtaskmanagement);
            this.pnlouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlouter.Location = new System.Drawing.Point(0, 0);
            this.pnlouter.Name = "pnlouter";
            this.pnlouter.Size = new System.Drawing.Size(1097, 636);
            this.pnlouter.TabIndex = 2;
            // 
            // groupBoxforexistingemployee
            // 
            this.groupBoxforexistingemployee.BackColor = System.Drawing.Color.White;
            this.groupBoxforexistingemployee.Controls.Add(this.dview);
            this.groupBoxforexistingemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxforexistingemployee.Location = new System.Drawing.Point(12, 290);
            this.groupBoxforexistingemployee.Name = "groupBoxforexistingemployee";
            this.groupBoxforexistingemployee.Size = new System.Drawing.Size(1076, 278);
            this.groupBoxforexistingemployee.TabIndex = 15;
            this.groupBoxforexistingemployee.TabStop = false;
            this.groupBoxforexistingemployee.Text = "Existing Task and Description";
            // 
            // dview
            // 
            this.dview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dview.GridColor = System.Drawing.Color.Gray;
            this.dview.Location = new System.Drawing.Point(6, 24);
            this.dview.Name = "dview";
            this.dview.Size = new System.Drawing.Size(1054, 248);
            this.dview.TabIndex = 0;
            this.dview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dview_CellClick);
            // 
            // groupBoxforbutton
            // 
            this.groupBoxforbutton.Controls.Add(this.btnsave);
            this.groupBoxforbutton.Controls.Add(this.btnmodify);
            this.groupBoxforbutton.Controls.Add(this.btncancel);
            this.groupBoxforbutton.Controls.Add(this.btnadd);
            this.groupBoxforbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxforbutton.Location = new System.Drawing.Point(403, 197);
            this.groupBoxforbutton.Name = "groupBoxforbutton";
            this.groupBoxforbutton.Size = new System.Drawing.Size(316, 48);
            this.groupBoxforbutton.TabIndex = 14;
            this.groupBoxforbutton.TabStop = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(82, 11);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(72, 31);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.Location = new System.Drawing.Point(159, 11);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(72, 31);
            this.btnmodify.TabIndex = 15;
            this.btnmodify.Text = "&Modify";
            this.btnmodify.UseVisualStyleBackColor = true;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(237, 11);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(72, 31);
            this.btncancel.TabIndex = 16;
            this.btncancel.Text = "&Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(6, 11);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(72, 31);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "&Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // gbxtaskmanagement
            // 
            this.gbxtaskmanagement.Controls.Add(this.cmbactivity);
            this.gbxtaskmanagement.Controls.Add(this.lblactivity);
            this.gbxtaskmanagement.Controls.Add(this.chkactive);
            this.gbxtaskmanagement.Controls.Add(this.rtxtremark);
            this.gbxtaskmanagement.Controls.Add(this.lbltaskname);
            this.gbxtaskmanagement.Controls.Add(this.lblremark);
            this.gbxtaskmanagement.Controls.Add(this.txttaskName);
            this.gbxtaskmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxtaskmanagement.Location = new System.Drawing.Point(12, 2);
            this.gbxtaskmanagement.Name = "gbxtaskmanagement";
            this.gbxtaskmanagement.Size = new System.Drawing.Size(1076, 191);
            this.gbxtaskmanagement.TabIndex = 12;
            this.gbxtaskmanagement.TabStop = false;
            this.gbxtaskmanagement.Text = "Define Task";
            // 
            // cmbactivity
            // 
            this.cmbactivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbactivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbactivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cmbactivity.FormattingEnabled = true;
            this.cmbactivity.Location = new System.Drawing.Point(478, 23);
            this.cmbactivity.Name = "cmbactivity";
            this.cmbactivity.Size = new System.Drawing.Size(296, 29);
            this.cmbactivity.TabIndex = 9;
            this.cmbactivity.SelectedIndexChanged += new System.EventHandler(this.cmbactivity_SelectedIndexChanged);
            // 
            // lblactivity
            // 
            this.lblactivity.AutoSize = true;
            this.lblactivity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactivity.Location = new System.Drawing.Point(315, 27);
            this.lblactivity.Name = "lblactivity";
            this.lblactivity.Size = new System.Drawing.Size(115, 19);
            this.lblactivity.TabIndex = 8;
            this.lblactivity.Text = "Select Activity";
            // 
            // chkactive
            // 
            this.chkactive.AutoSize = true;
            this.chkactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkactive.Location = new System.Drawing.Point(478, 163);
            this.chkactive.Name = "chkactive";
            this.chkactive.Size = new System.Drawing.Size(69, 19);
            this.chkactive.TabIndex = 7;
            this.chkactive.Text = "Is Active";
            this.chkactive.UseVisualStyleBackColor = true;
            // 
            // rtxtremark
            // 
            this.rtxtremark.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtxtremark.Location = new System.Drawing.Point(478, 98);
            this.rtxtremark.Name = "rtxtremark";
            this.rtxtremark.Size = new System.Drawing.Size(296, 62);
            this.rtxtremark.TabIndex = 6;
            this.rtxtremark.Text = "";
            // 
            // lbltaskname
            // 
            this.lbltaskname.AutoSize = true;
            this.lbltaskname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaskname.Location = new System.Drawing.Point(315, 63);
            this.lbltaskname.Name = "lbltaskname";
            this.lbltaskname.Size = new System.Drawing.Size(95, 19);
            this.lbltaskname.TabIndex = 1;
            this.lbltaskname.Text = "Task Name";
            // 
            // lblremark
            // 
            this.lblremark.AutoSize = true;
            this.lblremark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblremark.Location = new System.Drawing.Point(315, 98);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(131, 19);
            this.lblremark.TabIndex = 5;
            this.lblremark.Text = "Task Description";
            // 
            // txttaskName
            // 
            this.txttaskName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txttaskName.Location = new System.Drawing.Point(478, 63);
            this.txttaskName.Name = "txttaskName";
            this.txttaskName.Size = new System.Drawing.Size(296, 27);
            this.txttaskName.TabIndex = 1;
            // 
            // DefineTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlouter);
            this.Name = "DefineTask";
            this.Size = new System.Drawing.Size(1097, 636);
            this.Load += new System.EventHandler(this.DefineTask_Load);
            this.pnlouter.ResumeLayout(false);
            this.groupBoxforexistingemployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dview)).EndInit();
            this.groupBoxforbutton.ResumeLayout(false);
            this.gbxtaskmanagement.ResumeLayout(false);
            this.gbxtaskmanagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlouter;
        private System.Windows.Forms.GroupBox groupBoxforexistingemployee;
        private System.Windows.Forms.DataGridView dview;
        private System.Windows.Forms.GroupBox groupBoxforbutton;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox gbxtaskmanagement;
        private System.Windows.Forms.CheckBox chkactive;
        private System.Windows.Forms.RichTextBox rtxtremark;
        private System.Windows.Forms.Label lbltaskname;
        private System.Windows.Forms.Label lblremark;
        private System.Windows.Forms.TextBox txttaskName;
        private System.Windows.Forms.Label lblactivity;
        private System.Windows.Forms.ComboBox cmbactivity;
    }
}
