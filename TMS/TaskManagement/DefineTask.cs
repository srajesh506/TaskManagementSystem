using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI.Utilities;
using TMS.BusinessEntities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;

namespace TMS.UI
{
    public partial class DefineTask : UserControl
    {
        private int _activityId;
        private int _taskId;
        private string _taskName;
        private string _taskDescription;
        private Boolean _isActive;

        //private DataTable _tasks;

        Task task = new Task();
        TaskManagement taskManagement = new TaskManagement();

        public DefineTask()
        {
            try
            {
                InitializeComponent();
                LoadTheme();
                LoadTaskDataGrid(true, true);
                EnableDisableButtons(2);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Define Task Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Form Load event - Loads the activity combobox
        private void DefineTask_Load(object sender, EventArgs e)
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
                PopupMessageBox.Show("TMSError - Failed to Load the Define Task Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Add button click event to enable the form for adding new record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EnableDisableButtons(1);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to open Define SubTask form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Save button click event to save the form for adding new record
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveModifyTaskData("S");
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to save a new record!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Modify button click event to enable the form for updating existing record
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                SaveModifyTaskData("M");
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Update an existing record!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cancel button click event to cancel the last chosen active operation
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                FormControlHandling.ClearControls(grpBoxInputControls);
                EnableDisableButtons(2);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to cancel the active record add/update action!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //DataGridView cell click event to load the existing record in form for modification
        private void dView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dView.CurrentRow.Index;
                if ((index >=0) && (index <= dView.RowCount - 1))
                {
                    _activityId = Convert.ToInt32(dView.Rows[index].Cells[6].Value);
                    _taskName = Convert.ToString(dView.Rows[index].Cells[2].Value);
                    _taskDescription = Convert.ToString(dView.Rows[index].Cells[3].Value);
                    _isActive = Convert.ToBoolean(dView.Rows[index].Cells[4].Value);
                    _taskId = Convert.ToInt32(dView.Rows[index].Cells[5].Value);

                    cmbActivity.SelectedValue = _activityId;
                    txtTaskName.Text = _taskName;
                    rtxtTaskDescription.Text = _taskDescription;
                    chkActive.Checked = _isActive;

                    EnableDisableButtons(3);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the selected record in the Form fields from the DataGrid!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Activity ComboBox Value change Event - to load data in GridView based on selected activity
        private void cmbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbActivity.SelectedIndex > 0)
                {
                    LoadTaskDataGrid(true, true, cmbActivity.SelectedIndex);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the GridView Data based on Activity Dropdown values!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //User Defined

        // Function to Load the Form Theme
        private void LoadTheme()
        {
            try
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
                grpBoxInputControls.ForeColor = ThemeColor.PrimaryColor;
                grpBoxButtons.ForeColor = ThemeColor.PrimaryColor;
                grpBoxDataGrid.ForeColor = ThemeColor.PrimaryColor;
                txtTaskName.ForeColor = ThemeColor.SecondaryColor;
                rtxtTaskDescription.ForeColor = ThemeColor.SecondaryColor;
                chkActive.ForeColor = ThemeColor.SecondaryColor;
                cmbActivity.ForeColor = ThemeColor.SecondaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Function to Validate the mandatory controls are supplied with correct values
        public Boolean ValidateControls(string mode)
        {
            try
            {
                if (mode == "S")
                {
                    if (chkActive.Checked == false)
                    {
                        PopupMessageBox.Show("Please Confirm Active status!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                if (cmbActivity.SelectedIndex == 0)
                {
                    PopupMessageBox.Show("Please Select Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (txtTaskName.Text == "")
                {
                    PopupMessageBox.Show("Please Enter Task Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTaskName.Select();
                    return false;
                }
                if (rtxtTaskDescription.Text == "")
                {
                    PopupMessageBox.Show("Please enter Task Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtTaskDescription.Select();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to validate the form controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        // Function to enable or disable the buttons based on the selected operation (ADD/MODIFY/SAVE/CANCEL) or GridView Page Selected or No of Records per Page changes) 
        public void EnableDisableButtons(int flag)
        {
            try
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
                    rtxtTaskDescription.Enabled = true;
                    btnAdd.Enabled = false;
                    cmbActivity.Enabled = true;
                }
                if (flag == 2)//modify and Cancel
                {
                    txtTaskName.Enabled = false;
                    rtxtTaskDescription.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnModify.Enabled = false;
                    btnAdd.Enabled = true;
                    cmbActivity.Enabled = false;
                }
                if (flag == 3)
                {
                    txtTaskName.Enabled = true;
                    rtxtTaskDescription.Enabled = true;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = true;
                    btnModify.Enabled = true;
                    cmbActivity.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to setup the Create Task form button controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Function to perform new record addition and existing record update
        private void SaveModifyTaskData(String mode)
        {
            try
            {
                if (ValidateControls(mode))
                {
                    task.TaskName = txtTaskName.Text;
                    task.TaskDescription = rtxtTaskDescription.Text;
                    task.ActivityId = Convert.ToInt32(cmbActivity.SelectedValue);
                    task.IsActive = chkActive.Checked;
                    task.TaskId = _taskId;
                    switch (mode)
                    {
                        case "S":
                            if (taskManagement.AddUpdateTask(task) <= 0)
                            {
                                throw new Exception("Task: '" + txtTaskName.Text + "' already exists in Database!");
                            }
                            break;
                        case "M":
                            if (taskManagement.AddUpdateTask(task, true) <= 0)
                            {
                                throw new Exception("Task: '" + txtTaskName.Text + "' doesnt exist in Database!!");
                            }
                            break;
                        default:
                            throw new Exception("TMSError - Invalid Operation!! ");
                    }
                    LoadTaskDataGrid(true, true);
                    FormControlHandling.ClearControls(grpBoxInputControls);
                    EnableDisableButtons(2);
                    RightBottomMessageBox.Success("Data Saved Successfully!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform save/modify operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Function to load the datagridview with the records and setup other options for datagridview
        private void LoadTaskDataGrid(Boolean isActive, Boolean refresh = false, int activityId = -1)
        {
            try
            {
                if (refresh)
                {
                    if (activityId != -1)
                    {
                        dView.DataSource = null;
                        dView.DataSource = taskManagement.GetTasks(false, -1, activityId);
                    }
                    else
                    {
                        dView.DataSource = taskManagement.GetTasks(isActive);
                    }
                    dView.Columns[0].Width = 50;
                    dView.Columns[1].Width = 200;
                    dView.Columns[2].Width = 300;
                    dView.Columns[3].Width = 600;
                    dView.Columns[4].Visible = false;
                    dView.Columns[5].Visible = false;
                    dView.Columns[6].Visible = false;
                    dView.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the data in GridView!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }


    }
}
