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
                // To load available team members:
                LoadTeamMembers(lstTeamMembers, 0);
                // To load assigned team members:
                LoadTeamMembers(lstAssignedTeamMember, 1);
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
                lstTeamMembers.BackColor = ThemeColor.PrimaryColor;
                lstAssignedTeamMember.BackColor = ThemeColor.PrimaryColor;
                grpBoxRegistrationForm.ForeColor = ThemeColor.PrimaryColor;
             
                
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }

        }
        private void LoadTeamMembers(ListBox listBox, int flag)
        {
            try
            {
                DataTable dataTable = teamManagement.GetProjectMemberByProjectId(UserInfo.projectID, flag);
                listBox.DataSource = dataTable;
                listBox.ValueMember = "UserId";
                listBox.DisplayMember = "EmployeeName";
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the team members!!\n" + ex.Message, ex.InnerException);
            }
        }

        private void btnArrowRight_Click(object sender, EventArgs e)
        {
            try
            {
                AddUpdateListBoxItem(lstTeamMembers);
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
                AddUpdateListBoxItem(lstAssignedTeamMember);
               
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform save/modify operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        private void AddUpdateListBoxItem(ListBox lstbox)
        {
            string SelectedUserId;
            string SelectedUserName;
            foreach (var item in lstbox.SelectedItems)
            {
                SelectedUserId = ((DataRowView)item).Row["UserId"].ToString();
                SelectedUserName = ((DataRowView)item).Row["EmployeeName"].ToString();
                teamManagement.AssignedProjectMember(Convert.ToInt32(UserInfo.projectID), SelectedUserId);
                // To load available team members:
                LoadTeamMembers(lstTeamMembers, 0);
                // To load assigned team members:
                LoadTeamMembers(lstAssignedTeamMember, 1);
            }
        }
    }
}
