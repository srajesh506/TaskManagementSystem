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
            btnadd.ForeColor = ThemeColor.PrimaryColor;
            btnsave.ForeColor = ThemeColor.PrimaryColor;
            btnmodify.ForeColor = ThemeColor.PrimaryColor;
            btncancel.ForeColor = ThemeColor.PrimaryColor;
            //lblremark.ForeColor = ThemeColor.SecondaryColor;
            gbxtaskmanagement.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
            txttaskName.ForeColor = ThemeColor.SecondaryColor;
            rtxtremark.ForeColor = ThemeColor.SecondaryColor;
            chkactive.ForeColor = ThemeColor.SecondaryColor;
        }
        public void EnableDisableButtons(int flag)
        {
            if (flag == 0) //
            {
                btnsave.Enabled = false;
                btnmodify.Enabled = false;
                btncancel.Enabled = false;

            }
            if (flag == 1) //Add Data
            {
                txttaskName.Enabled = true;
                txttaskName.Enabled = true;
                txttaskName.Select();
                btnsave.Enabled = true;
                btncancel.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
            }
            if (flag == 2)//modify and Cancel
            {
                txttaskName.Enabled = false;
                rtxtremark.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = false;
                btnmodify.Enabled = false;
                btnadd.Enabled = true;
            }
            if (flag == 3)
            {
                txttaskName.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = true;
                btnmodify.Enabled = true;
                //txttaskName.Enabled = false;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            EnableDisableButtons(1);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            FormControlHandling.ClearControls(gbxtaskmanagement);
            EnableDisableButtons(2);
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Validation();
                if (val == 1) return;
                activity.ActivityId = activityid;
                activity.ActivityName = txttaskName.Text;
                activity.ActivityDescription = rtxtremark.Text;
                activity.IsActive = chkactive.Checked;
                int returnvalue = taskManagement. AddUpdateActivity(activity,true);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("Activity: '" + txttaskName.Text + "' doesnt exist in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GetAllData();
                    FormControlHandling.ClearControls(gbxtaskmanagement);
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
                if (chkactive.Checked == false)
                {
                    PopupMessageBox.Show("Please Confirm Active Activity!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                activity.ActivityName = txttaskName.Text;
                activity.ActivityDescription = rtxtremark.Text;
                activity.IsActive=chkactive.Checked;
                int returnvalue = taskManagement.AddUpdateActivity(activity);
                if (returnvalue <= 0)
                {
                    PopupMessageBox.Show("Activity: '" + txttaskName.Text + "' already exists in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GetAllData();
                    FormControlHandling.ClearControls(gbxtaskmanagement);
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
            dview.DataSource = null;
            dview.DataSource = taskManagement.GetActivities(true);
            dview.Columns[0].Width = 150;
            dview.Columns[1].Width = 400;
            dview.Columns[2].Width = 500;
            dview.Columns[3].Visible = false;
            dview.Columns[4].Visible = false;
            dview.ReadOnly = true;

        }

        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                activityid = 0;
                int index = dview.CurrentRow.Index;
                if (index <= dview.RowCount - 1)
                {

                    txttaskName.Text = Convert.ToString(dview.Rows[index].Cells[1].Value);
                    rtxtremark.Text = Convert.ToString(dview.Rows[index].Cells[2].Value);
                    activityid = Convert.ToInt32(dview.Rows[index].Cells[0].Value);
                    chkactive.Checked = Convert.ToBoolean(dview.Rows[index].Cells[3].Value);
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
            if (txttaskName.Text == "")
            {
                PopupMessageBox.Show("Please enter Activity Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttaskName.Select();
                return 1;
            }
            if (rtxtremark.Text == "")
            {
                PopupMessageBox.Show("Please enter Activity Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxtremark.Select();
                return 1;
            }
            return 0;
        }
    }
}
