using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TMS.BusinessEntities;
using TMS.BusinessLogicLayer;
using TMS.UI.Utilities;
using TMS.UI.CustomMessageBox;

namespace TMS.UI
{
    public partial class FrmTeamRegister : Form
    {
        Employee employee = new Employee();
        TeamManagement teamManagement = new TeamManagement();
        Operations operations = new Operations();
        public FrmTeamRegister()
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
            lblReg.BackColor = ThemeColor.SecondaryColor;
            lblUserId.ForeColor = ThemeColor.SecondaryColor;
            lblName.ForeColor = ThemeColor.SecondaryColor;
            lblRole.ForeColor = ThemeColor.SecondaryColor;
            lblEmail.ForeColor = ThemeColor.SecondaryColor;
            lblRemark.ForeColor = ThemeColor.SecondaryColor;
            grpBoxRegistrationForm.ForeColor = ThemeColor.PrimaryColor;
            grpBoxButtons.ForeColor = ThemeColor.PrimaryColor;
            grpBoxEmployeeGridView.ForeColor = ThemeColor.PrimaryColor;
            chkActive.ForeColor = ThemeColor.SecondaryColor;
            txtUserId.ForeColor = ThemeColor.SecondaryColor;
            txtName.ForeColor = ThemeColor.SecondaryColor;
            txtEmail.ForeColor = ThemeColor.SecondaryColor;
            rtxtRemark.ForeColor = ThemeColor.SecondaryColor;
            txtPwd.ForeColor = ThemeColor.SecondaryColor;
            btnUpload.BackColor = ThemeColor.PrimaryColor;
            btnUpload.ForeColor = ThemeColor.SecondaryColor;
            cmbRole.ForeColor = ThemeColor.SecondaryColor;
        }
        private void LoadRoles()
        {
            DataTable dt = new DataTable();
            dt = teamManagement.GetRoles();
            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Role--" };
            dt.Rows.InsertAt(dr, 0);
            cmbRole.ValueMember = "RoleId";
            cmbRole.DisplayMember = "RoleName";
            cmbRole.DataSource = dt;
        }
        private void FrmTeamRegister_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EnableDisableButtons(int flag)
        {
            if (flag == 0) //
            {
                btnSave.Enabled = false;
                btnModify.Enabled = false;
                btnCancel.Enabled = false;
                btnAddRole.Enabled = false;
            }
            if (flag == 1) //Add Data
            {
                txtUserId.Enabled = true;
                txtUserId.Enabled = true;
                txtUserId.Select();
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnAddRole.Enabled = true;

                txtName.Enabled = true;
                cmbRole.Enabled = true;
                txtEmail.Enabled = true;
                rtxtRemark.Enabled = true;
                txtPwd.Enabled = true;
                btnAdd.Enabled = false;
            }
            if (flag == 2)//modify and Cancel
            {
                txtUserId.Enabled = false;
                txtName.Enabled = false;
                cmbRole.Enabled = false;
                txtEmail.Enabled = false;
                rtxtRemark.Enabled = false;
                txtPwd.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnModify.Enabled = false;
                btnAdd.Enabled = true;
                btnAddRole.Enabled = false;
            }
            if (flag == 3)
            {
                txtUserId.Enabled = true;
                txtName.Enabled = true;
                cmbRole.Enabled = true;
                txtEmail.Enabled = true;
                rtxtRemark.Enabled = true;
                txtPwd.Enabled = true;
                btnAdd.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = true;
                btnModify.Enabled = true;
                txtUserId.Enabled = false;
            }
        }
        public void GetAllData()
        {
            dgView.DataSource = null;
            dgView.DataSource = teamManagement.GetEmployeesRoles();
            dgView.Columns[0].Width = 150;
            dgView.Columns[1].Width = 200;
            dgView.Columns[2].Width = 150;
            dgView.Columns[3].Width = 300;
            dgView.Columns[4].Width = 300;
            dgView.Columns[5].Visible = false;
            dgView.Columns[6].Visible = false;
            dgView.Columns[7].Visible = false;
            dgView.Columns[8].Visible = false;
            dgView.ReadOnly = true;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableDisableButtons(1);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateControls())
                {

                    if (chkActive.Checked == false)
                    {
                        PopupMessageBox.Show("Please Confirm Active Member!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (!File.Exists(Application.StartupPath + "\\Image\\" + txtUserId.Text + ".jpg"))
                    {

                        if (pbPic.Image != null)
                        {
                            using (Bitmap bmb = new Bitmap(pbPic.Image))
                            {
                                //pictureBox1.Image.SaveApplication.StartupPath + "\\Image\\" + maxid + ".jpg");
                                MemoryStream m = new MemoryStream();
                                bmb.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                            using (Bitmap bmb = (Bitmap)pbPic.Image.Clone())
                            {
                                bmb.Save(Application.StartupPath + "\\Image\\" + txtUserId.Text + ".jpg", bmb.RawFormat);
                            }

                        }
                    }
                    employee.UserId = txtUserId.Text;
                    employee.EmpName = txtName.Text;
                    employee.RoleId = cmbRole.SelectedIndex;
                    employee.Email = txtEmail.Text;
                    employee.Remark = rtxtRemark.Text;
                    employee.IsActive = chkActive.Checked;
                    employee.Password = operations.Encrypt(txtPwd.Text);
                    employee.Pic = pbPic.Image == null ? null : txtUserId.Text + ".jpg";
                    int returnvalue = teamManagement.AddUpdateEmployee(employee);
                    if (returnvalue <= 0)
                    {
                        PopupMessageBox.Show("Employee ID: '" + txtUserId.Text + "' already exit in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        GetAllData();
                        FormControlHandling.ClearControls(grpBoxRegistrationForm);
                        //MessageBox.Show("Data Saved Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RightBottomMessageBox.Success("Data Saved Successfully!");

                    }
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateControls())
                {
                    if (!File.Exists(Application.StartupPath + "\\Image\\" + txtUserId.Text + ".jpg"))
                    {
                        if (pbPic.Image != null)
                        {
                            using (Bitmap bmb = new Bitmap(pbPic.Image))
                            {
                                MemoryStream m = new MemoryStream();
                                bmb.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                                pbPic.Image = Image.FromStream(m);
                            }
                            using (Bitmap bmb = (Bitmap)pbPic.Image.Clone())
                            {
                                bmb.Save(Application.StartupPath + "\\Image\\" + txtUserId.Text + ".jpg", bmb.RawFormat);
                            }
                        }
                    }

                    employee.UserId = txtUserId.Text;
                    employee.EmpName = txtName.Text;
                    employee.RoleId = cmbRole.SelectedIndex;
                    employee.Email = txtEmail.Text;
                    employee.Remark = rtxtRemark.Text;
                    employee.IsActive = chkActive.Checked;
                    employee.Password = operations.Encrypt(txtPwd.Text);
                    employee.Pic = pbPic.Image == null ? null : txtUserId.Text + ".jpg";
                    int returnvalue = teamManagement.AddUpdateEmployee(employee, true);
                    if (returnvalue <= 0)
                    {
                        PopupMessageBox.Show("User ID: '" + txtUserId.Text + "' does not exist in Database!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        GetAllData();
                        FormControlHandling.ClearControls(grpBoxRegistrationForm);
                        EnableDisableButtons(2);
                        RightBottomMessageBox.Info("Data modify Successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

            FormControlHandling.ClearControls(grpBoxRegistrationForm);
            EnableDisableButtons(2);
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    pbPic.ImageLocation = imagelocation;
                }
            }
            catch (Exception)
            {
                PopupMessageBox.Show("An error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            AddRole frm = new AddRole();
            frm.Show();
            LoadRoles();
        }
        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int index = dgView.CurrentRow.Index;
                if (index <= dgView.RowCount - 1)
                {
                    txtUserId.Text = Convert.ToString(dgView.Rows[index].Cells[0].Value);
                    txtName.Text = Convert.ToString(dgView.Rows[index].Cells[1].Value);
                    cmbRole.SelectedValue = Convert.ToString(dgView.Rows[index].Cells[7].Value);
                    txtEmail.Text = Convert.ToString(dgView.Rows[index].Cells[3].Value);
                    rtxtRemark.Text = Convert.ToString(dgView.Rows[index].Cells[4].Value);
                    txtPwd.Text = operations.Decrypt(Convert.ToString(dgView.Rows[index].Cells[5].Value));
                    chkActive.Checked = Convert.ToBoolean(dgView.Rows[index].Cells[8].Value);
                    EnableDisableButtons(3);

                    if (File.Exists(Application.StartupPath + "\\Image\\" + txtUserId.Text + ".jpg"))
                    {
                        pbPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\" + txtUserId.Text + ".jpg");
                    }
                    else
                    {
                        pbPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\noimage.png");
                    }

                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void pbPwdIcon_MouseDown(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = false;
        }
        private void pbPwdIcon_MouseUp(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = true;
        }
        public Boolean ValidateControls()
        {
            if (txtUserId.Text == "")
            {
                PopupMessageBox.Show("Please enter Userid!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserId.Select();
                return false;
            }
            if (txtName.Text == "")
            {
                PopupMessageBox.Show("Please enter Name!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Select();
                return false;
            }
            if (cmbRole.SelectedIndex == 0)
            {
                PopupMessageBox.Show("Please Select Role!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtEmail.Text == "")
            {
                PopupMessageBox.Show("Please enter EmailId!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Select();
                return false;
            }
            if (rtxtRemark.Text == "")
            {
                PopupMessageBox.Show("Please enter Remark!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxtRemark.Select();
                return false;
            }
            if (txtPwd.Text == "")
            {
                PopupMessageBox.Show("Please enter Password!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Select();
                return false;
            }
            return true;
        }
    }
}
