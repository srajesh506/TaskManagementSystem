namespace TMS.UI
{
    partial class TaskManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagement));
            this.pnltablelayout = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlManagetask = new System.Windows.Forms.Panel();
            this.btnManagetask = new System.Windows.Forms.Button();
            this.pnlmanageactivity = new System.Windows.Forms.Panel();
            this.btnmanageactivity = new System.Windows.Forms.Button();
            this.pnlmanagesubtask = new System.Windows.Forms.Panel();
            this.btnmanagesubtask = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pnltablelayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlManagetask.SuspendLayout();
            this.pnlmanageactivity.SuspendLayout();
            this.pnlmanagesubtask.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltablelayout
            // 
            this.pnltablelayout.Controls.Add(this.tableLayoutPanel1);
            this.pnltablelayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltablelayout.Location = new System.Drawing.Point(5, 5);
            this.pnltablelayout.Name = "pnltablelayout";
            this.pnltablelayout.Size = new System.Drawing.Size(990, 82);
            this.pnltablelayout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlManagetask, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlmanageactivity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlmanagesubtask, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(990, 90);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pnlManagetask
            // 
            this.pnlManagetask.BackColor = System.Drawing.Color.Silver;
            this.pnlManagetask.Controls.Add(this.btnManagetask);
            this.pnlManagetask.Location = new System.Drawing.Point(335, 5);
            this.pnlManagetask.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.pnlManagetask.Name = "pnlManagetask";
            this.pnlManagetask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.pnlManagetask.Size = new System.Drawing.Size(319, 79);
            this.pnlManagetask.TabIndex = 1;
            // 
            // btnManagetask
            // 
            this.btnManagetask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnManagetask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagetask.FlatAppearance.BorderSize = 0;
            this.btnManagetask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagetask.ForeColor = System.Drawing.Color.White;
            this.btnManagetask.Image = ((System.Drawing.Image)(resources.GetObject("btnManagetask.Image")));
            this.btnManagetask.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManagetask.Location = new System.Drawing.Point(0, 0);
            this.btnManagetask.Margin = new System.Windows.Forms.Padding(0);
            this.btnManagetask.Name = "btnManagetask";
            this.btnManagetask.Size = new System.Drawing.Size(319, 70);
            this.btnManagetask.TabIndex = 3;
            this.btnManagetask.Text = "Manage Task";
            this.btnManagetask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManagetask.UseVisualStyleBackColor = false;
            this.btnManagetask.Click += new System.EventHandler(this.btn_click);
            // 
            // pnlmanageactivity
            // 
            this.pnlmanageactivity.BackColor = System.Drawing.Color.Black;
            this.pnlmanageactivity.Controls.Add(this.btnmanageactivity);
            this.pnlmanageactivity.Location = new System.Drawing.Point(5, 5);
            this.pnlmanageactivity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.pnlmanageactivity.Name = "pnlmanageactivity";
            this.pnlmanageactivity.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.pnlmanageactivity.Size = new System.Drawing.Size(319, 79);
            this.pnlmanageactivity.TabIndex = 3;
            // 
            // btnmanageactivity
            // 
            this.btnmanageactivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnmanageactivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmanageactivity.FlatAppearance.BorderSize = 0;
            this.btnmanageactivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmanageactivity.ForeColor = System.Drawing.Color.White;
            this.btnmanageactivity.Image = ((System.Drawing.Image)(resources.GetObject("btnmanageactivity.Image")));
            this.btnmanageactivity.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmanageactivity.Location = new System.Drawing.Point(0, 0);
            this.btnmanageactivity.Margin = new System.Windows.Forms.Padding(0);
            this.btnmanageactivity.Name = "btnmanageactivity";
            this.btnmanageactivity.Size = new System.Drawing.Size(319, 70);
            this.btnmanageactivity.TabIndex = 2;
            this.btnmanageactivity.Text = "Manage Activity";
            this.btnmanageactivity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmanageactivity.UseVisualStyleBackColor = false;
            this.btnmanageactivity.Click += new System.EventHandler(this.btn_click);
            // 
            // pnlmanagesubtask
            // 
            this.pnlmanagesubtask.BackColor = System.Drawing.Color.Silver;
            this.pnlmanagesubtask.Controls.Add(this.btnmanagesubtask);
            this.pnlmanagesubtask.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmanagesubtask.Location = new System.Drawing.Point(665, 5);
            this.pnlmanagesubtask.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.pnlmanagesubtask.Name = "pnlmanagesubtask";
            this.pnlmanagesubtask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.pnlmanagesubtask.Size = new System.Drawing.Size(320, 79);
            this.pnlmanagesubtask.TabIndex = 2;
            // 
            // btnmanagesubtask
            // 
            this.btnmanagesubtask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnmanagesubtask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmanagesubtask.FlatAppearance.BorderSize = 0;
            this.btnmanagesubtask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmanagesubtask.ForeColor = System.Drawing.Color.White;
            this.btnmanagesubtask.Image = ((System.Drawing.Image)(resources.GetObject("btnmanagesubtask.Image")));
            this.btnmanagesubtask.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmanagesubtask.Location = new System.Drawing.Point(0, 0);
            this.btnmanagesubtask.Margin = new System.Windows.Forms.Padding(0);
            this.btnmanagesubtask.Name = "btnmanagesubtask";
            this.btnmanagesubtask.Size = new System.Drawing.Size(320, 70);
            this.btnmanagesubtask.TabIndex = 4;
            this.btnmanagesubtask.Text = "Manage Subtask";
            this.btnmanagesubtask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmanagesubtask.UseVisualStyleBackColor = false;
            this.btnmanagesubtask.Click += new System.EventHandler(this.btn_click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(5, 87);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(990, 458);
            this.panelMain.TabIndex = 1;
            // 
            // TaskManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pnltablelayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskManagement";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management";
            this.pnltablelayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlManagetask.ResumeLayout(false);
            this.pnlmanageactivity.ResumeLayout(false);
            this.pnlmanagesubtask.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltablelayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel pnlManagetask;
        private System.Windows.Forms.Button btnManagetask;
        private System.Windows.Forms.Panel pnlmanageactivity;
        private System.Windows.Forms.Button btnmanageactivity;
        private System.Windows.Forms.Panel pnlmanagesubtask;
        private System.Windows.Forms.Button btnmanagesubtask;
    }
}