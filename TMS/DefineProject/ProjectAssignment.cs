using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TMS.UI.Utilities;
using TMS.BusinessEntities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;
using System.Collections.Generic;
using System.ComponentModel;

namespace TMS.UI
{
    public partial class ProjectAssignment : Form
    {
        private BindingList<Employee> _unassignedEmployees;
        private BindingList<Employee> _assignedEmployees;
        private List<Employee> _unassignedEmployeesChangedList = new List<Employee>();
        private List<Employee> _assignedEmployeesChangedList = new List<Employee>();
        TeamManagement teamManagement = new TeamManagement();
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
                LoadTheme();
                LoadTeamMembers();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Team Register Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTeamMembers()
        {
            _unassignedEmployees = LoadTeamMembers(0);
            _unassignedEmployees.ListChanged += _unassignedEmployees_ListChanged;
            lstTeamMembers.DataSource = _unassignedEmployees;
            lstTeamMembers.ValueMember = "UserId";
            lstTeamMembers.DisplayMember = "EmpName";
            _assignedEmployees = LoadTeamMembers(1);
            _assignedEmployees.ListChanged += _assignedEmployees_ListChanged;
            lstAssignedTeamMember.DataSource = _assignedEmployees;
            lstAssignedTeamMember.ValueMember = "UserId";
            lstAssignedTeamMember.DisplayMember = "EmpName";
        }
        private void _assignedEmployees_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    break;
                case ListChangedType.ItemAdded:
                    Employee addedItem = _assignedEmployees[e.NewIndex];
                    _assignedEmployeesChangedList.Add(addedItem);
                    break;
                case ListChangedType.ItemDeleted:
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.ItemChanged:
                    break;
                case ListChangedType.PropertyDescriptorAdded:
                    break;
                case ListChangedType.PropertyDescriptorDeleted:
                    break;
                case ListChangedType.PropertyDescriptorChanged:
                    break;
                default:
                    break;
            }
        }
        private void _unassignedEmployees_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    break;
                case ListChangedType.ItemAdded:
                    Employee addedItem = _unassignedEmployees[e.NewIndex];
                    _unassignedEmployeesChangedList.Add(addedItem);
                    break;
                case ListChangedType.ItemDeleted:
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.ItemChanged:
                    break;
                case ListChangedType.PropertyDescriptorAdded:
                    break;
                case ListChangedType.PropertyDescriptorDeleted:
                    break;
                case ListChangedType.PropertyDescriptorChanged:
                    break;
                default:
                    break;
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
                grpBoxProjectAssignmentForm.ForeColor = ThemeColor.PrimaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        private BindingList<Employee> LoadTeamMembers(int flag)
        {
            try
            {
                DataTable projectMember = teamManagement.GetProjectMemberByProjectId(UserInfo.ProjectId, flag);
                List<Employee> empList = new List<Employee>();

                foreach (DataRow row in projectMember.Rows)
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
                MoveSelectedItem(lstAssignedTeamMember, _assignedEmployees, lstTeamMembers, _unassignedEmployees);
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform remove items in list operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        private void MoveSelectedItem(ListBox srcListBox, BindingList<Employee> srcBindingList, ListBox dstListBox, BindingList<Employee> dstBindingList)
        {
            List<Employee> selectedEmployees = new List<Employee>();
            foreach (int i in srcListBox.SelectedIndices)
            {
                Employee selectedEmployee = srcListBox.Items[i] as Employee;
                if (selectedEmployee != null)
                {
                    selectedEmployees.Add(selectedEmployee);
                }
            }
            foreach (Employee emp in selectedEmployees)
            {
                dstBindingList.Add(emp);
                srcBindingList.Remove(emp);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTeamMembers();
                RightBottomMessageBox.warning("Operation Cancelled!");
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform save/modify operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                AddUpdateAssignment();
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform save/modify operation!! \n" + ex.Message + "\n", ex.InnerException);
            }

        }
        private void AddUpdateAssignment()
        {
            if (_unassignedEmployeesChangedList != null || _assignedEmployeesChangedList != null)
            {
                if (_unassignedEmployeesChangedList != null)
                {
                    foreach (Employee emp in _unassignedEmployeesChangedList)
                    {
                        teamManagement.AssignedProjectMember(Convert.ToInt32(UserInfo.ProjectId), emp.UserId);
                    }
                    _unassignedEmployeesChangedList.Clear();
                }
                if (_assignedEmployeesChangedList != null)
                {
                    foreach (Employee emp in _assignedEmployeesChangedList)
                    {
                        teamManagement.AssignedProjectMember(Convert.ToInt32(UserInfo.ProjectId), emp.UserId);
                    }
                    _assignedEmployeesChangedList.Clear();
                }
                LoadTeamMembers();
                RightBottomMessageBox.Success("Data saved Successfully!");
            }
        }
    }
}
