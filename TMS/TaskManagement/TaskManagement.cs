using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI.Utilities;
using TMS.BusinessEntities;

namespace TMS.UI
{
    public partial class TaskManagementForm : Form
    {
        public TaskManagementForm()
        {
            InitializeComponent();
            if(UserInfo.TaskManagementPageName==null)
            {
                AddControl(new DefineActivity());
                pnlManageActivity.BackColor = Color.Black;
            }
            else
            {
                foreach (var pnl in tblLayoutPanelMain.Controls.OfType<Panel>())
                {
                    pnl.BackColor = Color.Silver;
                }
                switch (UserInfo.TaskManagementPageName)
                {

                    case "DefineActivity":
                        AddControl(new DefineActivity());
                        pnlManageActivity.BackColor = Color.Black;
                        break;
                    case "DefineTask":
                        AddControl(new DefineTask());
                        pnlManageTask.BackColor = Color.Black;
                        break;
                    case "DefineSubTask":
                        AddControl(new DefineSubTask());
                        pnlManageSubTask.BackColor = Color.Black;
                        break;
                    default:
                        break;
                }
                //UserInfo.Taskmanagementpagename = null;
            }
          
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
        }
        private void AddControl(Control userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            foreach (var pnl in tblLayoutPanelMain.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Silver;
            }
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnManageActivity":
                    AddControl(new DefineActivity());
                    pnlManageActivity.BackColor = Color.Black;
                    break;
                case "btnManageTask":
                    AddControl(new DefineTask());
                    pnlManageTask.BackColor = Color.Black;
                    break;
                case "btnManageSubTask":
                    AddControl(new DefineSubTask());
                    pnlManageSubTask.BackColor = Color.Black;
                    break;
                default:
                    break;
            }
        }
    }
}
