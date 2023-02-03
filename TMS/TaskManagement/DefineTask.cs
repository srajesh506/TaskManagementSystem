using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using TMS.BusinessEntities;
using TMS.UI.Utilities;
using TMS.UI.CustomMessageBox;

namespace TMS.UI
{
    public partial class DefineTask : UserControl
    {
        private static int s_taskId;
        private static int s_activityId;
        private static string s_taskName;
        private static string s_taskDescription;
        private static Boolean s_isActive;

        Task task = new Task();

        TMS.BusinessLogicLayer.TaskManagement taskManagement = new TMS.BusinessLogicLayer.TaskManagement();
        public DefineTask()
        {
            InitializeComponent();
            LoadTheme();
            GetAllData();
            EnableDisableButtons(2);
        }

        private void LoadTheme()
        {

            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            btnadd.ForeColor = ThemeColor.PrimaryColor;
            btnsave.ForeColor = ThemeColor.PrimaryColor;
            btnmodify.ForeColor = ThemeColor.PrimaryColor;
            btncancel.ForeColor = ThemeColor.PrimaryColor;
            gbxtaskmanagement.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
            txttaskName.ForeColor = ThemeColor.SecondaryColor;
            rtxtremark.ForeColor = ThemeColor.SecondaryColor;
            chkactive.ForeColor = ThemeColor.SecondaryColor;
            cmbactivity.ForeColor = ThemeColor.SecondaryColor;
        }
        public void EnableDisableButtons(int flag)
        {
            if (flag == 0) //
            {
                btnsave.Enabled = false;
                btnmodify.Enabled = false;
                btncancel.Enabled = false;

            }
            if (flag == 1) //Add Data
            {
                txttaskName.Enabled = true;
                txttaskName.Enabled = true;
                txttaskName.Select();
                btnsave.Enabled = true;
                btncancel.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                cmbactivity.Enabled = true;
            }
            if (flag == 2)//modify and Cancel
            {
                txttaskName.Enabled = false;
                rtxtremark.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = false;
                btnmodify.Enabled = false;
                btnadd.Enabled = true;
                cmbactivity.Enabled = false;
            }
            if (flag == 3)
            {
                txttaskName.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = true;
                btnmodify.Enabled = true;
                cmbactivity.Enabled = true;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            EnableDisableButtons(1);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            FormControlHandling.ClearControls(gbxtaskmanagement);
            EnableDisableButtons(2);
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Validation();
                if (val == 1) return;
                task.TaskName = txttaskName.Text;
                task.TaskDescription = rtxtremark.Text;
                task.ActivityId = Convert.ToInt32(cmbactivity.SelectedValue);
                task.IsActive = chkactive.Checked;
                task.TaskId = s_taskId;
                int returnvalue = taskManagement.AddUpdateTask(task, true);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("Activity: '" + txttaskName.Text + "' doesnt exist in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FormControlHandling.ClearControls(gbxtaskmanagement);
                    GetAllData();
                    EnableDisableButtons(2);
                    RightBottomMessageBox.Info("Data modify Successfully!");
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Validation();
                if (val == 1) return;
                if (chkactive.Checked == false)
                {
                    PopupMessageBox.Show("Please Confirm Active Activity!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                task.TaskName = txttaskName.Text;
                task.TaskDescription = rtxtremark.Text;
                task.ActivityId = Convert.ToInt32(cmbactivity.SelectedValue);
                task.IsActive = chkactive.Checked;
                int returnvalue = taskManagement.AddUpdateTask(task);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("Task: '" + txttaskName.Text + "' already exists in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GetAllData();
                    FormControlHandling.ClearControls(gbxtaskmanagement);
                    EnableDisableButtons(2);
                    RightBottomMessageBox.Success("Data Saved Successfully!");
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefineTask_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = taskManagement.GetActivities(true);
                DataRow dr;
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Activity--" };
                dt.Rows.InsertAt(dr, 0);
                cmbactivity.ValueMember = "ActivityId";
                cmbactivity.DisplayMember = "ActivityName";
                cmbactivity.DataSource = dt;
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetAllData()
        {
            dview.DataSource = null;
            dview.DataSource = taskManagement.GetTasks();
            dview.Columns[0].Width = 50;
            dview.Columns[1].Width = 200;
            dview.Columns[2].Width = 300;
            dview.Columns[3].Width = 600;
            dview.Columns[4].Visible = false;
            dview.Columns[5].Visible = false;
            dview.Columns[6].Visible = false;
            dview.ReadOnly = true;
        }
        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
 
                int index = dview.CurrentRow.Index;
                if (index <= dview.RowCount - 1)
                {
                    s_activityId = Convert.ToInt32(dview.Rows[index].Cells[6].Value);
                    s_taskName = Convert.ToString(dview.Rows[index].Cells[2].Value);
                    s_taskDescription = Convert.ToString(dview.Rows[index].Cells[3].Value);
                    s_isActive = Convert.ToBoolean(dview.Rows[index].Cells[4].Value);
                    s_taskId = Convert.ToInt32(dview.Rows[index].Cells[5].Value);

                    cmbactivity.SelectedValue = s_activityId;
                    txttaskName.Text = s_taskName;
                    rtxtremark.Text = s_taskDescription;
                    chkactive.Checked = s_isActive;

                    EnableDisableButtons(3);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbactivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbactivity.SelectedIndex > 0)
                {
                    dview.DataSource = null;
                    dview.DataSource = taskManagement.GetTasks(false,-1,Convert.ToInt32(cmbactivity.SelectedValue));
                    dview.Columns[0].Width = 50;
                    dview.Columns[1].Width = 200;
                    dview.Columns[2].Width = 300;
                    dview.Columns[3].Width = 600;
                    dview.Columns[4].Visible = false;
                    dview.Columns[5].Visible = false;
                    dview.Columns[6].Visible = false;
                    dview.ReadOnly = true;
                }
                else
                {
                    GetAllData();
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public int Validation()
        {
            if (cmbactivity.SelectedIndex == 0)
            {
                PopupMessageBox.Show("Please Select Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
            if (txttaskName.Text == "")
            {
                PopupMessageBox.Show("Please Enter Task Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttaskName.Select();
                return 1;
            }
            if (rtxtremark.Text == "")
            {
                PopupMessageBox.Show("Please enter Task Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxtremark.Select();
                return 1;
            }
            return 0;
        }
    }
}
