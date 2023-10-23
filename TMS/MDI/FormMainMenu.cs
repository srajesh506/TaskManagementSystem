using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI;
using TMS.UI.Utilities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;
using System.Data;
using CrystalDecisions.ReportAppServer.DataDefModel;
using DataSet = System.Data.DataSet;
using TMS.BusinessEntities;
using System.Diagnostics.Eventing.Reader;

namespace TMS.MDI
{
    public partial class FormMainMenu : Form
    {
        //Flags to store the expanded or collapsed status of Menu Options
        private bool _sideBarExpand = true;
        private bool _masterDataCollaps = true;
        private bool _workItemCollaps = true;
        private bool _reportCollaps = true;
        private bool _settingsCollaps = true;

        //String variable to hold the name of the control which triggered the Timer to start as part of Menu Expand/Collapse Functionality.
        private String _timerStartControlName;

        private Button _currentButton;
        private Random _random;

        private Form _activeForm;

        TeamManagement teamManagement = new TeamManagement();


        public FormMainMenu(string userId)
        {
            try
            {
                InitializeComponent();
                _random = new Random();
                UserInfo.userId = userId;
                btnCloseChildForm.Visible = false;
                this.Text = string.Empty;
                this.ControlBox = false;
                if (File.Exists(Application.StartupPath + "\\Images\\" + userId + ".jpg"))
                {
                    pbUser.Image = Image.FromFile(Application.StartupPath + "\\Images\\" + userId + ".jpg");
                    lblWelcome.Text = "Welcome " + teamManagement.GetEmployees(userId).Rows[0][1].ToString();
                }
                else
                {
                    pbUser.Image = Image.FromFile(Application.StartupPath + "\\Images\\noimageMDI.png");
                    lblWelcome.Text = "Welcome " + teamManagement.GetEmployees(userId).Rows[0][1].ToString();
                }
                DataSet dsrole = new DataSet();
                dsrole = teamManagement.GetRolebyUserId(userId);
                if (dsrole != null)
                {
                    if (dsrole.Tables[0].Rows.Count > 0)
                    {
                        UserInfo.roleID = dsrole.Tables[0].Rows[0][1].ToString();

                            //Manager RoleId is 2 
                            if (UserInfo.roleID == "2")
                        {
                            pnlAdmin.Visible = false;
                        }
                        else if(UserInfo.roleID == "3") //Team Member RoleID is 3
                        {
                            pnlAdmin.Visible = false;
                            pnlMasterData.Visible = false;
                        }
                            else                   //Admin RoleId is 1
                        {
                            pnlAdmin.Visible = true;
                            pnlMasterData.Visible = true;
                        }
                    }
                    DataTable dataTable = new DataTable();
                    dataTable = dsrole.Tables[1];
                    DataRow dataRow = dataTable.NewRow();
                    dataRow.ItemArray = new object[] { 0, "--Select Project--" };
                    dataTable.Rows.InsertAt(dataRow, 0);
                    if (dsrole.Tables[1].Rows.Count > 0)
                    {
                        cmbprojects.ValueMember = "projectid";
                        cmbprojects.DisplayMember = "projectname";
                        cmbprojects.DataSource = dataTable;
                    }
                        lblprojectname.Visible = dsrole.Tables[0].Rows[0][1].ToString() == "1" ? false : true;
                        cmbprojects.Visible = dsrole.Tables[0].Rows[0][1].ToString() == "1"  ? false : true; 
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Home Page!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        //Form Load Event
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                //OpenChildForm(new MDI.Dashboard());
                Reset();
                //pnlAdmin.Visible = false;
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Home Page!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Logout Option Click Event
        private void lblLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (PopupMessageBox.Show("Do you want to close this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                    Login frm = new Login();
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in Logout operation!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Child Form Close Button Event
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (_activeForm != null)
                    _activeForm.Close();
                //OpenChildForm(new MDI.Dashboard(), sender);
                Reset();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to close the last open form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Minimize Application Window Event
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Maximize Application Window Event
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        //Close Application Window Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Main Menu Button Click Event - Used in sidebar(Horizontal) expand/collapse of Main Menu using the timer
        private void pbMenuButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartTimer(sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in Main Menu SideBar Option Expand/Collapse event!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Master Data Button Click Event - Used in Vertical expand/collapse of Master Data Menu in the Main Menu using the timer
        private void btnMasterData_Click(object sender, EventArgs e)
        {
            try
            {
                StartTimer(sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in Master Data Menu Option Expand/Collapse event!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Team Register Button Click Event - Opens the Team Register Form as ChildForm
        private void btnTeamRegister_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new UI.FrmTeamRegister(), sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Task Management Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Task Management Button Click Event - Opens the Task Management Form as ChildForm
        private void btnTaskManagement_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new UI.TaskManagementForm(), sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Task Management Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //WorkItem Button Click Event - Used in Vertical expand/collapse of WorkItem Menu in the Main Menu using the timer
        private void btnWorkItem_Click(object sender, EventArgs e)
        {
            try
            {
                StartTimer(sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in WorkItem Option Menu Expand/Collapse event!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Create WorkItem Button Click Event - Opens the Create WorkItem Form as ChildForm
        private void btnCreateWorkItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new UI.CreateWorkItem(), sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Create WorkItem Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Assign WorkItem Button Click Event - Opens the Assign WorkItem Form as ChildForm
        private void btnAssignWorkItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new UI.WorkItemAssignments(), sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Assign WorkItem Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Report Analysis Button Click Event - Used in Vertical expand/collapse of Report Analysis Menu in the Main Menu using the timer
        private void btnReportAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                StartTimer(sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in Report Analysis Menu Option Expand/Collapse event!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Status Based Report Button Click Event - Opens the Status Based Report Form as ChildForm
        private void btnStatusBasedReport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new UI.StatusBasedReport(), sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Status Based Report Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Assignee Based Report Button Click Event - Opens the Assignee Based Report Form as ChildForm
        private void btnAssigneeBasedReport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new UI.AssigneeBasedReport(), sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Assignee Based Report Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Time Based Report Button Click Event - Opens the Time Based Report Form as ChildForm
        private void btnTimeBasedReport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new UI.TimeBasedReport(), sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Time Based Report Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Settings Button Click Event - Used in Vertical expand/collapse of Settings Menu in the Main Menu using the timer
        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                StartTimer(sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in Settings Menu Option Expand/Collapse event!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Change password Button Click Event - Opens the Change Password Form as ChildForm
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new ChangePassword(), sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Settings - Change Password Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Yellow highlight for Logout Label on Mouse Enter
        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            EnterMouse(lblLogOut);
        }
        //Yellow highlight for Welcome Label on Mouse Enter
        private void lblWelcome_MouseEnter(object sender, EventArgs e)
        {
            EnterMouse(lblWelcome);
        }
        //Yellow highlight for Menu Label on Mouse Enter
        private void lblMenu_MouseEnter(object sender, EventArgs e)
        {
            EnterMouse(lblMenu);
        }


        //Removes Yellow highlight for Logout Label on Mouse Leave
        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            LeaveMouse(lblLogOut);
        }
        //Removes Yellow highlight for Welcome Label on Mouse Leave
        private void lblWelcome_MouseLeave(object sender, EventArgs e)
        {
            LeaveMouse(lblWelcome);
        }
        //Removes Yellow highlight for Menu Label on Mouse Leave
        private void lblMenu_MouseLeave(object sender, EventArgs e)
        {
            LeaveMouse(lblMenu);
        }


        //Timer Tick Event - to Expand/Collapse the Menu option chosen
        private void timerExpandCollapse_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (_timerStartControlName)
                {
                    case "pbMenuButton":
                        VerticalTimerTick();
                        break;
                    case "btnAdmin":
                        _masterDataCollaps = HorizantalTimerTick(_masterDataCollaps, pnlAdmin);
                        break;
                    case "btnMasterData":
                        _masterDataCollaps = HorizantalTimerTick(_masterDataCollaps, pnlMasterData);
                        break;
                    case "btnWorkItem":
                        _workItemCollaps = HorizantalTimerTick(_workItemCollaps, pnlWorkItem);
                        break;
                    case "btnReportAnalysis":
                        _reportCollaps = HorizantalTimerTick(_reportCollaps, pnlReportAnalysis);
                        break;
                    case "btnSettings":
                        _settingsCollaps = HorizantalTimerTick(_settingsCollaps, pnlSettings);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in Menu Option Expand/Collapse event!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //User Defined

        //Function to reset the form back to Dashboard or Home screen
        private void Reset()
        {
            try
            {
                DisableButton();
                lblTitle.Text = "TASK MANAGEMENT SYSTEM";
                pnlTitleBar.BackColor = Color.FromArgb(0, 150, 136);
                pnlLogo.BackColor = Color.FromArgb(35, 40, 45);
                _currentButton = null;
                btnCloseChildForm.Visible = false;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Error in Form Reset operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }


        //Theme Color Selection
        private Color SelectThemeColor()
        {
            int index = _random.Next(ThemeColor.ColorList.Count);
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }


        private void DisableButton()
        {
            try
            {
                foreach (Control previousButton in pnlSideBar.Controls)
                {
                    foreach (Control button in previousButton.Controls)
                    {
                        if (button.GetType() == typeof(Button))
                        {
                            button.BackColor = Color.FromArgb(35, 40, 45);
                            button.ForeColor = Color.Gainsboro;
                            button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        }
                        foreach (Control layerButton in button.Controls)
                        {
                            if (layerButton.GetType() == typeof(Button))
                            {
                                layerButton.BackColor = Color.FromArgb(35, 40, 45);
                                layerButton.ForeColor = Color.Gainsboro;
                                layerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Error in Disable Button operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        private void ActiveButton(object btnSender)
        {
            try
            {
                if (btnSender != null)
                {
                    if (_currentButton != (Button)btnSender)
                    {
                        DisableButton();
                        Color color = SelectThemeColor();
                        _currentButton = (Button)btnSender;
                        _currentButton.BackColor = color;
                        _currentButton.ForeColor = Color.White;
                        _currentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        pnlTitleBar.BackColor = color;
                        pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, 0.3);
                        ThemeColor.PrimaryColor = color;
                        ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, 0.3);
                        btnCloseChildForm.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Error in Activate Button operation!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
       

        //Function to open Child Form Based on Menu Option Selected
        private void OpenChildForm(Form childForm, Object btnSender = null)
        {
            try
            {
                if (_activeForm != null)
                {
                    _activeForm.Close();
                }
                if (btnSender != null)
                {
                    ActiveButton(btnSender);
                }
                _activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.pnlDesktopPanel.Controls.Add(childForm);
                this.pnlDesktopPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                lblTitle.Text = childForm.Text;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Error in loading Form!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }


        private void OpenChildForm(string childFormName, object btnSender = null)
        {
            try
            {
                if (_activeForm != null)
                {
                    _activeForm.Close();
                }

                if (btnSender != null)
                {
                    ActiveButton(btnSender);
                }

                // Use reflection to create an instance of the child form by its name
                Type formType = Type.GetType(childFormName);
                if (formType != null)
                {
                    Form childForm = (Form)Activator.CreateInstance(formType);

                    _activeForm = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    pnlDesktopPanel.Controls.Add(childForm);
                    pnlDesktopPanel.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();

                    lblTitle.Text = childForm.Text;
                }
                else
                {
                    MessageBox.Show("Child form not found: " + childFormName, "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }


        //Function for Mouse Enter - Yellow Highlight
        private void EnterMouse(Label label)
        {
            label.Font = new Font(lblMenu.Font.Name, lblMenu.Font.SizeInPoints, FontStyle.Bold);
            label.ForeColor = Color.Yellow;
        }

        //Function for Mouse Leave - Yellow Highlight Removal
        private void LeaveMouse(Label label)
        {
            label.Font = new Font(lblMenu.Font.Name, lblMenu.Font.SizeInPoints, FontStyle.Regular);
            label.ForeColor = Color.White;
        }


        //Function to vertical Expand/Collapse the Main Menu (SideBar)
        private void VerticalTimerTick()
        {
            try
            {
                if (_sideBarExpand)
                {
                    pnlSideBar.Width = pnlSideBar.Width - 10;
                    if (pnlSideBar.Width == pnlSideBar.MinimumSize.Width)
                    {
                        _sideBarExpand = false;
                        timerExpandCollapse.Stop();
                    }
                }
                else
                {
                    pnlSideBar.Width = pnlSideBar.Width + 10;
                    if (pnlSideBar.Width == pnlSideBar.MaximumSize.Width)
                    {
                        _sideBarExpand = true;
                        timerExpandCollapse.Stop();
                    }
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in SideBar Menu Expand/Collapse event!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Function to horizontal Expand/Collapse the Menu option supplied
        private Boolean HorizantalTimerTick(Boolean collaps, Panel panel)
        {
            try
            {
                if (collaps)
                {
                    panel.Height = panel.Height + 10;
                    if (panel.Height == panel.MaximumSize.Height)
                    {
                        collaps = false;
                        timerExpandCollapse.Stop();
                    }
                }
                else
                {
                    panel.Height = panel.Height - 10;
                    if (panel.Height == panel.MinimumSize.Height)
                    {
                        collaps = true;
                        timerExpandCollapse.Stop();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Error in Menu Options Expand/Collapse event!! \n" + ex.Message + "\n", ex.InnerException);
            }
            return collaps;
        }
              

        //Function to start timer and capture the name of control which triggered timer to start
        private void StartTimer(object controlSender)
        {
            try
            {
                var temp = (Control)controlSender;
                _timerStartControlName = temp.Name;
                if (!timerExpandCollapse.Enabled)
                    timerExpandCollapse.Start();
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failure in Menu Option Expand/Collapse Event!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }

        private void btnProjectAssignment_Click(object sender, EventArgs e)
        {
            try
            {
                var temp = (Control)sender;
                UserInfo.formname = temp.Text.Replace(" ","");
                OpenChildForm(new UI.ProjectAssignment(), sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Task Management Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProjectManagement_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new UI.FrmAssignProject(), sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Task Management Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                StartTimer(sender);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in Master Data Menu Option Expand/Collapse event!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbprojects_SelectedIndexChanged(object sender, EventArgs e)
        {
               UserInfo.projectID = cmbprojects.SelectedIndex > 0 ?  Convert.ToString(cmbprojects.SelectedValue) : null;
            try
            {
                if (cmbprojects.SelectedIndex > 0)
                {
                    string formname = "UI." + UserInfo.formname + "";
                    Type formtype = Type.GetType(formname);
                    if (formtype != null)
                    {
                        Form form = (Form)Activator.CreateInstance(formtype);
                        OpenChildForm(formname);
                    }
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Task Management Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
