using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TMS.BusinessEntities;
using TMS.BusinessLogicLayer;
using TMS.UI.Utilities;
using TMS.UI.CustomMessageBox;
using System.Threading.Tasks;

namespace TMS.UI
{
    public partial class CreateWorkItem : Form
    {
        static private string s_id;
        static private string s_activity;
        static private string s_task;
        static private string s_subTask;
        static private string s_remark;

        TMS.BusinessLogicLayer.TaskManagement taskManagement = new TMS.BusinessLogicLayer.TaskManagement();
        WorkItemManagement workItemManagement = new WorkItemManagement();
        public CreateWorkItem()
        {
            InitializeComponent();
            LoadTheme();
            GetDefaultControlValues();
            GetAllData();
            EnableDisableButtons(2);
        }
        private void CreateWorkItem_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtActivity = new DataTable();
                dtActivity = taskManagement.GetActivities(true);
                DataRow drActivity = dtActivity.NewRow();
                drActivity.ItemArray = new object[] { 0, "--Select Activity--" };
                dtActivity.Rows.InsertAt(drActivity, 0);
                cmbActivity.ValueMember = "ActivityId";
                cmbActivity.DisplayMember = "ActivityName";
                cmbActivity.DataSource = dtActivity;
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbActivity.SelectedIndex > 0)
                {
                    DataTable dt_temp = new DataTable();
                    dt_temp = taskManagement.GetTasks(false,-1, (Convert.ToInt32(cmbActivity.SelectedValue)));
                    string[] selectedColumns = new[] { "TaskId", "Task Name" };
                    DataTable dt = new DataView(dt_temp).ToTable(false, selectedColumns);
                    DataRow dr_task;
                    dr_task = dt.NewRow();
                    dr_task.ItemArray = new object[] { 0, "--Select Task--" };
                    dt.Rows.InsertAt(dr_task, 0);
                    cmbTask.ValueMember = "TaskId";
                    cmbTask.DisplayMember = "Task Name";
                    cmbTask.DataSource = dt;
                    GetCustomData();
                    rtxtRemark.Text = "";
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTask.SelectedIndex > 0)
                {
                    DataTable dt_temp = new DataTable();
                    dt_temp = taskManagement.GetSubTasks(false, -1,Convert.ToInt32(cmbTask.SelectedValue), Convert.ToInt32(cmbActivity.SelectedValue));
                    // ViewSubTasks(Convert.ToInt32(cmbActivity.SelectedValue), Convert.ToInt32(cmbTask.SelectedValue));
                    if (dt_temp.Rows.Count > 0)
                    {
                        cmbSubTask.Enabled = true;
                        string[] selectedColumns = new[] { "SubTaskId", "SubTask Name" };
                        DataTable dt = new DataView(dt_temp).ToTable(false, selectedColumns);
                        DataRow dr_Subtask;
                        dr_Subtask = dt.NewRow();
                        dr_Subtask.ItemArray = new object[] { 0, "--Select SubTask--" };
                        dt.Rows.InsertAt(dr_Subtask, 0);
                        cmbSubTask.ValueMember = "SubTaskId";
                        cmbSubTask.DisplayMember = "SubTask Name";
                        cmbSubTask.DataSource = dt;
                        GetCustomData();
                        rtxtRemark.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbSubTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubTask.SelectedIndex > 0)
            {
                GetCustomData();
                rtxtRemark.Text = "";
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            EnableDisableButtons(1);
        }
        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateControls())
                {
                    WorkItem workitem = new WorkItem();
                    workitem.ActivityId = (int)cmbActivity.SelectedValue;
                    workitem.TaskId = (int)cmbTask.SelectedValue;
                    workitem.SubTaskId = (int)cmbSubTask.SelectedValue;
                    workitem.WorkItemDescription = rtxtRemark.Text;
                    workitem.WorkItemId = Convert.ToInt32(s_id);
                    workItemManagement.AddUpdateWorkItem(workitem, true);
                    GetAllData();
                    FormControlHandling.ClearControls(grpBoxAssignTask);
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
                if (!ValidateControls())
                {
                    WorkItem workitem = new WorkItem();
                    workitem.ActivityId = (int)cmbActivity.SelectedValue;
                    workitem.TaskId = (int)cmbTask.SelectedValue;
                    workitem.SubTaskId = (int)cmbSubTask.SelectedValue;
                    workitem.WorkItemDescription = rtxtRemark.Text;
                    workItemManagement.AddUpdateWorkItem(workitem);

                    GetAllData();
                    FormControlHandling.ClearControls(grpBoxAssignTask);
                    EnableDisableButtons(2);
                    RightBottomMessageBox.Success("Data Saved Successfully!");
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            FormControlHandling.ClearControls(grpBoxAssignTask);
            EnableDisableButtons(2);
            GetAllData();
        }
        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgView.CurrentRow.Index;
                if (index <= dgView.RowCount - 1)
                {
                    s_id = Convert.ToString(dgView.Rows[index].Cells[8].Value);
                    s_activity = Convert.ToString(dgView.Rows[index].Cells[6].Value);
                    s_task = Convert.ToString(dgView.Rows[index].Cells[5].Value);
                    s_subTask = Convert.ToString(dgView.Rows[index].Cells[7].Value);
                    s_remark = Convert.ToString(dgView.Rows[index].Cells[4].Value);


                    cmbActivity.SelectedValue = s_activity;
                    cmbTask.SelectedValue = s_task;
                    cmbSubTask.SelectedValue = s_subTask;
                    rtxtRemark.Text = s_remark;
                    EnableDisableButtons(3);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            grpBoxAssignTask.ForeColor = ThemeColor.PrimaryColor;
            grpBoxButtons.ForeColor = ThemeColor.PrimaryColor;
            grpBoxWorkItemGridView.ForeColor = ThemeColor.PrimaryColor;
            rtxtRemark.ForeColor = ThemeColor.SecondaryColor;
            cmbActivity.ForeColor = ThemeColor.SecondaryColor;
            cmbTask.ForeColor = ThemeColor.SecondaryColor;
        }
        public bool ValidateControls()
        {
            if (cmbActivity.SelectedIndex == 0)
            {
                PopupMessageBox.Show("Please Select Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (cmbTask.SelectedIndex == 0)
            {
                PopupMessageBox.Show("Please Select Task Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (cmbSubTask.SelectedIndex == 0)
            {
                PopupMessageBox.Show("Please Select SubTask Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (rtxtRemark.Text == "")
            {
                PopupMessageBox.Show("Please enter Remark!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxtRemark.Select();
                return true;
            }
            return false;
        }
        public void GetDefaultControlValues()
        {
            DataTable dtTask = new DataTable();
            dtTask.Columns.Add(new DataColumn("TaskId", typeof(int)));
            dtTask.Columns.Add(new DataColumn("Task Name", typeof(string)));
            DataRow drTask = dtTask.NewRow();
            drTask = dtTask.NewRow();
            drTask.ItemArray = new object[] { 0, "--Select Task--" };
            dtTask.Rows.InsertAt(drTask, 0);
            cmbTask.ValueMember = "TaskId";
            cmbTask.DisplayMember = "Task Name";
            cmbTask.DataSource = dtTask;

            DataTable dtSubTask = new DataTable();
            dtSubTask.Columns.Add(new DataColumn("SubTaskid", typeof(int)));
            dtSubTask.Columns.Add(new DataColumn("SubTask Name", typeof(string)));
            DataRow drSubTask = dtSubTask.NewRow();
            drSubTask = dtSubTask.NewRow();
            drSubTask.ItemArray = new object[] { 0, "--Select SubTask--" };
            dtSubTask.Rows.InsertAt(drSubTask, 0);
            cmbSubTask.ValueMember = "SubTaskId";
            cmbSubTask.DisplayMember = "SubTask Name";
            cmbSubTask.DataSource = dtSubTask;

        }
        public void GetAllData()
        {
            dgView.DataSource = null;
            dgView.DataSource = workItemManagement.GetWorkItems();
            dgView.Columns[0].Width = 70;
            dgView.Columns[1].Width = 150;
            dgView.Columns[2].Width = 300;
            dgView.Columns[3].Width = 200;
            dgView.Columns[4].Width = 300;
            dgView.Columns[5].Visible = false;
            dgView.Columns[6].Visible = false;
            dgView.Columns[7].Visible = false;
            dgView.Columns[8].Visible = false;
            dgView.ReadOnly = true;
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

                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                rtxtRemark.Enabled = true;
                btnAdd.Enabled = false;
                cmbActivity.Enabled = true;
                cmbTask.Enabled = true;
                cmbSubTask.Enabled = true;
            }
            if (flag == 2)//modify and Cancel
            {

                rtxtRemark.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnModify.Enabled = false;
                btnAdd.Enabled = true;
                cmbActivity.Enabled = false;
                cmbTask.Enabled = false;
                cmbSubTask.Enabled = false;
                //for (int i = 0; i < listemp.Items.Count; i++)
                //{
                //        listemp.SetItemChecked(i, false);
                //}
            }
            if (flag == 3)
            {
                rtxtRemark.Enabled = true;
                btnAdd.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = true;
                btnModify.Enabled = true;
                cmbActivity.Enabled = true;
                cmbTask.Enabled = true;
                cmbSubTask.Enabled = true;
            }
        }
        public void GetCustomData()
        {
            if (cmbActivity.SelectedIndex > 0)
            {
                dgView.DataSource = null;
                dgView.DataSource = workItemManagement.GetWorkItems(Convert.ToInt32(cmbActivity.SelectedValue));
                if (cmbTask.SelectedIndex > 0)
                {
                    dgView.DataSource = null;
                    dgView.DataSource = workItemManagement.GetWorkItems(Convert.ToInt32(cmbActivity.SelectedValue), Convert.ToInt32(cmbTask.SelectedValue));
                    if (cmbSubTask.SelectedIndex > 0)
                    {
                        dgView.DataSource = null;
                        dgView.DataSource = workItemManagement.GetWorkItems(Convert.ToInt32(cmbActivity.SelectedValue), Convert.ToInt32(cmbTask.SelectedValue), Convert.ToInt32(cmbSubTask.SelectedValue));
                    }
                }
                dgView.Columns[0].Width = 70;
                dgView.Columns[1].Width = 150;
                dgView.Columns[2].Width = 300;
                dgView.Columns[3].Width = 200;
                dgView.Columns[4].Width = 300;
                dgView.Columns[5].Visible = false;
                dgView.Columns[6].Visible = false;
                dgView.Columns[7].Visible = false;
                dgView.Columns[8].Visible = false;
                dgView.ReadOnly = true;
            }

        }
    }
}
