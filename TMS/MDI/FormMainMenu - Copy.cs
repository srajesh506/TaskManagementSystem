using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TMS.Home.wait;
using System.Threading;
using System.IO;
using TMS.Controls.TeamRegisterandManage;
using TMS.Utilities;

namespace TMS.MDI
{
    public partial class FormMainMenu_Copy : Form
    {
        private Button currentButton;
        private Random random;
        private int tempindex;
        bool sidebarexpand=true;
        bool homecollaps= true;
        bool Reportcollaps = true;
        bool Settingscollaps = true;
        bool WorkItemcollaps = true;
        private Form activeForm;
        waitformfunc waitform = new waitformfunc();
       
        public FormMainMenu_Copy(string  empid)
        {
            InitializeComponent();
            random = new Random();
            Global.GlobalVar = empid;
            btnclosechildform.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            if (File.Exists(Application.StartupPath + "\\Image\\" + empid + ".jpg"))
            {
                picemp.Image = Image.FromFile(Application.StartupPath + "\\Image\\" + empid + ".jpg");
                lblwelcome.Text = "Employee ID: " + empid +"\n"+"Welcome "+ obj.GetEmpnameandID("UserDetails","EmpName",int.Parse(empid)); 
            }
            else
            {
                picemp.Image = Image.FromFile(Application.StartupPath + "\\Image\\noimageMDI.png");
                lblwelcome.Text = "Employee ID: " + empid + "\n" + "Welcome " + obj.GetEmpnameandID("UserDetails", "EmpName", int.Parse(empid));
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempindex==index)
            {
               index= random.Next(ThemeColor.ColorList.Count);
            }tempindex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveButton(object btnsender)
        {
            if(btnsender!=null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color =  SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    paneltitlebar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, 0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, 0.3);
                    btnclosechildform.Visible = true;
                }
            }
        }

        private void OpenChildForm(Form childform, Object btnsender)
        {
            if(activeForm !=null)
            {
                activeForm.Close();
            }
            ActiveButton(btnsender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childform);
            this.panelDesktopPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            labeltitle.Text = childform.Text;
        }

        private void DisableButton()
        {
            foreach(Control previousbtn in Sidebar.Controls)
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
            if (sidebarexpand)
            {
                Sidebar.Width = Sidebar.Width-10;
                if (Sidebar.Width ==Sidebar.MinimumSize.Width)
                {
                    sidebarexpand = false;
                    Sidebartimer.Stop();
                }
            }
            else
            {
                Sidebar.Width = Sidebar.Width+10;
                if (Sidebar.Width==Sidebar.MaximumSize.Width)
                {
                    sidebarexpand = true;
                    Sidebartimer.Stop();
                }
            }
        }

        private void btnmasterdata_Click(object sender, EventArgs e)
        {
            //ActiveButton(sender);
            //OpenChildForm(new Home.FormHome(), sender);
            HomeTimer.Start();
            
        }

        private void btntaskcalender_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Home.TaskCalender_New(), sender);
            //waitform.Show(this);
            //Thread.Sleep(2000);
            //ActiveButton(sender);
            //waitform.Close();
        }
        private void btntasksheet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home.frmTaskSheet(), sender);
            waitform.Show(this);
            Thread.Sleep(2000);
            waitform.Close();
        }

        private void btnclosechildform_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            labeltitle.Text = "HOME";
            paneltitlebar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(35, 40, 45);
            currentButton = null;
            btnclosechildform.Visible = false;
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
            if(WindowState==FormWindowState.Normal)
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
            if (homecollaps)
            {
                HomeContainer.Height = HomeContainer.Height + 10;
                if (HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    homecollaps = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                HomeContainer.Height = HomeContainer.Height - 10;
                if (HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    homecollaps = true;
                    HomeTimer.Stop();
                }
            }

            }
        

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelReportAnalysis_Paint(object sender, PaintEventArgs e)
        {

        }
        //Set the Minimum and maximum size of Home panel on click of Report Analysis button to expand/Collaps Menus
        private void ReportTimer_Tick(object sender, EventArgs e)
        {
            if (Reportcollaps)
            {
                panelReportAnalysis.Height = panelReportAnalysis.Height + 10;
                if (panelReportAnalysis.Height == panelReportAnalysis.MaximumSize.Height)
                {
                    Reportcollaps = false;
                    ReportTimer.Stop();
                }
            }
            else
            {
                panelReportAnalysis.Height = panelReportAnalysis.Height - 10;
                if (panelReportAnalysis.Height == panelReportAnalysis.MinimumSize.Height)
                {
                    Reportcollaps = true;
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
            waitform.Show(this);
            Thread.Sleep(300);
            OpenChildForm(new Home.frmteamregister(), sender);
            ActiveButton(sender);
            waitform.Close();

        }
        private void btngrouptask_Click(object sender, EventArgs e)
        {
            waitform.Show(this);
            Thread.Sleep(2000);
            OpenChildForm(new Home.TaskManagement(), sender);
            ActiveButton(sender);
            waitform.Close();
        }
        private void btnTVTG_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reporting.StatusBasedReport(), sender);
            waitform.Show(this);
            Thread.Sleep(2000);
            ActiveButton(sender);
            waitform.Close();
        }
        private void btnTGVT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home.GroupTask(), sender);
            waitform.Show(this);
            Thread.Sleep(2000);
            ActiveButton(sender);
            waitform.Close();
        }
        private void btnteam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home.GroupTask(), sender);
            waitform.Show(this);
            Thread.Sleep(2000);
            ActiveButton(sender);
            waitform.Close();
        }
        private void btnTG_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home.GroupTask(), sender);
            waitform.Show(this);
            Thread.Sleep(2000);
            ActiveButton(sender);
            waitform.Close();
        }
        private void Logout_Click_1(object sender, EventArgs e)
        {
            waitform.Show(this);
            Thread.Sleep(2000);
            this.Hide();
            Login frm = new Login();
            frm.Show();
            waitform.Close();
        }
        private void lbllogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this application?", "Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                waitform.Show(this);
                Thread.Sleep(2000);
                this.Hide();
                Login frm = new Login();
                frm.Show();
                waitform.Close();
            }
        }
        private void lbllogout_MouseEnter(object sender, EventArgs e)
        {
            lbllogout.Font = new Font(lbllogout.Font.Name, lbllogout.Font.SizeInPoints, FontStyle.Bold);
            lbllogout.ForeColor = Color.Yellow;
        }
        private void lbllogout_MouseLeave(object sender, EventArgs e)
        {
            lbllogout.Font = new Font(lbllogout.Font.Name, lbllogout.Font.SizeInPoints, FontStyle.Regular);
            lbllogout.ForeColor = Color.White;
        }
        private void lblwelcome_MouseEnter(object sender, EventArgs e)
        {
            lblwelcome.Font = new Font(lblwelcome.Font.Name, lblwelcome.Font.SizeInPoints, FontStyle.Bold);
            lblwelcome.ForeColor = Color.Yellow;
        }
        private void lblwelcome_MouseLeave(object sender, EventArgs e)
        {
            lblwelcome.Font = new Font(lblwelcome.Font.Name, lblwelcome.Font.SizeInPoints, FontStyle.Regular);
            lblwelcome.ForeColor = Color.White;
        }
        private void labelmenu_MouseEnter(object sender, EventArgs e)
        {
            lblmenu.Font = new Font(lblmenu.Font.Name, lblmenu.Font.SizeInPoints, FontStyle.Bold);
            lblmenu.ForeColor = Color.Yellow;
        }

        private void labelmenu_MouseLeave(object sender, EventArgs e)
        {
            lblmenu.Font = new Font(lblmenu.Font.Name, lblmenu.Font.SizeInPoints, FontStyle.Regular);
            lblmenu.ForeColor = Color.White;
        }

       
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingTimer.Start();
        }
        private void SettingTimer_Tick(object sender, EventArgs e)
        {
            if (Settingscollaps)
            {
                pnlmainsettings.Height = pnlmainsettings.Height + 10;
                if (pnlmainsettings.Height == pnlmainsettings.MaximumSize.Height)
                {
                    Settingscollaps = false;
                    SettingTimer.Stop();
                }
            }
            else
            {
                pnlmainsettings.Height = pnlmainsettings.Height - 10;
                if (pnlmainsettings.Height == pnlmainsettings.MinimumSize.Height)
                {
                    Settingscollaps = true;
                    SettingTimer.Stop();
                }
            }
        }
        private void btnupdatepwd_Click(object sender, EventArgs e)
        {
            waitform.Show(this);
            Thread.Sleep(2000);
            OpenChildForm(new Changepassword(), sender);
            ActiveButton(sender);
            waitform.Close();
        }

        private void btnassigntask_Click(object sender, EventArgs e)
        {
          
            waitform.Show(this);
            Thread.Sleep(2000);
            OpenChildForm(new Home.CreateWorkItem(), sender);
            ActiveButton(sender);
            waitform.Close();
        }

        private void WorkITemtimer_Tick(object sender, EventArgs e)
        {
            if (WorkItemcollaps)
            {
                pnlmainworkitm.Height = pnlmainworkitm.Height + 10;
                if (pnlmainworkitm.Height == pnlmainworkitm.MaximumSize.Height)
                {
                    WorkItemcollaps = false;
                    WorkItemtimer.Stop();
                }
            }
            else
            {
                pnlmainworkitm.Height = pnlmainworkitm.Height - 10;
                if (pnlmainworkitm.Height == pnlmainworkitm.MinimumSize.Height)
                {
                    WorkItemcollaps = true;
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
            Thread.Sleep(2000);
            OpenChildForm(new Home.WorkItemAssignments(), sender);
            ActiveButton(sender);
            waitform.Close();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    Datacount();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        //public void Datacount()
        //{
        //    int emp_all = obj.GetDataCountFromTable("Select Count(*) as data from UserMaster");
        //    lblnumbers.Text = emp_all.ToString();
        //    int emp_Activeemp = obj.GetDataCountFromTable("Select Count(*) as data from UserMaster where Isactive=1");
        //    lblactiveonly.Text = emp_Activeemp.ToString();
        //    int totaltask = obj.GetDataCountFromTable("SELECT Count(*) as data FROM dbo.tbl_workitemsassignment INNER JOIN dbo.tbl_workitems ON dbo.tbl_workitemsassignment.assigmentitemId = dbo.tbl_workitems.Id INNER JOIN dbo.tbl_status ON dbo.tbl_workitemsassignment.Status = dbo.tbl_status.StatusId LEFT OUTER JOIN dbo.UserMaster ON dbo.tbl_workitemsassignment.empid = dbo.UserMaster.empid");
        //    lbltotaltask.Text = totaltask.ToString();
        //    int taskcompleted = obj.GetDataCountFromTable("SELECT Count(*) as data FROM dbo.tbl_workitemsassignment INNER JOIN dbo.tbl_workitems ON dbo.tbl_workitemsassignment.assigmentitemId = dbo.tbl_workitems.Id INNER JOIN dbo.tbl_status ON dbo.tbl_workitemsassignment.Status = dbo.tbl_status.StatusId LEFT OUTER JOIN dbo.UserMaster ON dbo.tbl_workitemsassignment.empid = dbo.UserMaster.empid where dbo.tbl_workitemsassignment.Status=5");
        //    lbltaskcompleted.Text = taskcompleted.ToString();

        //    int totalactivity = obj.GetDataCountFromTable("Select Count(*) as data from tbl_activity");
        //    lbltotalactivity.Text = totalactivity.ToString();

        //    int totalactivity_Active= obj.GetDataCountFromTable("Select Count(*) as data from tbl_activity where Isactive=1");
        //    lblactiveactivity.Text = totalactivity_Active.ToString();


        //}
    }
}
