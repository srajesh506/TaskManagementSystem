using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI.Utilities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;
using System.Linq;
using TMS.WorkitemHistory;
using System.Reflection;
using System.Collections.Generic;
using TMS.BusinessEntities;

namespace TMS.UI
{
    public partial class WorkItemAssignments : Form
    {

        //Paging Variables***********
        private int _currentPage = 1;
        private int _pageSize = 5;

        private int _noOfPages;
        private int _totalRecords;

        private int _startPageInLocal;
        private int _pagesInLocal;
        //************

        private int _workItemAssignmentId;
        private int _workItemId;
        private int _Id;
        private int _status;
        private string _userId;
        private string _empName;
        private string _remarks;
        private int _modifiedColumn;
        private DataTable _WorkItemAssignment;

        WorkItemManagement workItemManagement = new WorkItemManagement();
        DBCommonOperations dBCommonOperations = new DBCommonOperations();
        TeamManagement teamManagement = new TeamManagement();

        public WorkItemAssignments()
        {
            try
            {
                InitializeComponent();
                string roleid=UserInfo.RoleId;

            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the WorkItem Assignment Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                throw new Exception("TMSError - Failed to setup the Create WorkItem form button controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        private void dgView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgView.Rows.Count)
                {
                    var statusColorDict = new Dictionary<string, Color>
                            {
                                { "Completed", Color.Lavender },
                                { "HandedOver", Color.LightYellow },
                                { "Pending", Color.Red },
                                { "InProgress", Color.LightGreen },
                                { "Monitoring", Color.LightGreen }
                            };
                    DataGridViewRow row = dgView.Rows[e.RowIndex];
                    string statusDescription = row.Cells["FinalStatus"].Value.ToString();
                    if (statusColorDict.ContainsKey(statusDescription))
                    {
                        row.DefaultCellStyle.BackColor = statusColorDict[statusDescription];
                        row.DefaultCellStyle.ForeColor = statusDescription == "Pending" ? Color.WhiteSmoke : System.Drawing.Color.FromArgb(0, 181, 171);
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 181, 171);
                    }
                }
                e.CellStyle.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to format the records in the DataGridView!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //DataGridView cell click event to modify the selected record
        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check the cell clicked is not the column header cell
                if (e.RowIndex != -1)
                {
                    dgView.Controls.Clear();
                    int index = dgView.CurrentRow.Index;
                    _Id = (int)dgView.Rows[index].Cells[2].Value;
                    DataTable dtfinalstatus = new DataTable();
                    dtfinalstatus = workItemManagement.GetWorkItemFinalStatus(_Id);
                    if (dgView.CurrentRow.Cells[10].Value.ToString() != "Completed" && dgView.CurrentRow.Cells[10].Value.ToString() != "HandedOver")
                    {
                        //if (dtfinalstatus.Rows[0]["StatusDescription"].ToString() != "Completed" && dgView.CurrentRow.Cells[4].Value.ToString() != "HandedOver")
                        //{
                        //int index = dgView.CurrentRow.Index;
                        if (index <= dgView.RowCount - 1)
                        {
                            _workItemAssignmentId = (int)dgView.Rows[index].Cells[1].Value;
                            _empName = dgView.Rows[index].Cells[5].Value.ToString();
                            _workItemId = (int)dgView.Rows[index].Cells[2].Value;
                            _modifiedColumn = (int)e.ColumnIndex;
                        }
                        if (e.ColumnIndex == 9)
                        {
                            dgView.CurrentCell.ReadOnly = false;
                            _remarks = dgView.CurrentCell.Value.ToString();
                        }
                        if (e.ColumnIndex == 5)
                        {
                            dgView.CurrentCell.ReadOnly = false;
                            DataTable dtTemp = new DataTable();
                            dtTemp = teamManagement.GetEmployees(null,true,UserInfo.SelectedValue);
                            string[] selectedColumns = new[] { "UserId", "EmpName" };
                            DataTable dtEmployees = new DataView(dtTemp).ToTable(false, selectedColumns);
                            DataRow drEmpNameNoValues;
                            drEmpNameNoValues = dtEmployees.NewRow();
                            drEmpNameNoValues.ItemArray = new object[] { 0, "--Choose--" };
                            dtEmployees.Rows.InsertAt(drEmpNameNoValues, 0);
                            ComboBox EmpNamecombo = new ComboBox();
                            EmpNamecombo.DataSource = dtEmployees;
                            EmpNamecombo.ValueMember = "UserId";
                            EmpNamecombo.DisplayMember = "EmpName";
                            EmpNamecombo.Hide();
                            dgView.Controls.Add(EmpNamecombo);
                            Rectangle oRectangle = dgView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                            EmpNamecombo.Size = new Size(oRectangle.Width, oRectangle.Height);
                            EmpNamecombo.Location = new Point(oRectangle.X, oRectangle.Y);
                            EmpNamecombo.Leave += new EventHandler(comboLeave);
                            EmpNamecombo.Show();
                            EmpNamecombo.SelectedIndex = EmpNamecombo.FindString(dgView.CurrentCell.Value.ToString());
                        }
                        if (e.ColumnIndex == 4)
                        {
                            if (dgView.CurrentRow.Cells[5].Value.ToString() != "--Choose--")
                            {
                                dgView.CurrentCell.ReadOnly = false;
                                DataTable dtStatus = new DataTable();
                                dtStatus = dBCommonOperations.GetStatus(true);
                                DataRow drStatusNoValues;
                                drStatusNoValues = dtStatus.NewRow();
                                drStatusNoValues.ItemArray = new object[] { 0, "--Choose--" };
                                dtStatus.Rows.InsertAt(drStatusNoValues, 0);
                                ComboBox Statuscombo = new ComboBox();
                                Statuscombo.DataSource = dtStatus;
                                Statuscombo.ValueMember = "StatusId";
                                Statuscombo.DisplayMember = "StatusDescription";
                                Statuscombo.Hide();
                                dgView.Controls.Add(Statuscombo);
                                Rectangle oRectangle = dgView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                                Statuscombo.Size = new Size(oRectangle.Width, oRectangle.Height);
                                Statuscombo.Location = new Point(oRectangle.X, oRectangle.Y);
                                //Statuscombo.SelectedIndexChanged += new EventHandler(comboSelectedIndexChanged);
                                Statuscombo.Leave += new EventHandler(comboLeave);
                                Statuscombo.Show();
                                Statuscombo.SelectedIndex = Statuscombo.FindString(dgView.CurrentCell.Value.ToString());
                            }
                            else
                            {
                                PopupMessageBox.Show("Please assign the Work Item to one of the team members first", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                    else
                    {
                        if (e.ColumnIndex == 3)
                        {
                            _workItemId = (int)dgView.Rows[dgView.CurrentRow.Index].Cells[2].Value;
                            FrmWorkItemHistory objfrm = new FrmWorkItemHistory(_workItemId);
                            objfrm.Show();
                        }
                        //PopupMessageBox.Show("WorkItem is already closed or handed over. Please choose other workitems", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failure in the WorkItem Assignment Gridview Cell click event!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "Row", e.Row);
        }

        //CheckBox Filter Active records checked/unchecked event to load the DataGridView
        private void chkFilterActive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData(chkFilterActive.Checked);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the DataGridView data on Filter checkbox check/uncheck event!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //grpBoxGridView.ForeColor = ThemeColor.PrimaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        public void GetWorkItemsAssignmentData(int pageNum, int pageSize)
        {
            try
            {
                _WorkItemAssignment = workItemManagement.GetWorkItemAssignmentsUsingPaging(out _totalRecords, pageNum, pageSize, UserInfo.SelectedValue,chkFilterActive.Checked);
                _noOfPages = Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_totalRecords / pageSize));
                _pagesInLocal = Convert.ToInt32(Math.Ceiling((double)_WorkItemAssignment.Rows.Count / pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_WorkItemAssignment.Rows.Count / pageSize));
                _pageSize = pageSize;
                _startPageInLocal = pageNum;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to retrieve the Activities records!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        //Function to load the datagridview with the records and setup other options for datagridview
        private void LoadWorkItemAssignmentData(Boolean refresh = false, Boolean filterflag = false)
        {
            try
            {
                if (refresh || !Enumerable.Range(_startPageInLocal, _startPageInLocal + _pagesInLocal - 1).Contains(_currentPage))
                {
                    dgView.DataSource = null;
                    GetWorkItemsAssignmentData(_currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem));
                    lblCurrentPage.Text = _currentPage.ToString();
                    lblNoOfPages.Text = _noOfPages.ToString();
                    if (filterflag)
                    {
                        _WorkItemAssignment = workItemManagement.GetWorkItemAssignmentsUsingPaging(out _totalRecords, _currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem), UserInfo.SelectedValue, true);
                        DataTable records = FormControlHandling.GetPageRecords(_WorkItemAssignment, _currentPage, _pageSize);
                        dgView.DataSource = null;
                        dgView.DataSource = records;
                    }
                    else
                    {
                        _WorkItemAssignment = workItemManagement.GetWorkItemAssignmentsUsingPaging(out _totalRecords, _currentPage, Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem), UserInfo.SelectedValue);
                        DataTable records = FormControlHandling.GetPageRecords(_WorkItemAssignment, _currentPage, _pageSize);
                        dgView.DataSource = null;
                        dgView.DataSource = records;
                    }
                    dgView.Columns[0].Visible = false;               //SLNO
                    dgView.Columns[1].Visible = false;               //ID
                    dgView.Columns[2].Visible = false;
                    dgView.Columns[10].Visible = false;              //Final Status
                    dgView.Columns[3].Width = 175;                   //WorkItemDescription
                    dgView.Columns[4].Width = 90;                    //Status
                    dgView.Columns[5].Width = 100;                   //AssignedTo
                    dgView.Columns[6].Width = 150;                   //StartDate
                    dgView.Columns[7].Width = 150;                   //ClosedDate
                    dgView.Columns[8].Width = 105;                   //HandedOverTo
                    dgView.Columns[9].Width = 300;                   //Remarks

                    //dgView.Columns[3].ReadOnly = true;
                    dgView.Columns[4].ReadOnly = true;
                    dgView.Columns[5].ReadOnly = true;
                    dgView.Columns[6].ReadOnly = true;
                    dgView.Columns[7].ReadOnly = true;
                    dgView.Columns[8].ReadOnly = true;
                    dgView.Columns[9].ReadOnly = true;
                    EnableDisableButtons(4);
                    dgView.Columns["Remarks"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                    //changerowcolor();
                }
           }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to be called whenever data is to be loaded in GridView based on filter flag value
        private void FilterData(Boolean filterFlag = false)
        {
            try
            {
                LoadWorkItemAssignmentData(true, filterFlag);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load the DataGridView data on Filter checkbox check/uncheck event!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //DataGridView cell value change event to save remarks for the work item assignment field
        private void dgViewSaveText(object sender, EventArgs e)
        {
            try
            {
                if (_modifiedColumn == 9)    // Status
                {
                    if (_remarks != dgView.CurrentCell.Value.ToString())
                    {
                        workItemManagement.AddUpdateWorkassignmentItem(_workItemAssignmentId, _workItemId, null, 0, dgView.CurrentCell.Value.ToString(), UserInfo.SelectedValue);
                    }
                }
                FilterData(chkFilterActive.Checked);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failure in the WorkItem Assignment Remarks Update!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Function to update Status for the workitem assigment or assign the workitem to an employee
        private void comboLeave(object sender, EventArgs e)
        {
            try
            {
                int index = dgView.CurrentRow.Index;
                _remarks = dgView.Rows[index].Cells[9].Value.ToString();
                DataTable usertbl = new DataTable();
                usertbl = teamManagement.GetEmployees(UserInfo.UserId);
                if (!string.IsNullOrWhiteSpace(dgView.Rows[index].Cells[9].Value.ToString().ToString().Trim()))
                {
                    ComboBox temp = (ComboBox)sender;
                    if (_modifiedColumn == 4)    // Status
                    {
                        _Id = (int)dgView.Rows[index].Cells[1].Value;
                        if (Isremarksexitsindatabase(_Id))
                        {
                            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter mandatory remarks:", "Mandatory Remarks", "");
                            if (!string.IsNullOrWhiteSpace(input))
                            {
                                _status = Convert.ToInt32(temp.SelectedValue);
                                workItemManagement.AddUpdateWorkassignmentItem(_workItemAssignmentId, _workItemId, null, _status, _remarks + "\n" + usertbl.Rows[0]["EmpName"].ToString() + ":" + input + "(" + DateTime.Now.ToString() + ")",UserInfo.SelectedValue);
                            }
                        }
                        else
                        {
                            _status = Convert.ToInt32(temp.SelectedValue);
                            workItemManagement.AddUpdateWorkassignmentItem(_workItemAssignmentId, _workItemId, null, _status, usertbl.Rows[0]["EmpName"].ToString() + ":" + _remarks + "(" + DateTime.Now.ToString() + ")", UserInfo.SelectedValue);
                        }
                    }
                    else if (_modifiedColumn == 5) // UserId
                    {
                        if (_empName != temp.Text)
                        {
                            _Id = (int)dgView.Rows[index].Cells[1].Value;
                            if (Isremarksexitsindatabase(_Id))
                            {
                                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter mandatory remarks:", "Mandatory Remarks", "");
                                if (!string.IsNullOrWhiteSpace(input))
                                {
                                    _userId = Convert.ToString(temp.SelectedValue);
                                    workItemManagement.AddUpdateWorkassignmentItem(_workItemAssignmentId, _workItemId, _userId, 0, _remarks + "\n" + usertbl.Rows[0]["EmpName"].ToString() + ":" + input + "(" + DateTime.Now.ToString() + ")", UserInfo.SelectedValue);
                                }
                            }
                            else
                            {
                                _userId = Convert.ToString(temp.SelectedValue);
                                workItemManagement.AddUpdateWorkassignmentItem(_workItemAssignmentId, _workItemId, _userId, 0, usertbl.Rows[0]["EmpName"].ToString() + ":" + _remarks + "(" + DateTime.Now.ToString() + ")", UserInfo.SelectedValue);
                            }
                        }
                        else
                        {
                            PopupMessageBox.Show("Assigned To Value has not changed. Please choose a different value than currently assigned", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    temp.Hide();
                    FilterData(chkFilterActive.Checked);
                }
                else
                {
                    dgView.Rows[index].Cells[9].Value = Microsoft.VisualBasic.Interaction.InputBox("Remarks are mandatory.Please put appropiate remarks.", "Mandatory Remarks", "");
                    //PopupMessageBox.Show("Remarks are mandatory.Please put appropiate remarks.", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to update Employee name or Status in the selected record!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void WorkItemAssignments_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
                LoadWorkItemAssignmentData(true, false);

            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage += 1;
                if ((_currentPage >= _startPageInLocal) && (_currentPage <= _startPageInLocal + _pagesInLocal - 1))
                    LoadWorkItemAssignmentData(true, chkFilterActive.Checked);
                else
                    LoadWorkItemAssignmentData(true, chkFilterActive.Checked);
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
                    LoadWorkItemAssignmentData(true, false);
                else
                    LoadWorkItemAssignmentData(true, false);
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
                    LoadWorkItemAssignmentData(true, false);
                else
                    LoadWorkItemAssignmentData(true, false);
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
                    LoadWorkItemAssignmentData(true, false);
                else
                    LoadWorkItemAssignmentData(true, false);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to the first page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNoOfRecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadWorkItemAssignmentData(true, false);
        }

        private void dgViewSaveText(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    int index = dgView.CurrentRow.Index;
                    _workItemId = (int)dgView.Rows[index].Cells[2].Value;
                    FrmWorkItemHistory objfrm = new FrmWorkItemHistory(_workItemId);
                    objfrm.Show();
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool Isremarksexitsindatabase(int id)
        {
            bool _remarks = Convert.ToBoolean(workItemManagement.GetRemarksUsingID(id));
            return _remarks;
        }

        private void dgView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {

        }
    }
}
