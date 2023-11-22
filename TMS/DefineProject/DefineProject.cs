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
    public partial class FrmAssignProject : Form
    {
        private int _currentPage = 1;
        private int _pageSize = 5;
        private int _noOfPages;
        private int _totalRecords;
        private int _startPageInLocal;
        private int _pagesInLocal;
        private DataTable _projectdetails;

        Project projectData = new Project();
        ProjectManagement projectManagement = new ProjectManagement();
        public FrmAssignProject()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Team Register Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Form Load Event
        private void FrmTeamRegister_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
                EnableDisableButtons(2);
                LoadProjectDataGrid(true);        //True flag to make DB call for first time loading the grid
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Team Register Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Add button click event to enable the form for adding new Employee record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EnableDisableButtons(1);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to open add employee form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Save button click event to save the form for adding new Employee record
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveModifyEmployeesData("S");
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to save a new Employee record!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Modify button click event to enable the form for updating existing Employee record
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                SaveModifyEmployeesData("M");
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
                FormControlHandling.ClearControls(grpBoxRegistrationForm);
                EnableDisableButtons(2);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to cancel the active record add/update action!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //DataGridView cell click event to load the existing employee record in form for modification
        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgView.CurrentRow.Index;
                if (index <= dgView.RowCount - 1)
                {
                    projectData.ProjectId = Convert.ToInt32(dgView.Rows[index].Cells[1].Value);
                    txtProjectName.Text = Convert.ToString(dgView.Rows[index].Cells[4].Value);
                    rtxtProjectDescription.Text = Convert.ToString(dgView.Rows[index].Cells[5].Value);
                    //chkActive.Checked = Convert.ToBoolean(dgView.Rows[index].Cells[6].Value);
                    chkActive.Checked = (dgView.Rows[index].Cells[6].Value.ToString() == "Active") ? true : false;
                    EnableDisableButtons(3);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the selected record in the Form fields from the DataGrid!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //PictureBox Password Icon Mouse Down event to allow reading the password
        //PictureBox Password Icon Mouse Up event to disallow reading the password
        //Previous Page button click event to move to previous page of datagridview
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage -= 1;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                {
                    LoadProjectDataGrid();
                }
                else
                {
                    LoadProjectDataGrid(true);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to previous page in the grid !! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Next Page button click event to move to next page of datagridview
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage += 1;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadProjectDataGrid();
                else
                    LoadProjectDataGrid(true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to next page in the grid !! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //NoOfRecordsPerPage Combobox value change event to reload the datagridview data
        private void cmbNoOfRecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentPage = 1;
                LoadProjectDataGrid(true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load selected no. of records on grid page!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //First Page button click event to move to first page of datagridview
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage = 1;
                if (_startPageInLocal == 1)
                    LoadProjectDataGrid();
                else
                    LoadProjectDataGrid(true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to the first page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Last Page button click event to move to last page of datagridview
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage = _noOfPages;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadProjectDataGrid();
                else
                    LoadProjectDataGrid(true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to last page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //lblProjectManager.ForeColor = ThemeColor.SecondaryColor;
                lblProjectName.ForeColor = ThemeColor.SecondaryColor;
                lblProjectDescription.ForeColor = ThemeColor.SecondaryColor;
                grpBoxRegistrationForm.ForeColor = ThemeColor.PrimaryColor;
                grpBoxButtons.ForeColor = ThemeColor.PrimaryColor;
                grpBoxEmployeeGridView.ForeColor = ThemeColor.PrimaryColor;
                chkActive.ForeColor = ThemeColor.SecondaryColor;
                txtProjectName.ForeColor = ThemeColor.SecondaryColor;
                rtxtProjectDescription.ForeColor = ThemeColor.SecondaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        // Function to retrive the Project table data for GridView DataSource
        private void GetProjectData(int pageNum, int pageSize) 
        {
            try
            {
                _projectdetails = projectManagement.GetProjectDetails(out _totalRecords, pageNum, pageSize);
                _noOfPages = Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize));
                _pagesInLocal = Convert.ToInt32(Math.Ceiling((double)_projectdetails.Rows.Count / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_projectdetails.Rows.Count / pageSize));
                _pageSize = pageSize;
                _startPageInLocal = pageNum;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to retrieve the Employees records!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        //Function to Validate the mandatory controls are supplied with correct values
        private Boolean ValidateControls(String mode)
        {
            try
            {
                if (txtProjectName.Text == "")
                {
                    PopupMessageBox.Show("Please enter Project Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProjectName.Select();
                    return false;
                }
                if (rtxtProjectDescription.Text == "")
                {
                    PopupMessageBox.Show("Please enter project description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtProjectDescription.Select();
                    return false;
                }
                if (mode == "S")
                {
                    if (chkActive.Checked == false)
                    {
                        PopupMessageBox.Show("Please Confirm Active Member!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to validate the form controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        // Function to enable or disable the buttons based on the selected operation (ADD/MODIFY/SAVE/CANCEL) or GridView Page Selected or No of Records per Page changes) 
        private void EnableDisableButtons(int flag)
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
                    //cmbProjectManager.Select();
                    //cmbProjectManager.Enabled = true;
                    txtProjectName.Enabled = true;
                    rtxtProjectDescription.Enabled = true;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnAdd.Enabled = false;
                }
                if (flag == 2)//modify and Cancel
                {
                    //cmbProjectManager.Enabled = false;
                    txtProjectName.Enabled = false;
                    rtxtProjectDescription.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnModify.Enabled = false;
                    btnAdd.Enabled = true;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = true;
                }
                if (flag == 3)
                {
                    txtProjectName.Enabled = true;
                    //cmbProjectManager.Enabled = true;
                    rtxtProjectDescription.Enabled = true;
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
                throw new Exception("TMSError - Failed to setup the Team Register form button controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        //Function to perform new Project addition and existing Project update
        private void SaveModifyEmployeesData(String mode)
        {
            try
            {
                if (ValidateControls(mode))
                {
                    //ProjectData.ProjectManagerId = Convert.ToString(cmbProjectManager.SelectedValue);
                    projectData.ProjectName = txtProjectName.Text;
                    projectData.ProjectDescription = rtxtProjectDescription.Text;
                    projectData.IsActive = chkActive.Checked;
                    switch (mode)
                    {
                        case "S":
                            if (projectManagement.AddUpdateProject(projectData) <= 0)
                            {
                                throw new Exception("TMSError - User ID: '" + txtProjectName.Text + "' already exists in Database!! ");
                            }
                            break;
                        case "M":
                            if (projectManagement.AddUpdateProject(projectData, true) <= 0)
                            {
                                throw new Exception("TMSError - User ID: '" + txtProjectName.Text + "' does not exist in Database!! ");
                            }
                            break;
                        default:
                            throw new Exception("TMSError - Invalid Operation!! ");
                    }
                    _currentPage = 1;               //Freshly Load the grid with Page 1
                    LoadProjectDataGrid(true);    //True flag to make DB call for refreshing the grid
                    FormControlHandling.ClearControls(grpBoxRegistrationForm);
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
        private void LoadProjectDataGrid(Boolean refresh = false)
        {
            try
            {
                if (refresh || !Enumerable.Range(_startPageInLocal, _startPageInLocal + _pagesInLocal - 1).Contains(_currentPage))
                    GetProjectData(_currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem));
                lblCurrentPage.Text = _currentPage.ToString();
                lblNoOfPages.Text = _noOfPages.ToString();
                DataTable records = FormControlHandling.GetPageRecords(_projectdetails, _currentPage, _pageSize);
                dgView.DataSource = records;
                if (records != null && records.Rows.Count > 0)
                {
                    dgView.Columns[0].Visible = false;
                    dgView.Columns[2].Visible = false;
                    dgView.Columns[3].Visible = false;
                    //dgView.Columns[6].Visible = false;
                    //dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    //dgView.ReadOnly = true;
                    dgView.AllowUserToAddRows = false;
                    dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgView.AutoResizeColumns();
                    dgView.ReadOnly = true;
                    EnableDisableButtons(4);
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the data in GridView!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

    }
}
