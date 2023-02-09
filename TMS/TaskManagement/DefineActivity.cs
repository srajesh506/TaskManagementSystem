using System;
using System.Drawing;
using System.Windows.Forms;
using TMS.BusinessLogicLayer;
using TMS.BusinessEntities;
using TMS.UI.Utilities;
using TMS.UI.CustomMessageBox;
using TMS.UI;

namespace TMS.UI
{
    public partial class DefineActivity : UserControl
    {
        static int activityid;

        TMS.BusinessLogicLayer.TaskManagement taskManagement = new TMS.BusinessLogicLayer.TaskManagement();
        Activity activity = new Activity();
        public DefineActivity()
        {
            InitializeComponent();
            LoadTheme();
            EnableDisableButtons(2);
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
            btnAdd.ForeColor = ThemeColor.PrimaryColor;
            btnSave.ForeColor = ThemeColor.PrimaryColor;
            btnModify.ForeColor = ThemeColor.PrimaryColor;
            btnCancel.ForeColor = ThemeColor.PrimaryColor;
            //lblremark.ForeColor = ThemeColor.SecondaryColor;
            gbxTaskManagement.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
            txtTaskName.ForeColor = ThemeColor.SecondaryColor;
            rtxtRemark.ForeColor = ThemeColor.SecondaryColor;
            chkActive.ForeColor = ThemeColor.SecondaryColor;
        }
        public void EnableDisableButtons(int flag)
        {
            if (flag == 0) //
            {
                btnSave.Enabled = false;
                btnModify.Enabled = false;
                btnCancel.Enabled = false;

            }
            if (flag == 1) //Add Data
            {
                txtTaskName.Enabled = true;
                txtTaskName.Enabled = true;
                txtTaskName.Select();
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                rtxtRemark.Enabled = true;
                btnAdd.Enabled = false;
            }
            if (flag == 2)//modify and Cancel
            {
                txtTaskName.Enabled = false;
                rtxtRemark.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnModify.Enabled = false;
                btnAdd.Enabled = true;
            }
            if (flag == 3)
            {
                txtTaskName.Enabled = true;
                rtxtRemark.Enabled = true;
                btnAdd.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = true;
                btnModify.Enabled = true;
                //txttaskName.Enabled = false;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            EnableDisableButtons(1);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            FormControlHandling.ClearControls(gbxTaskManagement);
            EnableDisableButtons(2);
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Validation();
                if (val == 1) return;
                activity.ActivityId = activityid;
                activity.ActivityName = txtTaskName.Text;
                activity.ActivityDescription = rtxtRemark.Text;
                activity.IsActive = chkActive.Checked;
                int returnvalue = taskManagement. AddUpdateActivity(activity,true);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("Activity: '" + txtTaskName.Text + "' doesnt exist in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GetAllData();
                    FormControlHandling.ClearControls(gbxTaskManagement);
                    EnableDisableButtons(2);
                    RightBottomMessageBox.Info("Data modify Successfully!");
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                int val=Validation();
                if (val == 1) return;
                if (chkActive.Checked == false)
                {
                    PopupMessageBox.Show("Please Confirm Active Activity!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                activity.ActivityName = txtTaskName.Text;
                activity.ActivityDescription = rtxtRemark.Text;
                activity.IsActive=chkActive.Checked;
                int returnvalue = taskManagement.AddUpdateActivity(activity);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("Activity: '" + txtTaskName.Text + "' already exists in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GetAllData();
                    FormControlHandling.ClearControls(gbxTaskManagement);
                    EnableDisableButtons(2);
                    RightBottomMessageBox.Success("Data Saved Successfully!");
                }
           }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetAllData()
        {
            Dview.DataSource = null;
            Dview.DataSource = taskManagement.GetActivities(true);
            Dview.Columns[0].Width = 150;
            Dview.Columns[1].Width = 400;
            Dview.Columns[2].Width = 500;
            Dview.Columns[3].Visible = false;
            Dview.Columns[4].Visible = false;
            Dview.ReadOnly = true;

        }

        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                activityid = 0;
                int index = Dview.CurrentRow.Index;
                if (index <= Dview.RowCount - 1)
                {

                    txtTaskName.Text = Convert.ToString(Dview.Rows[index].Cells[1].Value);
                    rtxtRemark.Text = Convert.ToString(Dview.Rows[index].Cells[2].Value);
                    activityid = Convert.ToInt32(Dview.Rows[index].Cells[0].Value);
                    chkActive.Checked = Convert.ToBoolean(Dview.Rows[index].Cells[3].Value);
                    EnableDisableButtons(3);
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public int Validation()
        {
            if (txtTaskName.Text == "")
            {
                PopupMessageBox.Show("Please enter Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaskName.Select();
                return 1;
            }
            if (rtxtRemark.Text == "")
            {
                PopupMessageBox.Show("Please enter Activity Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxtRemark.Select();
                return 1;
            }
            return 0;
        }
    }
}
