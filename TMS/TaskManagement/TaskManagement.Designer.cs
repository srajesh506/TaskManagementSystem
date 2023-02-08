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
            this.pnlTableLayout = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlManageTask = new System.Windows.Forms.Panel();
            this.btnManageTask = new System.Windows.Forms.Button();
            this.pnlManageActivity = new System.Windows.Forms.Panel();
            this.btnManageActivity = new System.Windows.Forms.Button();
            this.pnlManageSubtask = new System.Windows.Forms.Panel();
            this.btnManageSubTask = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pnlTableLayout.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.pnlManageTask.SuspendLayout();
            this.pnlManageActivity.SuspendLayout();
            this.pnlManageSubtask.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTableLayout
            // 
            this.pnlTableLayout.Controls.Add(this.tableLayoutPanelMain);
            this.pnlTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTableLayout.Location = new System.Drawing.Point(5, 5);
            this.pnlTableLayout.Name = "pnlTableLayout";
            this.pnlTableLayout.Size = new System.Drawing.Size(990, 82);
            this.pnlTableLayout.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.pnlManageTask, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.pnlManageActivity, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.pnlManageSubtask, 3, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(990, 90);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // pnlManageTask
            // 
            this.pnlManageTask.BackColor = System.Drawing.Color.Silver;
            this.pnlManageTask.Controls.Add(this.btnManageTask);
            this.pnlManageTask.Location = new System.Drawing.Point(335, 5);
            this.pnlManageTask.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.pnlManageTask.Name = "pnlManageTask";
            this.pnlManageTask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.pnlManageTask.Size = new System.Drawing.Size(319, 79);
            this.pnlManageTask.TabIndex = 1;
            // 
            // btnManageTask
            // 
            this.btnManageTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnManageTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageTask.FlatAppearance.BorderSize = 0;
            this.btnManageTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTask.ForeColor = System.Drawing.Color.White;
            this.btnManageTask.Image = ((System.Drawing.Image)(resources.GetObject("btnManageTask.Image")));
            this.btnManageTask.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageTask.Location = new System.Drawing.Point(0, 0);
            this.btnManageTask.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageTask.Name = "btnManageTask";
            this.btnManageTask.Size = new System.Drawing.Size(319, 70);
            this.btnManageTask.TabIndex = 3;
            this.btnManageTask.Text = "Manage Task";
            this.btnManageTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageTask.UseVisualStyleBackColor = false;
            this.btnManageTask.Click += new System.EventHandler(this.btn_click);
            // 
            // pnlManageActivity
            // 
            this.pnlManageActivity.BackColor = System.Drawing.Color.Black;
            this.pnlManageActivity.Controls.Add(this.btnManageActivity);
            this.pnlManageActivity.Location = new System.Drawing.Point(5, 5);
            this.pnlManageActivity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.pnlManageActivity.Name = "pnlManageActivity";
            this.pnlManageActivity.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.pnlManageActivity.Size = new System.Drawing.Size(319, 79);
            this.pnlManageActivity.TabIndex = 3;
            // 
            // btnManageActivity
            // 
            this.btnManageActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnManageActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageActivity.FlatAppearance.BorderSize = 0;
            this.btnManageActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageActivity.ForeColor = System.Drawing.Color.White;
            this.btnManageActivity.Image = ((System.Drawing.Image)(resources.GetObject("btnManageActivity.Image")));
            this.btnManageActivity.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageActivity.Location = new System.Drawing.Point(0, 0);
            this.btnManageActivity.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageActivity.Name = "btnManageActivity";
            this.btnManageActivity.Size = new System.Drawing.Size(319, 70);
            this.btnManageActivity.TabIndex = 2;
            this.btnManageActivity.Text = "Manage Activity";
            this.btnManageActivity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageActivity.UseVisualStyleBackColor = false;
            this.btnManageActivity.Click += new System.EventHandler(this.btn_click);
            // 
            // pnlManageSubtask
            // 
            this.pnlManageSubtask.BackColor = System.Drawing.Color.Silver;
            this.pnlManageSubtask.Controls.Add(this.btnManageSubTask);
            this.pnlManageSubtask.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageSubtask.Location = new System.Drawing.Point(665, 5);
            this.pnlManageSubtask.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.pnlManageSubtask.Name = "pnlManageSubtask";
            this.pnlManageSubtask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.pnlManageSubtask.Size = new System.Drawing.Size(320, 79);
            this.pnlManageSubtask.TabIndex = 2;
            // 
            // btnManageSubTask
            // 
            this.btnManageSubTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnManageSubTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageSubTask.FlatAppearance.BorderSize = 0;
            this.btnManageSubTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSubTask.ForeColor = System.Drawing.Color.White;
            this.btnManageSubTask.Image = ((System.Drawing.Image)(resources.GetObject("btnManageSubTask.Image")));
            this.btnManageSubTask.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageSubTask.Location = new System.Drawing.Point(0, 0);
            this.btnManageSubTask.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageSubTask.Name = "btnManageSubTask";
            this.btnManageSubTask.Size = new System.Drawing.Size(320, 70);
            this.btnManageSubTask.TabIndex = 4;
            this.btnManageSubTask.Text = "Manage Subtask";
            this.btnManageSubTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageSubTask.UseVisualStyleBackColor = false;
            this.btnManageSubTask.Click += new System.EventHandler(this.btn_click);
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
            this.Controls.Add(this.pnlTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskManagement";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management";
            this.pnlTableLayout.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.pnlManageTask.ResumeLayout(false);
            this.pnlManageActivity.ResumeLayout(false);
            this.pnlManageSubtask.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel pnlManageTask;
        private System.Windows.Forms.Button btnManageTask;
        private System.Windows.Forms.Panel pnlManageActivity;
        private System.Windows.Forms.Button btnManageActivity;
        private System.Windows.Forms.Panel pnlManageSubtask;
        private System.Windows.Forms.Button btnManageSubTask;
    }
}