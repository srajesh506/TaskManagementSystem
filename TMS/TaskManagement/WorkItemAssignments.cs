using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TMS.UI.Utilities;
using TMS.BusinessEntities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;

namespace TMS.UI
{
    public partial class WorkItemAssignments : Form
    {
        static int Id;
        static int WorkitemId;
        static int Status;
        static int UserId;
        static string EmpName;
        static string Remarks;
        static int ModifiedColumn;

        
        WorkItemManagement workItemManagement= new WorkItemManagement();
        DBCommonOperations dBCommonOperations=new DBCommonOperations();
        TeamManagement teamManagement=new TeamManagement();

        public WorkItemAssignments()
        {
            InitializeComponent();
            LoadTheme();
            GetAllData();
        }
        private void LoadTheme()
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
            grpBoxWorkItemAssignmentGridView.ForeColor = ThemeColor.PrimaryColor;

        }

        private void dview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        public void GetAllData(bool filterflag = false)
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

        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
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
                        Id = (int)dgView.Rows[index].Cells[0].Value;
                        EmpName = dgView.Rows[index].Cells[4].Value.ToString();
                        WorkitemId = (int)dgView.Rows[index].Cells[1].Value;
                        ModifiedColumn = (int)e.ColumnIndex;
                    }
                    if (e.ColumnIndex == 8)
                    {
                        dgView.CurrentCell.ReadOnly = false;
                        Remarks = dgView.CurrentCell.Value.ToString();
                    }
                    if (e.ColumnIndex == 4)
                    {
                        dgView.CurrentCell.ReadOnly = false;
                        DataTable dt_temp = new DataTable();
                        //ds_EmpName = obj.GetDataFromTable("Select UserId, EmpName from UserMaster where IsActive=1");
                        dt_temp = teamManagement.GetEmployees();
                        string[] selectedColumns = new[] { "UserId", "EmpName" };
                        DataTable dt = new DataView(dt_temp).ToTable(false, selectedColumns);
                        DataRow dr_EmpNameNoValues;
                        dr_EmpNameNoValues = dt.NewRow();
                        dr_EmpNameNoValues.ItemArray = new object[] { 0, "--Choose--" };
                        dt.Rows.InsertAt(dr_EmpNameNoValues, 0);
                        ComboBox EmpNamecombo = new ComboBox();
                        EmpNamecombo.DataSource = dt;
                        EmpNamecombo.ValueMember = "UserId";
                        EmpNamecombo.DisplayMember = "EmpName";
                        EmpNamecombo.Hide();
                        dgView.Controls.Add(EmpNamecombo);
                        Rectangle oRectangle = dgView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        EmpNamecombo.Size = new Size(oRectangle.Width, oRectangle.Height);
                        EmpNamecombo.Location = new Point(oRectangle.X, oRectangle.Y);
                        // EmpNamecombo.SelectedIndexChanged += new EventHandler(comboSelectedIndexChanged);
                        EmpNamecombo.Leave += new EventHandler(comboLeave);
                        EmpNamecombo.Show();
                        EmpNamecombo.SelectedIndex = EmpNamecombo.FindString(dgView.CurrentCell.Value.ToString());
                    }
                    if (e.ColumnIndex == 3)
                    {
                        if (dgView.CurrentRow.Cells[4].Value.ToString() != "--Choose--")
                        {
                            dgView.CurrentCell.ReadOnly = false;
                            DataTable dt = new DataTable();
                            dt = dBCommonOperations.GetStatus(true);
                            //ds_Status = obj.GetDataFromTable("Select StatusId,Status from Status where StatusId <> 6");
                            DataRow dr_StatusNoValues;
                            dr_StatusNoValues = dt.NewRow();
                            dr_StatusNoValues.ItemArray = new object[] { 0, "--Choose--" };
                            dt.Rows.InsertAt(dr_StatusNoValues, 0);
                            ComboBox Statuscombo = new ComboBox();
                            Statuscombo.DataSource = dt;
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

        private void savetext(object sender, EventArgs e)
        {
            //dview.CurrentCell.Value = e.;
            if (ModifiedColumn == 8)    // Status
            {
                if (Remarks != dgView.CurrentCell.Value.ToString())
                {
                    workItemManagement.AddUpdateWorkassignmentItem(Id, WorkitemId, 0, 0, dgView.CurrentCell.Value.ToString());
                }
            }

            if (chkFilterActive.Checked)
            {
                GetAllData(true);
            }
            else
            {
                GetAllData();
            }
            ///temp.Visible = false;
        }

        private void comboLeave(object sender, EventArgs e)
        {
            ComboBox temp = (ComboBox)sender;
            if (ModifiedColumn == 3)    // Status
            {
                Status = Convert.ToInt32(temp.SelectedValue);
                workItemManagement.AddUpdateWorkassignmentItem(Id, WorkitemId, 0, Status, "");
            }
            else if (ModifiedColumn == 4) // UserId
            {
                if (EmpName != temp.Text)
                {
                    UserId = Convert.ToInt32(temp.SelectedValue);
                    workItemManagement.AddUpdateWorkassignmentItem(Id, WorkitemId, UserId, 0, "");
                }
                else
                {
                    PopupMessageBox.Show("Assigned To Value has not changed. Please choose a different value than currently assigned", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (chkFilterActive.Checked)
            {
                GetAllData(true);
            }
            else
            {
                GetAllData();
            }
            temp.Visible = false;

        }
        private void dview_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "Row", e.Row);
        }

        private void chkFilterActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilterActive.Checked)
            {
                GetAllData(true);
            }
            else
            {
                GetAllData();
            }
        }

    }
}
