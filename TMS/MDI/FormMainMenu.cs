using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TMS.UI.wait;
using System.Threading;
using System.IO;
using TMS.UI.Utilities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;
using TMS.UI;

namespace TMS.MDI
{
    public partial class FormMainMenu : Form
    {
        private Button CurrentButton;
        private Random Random;
        private int TempIndex;
        bool Sidebarexpand = true;
        bool HomeCollaps = true;
        bool ReportCollaps = true;
        bool SettingsCollaps = true;
        bool WorkItemCollaps = true;
        private Form ActiveFrm;
        waitformfunc waitform = new waitformfunc();
        TeamManagement teamManagement= new TeamManagement();


        public FormMainMenu(string userid)
        {
            InitializeComponent();
            Random = new Random();
            Global.GlobalVar = userid;
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            if (File.Exists(Application.StartupPath + "\\Image\\" + userid + ".jpg"))
            {
                picemp.Image = Image.FromFile(Application.StartupPath + "\\Image\\" + userid + ".jpg");
                //lblwelcome.Text = "Employee ID: " + empid +"\n"+"Welcome "+ dboperations.GetEmpname(int.Parse(empid)); 
                lblWelCome.Text = "Welcome " + teamManagement.GetEmployees(userid).Rows[0][0].ToString();
            }
            else
            {
                picemp.Image = Image.FromFile(Application.StartupPath + "\\Image\\noimageMDI.png");
               lblWelCome.Text = "Welcome " + teamManagement.GetEmployees(userid).Rows[0][0].ToString();
            }

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            int index = Random.Next(ThemeColor.ColorList.Count);
            while (TempIndex == index)
            {
                index = Random.Next(ThemeColor.ColorList.Count);
            }
            TempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (CurrentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    CurrentButton = (Button)btnsender;
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;
                    CurrentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    paneltitlebar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, 0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, 0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void OpenChildForm(Form childform, Object btnsender)
        {

            if (ActiveFrm != null)
            {
                ActiveFrm.Close();
            }
            ActiveButton(btnsender);
            ActiveFrm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childform);
            this.panelDesktopPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitle.Text = childform.Text;
        }
        private void OpenDashBoardForm(Form childform)
        {

            if (ActiveFrm != null)
            {
                ActiveFrm.Close();
            }
            ActiveFrm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childform);
            this.panelDesktopPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitle.Text = childform.Text;
        }
        private void DisableButton()
        {
            foreach (Control previousbtn in Sidebar.Controls)
            {
                foreach (Control btn in previousbtn.Controls)
                {
                    if (btn.GetType() == typeof(Button))
                    {
                        btn.BackColor = Color.FromArgb(35, 40, 45);
                        btn.ForeColor = Color.Gainsboro;
                        btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                    foreach (Control Layer1btn in btn.Controls)
                    {
                        if (Layer1btn.GetType() == typeof(Button))
                        {
                            Layer1btn.BackColor = Color.FromArgb(35, 40, 45);
                            Layer1btn.ForeColor = Color.Gainsboro;
                            Layer1btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        }
                    }
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sidebartimer.Start();
        }
        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            //Set the Minimum and maximum size of sidebar panel
            if (Sidebarexpand)
            {
                Sidebar.Width = Sidebar.Width - 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    Sidebarexpand = false;
                    Sidebartimer.Stop();
                }
            }
            else
            {
                Sidebar.Width = Sidebar.Width + 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    Sidebarexpand = true;
                    Sidebartimer.Stop();
                }
            }
        }

        private void btnmasterdata_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }
        private void btnclosechildform_Click(object sender, EventArgs e)
        {
            if (ActiveFrm != null)
                ActiveFrm.Close();
            OpenChildForm(new MDI.Dashboard(), sender);
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "DASHBOARD";
            paneltitlebar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(35, 40, 45);
            CurrentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void paneltitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Set the Minimum and maximum size of Home panel button to expand/Collaps Menus
        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (HomeCollaps)
            {
                HomeContainer.Height = HomeContainer.Height + 10;
                if (HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    HomeCollaps = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                HomeContainer.Height = HomeContainer.Height - 10;
                if (HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    HomeCollaps = true;
                    HomeTimer.Stop();
                }
            }

        }
        //Set the Minimum and maximum size of Home panel on click of Report Analysis button to expand/Collaps Menus
        private void ReportTimer_Tick(object sender, EventArgs e)
        {
            if (ReportCollaps)
            {
                panelReportAnalysis.Height = panelReportAnalysis.Height + 10;
                if (panelReportAnalysis.Height == panelReportAnalysis.MaximumSize.Height)
                {
                    ReportCollaps = false;
                    ReportTimer.Stop();
                }
            }
            else
            {
                panelReportAnalysis.Height = panelReportAnalysis.Height - 10;
                if (panelReportAnalysis.Height == panelReportAnalysis.MinimumSize.Height)
                {
                    ReportCollaps = true;
                    ReportTimer.Stop();
                }
            }
        }
        private void btnreportanalysis_Click(object sender, EventArgs e)
        {
            //ActiveButton(sender);
            ReportTimer.Start();
        }
        private void btnteamregister_Click(object sender, EventArgs e)
        {
            //this.btnteamregister.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnteamregister_Click);
            //waitform.Show(this);
            //Thread.Sleep(300);
            OpenChildForm(new UI.FrmTeamRegister(), sender);
            ActiveButton(sender);
            //waitform.Close();
        }
        private void btngrouptask_Click(object sender, EventArgs e)
        {
            //waitform.Show(this);
            //Thread.Sleep(2000);
            OpenChildForm(new UI.TaskManagement(), sender);
            ActiveButton(sender);
            //waitform.Close();
        }
        private void btnstatusbasedreport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UI.StatusBasedReport(), sender);
            //waitform.Show(this);
            //Thread.Sleep(2000);
            ActiveButton(sender);
            //waitform.Close();
        }
        private void btnAssigneeBaseReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UI.AssigneeBasedReport(), sender);
            //waitform.Show(this);
            //Thread.Sleep(2000);
            ActiveButton(sender);
            //waitform.Close();
        }
        private void btnTimeBasedReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UI.TimeBasedReport(), sender);
            //waitform.Show(this);
            //Thread.Sleep(2000);
            ActiveButton(sender);
            //waitform.Close();
        }
        private void btnTG_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new Home.GroupTask(), sender);
            waitform.Show(this);
            Thread.Sleep(50);
            ActiveButton(sender);
            waitform.Close();
        }
        private void Logout_Click_1(object sender, EventArgs e)
        {
            waitform.Show(this);
            Thread.Sleep(50);
            this.Hide();
            Login frm = new Login();
            frm.Show();
            waitform.Close();
        }
        private void lbllogout_Click(object sender, EventArgs e)
        {
            if (PopupMessageBox.Show("Do you want to close this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                waitform.Show(this);
                Thread.Sleep(50);
                this.Hide();
                Login frm = new Login();
                frm.Show();
                waitform.Close();
            }
        }
        private void lbllogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogOut.Font = new Font(lblLogOut.Font.Name, lblLogOut.Font.SizeInPoints, FontStyle.Bold);
            lblLogOut.ForeColor = Color.Yellow;
        }
        private void lbllogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogOut.Font = new Font(lblLogOut.Font.Name, lblLogOut.Font.SizeInPoints, FontStyle.Regular);
            lblLogOut.ForeColor = Color.White;
        }
        private void lblwelcome_MouseEnter(object sender, EventArgs e)
        {
            lblWelCome.Font = new Font(lblWelCome.Font.Name, lblWelCome.Font.SizeInPoints, FontStyle.Bold);
            lblWelCome.ForeColor = Color.Yellow;
        }
        private void lblwelcome_MouseLeave(object sender, EventArgs e)
        {
            lblWelCome.Font = new Font(lblWelCome.Font.Name, lblWelCome.Font.SizeInPoints, FontStyle.Regular);
            lblWelCome.ForeColor = Color.White;
        }
        private void labelmenu_MouseEnter(object sender, EventArgs e)
        {
            lblMenu.Font = new Font(lblMenu.Font.Name, lblMenu.Font.SizeInPoints, FontStyle.Bold);
            lblMenu.ForeColor = Color.Yellow;
        }

        private void labelmenu_MouseLeave(object sender, EventArgs e)
        {
            lblMenu.Font = new Font(lblMenu.Font.Name, lblMenu.Font.SizeInPoints, FontStyle.Regular);
            lblMenu.ForeColor = Color.White;
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingTimer.Start();
        }
        private void SettingTimer_Tick(object sender, EventArgs e)
        {
            if (SettingsCollaps)
            {
                pnlmainsettings.Height = pnlmainsettings.Height + 10;
                if (pnlmainsettings.Height == pnlmainsettings.MaximumSize.Height)
                {
                    SettingsCollaps = false;
                    SettingTimer.Stop();
                }
            }
            else
            {
                pnlmainsettings.Height = pnlmainsettings.Height - 10;
                if (pnlmainsettings.Height == pnlmainsettings.MinimumSize.Height)
                {
                    SettingsCollaps = true;
                    SettingTimer.Stop();
                }
            }
        }
        private void btnupdatepwd_Click(object sender, EventArgs e)
        {
            waitform.Show(this);
            Thread.Sleep(50);
            OpenChildForm(new ChangePassword(), sender);
            ActiveButton(sender);
            waitform.Close();
        }

        private void btnassigntask_Click(object sender, EventArgs e)
        {

            waitform.Show(this);
            Thread.Sleep(50);
            OpenChildForm(new UI.CreateWorkItem(), sender);
            ActiveButton(sender);
            waitform.Close();
        }

        private void WorkITemtimer_Tick(object sender, EventArgs e)
        {
            if (WorkItemCollaps)
            {
                pnlmainworkitm.Height = pnlmainworkitm.Height + 10;
                if (pnlmainworkitm.Height == pnlmainworkitm.MaximumSize.Height)
                {
                    WorkItemCollaps = false;
                    WorkItemtimer.Stop();
                }
            }
            else
            {
                pnlmainworkitm.Height = pnlmainworkitm.Height - 10;
                if (pnlmainworkitm.Height == pnlmainworkitm.MinimumSize.Height)
                {
                    WorkItemCollaps = true;
                    WorkItemtimer.Stop();
                }
            }
        }
        private void btnworkitem_Click(object sender, EventArgs e)
        {
            WorkItemtimer.Start();
        }
        private void btnassignworkItem_Click(object sender, EventArgs e)
        {
            waitform.Show(this);
            Thread.Sleep(50);
            OpenChildForm(new UI.WorkItemAssignments(), sender);
            ActiveButton(sender);
            waitform.Close();
        }
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                OpenDashBoardForm(new MDI.Dashboard());
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
