using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI.Utilities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;
using TMS.TaskReporting;

using CrystalDecisions.CrystalReports.Engine;
using System.Linq;
using TMS.BusinessEntities;

namespace TMS.UI
{
    public partial class StatusBasedReport : Form
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
        DBCommonOperations dBCommonOperations = new DBCommonOperations();

        public StatusBasedReport()
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

        //Form Load event - Loads the default griddata along with values in the dropdown for all Status
        private void StatusBasedReport_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
                dtpDateFrom.Enabled = false;
                dtpDateTo.Enabled = false;
                LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, false, Convert.ToInt32(cmbStatus.SelectedValue) == 0 ? 0 : Convert.ToInt32(cmbStatus.SelectedValue), true);

                DataTable dtStatus = new DataTable();
                dtStatus = dBCommonOperations.GetStatus();
                DataRow drStatus;
                drStatus = dtStatus.NewRow();
                drStatus.ItemArray = new object[] { 0, "--Select Status--" };
                dtStatus.Rows.InsertAt(drStatus, 0);
                cmbStatus.ValueMember = "StatusId";
                cmbStatus.DisplayMember = "StatusDescription";
                cmbStatus.DataSource = dtStatus;
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Status Based Report Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Status combobox value change event to load the gridview data based on selection of status
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (cmbStatus.SelectedIndex > 0)
                    LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue) == 0 ? -1 : Convert.ToInt32(cmbStatus.SelectedValue), true);
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the data in GridView based on Status selection!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Checkbox Date and Status check/uncheck Event to enable/disable datefrom and dateto fields
        private void chkTimeAndStatus_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkTimeAndStatus.Checked == true)
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
                if (cmbStatus.SelectedIndex <= 0)
                {
                    PopupMessageBox.Show("Please Select Status!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue),true);
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
                throw new Exception("TMSError - Failed to retrieve the records in GridView based on Status selection!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmbStatus.SelectedIndex <= 0 || chkTimeAndStatus.Checked == false) && (cmbStatus.SelectedIndex <= 0 || chkTimeAndStatus.Checked == true))
                {
                    PopupMessageBox.Show("Please Select Status!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataSet Ds = new DataSet();
                    DataTable dt = new DataTable();
                    //dt = taskReporting.GetStatusBasedReport(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue));
                    dt= taskReporting.GetStatusBasedReport(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked,UserInfo.SelectedValue, Convert.ToInt32(cmbStatus.SelectedValue));
                    Ds.Tables.Add(dt);
                    Ds.WriteXmlSchema("TMSReporting.xml");
                    ReportViewer fm = new ReportViewer();
                    CrystalReport cr = new CrystalReport();
                    CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;
                    CrystalDecisions.CrystalReports.Engine.TextObject txtProjectName;
                    txtReportHeader = cr.ReportDefinition.ReportObjects["Text7"] as TextObject;
                    txtReportHeader.Text = "STATUS BASED REPORT";
                    txtProjectName = cr.ReportDefinition.ReportObjects["Text10"] as TextObject;
                    txtProjectName.Text = UserInfo.ProjectText;
                    cr.SetDataSource(Ds);
                    fm.crystalReportViewer.ReportSource = cr;
                    fm.Show();
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                lblStatus.ForeColor = ThemeColor.PrimaryColor;
                lblStartDate.ForeColor = ThemeColor.PrimaryColor;
                lblEndDate.ForeColor = ThemeColor.PrimaryColor;
                dView.ForeColor = ThemeColor.PrimaryColor;
                grpBoxDataGrid.ForeColor = ThemeColor.PrimaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }     
        }

        public void GetStatusBasedReportData(int pageNum, int pageSize)
        {
            try
            {
                _taskReporting = taskReporting.GetStatusBasedReportusingPaging(out _totalRecords, pageNum, pageSize,UserInfo.SelectedValue, dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue) == 0 ? -1 : Convert.ToInt32(cmbStatus.SelectedValue));
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
        public void LoadStatusBasedReportGrid(DateTime dateFrom, DateTime dateTo, Boolean flagDateAndStatus = false, int statusId = -1, Boolean refresh = false)
        {
            try
            {
                if (refresh || !Enumerable.Range(_startPageInLocal, _startPageInLocal + _pagesInLocal - 1).Contains(_currentPage))
                GetStatusBasedReportData(_currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem));
                lblCurrentPage.Text = _currentPage.ToString();
                lblNoOfPages.Text = _noOfPages.ToString();
                DataTable records = FormControlHandling.GetPageRecords(_taskReporting, _currentPage, _pageSize);
                dView.DataSource = records;

                //dView.DataSource = null;
                //dView.DataSource = taskReporting.GetStatusBasedReport(dateFrom, dateTo, flagDateAndStatus, statusId);

                
                dView.Columns[1].Width = 400;
                dView.Columns[2].Width = 125;
                dView.Columns[3].Width = 125;
                dView.Columns[4].Width = 120;
                dView.Columns[5].Width = 150;
                dView.Columns[6].Width = 150;
                dView.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dView.Columns[0].Visible = false;
                dView.ReadOnly = true;
                EnableDisableButtons(4);
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the data in GridView!! \n" + ex.Message + "\n", ex.InnerException);
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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage -= 1;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue));
                else
                    LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue), true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to previous page in the grid !! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage += 1;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue));
                else
                    LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue), true);
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
                    LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue));
                else
                    LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue),true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to last page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage = 1;
                if (_startPageInLocal == 1)
                    LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue));
                else
                    LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue), true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to the first page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNoOfRecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadStatusBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkTimeAndStatus.Checked, Convert.ToInt32(cmbStatus.SelectedValue), true);
        }
    }
}
