using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI.Utilities;
using TMS.BusinessEntities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;
using System.Linq;

namespace TMS.UI
{
    public partial class CreateWorkItem : Form
    {

        //Paging Variables***********
        private int _currentPage = 1;
        private int _pageSize = 5;

        private int _noOfPages;
        private int _totalRecords;

        private int _startPageInLocal;
        private int _pagesInLocal;
        //************

        private string _activityId;
        private string _taskId;
        private string _subTaskId;
        private string _workItemId;
        private string _workItemDescription;
        private DataTable _WorkItem;
        TaskManagement taskManagement = new TaskManagement();
        WorkItemManagement workItemManagement = new WorkItemManagement();

        public CreateWorkItem()
        {
            InitializeComponent();
           
        }

        //Form Load event - Loads the activity combobox
        private void CreateWorkItem_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
                GetDefaultControlValues();
                EnableDisableButtons(2);
                LoadWorkItemDataGrid(true, true);

                DataTable dtActivity = new DataTable();
                dtActivity = taskManagement.GetActivities(UserInfo.SelectedValue, true);
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
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                PopupMessageBox.Show("TMSError - Failed to open Create WorkItem form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Save button click event to save the form for adding new record
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveModifyWorkItemData("S");
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
                SaveModifyWorkItemData("M");
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
                LoadWorkItemDataGrid(true, true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to cancel the active record add/update action!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //DataGridView cell click event to load the existing record in form for modification
        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgView.CurrentRow.Index;
                if ((index >= 0) && (index <= dgView.RowCount - 1))
                {
                    _workItemId = Convert.ToString(dgView.Rows[index].Cells[8].Value);
                    _activityId = Convert.ToString(dgView.Rows[index].Cells[6].Value);
                    _taskId = Convert.ToString(dgView.Rows[index].Cells[5].Value);
                    _subTaskId = Convert.ToString(dgView.Rows[index].Cells[7].Value);
                    _workItemDescription = Convert.ToString(dgView.Rows[index].Cells[4].Value);


                    cmbActivity.SelectedValue = _activityId;
                    cmbTask.SelectedValue = _taskId;
                    cmbSubTask.SelectedValue = _subTaskId;
                    rtxtWorkItemDescription.Text = _workItemDescription;
                    EnableDisableButtons(3);
                    LoadWorkItemDataGrid(true, true);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the selected DataGrid record in the Form fields !! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    dtTemp = taskManagement.GetTasks(false, -1, Convert.ToInt32(cmbActivity.SelectedValue), null,UserInfo.SelectedValue);
                    if (dtTemp.Rows.Count > 0)
                    {
                        cmbTask.Enabled = true;
                        string[] selectedColumns = new[] { "TaskId", "Task Name" };
                        DataTable dtTask = new DataView(dtTemp).ToTable(false, selectedColumns);
                        DataRow drTask;
                        drTask = dtTask.NewRow();
                        drTask.ItemArray = new object[] { 0, "--Select Task--" };
                        dtTask.Rows.InsertAt(drTask, 0);
                        cmbTask.ValueMember = "TaskId";
                        cmbTask.DisplayMember = "Task Name";
                        cmbTask.DataSource = dtTask;
                        LoadWorkItemDataGrid(true, true, Convert.ToInt32(cmbActivity.SelectedValue));
                    }
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the Task Records in dropdown list or GridView Data!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Task ComboBox Value change Event - to load the SubTasks Records in Subtask Combobox  based on activity & task selection. ALso reflect the update in GridView Data
        private void cmbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTask.SelectedIndex > 0)
                {
                    DataTable dtTemp = new DataTable();
                    dtTemp = taskManagement.GetSubTasks(false, -1, Convert.ToInt32(cmbTask.SelectedValue), Convert.ToInt32(cmbActivity.SelectedValue));
                    if (dtTemp.Rows.Count > 0)
                    {
                        cmbSubTask.Enabled = true;
                        string[] selectedColumns = new[] { "SubTaskId", "SubTask Name" };
                        DataTable dtSubTask = new DataView(dtTemp).ToTable(false, selectedColumns);
                        DataRow drSubtask;
                        drSubtask = dtSubTask.NewRow();
                        drSubtask.ItemArray = new object[] { 0, "--Select SubTask--" };
                        dtSubTask.Rows.InsertAt(drSubtask, 0);
                        cmbSubTask.ValueMember = "SubTaskId";
                        cmbSubTask.DisplayMember = "SubTask Name";
                        cmbSubTask.DataSource = dtSubTask;
                        LoadWorkItemDataGrid(true, true, Convert.ToInt32(cmbActivity.SelectedValue), Convert.ToInt32(cmbTask.SelectedValue));
                    }
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //SubTask ComboBox Value change Event - to load the data in GridView based on selected activity, task & SubTask
        private void cmbSubTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbActivity.SelectedIndex > 0 && cmbTask.SelectedIndex > 0 && cmbSubTask.SelectedIndex > 0)
                {
                    LoadWorkItemDataGrid(true, true, Convert.ToInt32(cmbActivity.SelectedValue), Convert.ToInt32(cmbTask.SelectedValue), Convert.ToInt32(cmbSubTask.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the GridView Data based on Activity,Task & SubTask Dropdown values!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                grpBoxWorkItemGridView.ForeColor = ThemeColor.PrimaryColor;
                rtxtWorkItemDescription.ForeColor = ThemeColor.SecondaryColor;
                cmbActivity.ForeColor = ThemeColor.SecondaryColor;
                cmbTask.ForeColor = ThemeColor.SecondaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Function to Validate the mandatory controls are supplied with correct values
        public bool ValidateControls()
        {
            try
            {
                if(UserInfo.SelectedValue ==0)
                    {
                    PopupMessageBox.Show("Please Select Project Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
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
                if (cmbSubTask.SelectedIndex == 0)
                {
                    PopupMessageBox.Show("Please Select SubTask Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (rtxtWorkItemDescription.Text == "")
                {
                    PopupMessageBox.Show("Please enter WorkItem Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtWorkItemDescription.Select();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to validate the form controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        // Function to enable or disable the buttons based on the selected operation (ADD/MODIFY/SAVE/CANCEL) or GridView Selected or No of Records per Page changes) 
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

                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    rtxtWorkItemDescription.Enabled = true;
                    btnAdd.Enabled = false;
                    cmbActivity.Enabled = true;
                    cmbTask.Enabled = true;
                    cmbSubTask.Enabled = true;
                }
                if (flag == 2)//modify and Cancel
                {

                    rtxtWorkItemDescription.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnModify.Enabled = false;
                    btnAdd.Enabled = true;
                    cmbActivity.Enabled = false;
                    cmbTask.Enabled = false;
                    cmbSubTask.Enabled = false;
                }
                if (flag == 3)
                {
                    rtxtWorkItemDescription.Enabled = true;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = true;
                    btnModify.Enabled = true;
                    cmbActivity.Enabled = true;
                    cmbTask.Enabled = true;
                    cmbSubTask.Enabled = true;
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
                throw new Exception("TMSError - Failed to setup the Create WorkItem form button controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Function to load default values in the combobox controls
        public void GetDefaultControlValues()
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to setup default values in Dropdown controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Function to perform new record addition and existing record update
        private void SaveModifyWorkItemData(String mode)
        {
            try
            {
                if (ValidateControls())
                {
                    WorkItem workitem = new WorkItem();
                    workitem.ActivityId = (int)cmbActivity.SelectedValue;
                    workitem.TaskId = (int)cmbTask.SelectedValue;
                    workitem.SubTaskId = (int)cmbSubTask.SelectedValue;
                    workitem.WorkItemDescription = rtxtWorkItemDescription.Text;
                    workitem.WorkItemId = Convert.ToInt32(_workItemId);
                    workitem.ProjectId = UserInfo.SelectedValue;
                    switch (mode)
                    {
                        case "S":
                            if (workItemManagement.AddUpdateWorkItem(workitem) <= 0)
                            {
                                throw new Exception("WorkItem: '" + rtxtWorkItemDescription.Text + "' already exists in Database!");
                            }
                            break;
                        case "M":
                            if (workItemManagement.AddUpdateWorkItem(workitem, true) <= 0)
                            {
                                throw new Exception("WorkItem: '" + rtxtWorkItemDescription.Text + "' doesnt exist in Database!!");
                            }
                            break;
                        default:
                            throw new Exception("TMSError - Invalid Operation!! ");
                    }
                    LoadWorkItemDataGrid(true, true);
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
        public void GetWorkItemsData(int pageNum, int pageSize)
        {
            try
            {
                _WorkItem = workItemManagement.GetWorkItemsUsingPaging(out _totalRecords, pageNum, pageSize,UserInfo.SelectedValue);
                _noOfPages = Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize));
                _pagesInLocal = Convert.ToInt32(Math.Ceiling((double)_WorkItem.Rows.Count / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_WorkItem.Rows.Count / pageSize));
                _pageSize = pageSize;
                _startPageInLocal = pageNum;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to retrieve the Activities records!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        //Function to load the datagridview with the records and setup other options for datagridview
        private void LoadWorkItemDataGrid(Boolean isActive, Boolean refresh = false, int activityId = -1, int taskId = -1, int subTaskId = -1)
        {
            try
            {
                if (refresh || !Enumerable.Range(_startPageInLocal, _startPageInLocal + _pagesInLocal - 1).Contains(_currentPage))
                {
                    GetWorkItemsData(_currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem));
                    lblCurrentPage.Text = _currentPage.ToString();
                    lblNoOfPages.Text = _noOfPages.ToString();
                    if (activityId != -1)
                    {
                        dgView.DataSource = null;
                        if (taskId != -1)
                        {
                            if (subTaskId != -1)
                            {
                                _WorkItem = workItemManagement.GetWorkItemsUsingPaging(out _totalRecords, _currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem), UserInfo.SelectedValue, activityId, taskId, subTaskId);
                            }
                            else
                            {
                                _WorkItem = workItemManagement.GetWorkItemsUsingPaging(out _totalRecords, _currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem), UserInfo.SelectedValue, activityId, taskId);
                            }
                           
                        }
                        else
                        {
                            _WorkItem = workItemManagement.GetWorkItemsUsingPaging(out _totalRecords, _currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem),UserInfo.SelectedValue, activityId);
                        }
                    }
                    else
                    {
                        _WorkItem = workItemManagement.GetWorkItemsUsingPaging(out _totalRecords, _currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem),UserInfo.SelectedValue,activityId);
                    }
                    DataTable records = FormControlHandling.GetPageRecords(_WorkItem, _currentPage, _pageSize);
                    dgView.DataSource = null;
                    dgView.DataSource = records;

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
                    LoadWorkItemDataGrid(true, true);
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
                if ((_currentPage >= _startPageInLocal) || (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadWorkItemDataGrid(true, true);
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
                if ((_currentPage >= _startPageInLocal) || (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadWorkItemDataGrid(true, true);
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
                if (_startPageInLocal >= 1)
                    LoadWorkItemDataGrid(true, true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to the first page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNoOfRecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadWorkItemDataGrid(true, true);
        }
    }
}
