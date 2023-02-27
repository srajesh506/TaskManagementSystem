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
    public partial class AddRole : Form
    {
        TeamManagement teamManagement = new TeamManagement();
        Role role = new Role();

        public AddRole()
        {
            InitializeComponent();
         
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
            btnAddRole.ForeColor = ThemeColor.SecondaryColor;
            lblRole.BackColor = ThemeColor.SecondaryColor;
            txtRole.ForeColor = ThemeColor.SecondaryColor;
        }
       
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRole.Text != "")
                {
                    DataTable dataTable = new DataTable();
                    dataTable = teamManagement.GetRoles(txtRole.Text);
                    if (dataTable.Rows.Count <= 0)
                    {
                        role.RoleName = txtRole.Text;
                        role.IsAdmin = true;
                        int returnvalue = teamManagement.AddRole(role);
                        if (returnvalue > 0)
                        {
                            PopupMessageBox.Show("Data Saved Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtRole.Text = "";
                        }
                        else
                        {
                            PopupMessageBox.Show("Error Adding new role!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        PopupMessageBox.Show("Role: '" + txtRole.Text + "' already exists in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    PopupMessageBox.Show("Please Enter RoleName!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in adding new Role!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void AddRole_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTheme();
                lblCaption.Text = "Add Role";
            }
            catch(Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
