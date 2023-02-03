using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using TMS.BusinessEntities;
using TMS.BusinessLogicLayer;
using TMS.UI.Utilities;
using System.Threading.Tasks;
using TMS.UI.CustomMessageBox;
using TMS.UI;

namespace TMS.UI
{
    public partial class DefineSubTask : UserControl
    {
        private static int s_activityId;
        private static int s_taskId;
        private static int s_subTaskId;
        private static string s_subTaskName;
        private static string s_subTaskDescription;
        private static Boolean s_isActive;


        SubTask subtask = new SubTask();

        TMS.BusinessLogicLayer.TaskManagement taskManagement = new TMS.BusinessLogicLayer.TaskManagement();

        public DefineSubTask()
        {
            InitializeComponent();
            LoadTheme();
            cmbtask.SelectedText = "--Select Task--";
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
            //lblsubtaskremark.ForeColor = ThemeColor.SecondaryColor;
            //lblsubtaskname.ForeColor = ThemeColor.SecondaryColor;
            //lblactivity.ForeColor = ThemeColor.SecondaryColor;
            //lbltask.ForeColor = ThemeColor.SecondaryColor;
            gbxtaskmanagement.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
            txtsubtaskName.ForeColor = ThemeColor.SecondaryColor;
            rtxtremark.ForeColor = ThemeColor.SecondaryColor;
            chkactive.ForeColor = ThemeColor.SecondaryColor;
            cmbactivity.ForeColor = ThemeColor.SecondaryColor;
            cmbtask.ForeColor = ThemeColor.SecondaryColor;
        }

        private void DefineSubTask_Load(object sender, EventArgs e)
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

        private void cmbactivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_temp = new DataTable();
                dt_temp = taskManagement.GetTasks(false,-1,(Convert.ToInt32(cmbactivity.SelectedValue)));
                string[] selectedColumns = new[] { "TaskId", "Task Name" };
                DataTable dt = new DataView(dt_temp).ToTable(false, selectedColumns);
                DataRow dr_task;
                dr_task = dt.NewRow();
                dr_task.ItemArray = new object[] { 0, "--Select Task--" };
                dt.Rows.InsertAt(dr_task, 0);
                cmbtask.ValueMember = "TaskId";
                cmbtask.DisplayMember = "Task Name";
                cmbtask.DataSource = dt;
                if (cmbactivity.SelectedIndex > 0)
                {
                    dview.DataSource = null;
                    dview.DataSource = taskManagement.GetSubTasks(false,-1,-1,(Convert.ToInt32(cmbactivity.SelectedValue)));
                    dview.Columns[0].Width = 50;
                    dview.Columns[1].Width = 200;
                    dview.Columns[2].Width = 300;
                    dview.Columns[3].Width = 300;
                    dview.Columns[4].Width = 400;
                    dview.Columns[5].Visible = false;
                    dview.Columns[6].Visible = false;
                    dview.Columns[7].Visible = false;
                    dview.Columns[8].Visible = false;
                    dview.ReadOnly = true;
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
                subtask.SubTaskName = txtsubtaskName.Text;
                subtask.SubTaskDescription = rtxtremark.Text;
                subtask.ActivityId = Convert.ToInt32(cmbactivity.SelectedValue);
                subtask.TaskId = Convert.ToInt32(cmbtask.SelectedValue);
                subtask.IsActive = chkactive.Checked;
           
                int returnvalue = taskManagement.AddUpdateSubtask(subtask);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("SubTask: '" + txtsubtaskName.Text + "' already exit in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtsubtaskName.Enabled = true;
                txtsubtaskName.Enabled = true;
                txtsubtaskName.Select();
                btnsave.Enabled = true;
                btncancel.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                cmbactivity.Enabled = true;
                cmbtask.Enabled = true;
            }
            if (flag == 2)//modify and Cancel
            {
                txtsubtaskName.Enabled = false;
                rtxtremark.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = false;
                btnmodify.Enabled = false;
                btnadd.Enabled = true;
                cmbactivity.Enabled = false;
                cmbtask.Enabled = false;
            }
            if (flag == 3)
            {
                txtsubtaskName.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = true;
                btnmodify.Enabled = true;
                cmbactivity.Enabled = true;
                cmbtask.Enabled = true;
            }
        }

        public void GetAllData()
        {
            dview.DataSource = null;
            dview.DataSource = taskManagement.GetSubTasks();
            dview.Columns[0].Width = 50;
            dview.Columns[1].Width = 200;
            dview.Columns[2].Width = 300;
            dview.Columns[3].Width = 300;
            dview.Columns[4].Width = 400;
            dview.Columns[5].Visible = false;
            dview.Columns[6].Visible = false;
            dview.Columns[7].Visible = false;
            dview.Columns[8].Visible = false;
            dview.ReadOnly = true;

        }

        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dview.CurrentRow.Index;
                if (index <= dview.RowCount - 1)
                {
                    s_activityId = Convert.ToInt32(dview.Rows[index].Cells[7].Value);
                    s_taskId = Convert.ToInt32(dview.Rows[index].Cells[6].Value);
                    s_subTaskName = Convert.ToString(dview.Rows[index].Cells[3].Value);
                    s_subTaskDescription = Convert.ToString(dview.Rows[index].Cells[4].Value);
                    s_isActive = Convert.ToBoolean(dview.Rows[index].Cells[5].Value);
                    s_subTaskId = Convert.ToInt32(dview.Rows[index].Cells[8].Value);

                    cmbactivity.SelectedValue = Convert.ToString(s_activityId);
                    cmbtask.SelectedValue = Convert.ToString(s_taskId);
                    txtsubtaskName.Text = Convert.ToString(s_subTaskName);
                    rtxtremark.Text = Convert.ToString(s_subTaskDescription);
                    chkactive.Checked = Convert.ToBoolean(s_isActive);
                    EnableDisableButtons(3);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            FormControlHandling.ClearControls(gbxtaskmanagement);
            EnableDisableButtons(2);
            GetAllData();
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Validation();
                if (val == 1) return;
                subtask.SubTaskName = txtsubtaskName.Text;
                subtask.SubTaskDescription = rtxtremark.Text;
                subtask.ActivityId = Convert.ToInt32(cmbactivity.SelectedValue);
                subtask.TaskId = Convert.ToInt32(cmbtask.SelectedValue); ;
                subtask.IsActive = chkactive.Checked;
                subtask.SubTaskId = s_subTaskId;
                int returnvalue = taskManagement.AddUpdateSubtask(subtask, true);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("Subtask: '" + txtsubtaskName.Text + "' doesnt exist in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            EnableDisableButtons(1);
        }

        private void cmbtask_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbactivity.SelectedIndex > 0 && cmbtask.SelectedIndex > 0)
                {
                    dview.DataSource = null;
                    dview.DataSource = taskManagement.GetSubTasks(false,-1,Convert.ToInt32(cmbtask.SelectedValue), Convert.ToInt32(cmbactivity.SelectedValue));
                    dview.Columns[0].Width = 50;
                    dview.Columns[1].Width = 200;
                    dview.Columns[2].Width = 300;
                    dview.Columns[3].Width = 300;
                    dview.Columns[4].Width = 400;
                    dview.Columns[5].Visible = false;
                    dview.Columns[6].Visible = false;
                    dview.Columns[7].Visible = false;
                    dview.Columns[8].Visible = false;
                    dview.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int Validation()
        {
            if (cmbactivity.SelectedIndex == 0)
            {
                PopupMessageBox.Show("Please Select Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
            if (cmbtask.SelectedIndex == 0)
            {
                PopupMessageBox.Show("Please Select Task Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
            if (txtsubtaskName.Text == "")
            {
                PopupMessageBox.Show("Please Enter SubTask Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsubtaskName.Select();
                return 1; 
            }
            if (rtxtremark.Text == "")
            {
                PopupMessageBox.Show("Please enter SubTask Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxtremark.Select();
                return 1;
            }
            return 0;
        }
    }
}
