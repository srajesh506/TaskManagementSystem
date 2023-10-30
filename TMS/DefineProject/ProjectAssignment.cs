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
using System.Collections.Generic;
using System.ComponentModel;

namespace TMS.UI
{
    public partial class ProjectAssignment : Form
    {
        private DataTable _employees;
        //List<Employee> unassignedEmployees = new List<Employee>();
        //List<Employee> assignedEmployees = new List<Employee>();

        private BindingList<Employee> _unassignedEmployees;
        private BindingList<Employee> _assignedEmployees;


        Employee employee = new Employee();
        TeamManagement teamManagement = new TeamManagement();
        Operations operations = new Operations();
        public ProjectAssignment()
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
        private void ProjectAssignment_Load(object sender, EventArgs e)
        {
            try
            {
                //LoadTheme();
                //// To load available team members:
                //LoadTeamMembers(lstTeamMembers, 0);
                //// To load assigned team members:
                //LoadTeamMembers(lstAssignedTeamMember, 1);
                LoadTheme();
                _unassignedEmployees = LoadTeamMembers(0);
                lstTeamMembers.DataSource = _unassignedEmployees;
                lstTeamMembers.ValueMember = "UserId";
                lstTeamMembers.DisplayMember = "EmpName";
                _assignedEmployees = LoadTeamMembers(1);
                lstAssignedTeamMember.DataSource = _assignedEmployees;
                lstAssignedTeamMember.ValueMember = "UserId";
                lstAssignedTeamMember.DisplayMember = "EmpName";
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Team Register Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
                lblAvailableTeamMember.ForeColor = ThemeColor.SecondaryColor;
                lblAssignedTeamMember.ForeColor = ThemeColor.SecondaryColor;
                btnSave.ForeColor = ThemeColor.SecondaryColor;
                btnCancel.ForeColor = ThemeColor.SecondaryColor;
                grpBoxRegistrationForm.ForeColor = ThemeColor.PrimaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        //private void LoadTeamMembers(ListBox listBox, int flag)
        //{
        //    try
        //    {
        //        DataTable dataTable = teamManagement.GetProjectMemberByProjectId(UserInfo.projectID, flag);
                
        //        if (listBox == lstTeamMembers)
        //        {
        //            foreach (DataRow row in dataTable.Rows)
        //            {
        //                Employee employee = new Employee();
        //                employee.UserId = row[0].ToString();
        //                employee.EmpName = row[1].ToString();
        //                unassignedEmployees.Add(employee);
        //            }
        //            listBox.DataSource = unassignedEmployees;
        //            listBox.ValueMember = "UserId";
        //            listBox.DisplayMember = "EmpName";
        //        }
        //        if (listBox == lstAssignedTeamMember)
        //        {
        //            foreach (DataRow row in dataTable.Rows)
        //            {
        //                Employee employee = new Employee();
        //                employee.UserId = row[0].ToString();
        //                employee.EmpName = row[1].ToString();
        //                assignedEmployees.Add(employee);
        //            }
        //            listBox.DataSource = assignedEmployees;
        //            listBox.ValueMember = "UserId";
        //            listBox.DisplayMember = "EmpName";
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("TMSError - Failed to load the team members!!\n" + ex.Message, ex.InnerException);
        //    }
        //}

        //private void LoadTeamMembers(ListBox listBox, int flag)
        //{
        //    try
        //    {
        //            DataTable dataTable = teamManagement.GetProjectMemberByProjectId(UserInfo.projectID, flag);
        //            listBox.DataSource = dataTable;
        //            listBox.ValueMember = "UserId";
        //            listBox.DisplayMember = "EmpName";
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("TMSError - Failed to load the team members!!\n" + ex.Message, ex.InnerException);
        //    }
        //}
        private BindingList<Employee> LoadTeamMembers(int flag)
        {
            try
            {
                System.Data.DataTable dataTable = teamManagement.GetProjectMemberByProjectId(UserInfo.projectID, flag);
                List<Employee> empList = new List<Employee>();

                foreach (DataRow row in dataTable.Rows)
                {
                    Employee employee = new Employee();
                    employee.UserId = row["UserId"].ToString();
                    employee.EmpName = row["EmployeeName"].ToString();
                    empList.Add(employee);
                }
                return new BindingList<Employee>(empList);

            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the team members!!\n" + ex.Message, ex.InnerException);
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            try
            { 
                //AddUpdateListBoxItem(lstTeamMembers);
                MoveSelectedItem(lstTeamMembers, _unassignedEmployees, lstAssignedTeamMember, _assignedEmployees);
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform add items in list operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            try
            {
                //AddUpdateListBoxItem(lstAssignedTeamMember);
                MoveSelectedItem(lstAssignedTeamMember, _assignedEmployees, lstTeamMembers, _unassignedEmployees);

            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform remove items in list operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        //private void AddUpdateListBoxItem(ListBox lstbox)
        //{
        //    string SelectedUserId;
        //    string SelectedUserName;
        //    foreach (var item in lstbox.SelectedItems)
        //    {
        //        SelectedUserId = ((DataRowView)item).Row["UserId"].ToString();
        //        SelectedUserName = ((DataRowView)item).Row["EmployeeName"].ToString();
        //        teamManagement.AssignedProjectMember(Convert.ToInt32(UserInfo.projectID), SelectedUserId);
        //        // To load available team members:
        //        LoadTeamMembers(lstTeamMembers, 0);
        //        // To load assigned team members:
        //        LoadTeamMembers(lstAssignedTeamMember, 1);
        //    }
        //}
        //private void AddUpdateListBoxItem(ListBox lstbox)
        //{
        //    List<Employee> EmployeesToAdd = new List<Employee>();
        //    List<Employee> EmployeesToRemove = new List<Employee>();
        //    foreach (int i in lstbox.SelectedIndices)
        //    {
        //        Employee selectedEmployee = lstbox.Items[i] as Employee;
        //        if (selectedEmployee != null)
        //        {
        //            EmployeesToAdd.Add(selectedEmployee);
        //            EmployeesToRemove.Add(selectedEmployee);
        //        }
        //    }
        //    foreach (Employee employee in EmployeesToAdd)
        //    {
        //        assignedEmployees.Add(employee);
        //        unassignedEmployees.Remove(employee);
        //    }
        //    // Rebind the ListBox controls
        //    lstTeamMembers.DataSource = unassignedEmployees;
        //    lstAssignedTeamMember.DataSource = assignedEmployees;
        //    lstAssignedTeamMember.DisplayMember = "EmpName";
        //    lstAssignedTeamMember.ValueMember = "UserId";
        //}
        private void MoveSelectedItem(ListBox srcListBox, BindingList<Employee> srcBindingList, ListBox dstListBox, BindingList<Employee> dstBindingList)
        {
            if (srcListBox.SelectedIndex != -1)
            {
                Employee selectedItem = (Employee)srcListBox.SelectedItem;
                dstBindingList.Add(selectedItem);
                srcBindingList.Remove(selectedItem);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //// To load available team members:
            //LoadTeamMembers(lstTeamMembers, 0);
            //// To load assigned team members:
            //LoadTeamMembers(lstAssignedTeamMember, 1);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
