using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using TMS.MDI;
using TMS.UI.Wait;
using TMS.UI.Utilities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;

namespace TMS.UI
{
    public partial class Login : Form
    {
        Settings settings = new Settings();
        Operations operations = new Operations();
        WaitForm waitForm = new WaitForm();

        public Login()
        {
            InitializeComponent();
           
        }
       
        private void Login_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
            Focustxtusername();
        }
       
        private void txtUserName_Click(object sender, EventArgs e)
        {
            Focustxtusername();
        }
      
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
       
        private void txtUserName_Leave(object sender, EventArgs e)
        {
            Focustxtpwd();
        }
       
        private void txtPwd_Click(object sender, EventArgs e)
        {
            Focustxtpwd();
        }
      
        private void pbPwdIcon_MouseDown(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = false;
        }
        
        private void pbPwdIcon_MouseUp(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = true;
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //waitForm.Show(this);
                //Thread.Sleep(50);
                DoLogin();
                //waitForm.Close();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Login Failed!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        public void DoLogin()
        {
            if (txtUserName.Text == "")
            {
                Focustxtusername();
                txtUserName.Select();
                PopupMessageBox.Show("Please enter Employee ID!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPwd.Text == "")
            {
                PopupMessageBox.Show("Please enter the Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Select();
                return;
            }
            if (settings.CheckLogin(FormControlHandling.ClearUpperQmark(txtUserName.Text), operations.Encrypt(txtPwd.Text)) == true)
            {
                var frm = new FormMainMenu(txtUserName.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                PopupMessageBox.Show("Invalid Employee ID or Password!!", "TMS", MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    
        public void Focustxtusername()
        {
            txtUserName.BackColor = Color.White;
            pnlUsrName.BackColor = Color.White;
            pnlPwd.BackColor = SystemColors.Control;
            txtPwd.BackColor = SystemColors.Control;
        }
       
        public void Focustxtpwd()
        {
            txtPwd.BackColor = Color.White;
            pnlPwd.BackColor = Color.White;
            txtUserName.BackColor = SystemColors.Control;
            pnlUsrName.BackColor = SystemColors.Control;
        }
    }
}
