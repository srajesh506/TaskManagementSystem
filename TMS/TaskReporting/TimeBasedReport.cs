using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI.Utilities;
using TMS.UI.CustomMessageBox;

using CrystalDecisions.CrystalReports.Engine;
using System.Linq;
using TMS.TaskReporting;

namespace TMS.UI
{
    public partial class TimeBasedReport : Form
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

        TMS.BusinessLogicLayer.TaskReporting taskReporting = new TMS.BusinessLogicLayer.TaskReporting();
        public TimeBasedReport()
        {
            try
            {
                InitializeComponent();
               
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Time Based Report Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        //Form Load event - Loads the default griddata.
        private void AssigneeBasedReport_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
                LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value,true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Time Based Report Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Get Record button click event to retrive the records in gridview
        private void btnGetRecord_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan span = new TimeSpan(0, 0, 2, 0);
                if (dtpDateFrom.Value > dtpDateTo.Value.Add(span))
                {
                    PopupMessageBox.Show("From date should not be greater than to date", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpDateTo.Value = DateTime.Now;
                }
                else
                {
                    LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value,true);
                    btnPrint.Enabled = false;
                    if (dView.Rows.Count <= 1)
                    {
                        PopupMessageBox.Show("No Record Found", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    btnPrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to retrieve the records in GridView based on Assignee selection!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        //Print button click event - to print the report using crystal report
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet Ds = new DataSet();
                DataTable dt = new DataTable();
                dt = taskReporting.GetTimeBasedReport(dtpDateFrom.Value, dtpDateTo.Value);
                Ds.Tables.Add(dt);
                Ds.WriteXmlSchema("TMSReporting.xml");
                ReportViewer fm = new ReportViewer();
                CrystalReport cr = new CrystalReport();
                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;
                txtReportHeader = cr.ReportDefinition.ReportObjects["Text7"] as TextObject;
                txtReportHeader.Text = "TIME BASED REPORT";
                cr.SetDataSource(Ds);
                fm.crystalReportViewer.ReportSource = cr;
                fm.Show();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to print the report!! \n" + ex.Message + "\n", "TMS",MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                lblStartDate.ForeColor = ThemeColor.PrimaryColor;
                lblEndDate.ForeColor = ThemeColor.PrimaryColor;
                dView.ForeColor = ThemeColor.PrimaryColor;
                //groupBoxforeTaskBasedReport.ForeColor = ThemeColor.PrimaryColor;
                //btngetrecord.ForeColor = ThemeColor.PrimaryColor;
                //btnprint.ForeColor = ThemeColor.PrimaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }


        public void GetTimeBasedReportData(int pageNum, int pageSize)
        {
            try
            {
                _taskReporting = taskReporting.GetTimeBasedReportUsingPaging(out _totalRecords, pageNum, pageSize, dtpDateFrom.Value, dtpDateTo.Value);
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
        public void LoadTimeBasedReportGrid(DateTime dateFrom, DateTime dateTo, Boolean refresh = false)
        {
            try
            {
                if (refresh || !Enumerable.Range(_startPageInLocal, _startPageInLocal + _pagesInLocal - 1).Contains(_currentPage))
                    GetTimeBasedReportData(_currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem));
                lblCurrentPage.Text = _currentPage.ToString();
                lblNoOfPages.Text = _noOfPages.ToString();
                DataTable records = FormControlHandling.GetPageRecords(_taskReporting, _currentPage, _pageSize);
                dView.DataSource = records;

                //dView.DataSource = null;
                //dView.DataSource = taskReporting.GetTimeBasedReport(dateFrom, dateTo);

                dView.Columns[1].Width = 400;
                dView.Columns[2].Width = 150;
                dView.Columns[3].Width = 150;
                dView.Columns[4].Width = 100;
                dView.Columns[5].Width = 120;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage += 1;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value,true);
                else
                    LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, true);
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
                    LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, true);
                else
                    LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, true);
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
                    LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, true);
                else
                    LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, true);
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
                    LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, true);
                else
                    LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, true);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to the first page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cmbNoOfRecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, true);
        }
    }
}
