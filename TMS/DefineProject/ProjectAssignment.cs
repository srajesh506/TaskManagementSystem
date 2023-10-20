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
    public partial class ProjectAssignment : Form
    {
       

        private DataTable _employees;

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
                LoadTheme();
                LoadProject();
                LoadAvailableTeamMember();
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
                lblProject.ForeColor = ThemeColor.SecondaryColor;
                grpBoxRegistrationForm.ForeColor = ThemeColor.PrimaryColor;
             
                
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }

        }

        // Function to Load the Roles in the Form Combobox.
        private void LoadProject()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = teamManagement.GetRoles("Project");
                DataRow dataRow = dataTable.NewRow();
                dataRow.ItemArray = new object[] { 0, "--Select Project--" };
                dataTable.Rows.InsertAt(dataRow, 0);
                cmbProject.ValueMember = "RoleId";
                cmbProject.DisplayMember = "RoleName";
                cmbProject.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to Load the Roles!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        private void LoadAvailableTeamMember()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = teamManagement.GetProjectMemberByProjectId(UserInfo.projectID);
                lstTeamMembers.DataSource = dataTable;
                lstTeamMembers.ValueMember = "UserId";
                lstTeamMembers.DisplayMember= "EmployeeName";
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to Load the Roles!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        //Function to perform new Employee addition and existing Employee update
        private void SaveModifyEmployeesData(String mode)
        {
            try
            {
                //if (ValidateControls(mode))
                //{

                //    employee.UserId = txt.Text;
                //    employee.EmpName = txtProjectName.Text;
                //    employee.RoleId = cmbRole.SelectedIndex;
                //    employee.Remark = rtxtProjectDescription.Text;
                //    employee.IsActive = chkActive.Checked;
                    switch (mode)
                    {
                        case "S":
                            if (teamManagement.AddUpdateEmployee(employee) <= 0)
                            {
                                //throw new Exception("TMSError - User ID: '" + txt.Text + "' already exists in Database!! ");
                            }
                            break;
                        case "M":
                            if (teamManagement.AddUpdateEmployee(employee, true) <= 0)
                            {
                                //throw new Exception("TMSError - User ID: '" + txt.Text + "' does not exist in Database!! ");
                            }
                            break;
                        default:
                            throw new Exception("TMSError - Invalid Operation!! ");
                    }
                //    _currentPage = 1;               //Freshly Load the grid with Page 1
                //    LoadEmployeesDataGrid(true);    //True flag to make DB call for refreshing the grid
                //    FormControlHandling.ClearControls(grpBoxRegistrationForm);
                //    EnableDisableButtons(2);
                //    if (mode == "S")
                //        RightBottomMessageBox.Success("Data saved Successfully!");
                //    else
                //        RightBottomMessageBox.Info("Data modify Successfully!");
                //}
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform save/modify operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        private void btnArrowRight_Click(object sender, EventArgs e)
        {
            SaveModifyEmployeesData("S");  // S for Add
        }

        private void btnArrowLeft_Click(object sender, EventArgs e)
        {
            SaveModifyEmployeesData("R"); //R for Remove
        }
    }
}
