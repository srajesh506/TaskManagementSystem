using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI.Utilities;
using TMS.BusinessEntities;
using TMS.UI.CustomMessageBox;
using TMS.BusinessLogicLayer;
using System.Linq;

namespace TMS.UI
{
    public partial class DefineSubTask : UserControl
    {

        //Paging Variables***********
        private int _currentPage = 1;
        private int _pageSize = 5;

        private int _noOfPages;
        private int _totalRecords;

        private int _startPageInLocal;
        private int _pagesInLocal;
        //************

        private int _activityId;
        private int _taskId;
        private int _subTaskId;
        private string _subTaskName;
        private string _subTaskDescription;
        private Boolean _isActive;

        private DataTable _subTasks;

        TaskManagement taskManagement = new TaskManagement();
        SubTask subtask = new SubTask();

        public DefineSubTask()
        {
            try
            {
                InitializeComponent();
                UserInfo.Taskmanagementpagename = this.GetType().Name;

            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Define SubTask Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Form Load event - Loads the activity combobox
        private void DefineSubTask_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
                LoadSubTaskDataGrid(true, true);
                EnableDisableButtons(2);

                DataTable dtActivity = new DataTable();
                dtActivity = taskManagement.GetActivities(UserInfo.selectedvalue, true);
                var dtActivityFilter = dtActivity.DefaultView.ToTable(false, "ActivityId", "ActivityName");
                DataRow drActivity = dtActivityFilter.NewRow();
                drActivity.ItemArray = new object[] { 0, "--Select Activity--" };
                dtActivityFilter.Rows.InsertAt(drActivity, 0);
                cmbActivity.ValueMember = "ActivityId";
                cmbActivity.DisplayMember = "ActivityName";
                cmbActivity.DataSource = dtActivityFilter;
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Define SubTask Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SaveModifySubTaskData("S");
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
                SaveModifySubTaskData("M");
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to update an existing record!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if ((index >= 0) && (index <= dView.RowCount - 1))
                {
                    _activityId = Convert.ToInt32(dView.Rows[index].Cells[7].Value);
                    _taskId = Convert.ToInt32(dView.Rows[index].Cells[6].Value);
                    _subTaskName = Convert.ToString(dView.Rows[index].Cells[3].Value);
                    _subTaskDescription = Convert.ToString(dView.Rows[index].Cells[4].Value);
                    _isActive = Convert.ToBoolean(dView.Rows[index].Cells[5].Value);
                    _subTaskId = Convert.ToInt32(dView.Rows[index].Cells[8].Value);

                    cmbActivity.SelectedValue = Convert.ToString(_activityId);
                    cmbTask.SelectedValue = Convert.ToString(_taskId);
                    txtSubTaskName.Text = Convert.ToString(_subTaskName);
                    rtxtSubTaskDescription.Text = Convert.ToString(_subTaskDescription);
                    chkActive.Checked = Convert.ToBoolean(_isActive);
                    EnableDisableButtons(3);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the selected record in the Form fields from the DataGrid!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Activity ComboBox Value change Event - to load the Task Records in Task Combobox based on Selected Activity record. Also reflect the update in GridView Data
        private void cmbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbActivity.SelectedIndex > 0)
                {
                    DataTable dtTemp = new DataTable();
                    dtTemp = taskManagement.GetTasks(false, -1, (Convert.ToInt32(cmbActivity.SelectedValue)),null, UserInfo.selectedvalue);
                    string[] selectedColumns = new[] { "TaskId", "Task Name" };
                    DataTable dtTask = new DataView(dtTemp).ToTable(false, selectedColumns);
                    DataRow drTask;
                    drTask = dtTask.NewRow();
                    drTask.ItemArray = new object[] { 0, "--Select Task--" };
                    dtTask.Rows.InsertAt(drTask, 0);
                    cmbTask.ValueMember = "TaskId";
                    cmbTask.DisplayMember = "Task Name";
                    cmbTask.DataSource = dtTask;
                    LoadSubTaskDataGrid(true, true, Convert.ToInt32(cmbActivity.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the Task Records in dropdown list or GridView Data!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Task ComboBox Value change Event - to load the data in GridView based on selected activity and selected task
        private void cmbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbActivity.SelectedIndex > 0 && cmbTask.SelectedIndex > 0)
                {
                    LoadSubTaskDataGrid(true, true, Convert.ToInt32(cmbActivity.SelectedValue), Convert.ToInt32(cmbTask.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the GridView Data based on Activity & Task Dropdown values!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //User Defined
        //Function to Load the Form Theme
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
                txtSubTaskName.ForeColor = ThemeColor.SecondaryColor;
                rtxtSubTaskDescription.ForeColor = ThemeColor.SecondaryColor;
                chkActive.ForeColor = ThemeColor.SecondaryColor;
                cmbActivity.ForeColor = ThemeColor.SecondaryColor;
                cmbTask.ForeColor = ThemeColor.SecondaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Function to Validate the mandatory controls are supplied with correct values
        public Boolean ValidateControls(String mode)
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
                if (cmbTask.SelectedIndex == 0)
                {
                    PopupMessageBox.Show("Please Select Task Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (txtSubTaskName.Text == "")
                {
                    PopupMessageBox.Show("Please Enter SubTask Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSubTaskName.Select();
                    return false;
                }
                if (rtxtSubTaskDescription.Text == "")
                {
                    PopupMessageBox.Show("Please enter SubTask Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtSubTaskDescription.Select();
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
                    txtSubTaskName.Enabled = true;
                    txtSubTaskName.Enabled = true;
                    txtSubTaskName.Select();
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    rtxtSubTaskDescription.Enabled = true;
                    btnAdd.Enabled = false;
                    cmbActivity.Enabled = true;
                    cmbTask.Enabled = true;
                }
                if (flag == 2)//modify and Cancel
                {
                    txtSubTaskName.Enabled = false;
                    rtxtSubTaskDescription.Enabled = false;
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
                    rtxtSubTaskDescription.Enabled = true;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = true;
                    btnModify.Enabled = true;
                    cmbActivity.Enabled = true;
                    cmbTask.Enabled = true;
                }
                if (flag == 4)                  //Grid Page no change or No of records per page change
                {
                    if (_currentPage == 1)
                    {
                        btnPrevious.Enabled = false;
                        btnNext.Enabled = true;
                        btnFirstPage.Enabled = false;
                        btnLastPage.Enabled = true;
                    }
                    if (_currentPage == _noOfPages)
                    {
                        btnNext.Enabled = false;
                        btnPrevious.Enabled = true;
                        btnFirstPage.Enabled = true;
                        btnLastPage.Enabled = false;
                    }
                    if ((_noOfPages == 1))
                    {
                        btnNext.Enabled = false;
                        btnPrevious.Enabled = false;
                        btnFirstPage.Enabled = false;
                        btnLastPage.Enabled = false;
                    }
                    if ((_currentPage > 1) && (_currentPage < _noOfPages))
                    {
                        btnNext.Enabled = true;
                        btnPrevious.Enabled = true;
                        btnFirstPage.Enabled = true;
                        btnLastPage.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to setup the Create SubTask form button controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Function to perform new record addition and existing record update
        private void SaveModifySubTaskData(String mode)
        {
            try
            {
                if (ValidateControls(mode))
                {
                    subtask.ActivityId = Convert.ToInt32(cmbActivity.SelectedValue);
                    subtask.TaskId = Convert.ToInt32(cmbTask.SelectedValue);
                    subtask.SubTaskName = txtSubTaskName.Text;
                    subtask.SubTaskDescription = rtxtSubTaskDescription.Text;
                    subtask.IsActive = chkActive.Checked;
                    subtask.SubTaskId = _subTaskId;
                    subtask.ProjectId = UserInfo.selectedvalue;
                    switch (mode)
                    {
                        case "S":
                            if (taskManagement.AddUpdateSubtask(subtask) <= 0)
                            {
                                throw new Exception("SubTask: '" + txtSubTaskName.Text + "' already exists in Database!");
                            }
                            break;
                        case "M":
                            if (taskManagement.AddUpdateSubtask(subtask, true) <= 0)
                            {
                                throw new Exception("SubTask: '" + txtSubTaskName.Text + "' doesnt exist in Database!!");
                            }
                            break;
                        default:
                            throw new Exception("TMSError - Invalid Operation!! ");
                    }
                    LoadSubTaskDataGrid(true, true);
                    FormControlHandling.ClearControls(grpBoxInputControls);
                    EnableDisableButtons(2);
                    if (mode == "S")
                        RightBottomMessageBox.Success("Data saved Successfully!");
                    else
                        RightBottomMessageBox.Info("Data modify Successfully!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform save/modify operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        public void GetSubTaskData(int pageNum, int pageSize)
        {
            try
            {
                _subTasks = taskManagement.GetSubTasksUsingPaging(out _totalRecords, pageNum, pageSize,UserInfo.selectedvalue, true);
                _noOfPages = Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize));
                _pagesInLocal = Convert.ToInt32(Math.Ceiling((double)_subTasks.Rows.Count / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_subTasks.Rows.Count / pageSize));
                _pageSize = pageSize;
                _startPageInLocal = pageNum;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to retrieve the Activities records!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        //Function to load the datagridview with the records and setup other options for datagridview
        private void LoadSubTaskDataGrid(Boolean isActive, Boolean refresh = false, int activityId = -1, int taskId = -1)
        {
            try
            {
                if (refresh || !Enumerable.Range(_startPageInLocal, _startPageInLocal + _pagesInLocal - 1).Contains(_currentPage))
                {
                    GetSubTaskData(_currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem));
                    lblCurrentPage.Text = _currentPage.ToString();
                    lblNoOfPages.Text = _noOfPages.ToString();
                    if (activityId != -1)
                    {
                        if (taskId != -1)
                        {
                            _subTasks = taskManagement.GetSubTasksUsingPaging(out _totalRecords, _currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem),UserInfo.selectedvalue, false, -1, taskId, activityId);
                        }
                        else
                        {
                            _subTasks = taskManagement.GetSubTasksUsingPaging(out _totalRecords, _currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem), UserInfo.selectedvalue, false, -1, -1, activityId);
                        }
                    }
                    else
                    {
                        _subTasks = taskManagement.GetSubTasksUsingPaging(out _totalRecords, _currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem), UserInfo.selectedvalue, isActive);
                    }
                    DataTable records = FormControlHandling.GetPageRecords(_subTasks, _currentPage, _pageSize);
                    dView.DataSource = null;
                    dView.DataSource = records;
                    dView.Columns[0].Width = 50;
                    dView.Columns[1].Width = 200;
                    dView.Columns[2].Width = 300;
                    dView.Columns[3].Width = 300;
                    dView.Columns[4].Width = 400;
                    dView.Columns[5].Visible = false;
                    dView.Columns[6].Visible = false;
                    dView.Columns[7].Visible = false;
                    dView.Columns[8].Visible = false;
                    dView.ReadOnly = true;
                    EnableDisableButtons(4);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the data in GridView!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage += 1;
                if ((_currentPage >= _startPageInLocal) || (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadSubTaskDataGrid(true, true);
              
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to next page in the grid !! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage = _noOfPages;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadSubTaskDataGrid(false);
                else
                    LoadSubTaskDataGrid(true, true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to last page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage -= 1;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadSubTaskDataGrid(false);
                else
                    LoadSubTaskDataGrid(true, true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to previous page in the grid !! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage = 1;
                if (_startPageInLocal == 1)
                    LoadSubTaskDataGrid(false);
                else
                    LoadSubTaskDataGrid(true, true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to the first page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNoOfRecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadSubTaskDataGrid(true, true);
        }
    }
}
