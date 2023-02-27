using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;

using TMS.UI.Utilities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;

using CrystalDecisions.CrystalReports.Engine;


namespace TMS.UI
{
    public partial class AssigneeBasedReport : Form
    {
        private int _currentPage = 1;
        private int _noOfPages;

        TaskReporting taskReporting = new TaskReporting();
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
                LoadAssigneeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, false);

                DataTable dtAssignee = new DataTable();
                dtAssignee = teamManagement.GetEmployees(null, true);
                DataRow drAssignee;
                drAssignee = dtAssignee.NewRow();
                drAssignee.ItemArray = new object[] { 0, "--Select Assignee--" };
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
                if (cmbAssignee.SelectedIndex > 0)
                    LoadAssigneeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkDateAndAssignee.Checked, cmbAssignee.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the data in GridView based on Assignee selection!! \n" + ex.Message + "\n", ex.InnerException);
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
                    LoadAssigneeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value, chkDateAndAssignee.Checked, cmbAssignee.SelectedValue.ToString());
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

        // Function to enable or disable the buttons based on GridView Page Selected or No of Records per Page changes) 
        private void EnableDisableButtons(int flag)
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
                throw new Exception("TMSError - Failed to setup the form button controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Function to load the datagridview with the records and setup other options for datagridview
        public void LoadAssigneeBasedReportGrid(DateTime dateFrom, DateTime dateTo, Boolean flagDateAndAssignee = false, string userId = null)
        {
            try
            {
                dView.DataSource = null;
                dView.DataSource = taskReporting.GetAssigneeBasedReport(dateFrom, dateTo, flagDateAndAssignee, userId);
                dView.Columns[0].Width = 400;
                dView.Columns[1].Width = 100;
                dView.Columns[2].Width = 100;
                dView.Columns[3].Width = 100;
                dView.Columns[4].Width = 120;
                dView.Columns[5].Width = 150;
                dView.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dView.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the data in GridView!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

    }
}
