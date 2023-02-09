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
            cmbTask.SelectedText = "--Select Task--";
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
            btnAdd.ForeColor = ThemeColor.PrimaryColor;
            btnSave.ForeColor = ThemeColor.PrimaryColor;
            btnModify.ForeColor = ThemeColor.PrimaryColor;
            btnCancel.ForeColor = ThemeColor.PrimaryColor;
            //lblsubtaskremark.ForeColor = ThemeColor.SecondaryColor;
            //lblsubtaskname.ForeColor = ThemeColor.SecondaryColor;
            //lblactivity.ForeColor = ThemeColor.SecondaryColor;
            //lbltask.ForeColor = ThemeColor.SecondaryColor;
            gbxTaskManagement.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxForSubTaskandDescription.ForeColor = ThemeColor.PrimaryColor;
            txtSubTaskName.ForeColor = ThemeColor.SecondaryColor;
            rtxtRemark.ForeColor = ThemeColor.SecondaryColor;
            chkActive.ForeColor = ThemeColor.SecondaryColor;
            cmbActivity.ForeColor = ThemeColor.SecondaryColor;
            cmbTask.ForeColor = ThemeColor.SecondaryColor;
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
                cmbActivity.ValueMember = "ActivityId";
                cmbActivity.DisplayMember = "ActivityName";
                cmbActivity.DataSource = dt;
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
                dt_temp = taskManagement.GetTasks(false,-1,(Convert.ToInt32(cmbActivity.SelectedValue)));
                string[] selectedColumns = new[] { "TaskId", "Task Name" };
                DataTable dt = new DataView(dt_temp).ToTable(false, selectedColumns);
                DataRow dr_task;
                dr_task = dt.NewRow();
                dr_task.ItemArray = new object[] { 0, "--Select Task--" };
                dt.Rows.InsertAt(dr_task, 0);
                cmbTask.ValueMember = "TaskId";
                cmbTask.DisplayMember = "Task Name";
                cmbTask.DataSource = dt;
                if (cmbActivity.SelectedIndex > 0)
                {
                    Dview.DataSource = null;
                    Dview.DataSource = taskManagement.GetSubTasks(false,-1,-1,(Convert.ToInt32(cmbActivity.SelectedValue)));
                    Dview.Columns[0].Width = 50;
                    Dview.Columns[1].Width = 200;
                    Dview.Columns[2].Width = 300;
                    Dview.Columns[3].Width = 300;
                    Dview.Columns[4].Width = 400;
                    Dview.Columns[5].Visible = false;
                    Dview.Columns[6].Visible = false;
                    Dview.Columns[7].Visible = false;
                    Dview.Columns[8].Visible = false;
                    Dview.ReadOnly = true;
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
                if (chkActive.Checked == false)
                {
                    PopupMessageBox.Show("Please Confirm Active Activity!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                subtask.SubTaskName = txtSubTaskName.Text;
                subtask.SubTaskDescription = rtxtRemark.Text;
                subtask.ActivityId = Convert.ToInt32(cmbActivity.SelectedValue);
                subtask.TaskId = Convert.ToInt32(cmbTask.SelectedValue);
                subtask.IsActive = chkActive.Checked;
           
                int returnvalue = taskManagement.AddUpdateSubtask(subtask);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("SubTask: '" + txtSubTaskName.Text + "' already exit in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GetAllData();
                    FormControlHandling.ClearControls(gbxTaskManagement);
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
                btnSave.Enabled = false;
                btnModify.Enabled = false;
                btnCancel.Enabled = false;

            }
            if (flag == 1) //Add Data
            {
                txtSubTaskName.Enabled = true;
                txtSubTaskName.Enabled = true;
                txtSubTaskName.Select();
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                rtxtRemark.Enabled = true;
                btnAdd.Enabled = false;
                cmbActivity.Enabled = true;
                cmbTask.Enabled = true;
            }
            if (flag == 2)//modify and Cancel
            {
                txtSubTaskName.Enabled = false;
                rtxtRemark.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnModify.Enabled = false;
                btnAdd.Enabled = true;
                cmbActivity.Enabled = false;
                cmbTask.Enabled = false;
            }
            if (flag == 3)
            {
                txtSubTaskName.Enabled = true;
                rtxtRemark.Enabled = true;
                btnAdd.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = true;
                btnModify.Enabled = true;
                cmbActivity.Enabled = true;
                cmbTask.Enabled = true;
            }
        }

        public void GetAllData()
        {
            Dview.DataSource = null;
            Dview.DataSource = taskManagement.GetSubTasks();
            Dview.Columns[0].Width = 50;
            Dview.Columns[1].Width = 200;
            Dview.Columns[2].Width = 300;
            Dview.Columns[3].Width = 300;
            Dview.Columns[4].Width = 400;
            Dview.Columns[5].Visible = false;
            Dview.Columns[6].Visible = false;
            Dview.Columns[7].Visible = false;
            Dview.Columns[8].Visible = false;
            Dview.ReadOnly = true;

        }

        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = Dview.CurrentRow.Index;
                if (index <= Dview.RowCount - 1)
                {
                    s_activityId = Convert.ToInt32(Dview.Rows[index].Cells[7].Value);
                    s_taskId = Convert.ToInt32(Dview.Rows[index].Cells[6].Value);
                    s_subTaskName = Convert.ToString(Dview.Rows[index].Cells[3].Value);
                    s_subTaskDescription = Convert.ToString(Dview.Rows[index].Cells[4].Value);
                    s_isActive = Convert.ToBoolean(Dview.Rows[index].Cells[5].Value);
                    s_subTaskId = Convert.ToInt32(Dview.Rows[index].Cells[8].Value);

                    cmbActivity.SelectedValue = Convert.ToString(s_activityId);
                    cmbTask.SelectedValue = Convert.ToString(s_taskId);
                    txtSubTaskName.Text = Convert.ToString(s_subTaskName);
                    rtxtRemark.Text = Convert.ToString(s_subTaskDescription);
                    chkActive.Checked = Convert.ToBoolean(s_isActive);
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
            FormControlHandling.ClearControls(gbxTaskManagement);
            EnableDisableButtons(2);
            GetAllData();
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Validation();
                if (val == 1) return;
                subtask.SubTaskName = txtSubTaskName.Text;
                subtask.SubTaskDescription = rtxtRemark.Text;
                subtask.ActivityId = Convert.ToInt32(cmbActivity.SelectedValue);
                subtask.TaskId = Convert.ToInt32(cmbTask.SelectedValue); ;
                subtask.IsActive = chkActive.Checked;
                subtask.SubTaskId = s_subTaskId;
                int returnvalue = taskManagement.AddUpdateSubtask(subtask, true);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("Subtask: '" + txtSubTaskName.Text + "' doesnt exist in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FormControlHandling.ClearControls(gbxTaskManagement);
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
                if (cmbActivity.SelectedIndex > 0 && cmbTask.SelectedIndex > 0)
                {
                    Dview.DataSource = null;
                    Dview.DataSource = taskManagement.GetSubTasks(false,-1,Convert.ToInt32(cmbTask.SelectedValue), Convert.ToInt32(cmbActivity.SelectedValue));
                    Dview.Columns[0].Width = 50;
                    Dview.Columns[1].Width = 200;
                    Dview.Columns[2].Width = 300;
                    Dview.Columns[3].Width = 300;
                    Dview.Columns[4].Width = 400;
                    Dview.Columns[5].Visible = false;
                    Dview.Columns[6].Visible = false;
                    Dview.Columns[7].Visible = false;
                    Dview.Columns[8].Visible = false;
                    Dview.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int Validation()
        {
            if (cmbActivity.SelectedIndex == 0)
            {
                PopupMessageBox.Show("Please Select Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
            if (cmbTask.SelectedIndex == 0)
            {
                PopupMessageBox.Show("Please Select Task Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
            if (txtSubTaskName.Text == "")
            {
                PopupMessageBox.Show("Please Enter SubTask Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSubTaskName.Select();
                return 1; 
            }
            if (rtxtRemark.Text == "")
            {
                PopupMessageBox.Show("Please enter SubTask Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxtRemark.Select();
                return 1;
            }
            return 0;
        }
    }
}
