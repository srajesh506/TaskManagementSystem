namespace TMS.UI
{
    partial class DefineActivity
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
            this.chkactive = new System.Windows.Forms.CheckBox();
            this.rtxtremark = new System.Windows.Forms.RichTextBox();
            this.lblactivityname = new System.Windows.Forms.Label();
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
            this.pnlouter.TabIndex = 1;
            // 
            // groupBoxforexistingemployee
            // 
            this.groupBoxforexistingemployee.BackColor = System.Drawing.Color.White;
            this.groupBoxforexistingemployee.Controls.Add(this.dview);
            this.groupBoxforexistingemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxforexistingemployee.Location = new System.Drawing.Point(12, 290);
            this.groupBoxforexistingemployee.Name = "groupBoxforexistingemployee";
            this.groupBoxforexistingemployee.Size = new System.Drawing.Size(1074, 345);
            this.groupBoxforexistingemployee.TabIndex = 15;
            this.groupBoxforexistingemployee.TabStop = false;
            this.groupBoxforexistingemployee.Text = "Existing Activity and Description";
            // 
            // dview
            // 
            this.dview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dview.Location = new System.Drawing.Point(6, 24);
            this.dview.Name = "dview";
            this.dview.Size = new System.Drawing.Size(1061, 294);
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
            this.gbxtaskmanagement.Controls.Add(this.chkactive);
            this.gbxtaskmanagement.Controls.Add(this.rtxtremark);
            this.gbxtaskmanagement.Controls.Add(this.lblactivityname);
            this.gbxtaskmanagement.Controls.Add(this.lblremark);
            this.gbxtaskmanagement.Controls.Add(this.txttaskName);
            this.gbxtaskmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbxtaskmanagement.Location = new System.Drawing.Point(12, 3);
            this.gbxtaskmanagement.Name = "gbxtaskmanagement";
            this.gbxtaskmanagement.Size = new System.Drawing.Size(1074, 180);
            this.gbxtaskmanagement.TabIndex = 12;
            this.gbxtaskmanagement.TabStop = false;
            this.gbxtaskmanagement.Text = "Define Activity";
            // 
            // chkactive
            // 
            this.chkactive.AutoSize = true;
            this.chkactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkactive.Location = new System.Drawing.Point(478, 154);
            this.chkactive.Name = "chkactive";
            this.chkactive.Size = new System.Drawing.Size(69, 19);
            this.chkactive.TabIndex = 7;
            this.chkactive.Text = "Is Active";
            this.chkactive.UseVisualStyleBackColor = true;
            // 
            // rtxtremark
            // 
            this.rtxtremark.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtxtremark.Location = new System.Drawing.Point(478, 83);
            this.rtxtremark.Name = "rtxtremark";
            this.rtxtremark.Size = new System.Drawing.Size(272, 62);
            this.rtxtremark.TabIndex = 6;
            this.rtxtremark.Text = "";
            // 
            // lblactivityname
            // 
            this.lblactivityname.AutoSize = true;
            this.lblactivityname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactivityname.Location = new System.Drawing.Point(315, 30);
            this.lblactivityname.Name = "lblactivityname";
            this.lblactivityname.Size = new System.Drawing.Size(118, 19);
            this.lblactivityname.TabIndex = 1;
            this.lblactivityname.Text = "Activity Name";
            // 
            // lblremark
            // 
            this.lblremark.AutoSize = true;
            this.lblremark.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblremark.Location = new System.Drawing.Point(315, 83);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(154, 19);
            this.lblremark.TabIndex = 5;
            this.lblremark.Text = "Activity Description";
            // 
            // txttaskName
            // 
            this.txttaskName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txttaskName.Location = new System.Drawing.Point(478, 30);
            this.txttaskName.Name = "txttaskName";
            this.txttaskName.Size = new System.Drawing.Size(272, 27);
            this.txttaskName.TabIndex = 1;
            // 
            // DefineActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlouter);
            this.Name = "DefineActivity";
            this.Size = new System.Drawing.Size(1097, 636);
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
        private System.Windows.Forms.Label lblactivityname;
        private System.Windows.Forms.Label lblremark;
        private System.Windows.Forms.TextBox txttaskName;
    }
}
