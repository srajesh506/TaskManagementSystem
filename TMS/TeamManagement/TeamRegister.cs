using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI.Utilities;
using TMS.BusinessEntities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;


namespace TMS.UI
{
    public partial class FrmTeamRegister : Form
    {
        private int _currentPage = 1;
        private int _pageSize = 5;
        private int _noOfPages;
        private DataTable _employees;

        Employee employee = new Employee();
        TeamManagement teamManagement = new TeamManagement();
        Operations operations = new Operations();
        public FrmTeamRegister()
        {
            try
            {
                InitializeComponent();
                LoadTheme();
                EnableDisableButtons(2);
                LoadEmployeesDataGrid(true);        //True flag to make DB call for first time loading the grid
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Form Load Event
        private void FrmTeamRegister_Load(object sender, EventArgs e)
        {
            try
            {
                LoadRoles();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Add button click event to enable the form for adding new Employee record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EnableDisableButtons(1);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to open add employee form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Save button click event to save the form for adding new Employee record
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveModifyEmployeesData("S");
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to save a new Employee record!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Modify button click event to enable the form for updating existing Employee record
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                SaveModifyEmployeesData("M");
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to update an existing record!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cancel button click event to cancel the last chosen active operation
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                FormControlHandling.ClearControls(grpBoxRegistrationForm);
                EnableDisableButtons(2);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to cancel the active record add/update action!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Upload button click event to upload image for the employee record
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
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to upload the image!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Add Role Button click event to open the Add Role form for adding new Role record
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            try
            {
                AddRole frm = new AddRole();
                frm.Show();
                LoadRoles();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to add the new Role!!\n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //DataGridView cell click event to load the existing employee record in form for modification
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
                PopupMessageBox.Show("TMSError - Failed to load the selected record in the Form fields from the DataGrid!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //UserId TextBox KeyPress event to allow specific charaters only
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

        //PictureBox Password Icon Mouse Down event to allow reading the password
        private void pbPwdIcon_MouseDown(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = false;
        }

        //PictureBox Password Icon Mouse Up event to disallow reading the password
        private void pbPwdIcon_MouseUp(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = true;
        }

        //Previous Page button click event to move to previous page of datagridview
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage -= 1;
                LoadEmployeesDataGrid();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to previous page in the grid !! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Next Page button click event to move to next page of datagridview
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage += 1;
                LoadEmployeesDataGrid();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to next page in the grid !! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //NoOfRecordsPerPage Combobox value change event to reload the datagridview data
        private void cmbNoOfRecordsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentPage = 1;
                LoadEmployeesDataGrid();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to load selected no. of records on grid page!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //First Page button click event to move to first page of datagridview
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage = 1;
                LoadEmployeesDataGrid();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to the first page in the grid!!  \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Last Page button click event to move to last page of datagridview
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            try
            {
                _currentPage = _noOfPages;
                LoadEmployeesDataGrid();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to move to last page in the grid!!  \n" + ex.Message + "\n", "TMS",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //User Defined

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
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }

        }

        // Function to Load the Roles in the Form Combobox.
        private void LoadRoles()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = teamManagement.GetRoles();
                DataRow dataRow = dataTable.NewRow();
                dataRow.ItemArray = new object[] { 0, "--Select Role--" };
                dataTable.Rows.InsertAt(dataRow, 0);
                cmbRole.ValueMember = "RoleId";
                cmbRole.DisplayMember = "RoleName";
                cmbRole.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to Load the Roles!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        // Function to retrive the Employee table data for GridView DataSource
        private void GetEmployeesData()
        {
            try
            {
                _employees = teamManagement.GetEmployeesRoles();
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to retrieve the Employees records!! \n" + ex.Message + "\n", ex.InnerException);
            }

        }

        //Function to Validate the mandatory controls are supplied with correct values
        private Boolean ValidateControls(String mode)
        {
            try
            {
                if (mode == "S")
                {
                    if (chkActive.Checked == false)
                    {
                        PopupMessageBox.Show("Please Confirm Active Member!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
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
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to validate the form controls!! \n" + ex.Message + "\n", ex.InnerException);
            }

        }

        // Function to enable or disable the buttons based on the selected operation (ADD/MODIFY/SAVE/CANCEL) or GridView Page Selected or No of Records per Page changes) 
        private void EnableDisableButtons(int flag)
        {
            try
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
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = true;
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
                if (flag == 4)                  //Grid Page no change or No of records per page change
                {
                    if (_currentPage == 1)
                    {
                        btnPrevious.Enabled = false;
                        btnNext.Enabled = true;
                        btnFirstPage.Enabled = false;
                        btnLastPage.Enabled = true;
                    }
                    if (_currentPage == _noOfPages)
                    {
                        btnNext.Enabled = false;
                        btnPrevious.Enabled = true;
                        btnFirstPage.Enabled = true;
                        btnLastPage.Enabled = false;
                    }
                    if ((_noOfPages == 1))
                    {
                        btnNext.Enabled = false;
                        btnPrevious.Enabled = false;
                        btnFirstPage.Enabled = false;
                        btnLastPage.Enabled = false;
                    }
                    if ((_currentPage > 1) && (_currentPage < _noOfPages))
                    {
                        btnNext.Enabled = true;
                        btnPrevious.Enabled = true;
                        btnFirstPage.Enabled = true;
                        btnLastPage.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to setup the form button controls!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        //Function to perform new Employee addition and existing Employee update
        private void SaveModifyEmployeesData(String mode)
        {
            try
            {
                if (ValidateControls(mode))
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
                    switch (mode)
                    {
                        case "S":
                            if (teamManagement.AddUpdateEmployee(employee) <= 0)
                            {
                                throw new Exception("TMSError - User ID: '" + txtUserId.Text + "' already exists in Database!! ");
                            }
                            break;
                        case "M":
                            if (teamManagement.AddUpdateEmployee(employee, true) <= 0)
                            {
                                throw new Exception("TMSError - User ID: '" + txtUserId.Text + "' does not exist in Database!! ");
                            }
                            break;
                        default:
                            throw new Exception("TMSError - Invalid Operation!! ");
                    }
                    _currentPage = 1;               //Freshly Load the grid with Page 1
                    LoadEmployeesDataGrid(true);    //True flag to make DB call for refreshing the grid
                    FormControlHandling.ClearControls(grpBoxRegistrationForm);
                    EnableDisableButtons(2);
                    RightBottomMessageBox.Info("Data saved Successfully!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to perform save/modify operation!! \n" + ex.Message+ "\n", ex.InnerException);
            }
        }

        //Function to load the datagridview with the records and setup other options for datagridview
        private void LoadEmployeesDataGrid(Boolean refresh = false)
        {
            try
            {
                if (refresh)
                    GetEmployeesData();
                _pageSize = Convert.ToInt32(cmbNoOfRecordsPerPage.SelectedItem);
                _noOfPages = Convert.ToInt32(Math.Ceiling((double)_employees.Rows.Count / _pageSize)) == 0 ? 1 : Convert.ToInt32(Math.Ceiling((double)_employees.Rows.Count / _pageSize));
                lblCurrentPage.Text = _currentPage.ToString();
                lblNoOfPages.Text = _noOfPages.ToString();
                DataTable records = FormControlHandling.GetPageRecords(_employees, _currentPage, _pageSize);
                dgView.DataSource = records;
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
                EnableDisableButtons(4);
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the data in GridView!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
    }
}
