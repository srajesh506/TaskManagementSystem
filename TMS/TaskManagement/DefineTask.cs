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
            btnAdd.ForeColor = ThemeColor.PrimaryColor;
            btnSave.ForeColor = ThemeColor.PrimaryColor;
            btnModify.ForeColor = ThemeColor.PrimaryColor;
            btnCancel.ForeColor = ThemeColor.PrimaryColor;
            gbxTaskManagement.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforExistingTask.ForeColor = ThemeColor.PrimaryColor;
            txtTaskName.ForeColor = ThemeColor.SecondaryColor;
            rtxtRemark.ForeColor = ThemeColor.SecondaryColor;
            chkActive.ForeColor = ThemeColor.SecondaryColor;
            cmbActivity.ForeColor = ThemeColor.SecondaryColor;
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
                txtTaskName.Enabled = true;
                txtTaskName.Enabled = true;
                txtTaskName.Select();
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                rtxtRemark.Enabled = true;
                btnAdd.Enabled = false;
                cmbActivity.Enabled = true;
            }
            if (flag == 2)//modify and Cancel
            {
                txtTaskName.Enabled = false;
                rtxtRemark.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnModify.Enabled = false;
                btnAdd.Enabled = true;
                cmbActivity.Enabled = false;
            }
            if (flag == 3)
            {
                txtTaskName.Enabled = true;
                rtxtRemark.Enabled = true;
                btnAdd.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = true;
                btnModify.Enabled = true;
                cmbActivity.Enabled = true;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            EnableDisableButtons(1);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            FormControlHandling.ClearControls(gbxTaskManagement);
            EnableDisableButtons(2);
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Validation();
                if (val == 1) return;
                task.TaskName = txtTaskName.Text;
                task.TaskDescription = rtxtRemark.Text;
                task.ActivityId = Convert.ToInt32(cmbActivity.SelectedValue);
                task.IsActive = chkActive.Checked;
                task.TaskId = s_taskId;
                int returnvalue = taskManagement.AddUpdateTask(task, true);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("Activity: '" + txtTaskName.Text + "' doesnt exist in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                task.TaskName = txtTaskName.Text;
                task.TaskDescription = rtxtRemark.Text;
                task.ActivityId = Convert.ToInt32(cmbActivity.SelectedValue);
                task.IsActive = chkActive.Checked;
                int returnvalue = taskManagement.AddUpdateTask(task);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("Task: '" + txtTaskName.Text + "' already exists in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmbActivity.ValueMember = "ActivityId";
                cmbActivity.DisplayMember = "ActivityName";
                cmbActivity.DataSource = dt;
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetAllData()
        {
            Dview.DataSource = null;
            Dview.DataSource = taskManagement.GetTasks();
            Dview.Columns[0].Width = 50;
            Dview.Columns[1].Width = 200;
            Dview.Columns[2].Width = 300;
            Dview.Columns[3].Width = 600;
            Dview.Columns[4].Visible = false;
            Dview.Columns[5].Visible = false;
            Dview.Columns[6].Visible = false;
            Dview.ReadOnly = true;
        }
        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
 
                int index = Dview.CurrentRow.Index;
                if (index <= Dview.RowCount - 1)
                {
                    s_activityId = Convert.ToInt32(Dview.Rows[index].Cells[6].Value);
                    s_taskName = Convert.ToString(Dview.Rows[index].Cells[2].Value);
                    s_taskDescription = Convert.ToString(Dview.Rows[index].Cells[3].Value);
                    s_isActive = Convert.ToBoolean(Dview.Rows[index].Cells[4].Value);
                    s_taskId = Convert.ToInt32(Dview.Rows[index].Cells[5].Value);

                    cmbActivity.SelectedValue = s_activityId;
                    txtTaskName.Text = s_taskName;
                    rtxtRemark.Text = s_taskDescription;
                    chkActive.Checked = s_isActive;

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
                if (cmbActivity.SelectedIndex > 0)
                {
                    Dview.DataSource = null;
                    Dview.DataSource = taskManagement.GetTasks(false,-1,Convert.ToInt32(cmbActivity.SelectedValue));
                    Dview.Columns[0].Width = 50;
                    Dview.Columns[1].Width = 200;
                    Dview.Columns[2].Width = 300;
                    Dview.Columns[3].Width = 600;
                    Dview.Columns[4].Visible = false;
                    Dview.Columns[5].Visible = false;
                    Dview.Columns[6].Visible = false;
                    Dview.ReadOnly = true;
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
            if (cmbActivity.SelectedIndex == 0)
            {
                PopupMessageBox.Show("Please Select Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
            if (txtTaskName.Text == "")
            {
                PopupMessageBox.Show("Please Enter Task Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaskName.Select();
                return 1;
            }
            if (rtxtRemark.Text == "")
            {
                PopupMessageBox.Show("Please enter Task Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxtRemark.Select();
                return 1;
            }
            return 0;
        }
    }
}
