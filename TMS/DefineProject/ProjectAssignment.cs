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
                LoadAssignedTeamMember();
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
        private void LoadAssignedTeamMember()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = teamManagement.GetProjectMemberByProjectId(UserInfo.projectID,flag:1);
                lstAssignedTeamMember.DataSource = dataTable;
                lstAssignedTeamMember.ValueMember = "UserId";
                lstAssignedTeamMember.DisplayMember = "EmployeeName";
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to Load the Roles!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        private void btnArrowRight_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedUserId;
                string SelectedUserName;
                foreach (var item in lstTeamMembers.SelectedItems)
                {
                    SelectedUserId = ((DataRowView)item).Row["UserId"].ToString();
                    SelectedUserName = ((DataRowView)item).Row["EmployeeName"].ToString();
                    teamManagement.AssignedProjectMember(Convert.ToInt32(UserInfo.projectID), SelectedUserId);
                    LoadAssignedTeamMember();
                    LoadAvailableTeamMember();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform save/modify operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        private void btnArrowLeft_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedUserId;
                string SelectedUserName;
                foreach (var item in lstAssignedTeamMember.SelectedItems)
                {
                    SelectedUserId = ((DataRowView)item).Row["UserId"].ToString();
                    SelectedUserName = ((DataRowView)item).Row["EmployeeName"].ToString();
                    teamManagement.AssignedProjectMember(Convert.ToInt32(UserInfo.projectID), SelectedUserId);
                    LoadAssignedTeamMember();
                    LoadAvailableTeamMember();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform save/modify operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
    }
}
