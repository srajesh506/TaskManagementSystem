﻿using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI;
using TMS.UI.Utilities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;
using System.Data;
using TMS.BusinessEntities;
using System.Linq;
using System.Collections.Generic;

namespace TMS.MDI
{
    public partial class FormMainMenu : Form
    {
        //Flags to store the expanded or collapsed status of Menu Options
        private bool _sideBarExpand = true;
        private bool _adminCollaps = true;
        private bool _masterDataCollaps = true;
        private bool _workItemCollaps = true;
        private bool _reportCollaps = true;
        private bool _settingsCollaps = true;

        //String variable to hold the name of the control which triggered the Timer to start as part of Menu Expand/Collapse Functionality.
        private String _timerStartControlName;
        private System.Windows.Forms.Button _currentButton;
        private Random _random;
        private Form _activeForm;

        ProjectManagement projectManagement = new ProjectManagement();
        TeamManagement teamManagement = new TeamManagement();
        public FormMainMenu(string userId)
        {
            try
            {
                InitializeComponent();
                IsMdiContainer = true;
                _random = new Random();
                UserInfo.UserId = userId;
                btnCloseChildForm.Visible = false;
                this.Text = string.Empty;
                this.ControlBox = false;
                DataTable employeeDetails = new System.Data.DataTable();
                employeeDetails = teamManagement.GetEmployees(userId);
                pbUser.Image = File.Exists(System.Windows.Forms.Application.StartupPath + "\\Images\\" + userId + ".jpg") ? Image.FromFile(Application.StartupPath + "\\Images\\" + userId + ".jpg") : Image.FromFile(Application.StartupPath + "\\Images\\noimageMDI.png");
                lblWelcome.Text = "Welcome " + employeeDetails.Rows[0]["EmpName"].ToString();
                UserInfo.RoleId = employeeDetails.Rows[0]["RoleId"].ToString();

                int[] projectIdArray ;
                string[] projectNameArray;
                DataTable employeeProjectAssignedRecord = new DataTable();

                if (employeeDetails.Rows[0]["RoleId"].ToString() == "1")
                {
                    employeeProjectAssignedRecord = projectManagement.GetAllProject();
                }

                else if (!string.IsNullOrEmpty(employeeDetails.Rows[0]["ProjectId"].ToString()) && !string.IsNullOrEmpty(employeeDetails.Rows[0]["ProjectName"].ToString()))
                {
                    projectIdArray = employeeDetails.Rows[0]["ProjectId"].ToString().Split(',').Select(int.Parse).ToArray();
                    projectNameArray = employeeDetails.Rows[0]["ProjectName"].ToString().Split(',');
                    
                    employeeProjectAssignedRecord.Columns.Add("ProjectId", typeof(int));
                    employeeProjectAssignedRecord.Columns.Add("ProjectName", typeof(string));
                    for (int i = 0; i < projectIdArray.Length && i < projectNameArray.Length; i++)
                    {
                        employeeProjectAssignedRecord.Rows.Add(projectIdArray[i].ToString().Trim(), projectNameArray[i].Trim());
                    }
                }                
                if (employeeProjectAssignedRecord != null && employeeProjectAssignedRecord.Rows.Count > 0)
                {
                    DataRow dataRow = employeeProjectAssignedRecord.NewRow();
                    dataRow.ItemArray = new object[] { 0, "--Select Project--" };
                    employeeProjectAssignedRecord.Rows.InsertAt(dataRow, 0);
                    if (employeeProjectAssignedRecord.Rows.Count > 0)
                    {
                        cmbProjects.ValueMember = "ProjectId";
                        cmbProjects.DisplayMember = "ProjectName";
                        cmbProjects.DataSource = employeeProjectAssignedRecord;
                        switch (UserInfo.RoleId)
                        {
                            case "1": // Admin Role
                                pnlAdmin.Visible = true;
                                pnlMasterData.Visible = true;
                                lblProjectName.Visible = false;
                                cmbProjects.Visible = false;
                                break;
                            case "2": // Manager Role
                                pnlAdmin.Visible = false;
                                lblProjectName.Visible = true;
                                cmbProjects.Visible = true;
                                break;
                            case "3": // Team Member Role
                                pnlAdmin.Visible = false;
                                pnlMasterData.Visible = false;
                                lblProjectName.Visible = true;
                                cmbProjects.Visible = true;
                                break;
                            default:
                                // Handle other cases, if necessary
                                break;
                        }
                    }
                }
                else
                {
                    PopupMessageBox.Show("User is not assigned to any project. Please connect with your reporting manager", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        _adminCollaps = HorizantalTimerTick(_adminCollaps, pnlAdmin);
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
                if (ActiveMdiChild != null)
                {
                    ActiveMdiChild.Close();
                }
                if (btnSender != null)
                {
                    ActiveButton(btnSender);
                }
                _activeForm = childForm;
                childForm.MdiParent = this;
                childForm.Show();
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.pnlDesktopPanel.Controls.Add(childForm);
                this.pnlDesktopPanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                lblTitle.Text = childForm.Text;
                UserInfo.FormName = childForm.GetType().Name;
                if (UserInfo.RoleId == "1")
                {
                    switch (UserInfo.FormName)
                    {
                        case "ProjectAssignment":
                        case "TaskManagementForm":
                        case "CreateWorkItem":
                        case "WorkItemAssignments":
                        case "StatusBasedReport":
                        case "AssigneeBasedReport":
                        case "TimeBasedReport":
                            lblProjectName.Visible = true;
                            cmbProjects.Visible = true;
                            break;
                        default: lblProjectName.Visible = false; cmbProjects.Visible = false; break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Error in loading Form!! \n" + ex.Message + "\n", ex.InnerException);
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
                    foreach (Panel control in pnlSideBar.Controls)
                    {
                        if (control != panel && control != pnlLogo)
                        {
                            if (control.Height > control.MinimumSize.Height)
                            {
                                control.Height = control.MinimumSize.Height;
                                ResetPanelCollapsFlags(control, true);
                            }
                        }
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

        private void ResetPanelCollapsFlags(Panel pnl, Boolean flag)
        {
            switch (pnl.Name)
            {
                case "pnlAdmin":
                    _adminCollaps = flag;
                    break;
                case "pnlMasterData":
                    _masterDataCollaps = flag;
                    break;
                case "pnlWorkItem":
                    _workItemCollaps = flag;
                    break;
                case "pnlReportAnalysis":
                    _reportCollaps = flag;
                    break;
                case "pnlSettings":
                    _settingsCollaps = flag;
                    break;
                default:
                    break;
            }
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

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cmbprojects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbProjects.SelectedIndexChanged -= cmbprojects_SelectedIndexChanged;
                string lastProjectId = UserInfo.ProjectId;
                if (cmbProjects.SelectedIndex > 0)
                {
                    string currentProjectId = Convert.ToString(cmbProjects.SelectedValue);
                    if (currentProjectId != lastProjectId)
                    {
                        if (ActiveMdiChild != null)
                        {
                            if (PopupMessageBox.Show("Do you want to switch the Project? if Yes,Enter Data will loss for the current page.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                SetupUserInfo();
                                Type childType = ActiveMdiChild.GetType();
                                Form newChild = (Form)Activator.CreateInstance(childType);
                                OpenChildForm(newChild);
                            }
                            else
                            {
                                //if (i++ == 0)
                                cmbProjects.SelectedValue = lastProjectId;
                                SetupUserInfo();
                            }
                        }
                        else
                        {
                            SetupUserInfo();
                        }
                    }
                }
                else
                {
                    cmbProjects.SelectedIndex = (cmbProjects.Items.Count > 0) ? 1 : 0;
                    SetupUserInfo();
                    //PopupMessageBox.Show("Default Project Selected", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cmbProjects.SelectedIndexChanged += cmbprojects_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Error in loading Task Management Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetupUserInfo()
        {
            UserInfo.ProjectId = cmbProjects.SelectedIndex > 0 ? Convert.ToString(cmbProjects.SelectedValue) : null;
            UserInfo.ProjectText = cmbProjects.Text;
            UserInfo.SelectedValue = Convert.ToInt32(cmbProjects.SelectedValue);
        }

    }
}
