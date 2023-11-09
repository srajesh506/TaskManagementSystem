using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI.Utilities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;

using CrystalDecisions.CrystalReports.Engine;
using System.Linq;
using TMS.TaskReporting;
using TMS.BusinessEntities;

namespace TMS.UI
{
    public partial class AssigneeBasedReport : Form
    {
        //Paging Variables***********
        private int _currentPage = 1;
        private int _pageSize = 5;

        private int _noOfPages;
        private int _totalRecords;

        private int _startPageInLocal;
        private int _pagesInLocal;
        //************

        private DataTable _taskReporting;

        BusinessLogicLayer.TaskReporting taskReporting = new BusinessLogicLayer.TaskReporting();

       // TaskReporting  = new TaskReporting();
        WorkItemManagement workItemManagement = new WorkItemManagement();
        TeamManagement teamManagement = new TeamManagement();

        public AssigneeBasedReport()
        {
            try
            {
                InitializeComponent();
                
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Assignee Based Report Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Form Load event - Loads the default griddata along with values in the dropdown for Assignee
        private void AssigneeBasedReport_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
                dtpDateFrom.Enabled = false;
                dtpDateTo.Enabled = false;
                LoadAssigneeBasedReportGrid(true);

                DataTable dtAssignee = new DataTable();
                dtAssignee = teamManagement.GetEmployees(null, true,UserInfo.SelectedValue);
                DataRow drAssignee;
                drAssignee = dtAssignee.NewRow();
                drAssignee.ItemArray = new object[] {  "--Select Assignee--", 0 };
                dtAssignee.Rows.InsertAt(drAssignee, 0);
                cmbAssignee.ValueMember = "UserId";
                cmbAssignee.DisplayMember = "EmpName";
                cmbAssignee.DataSource = dtAssignee;
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Assignee Based Report Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Assignee combobox value change event to load the gridview data based on selection of assignee
        private void cmbAssignee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (cmbAssignee.SelectedIndex > 0)
                    LoadAssigneeBasedReportGrid(true);
            }
            catch(Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Checkbox Date and Assignee check/uncheck Event to enable/disable datefrom and dateto fields
        private void chkDateAndAssignee_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkDateAndAssignee.Checked == true)
                {
                    dtpDateFrom.Enabled = true;
                    dtpDateTo.Enabled = true;
                }
                else
                {
                    dtpDateFrom.Enabled = false;
                    dtpDateTo.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failure on checkbox check/uncheck to enable date control fields on the form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        //Get Record button click event to retrive the records in gridview
        private void btnGetRecord_Click(object sender, EventArgs e)
        {
            try
            {
                btnPrint.Enabled = false;
                if (cmbAssignee.SelectedIndex <= 0)
                {
                    PopupMessageBox.Show("Please Select Assignee!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LoadAssigneeBasedReportGrid(true);
                    if (dView.Rows.Count <= 1)
                    {
                        PopupMessageBox.Show("No Records Found!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    btnPrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to retrieve the records in GridView based on Assignee selection!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Print button click event - to print the report using crystal report
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmbAssignee.SelectedIndex <= 0 || chkDateAndAssignee.Checked == false) && (cmbAssignee.SelectedIndex <= 0 || chkDateAndAssignee.Checked == true))
                {
                    PopupMessageBox.Show("Please Select Assignee!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataSet Ds = new DataSet();
                    DataTable dt = new DataTable();
                    dt = taskReporting.GetAssigneeBasedReport(dtpDateFrom.Value, dtpDateTo.Value, chkDateAndAssignee.Checked, cmbAssignee.SelectedValue.ToString());
                    Ds.Tables.Add(dt);
                    Ds.WriteXmlSchema("TMSReporting.xml");
                    ReportViewer fm = new ReportViewer();
                    CrystalReport cr = new CrystalReport();

                    CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;
                    txtReportHeader = cr.ReportDefinition.ReportObjects["Text7"] as TextObject;
                    txtReportHeader.Text = "Assignee Based Report";
                    cr.SetDataSource(Ds);
                    fm.crystalReportViewer.ReportSource = cr;
                    fm.Show();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to print the report!! \n" + ex.Message + "\n", ex.InnerException);
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
                        btnPrint.ForeColor = ThemeColor.PrimaryColor;
                    }
                }

                lblAssignee.ForeColor = ThemeColor.PrimaryColor;
                lblStartDate.ForeColor = ThemeColor.PrimaryColor;
                lblEndDate.ForeColor = ThemeColor.PrimaryColor;
                dView.ForeColor = ThemeColor.PrimaryColor;
                grpBoxGridView.ForeColor = ThemeColor.PrimaryColor;
                chkDateAndAssignee.ForeColor = ThemeColor.PrimaryColor;
                btnPrint.Enabled = false;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        public void EnableDisableButtons(int flag)
        {
            try
            {
               
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

        // Function to enable or disable the buttons based on GridView Page Selected or No of Records per Page changes) 
        public void GGetAssigneeBasedReportData(int pageNum, int pageSize)
        {
            try
            {
                _taskReporting = taskReporting.GetAssigneeBasedReportUsingPaging(out _totalRecords, pageNum, pageSize, dtpDateFrom.Value, dtpDateTo.Value, chkDateAndAssignee.Checked, Convert.ToString(cmbAssignee.SelectedValue)=="0" ? null : Convert.ToString(cmbAssignee.SelectedValue),UserInfo.SelectedValue);
                _noOfPages = Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize));
                _pagesInLocal = Convert.ToInt32(Math.Ceiling((double)_taskReporting.Rows.Count / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_taskReporting.Rows.Count / pageSize));
                _pageSize = pageSize;
                _startPageInLocal = pageNum;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to retrieve the Activities records!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        //Function to load the datagridview with the records and setup other options for datagridview
        public void LoadAssigneeBasedReportGrid(Boolean refresh = false)
        {
            try
            {
                if (refresh || !Enumerable.Range(_startPageInLocal, _startPageInLocal + _pagesInLocal - 1).Contains(_currentPage))
                    GGetAssigneeBasedReportData(_currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem));
                lblCurrentPage.Text = _currentPage.ToString();
                lblNoOfPages.Text = _noOfPages.ToString();
                DataTable records = FormControlHandling.GetPageRecords(_taskReporting, _currentPage, _pageSize);
                dView.DataSource = records;
                //dView.DataSource = null;
                //dView.DataSource = taskReporting.GetAssigneeBasedReport(dtpDateFrom.Value, dtpDateTo.Value, chkDateAndAssignee.Checked, Convert.ToString(cmbAssignee.SelectedValue));
                
                dView.Columns[1].Width = 450;
                dView.Columns[2].Width = 100;
                dView.Columns[3].Width = 100;
                dView.Columns[4].Width = 120;
                dView.Columns[5].Width = 150;
                dView.Columns[6].Width = 150;
                dView.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dView.Columns[0].Visible = false;
                dView.ReadOnly = true;
                EnableDisableButtons(4);
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
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadAssigneeBasedReportGrid();
                else
                    LoadAssigneeBasedReportGrid(true);
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
                    LoadAssigneeBasedReportGrid();
                else
                    LoadAssigneeBasedReportGrid(true);
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
                    LoadAssigneeBasedReportGrid();
                else
                    LoadAssigneeBasedReportGrid(true);
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
                    LoadAssigneeBasedReportGrid();
                else
                    LoadAssigneeBasedReportGrid(true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to the first page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNoOfRecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadAssigneeBasedReportGrid(true);
        }
    }
}
