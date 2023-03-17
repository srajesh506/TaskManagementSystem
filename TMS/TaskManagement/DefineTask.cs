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
    public partial class DefineTask : UserControl
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
        private string _taskName;
        private string _taskDescription;
        private Boolean _isActive;

        private DataTable _tasks;

        Task task = new Task();
        TaskManagement taskManagement = new TaskManagement();

        public DefineTask()
        {
            try
            {
                InitializeComponent();
            
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
                LoadTheme();
                LoadTaskDataGrid(true);
                EnableDisableButtons(2);

                DataTable dtActivity = new DataTable();
                dtActivity = taskManagement.GetActivities(true);
                var dtActivityFilter = dtActivity.DefaultView.ToTable(false, "ActivityId","ActivityName");
                DataRow drActivity = dtActivityFilter.NewRow();
                drActivity.ItemArray = new object[] { 0, "--Select Activity--" };
                dtActivityFilter.Rows.InsertAt(drActivity, 0);
                cmbActivity.ValueMember = "ActivityId";
                cmbActivity.DisplayMember = "ActivityName";
                cmbActivity.DataSource = dtActivityFilter;
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
                LoadTaskDataGrid(true);
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
                    LoadTaskDataGrid(true, Convert.ToInt32(cmbActivity.SelectedValue));
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
                    LoadTaskDataGrid(true, Convert.ToInt32(cmbActivity.SelectedValue));
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
                    LoadTaskDataGrid(true);
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

        //Function to load the datagridview with the records and setup other options for datagridview
        private void LoadTaskDataGrid(Boolean refresh = false, int activityId = -1)
        {
            try
            {
                if (refresh || !Enumerable.Range(_startPageInLocal, _startPageInLocal + _pagesInLocal - 1).Contains(_currentPage))
                {
                    if (activityId != -1)
                    {
                        GetTaskData(_currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem));
                        lblCurrentPage.Text = _currentPage.ToString();
                        lblNoOfPages.Text = _noOfPages.ToString();
                        _tasks = taskManagement.GetTasksUsingPaging(out _totalRecords, _currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem), false, -1, activityId);
                        DataTable records = FormControlHandling.GetPageRecords(_tasks, _currentPage, _pageSize);
                        dView.DataSource = null;
                        dView.DataSource = records;
                       
                    }
                    else
                    {
                        GetTaskData(_currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem));
                        _tasks = taskManagement.GetTasksUsingPaging(out _totalRecords, _currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem),true);
                        lblCurrentPage.Text = _currentPage.ToString();
                        lblNoOfPages.Text = _noOfPages.ToString();
                        DataTable records = FormControlHandling.GetPageRecords(_tasks, _currentPage, _pageSize);
                        dView.DataSource = records;
                    }


                    dView.Columns[0].Width = 50;
                    dView.Columns[1].Width = 200;
                    dView.Columns[2].Width = 300;
                    dView.Columns[3].Width = 600;
                    dView.Columns[4].Visible = false;
                    dView.Columns[5].Visible = false;
                    dView.Columns[6].Visible = false;
                    dView.ReadOnly = true;
                    EnableDisableButtons(4);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the data in GridView!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        public void GetTaskData(int pageNum, int pageSize)
        {
            try
            {
                _tasks = taskManagement.GetTasksUsingPaging(out _totalRecords, pageNum, pageSize, true);
                _noOfPages = Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize));
                _pagesInLocal = Convert.ToInt32(Math.Ceiling((double)_tasks.Rows.Count / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_tasks.Rows.Count / pageSize));
                _pageSize = pageSize;
                _startPageInLocal = pageNum;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to retrieve the Activities records!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage += 1;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                LoadTaskDataGrid(true);
                else
                    LoadTaskDataGrid(true);
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
                    LoadTaskDataGrid(false);
                else
                    LoadTaskDataGrid(true);
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
                    LoadTaskDataGrid(false);
                else
                    LoadTaskDataGrid(true);
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
                    LoadTaskDataGrid(false);
                else
                    LoadTaskDataGrid(true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to the first page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNoOfRecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadTaskDataGrid(true);
        }
    }
}
