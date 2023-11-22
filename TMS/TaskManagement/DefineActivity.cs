using System;
using System.IO;
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
    public partial class DefineActivity : UserControl
    {

        //Paging Variables***********
        private int _currentPage = 1;
        private int _pageSize = 5;

        private int _noOfPages;
        private int _totalRecords;

        private int _startPageInLocal;
        private int _pagesInLocal;
        //************

        private int _activityId = 0;

        private DataTable _activities;

        TaskManagement taskManagement = new TaskManagement();
        Activity activity = new Activity();

        public DefineActivity()
        {
            try
            {
                InitializeComponent();
                UserInfo.TaskManagementPageName = this.GetType().Name;


            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Define Activity Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                PopupMessageBox.Show("TMSError - Failed to open Define Activity form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Save button click event to save the form for adding new record
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveModifyActivityData("S");
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to save a new Activity record!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Modify button click event to enable the form for updating existing record
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                SaveModifyActivityData("M");
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to update an existing Activity record!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //DataGridView cell click event to load the existing activities record in form for modification
        private void dView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dView.CurrentRow.Index;
                if ((index >= 0) && (index <= dView.RowCount - 1))
                {
                    _activityId = Convert.ToInt32(dView.Rows[index].Cells[1].Value);
                    txtTaskName.Text = Convert.ToString(dView.Rows[index].Cells[2].Value);
                    rtxtActivityDescription.Text = Convert.ToString(dView.Rows[index].Cells[3].Value);
                    //chkActive.Checked = Convert.ToBoolean(dView.Rows[index].Cells[4].Value);
                    chkActive.Checked = (dView.Rows[index].Cells[4].Value.ToString() == "Active") ? true : false;
                    EnableDisableButtons(3);
                }
                else
                {
                    PopupMessageBox.Show("Please select a record item from the DataGrid!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the selected record in the Form fields from the DataGrid!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                grpBoxForButton.ForeColor = ThemeColor.PrimaryColor;
                grpBoxForGridView.ForeColor = ThemeColor.PrimaryColor;
                txtTaskName.ForeColor = ThemeColor.SecondaryColor;
                rtxtActivityDescription.ForeColor = ThemeColor.SecondaryColor;
                chkActive.ForeColor = ThemeColor.SecondaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        // Function to retrive the Activity table data for GridView DataSource
        public void GetActivityData(int pageNum, int pageSize)
        {
            try
            {
                _activities = taskManagement.GetActivitiesUsingPaging(out _totalRecords, pageNum, pageSize, UserInfo.SelectedValue);
                if (_totalRecords > 0)
                {
                    _noOfPages = Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize));
                    _pagesInLocal = Convert.ToInt32(Math.Ceiling((double)_activities.Rows.Count / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_activities.Rows.Count / pageSize));
                }
                else
                {
                    _noOfPages = 0;
                    _pagesInLocal = 0;
                }
                _pageSize = pageSize;
                _startPageInLocal = pageNum;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to retrieve the Activities records!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Function to Validate the mandatory controls are supplied with correct values
        private Boolean ValidateControls(String mode)
        {
            try
            {
                if (UserInfo.SelectedValue == 0)
                {
                    PopupMessageBox.Show("Please Select Project Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (mode == "S")
                {
                    if (chkActive.Checked == false)
                    {
                        PopupMessageBox.Show("Please Confirm Active Activity!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                if (txtTaskName.Text == "")
                {
                    PopupMessageBox.Show("Please enter Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTaskName.Select();
                    return false;
                }
                if (rtxtActivityDescription.Text == "")
                {
                    PopupMessageBox.Show("Please enter Activity Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtActivityDescription.Select();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to validate the form controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
            return true;
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
                    rtxtActivityDescription.Enabled = true;
                    btnAdd.Enabled = false;
                }
                if (flag == 2)//modify and Cancel
                {
                    txtTaskName.Enabled = false;
                    rtxtActivityDescription.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnModify.Enabled = false;
                    btnAdd.Enabled = true;
                }
                if (flag == 3)
                {
                    txtTaskName.Enabled = true;
                    rtxtActivityDescription.Enabled = true;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = true;
                    btnModify.Enabled = true;
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
                throw new Exception("TMSError - Failed to setup the Create Activity form button controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }


        //Function to perform new Employee addition and existing Employee update
        private void SaveModifyActivityData(String mode)
        {
            try
            {
                if (ValidateControls(mode))
                {
                    activity.ActivityId = _activityId;
                    activity.ActivityName = txtTaskName.Text;
                    activity.ActivityDescription = rtxtActivityDescription.Text;
                    activity.IsActive = chkActive.Checked;
                    activity.ProjectId = UserInfo.SelectedValue;
                    switch (mode)
                    {
                        case "S":
                            if (taskManagement.AddUpdateActivity(activity) <= 0)
                            {
                                throw new Exception("Activity: '" + txtTaskName.Text + "' already exists in Database!");
                            }
                            break;
                        case "M":
                            if (taskManagement.AddUpdateActivity(activity, true) <= 0)
                            {
                                throw new Exception("Activity: '" + txtTaskName.Text + "' doesnt exist in Database!");
                            }
                            break;
                        default:
                            throw new Exception("TMSError - Invalid Operation!! ");
                    }

                    LoadActivityDataGrid(true, true);
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
        private void LoadActivityDataGrid(Boolean refresh = false, Boolean resetCurrentPage = false)
        {
            try
            {
                if (refresh || !Enumerable.Range(_startPageInLocal, _startPageInLocal + _pagesInLocal - 1).Contains(_currentPage))
                {
                    if (resetCurrentPage)
                        _currentPage = 1;
                    GetActivityData(_currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem));
                }
                if (_noOfPages > 0)
                {
                    grpBoxPaging.Visible = true;
                    lblCurrentPage.Text = _currentPage.ToString();
                    lblNoOfPages.Text = _noOfPages.ToString();
                }
                else
                {
                    grpBoxPaging.Visible = false;
                }
                
                DataTable records = FormControlHandling.GetPageRecords(_activities, _currentPage, _pageSize);
                dView.DataSource = null;
                if (records != null && records.Rows.Count > 0)
                {
                    dView.DataSource = records;
                    dView.Columns[0].Visible = false;
                    dView.AllowUserToAddRows = false;
                    dView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dView.AutoResizeColumns();
                    dView.ReadOnly = true;
                    EnableDisableButtons(4);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the data in GridView!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        private void DefineActivity_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
                EnableDisableButtons(2);
                LoadActivityDataGrid(true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage -= 1;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadActivityDataGrid();
                else
                {
                    LoadActivityDataGrid(true);
                }
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
                    LoadActivityDataGrid();
                else
                    LoadActivityDataGrid(true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to the first page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage += 1;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadActivityDataGrid();
                else
                    LoadActivityDataGrid(true);
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
                    LoadActivityDataGrid();
                else
                    LoadActivityDataGrid(true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to last page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNoOfRecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentPage = 1;
                LoadActivityDataGrid(true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load selected no. of records on grid page!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
