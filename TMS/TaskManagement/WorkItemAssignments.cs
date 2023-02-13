using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI.Utilities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;

namespace TMS.UI
{
    public partial class WorkItemAssignments : Form
    {
        private int _workItemAssignmentId;
        private int _workItemId;
        private int _status;
        private int _userId;
        private string _empName;
        private string _remarks;
        private int _modifiedColumn;

        
        WorkItemManagement workItemManagement= new WorkItemManagement();
        DBCommonOperations dBCommonOperations=new DBCommonOperations();
        TeamManagement teamManagement=new TeamManagement();

        public WorkItemAssignments()
        {
            try
            {
                InitializeComponent();
                LoadTheme();
                LoadWorkItemAssignmentData(true, false);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the WorkItem Assignment Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        //Datagridview formatting Event to highlight records based on the status
        private void dgView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                for (int i = 0; i < dgView.Rows.Count; i++)
                {
                    if (dgView.Rows[i].Cells[3].Value.ToString() == "Completed")
                    {
                        dgView.Rows[i].DefaultCellStyle.BackColor = Color.Lavender;
                        dgView.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
                    }
                    else if (dgView.Rows[i].Cells[3].Value.ToString() == "HandedOver")
                    {
                        dgView.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                        dgView.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
                    }
                    else if (dgView.Rows[i].Cells[3].Value.ToString() == "Pending")
                    {
                        dgView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgView.Rows[i].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                    }
                    else if (dgView.Rows[i].Cells[3].Value.ToString() == "InProgress" || dgView.Rows[i].Cells[3].Value.ToString() == "Monitoring")
                    {
                        dgView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        dgView.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
                    }
                    else
                    {
                        dgView.Rows[i].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
                        dgView.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
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
                    if (dgView.CurrentRow.Cells[3].Value.ToString() != "Completed" && dgView.CurrentRow.Cells[3].Value.ToString() != "HandedOver")
                    {
                        int index = dgView.CurrentRow.Index;
                        if (index <= dgView.RowCount - 1)
                        {
                            _workItemAssignmentId = (int)dgView.Rows[index].Cells[0].Value;
                            _empName = dgView.Rows[index].Cells[4].Value.ToString();
                            _workItemId = (int)dgView.Rows[index].Cells[1].Value;
                            _modifiedColumn = (int)e.ColumnIndex;
                        }
                        if (e.ColumnIndex == 8)
                        {
                            dgView.CurrentCell.ReadOnly = false;
                            _remarks = dgView.CurrentCell.Value.ToString();
                        }
                        if (e.ColumnIndex == 4)
                        {
                            dgView.CurrentCell.ReadOnly = false;
                            DataTable dtTemp = new DataTable();
                            dtTemp = teamManagement.GetEmployees();
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
                        if (e.ColumnIndex == 3)
                        {
                            if (dgView.CurrentRow.Cells[4].Value.ToString() != "--Choose--")
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
                        PopupMessageBox.Show("WorkItem is already closed or handed over. Please choose other workitems", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                grpBoxGridView.ForeColor = ThemeColor.PrimaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }    
        }

        //Function to load the datagridview with the records and setup other options for datagridview
        private void LoadWorkItemAssignmentData(Boolean refresh = false, Boolean filterflag = false)
        {
            try
            {
                if (refresh)
                {
                    dgView.DataSource = null;
                    if (filterflag)
                    {
                        dgView.DataSource = workItemManagement.GetWorkItemAssignments(true);
                    }
                    else
                    {
                        dgView.DataSource = workItemManagement.GetWorkItemAssignments();
                    }
                    dgView.Columns[0].Visible = false;               //Id
                    dgView.Columns[1].Visible = false;               //WorkitemId
                    dgView.Columns[2].Width = 175;                   //WorkItemDescription
                    dgView.Columns[3].Width = 90;                    //Status
                    dgView.Columns[4].Width = 100;                   //AssignedTo
                    dgView.Columns[5].Width = 150;                   //StartDate
                    dgView.Columns[6].Width = 150;                   //ClosedDate
                    dgView.Columns[7].Width = 105;                   //HandedOverTo
                    dgView.Columns[8].Width = 300;                   //Remarks

                    dgView.Columns[2].ReadOnly = true;
                    dgView.Columns[3].ReadOnly = true;
                    dgView.Columns[4].ReadOnly = true;
                    dgView.Columns[5].ReadOnly = true;
                    dgView.Columns[6].ReadOnly = true;
                    dgView.Columns[7].ReadOnly = true;
                    dgView.Columns[8].ReadOnly = true;
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
                if (_modifiedColumn == 8)    // Status
                {
                    if (_remarks != dgView.CurrentCell.Value.ToString())
                    {
                        workItemManagement.AddUpdateWorkassignmentItem(_workItemAssignmentId, _workItemId, 0, 0, dgView.CurrentCell.Value.ToString());
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
                ComboBox temp = (ComboBox)sender;
                if (_modifiedColumn == 3)    // Status
                {
                    _status = Convert.ToInt32(temp.SelectedValue);
                    workItemManagement.AddUpdateWorkassignmentItem(_workItemAssignmentId, _workItemId, 0, _status, "");
                }
                else if (_modifiedColumn == 4) // UserId
                {
                    if (_empName != temp.Text)
                    {
                        _userId = Convert.ToInt32(temp.SelectedValue);
                        workItemManagement.AddUpdateWorkassignmentItem(_workItemAssignmentId, _workItemId, _userId, 0, "");
                    }
                    else
                    {
                        PopupMessageBox.Show("Assigned To Value has not changed. Please choose a different value than currently assigned", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                FilterData(chkFilterActive.Checked);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to update Employee name or Status in the selected record!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
