using System;
using System.Data;
using System.Windows.Forms;
using TMS.BusinessLogicLayer;
using TMS.UI.Utilities;
using TMS.UI.CustomMessageBox;

namespace TMS.UI
{
    public partial class ChangePassword : Form
    {
        Settings settings = new Settings();
        Operations operations = new Operations();
       
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void picOldPwd_MouseDown(object sender, MouseEventArgs e)
        {
            txtOldPwd.UseSystemPasswordChar = false;
        }

        private void picNewPwd_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPwd.UseSystemPasswordChar = false;
        }

        private void picNewConfirmPwd_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewConfirmPwd.UseSystemPasswordChar = false;
        }

        private void picOldPwd_MouseUp(object sender, MouseEventArgs e)
        {
            txtOldPwd.UseSystemPasswordChar = true;
        }

        private void picNewPwd_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPwd.UseSystemPasswordChar = true;
        }

        private void picNewConfirmPwd_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewConfirmPwd.UseSystemPasswordChar = true;
        }



        private void txtOldPwd_MouseEnter(object sender, EventArgs e)
        {

            if (txtOldPwd.Text == "Type your old Password" && txtOldPwd.Text != "")
            {
                txtOldPwd.UseSystemPasswordChar = true;
                txtOldPwd.Text = "";
            }

        }

        private void txtOldPwd_MouseLeave(object sender, EventArgs e)
        {
            if (txtOldPwd.Text == "")
            {
                txtOldPwd.UseSystemPasswordChar = false;
                txtOldPwd.Text = "Type your old Password";

            }
        }

        private void txtNewPwd_MouseEnter(object sender, EventArgs e)
        {

            if (txtNewPwd.Text == "Type your New Password" && txtNewPwd.Text != "")
            {
                txtNewPwd.UseSystemPasswordChar = true;
                txtNewPwd.Text = "";
            }
        }

        private void txtNewPwd_MouseLeave(object sender, EventArgs e)
        {
            if (txtNewPwd.Text == "")
            {
                txtNewPwd.UseSystemPasswordChar = false;
                txtNewPwd.Text = "Type your New Password";

            }
        }

        private void txtNewConfirmPwd_MouseEnter(object sender, EventArgs e)
        {

            if (txtNewConfirmPwd.Text == "Type your Confirm Password" && txtNewConfirmPwd.Text != "")
            {
                txtNewConfirmPwd.UseSystemPasswordChar = true;
                txtNewConfirmPwd.Text = "";
            }
        }

        private void txtNewConfirmPwd_MouseLeave(object sender, EventArgs e)
        {
            if (txtNewConfirmPwd.Text == "")
            {
                txtNewConfirmPwd.UseSystemPasswordChar = false;
                txtNewConfirmPwd.Text = "Type your Confirm Password";

            }
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            try
            {
                string empid;
                empid = Global.GlobalVar;
                if (txtOldPwd.Text == "Type your old Password")
                {
                    
                    PopupMessageBox.Show("Please enter your old Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtOldPwd.Select();
                    return;
                }
                if (txtNewPwd.Text == "Type your New Password")
                {
                    PopupMessageBox.Show("Please enter your New Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNewPwd.Select();
                    return;
                }
                if (txtNewConfirmPwd.Text == "Type your Confirm Password")
                {
                    PopupMessageBox.Show("Please enter Confirm Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNewConfirmPwd.Select();
                    return;

                    //Dear "+ obj.GetEmpnameandID("Employee","EmpName",int.Parse(Global.GlobalVar)) +"..
                }
                if (settings.CheckLogin(FormControlHandling.ClearUpperQmark(Global.GlobalVar), operations.Encrypt(txtOldPwd.Text)) == true)
                {
                    if (txtNewPwd.Text == txtNewConfirmPwd.Text)
                    {
                        int temp = settings.ChangePwd(Global.GlobalVar, operations.Encrypt(txtNewConfirmPwd.Text));
                        if (temp != 0)
                        {
                            FormControlHandling.ClearControls(grpBoxChangePwd);
                            PopupMessageBox.Show("Password Changed Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            FormControlHandling.ClearControls(grpBoxChangePwd);
                            PopupMessageBox.Show("There was some issue changing the password", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        PopupMessageBox.Show("New Password and Confirm Password does not match!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNewConfirmPwd.Text = "";
                        txtNewConfirmPwd.Select();
                    }
                }
                else
                {
                    PopupMessageBox.Show("Invalid Old Password!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOldPwd.Select();
                }

            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
