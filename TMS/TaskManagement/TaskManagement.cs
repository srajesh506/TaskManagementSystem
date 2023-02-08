using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TMS.UI;
using TMS.UI.Utilities;

namespace TMS.UI
{
    public partial class TaskManagement : Form
    {
        public TaskManagement()
        {
            InitializeComponent();
            addControl(new DefineActivity());
            pnlManageActivity.BackColor = Color.Black;
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
            //grpboxmember.ForeColor = ThemeColor.PrimaryColor;
           
        }
        private void addControl(Control usercontrol)
        {
            
            usercontrol.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void btn_click(object sender, EventArgs e)
        {
            foreach (var pnl in tableLayoutPanelMain.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Silver;
            }
            Button btn = (Button)sender;
            switch(btn.Name)
            {
                case "btnmanageactivity":
                    addControl(new DefineActivity());
                    pnlManageActivity.BackColor = Color.Black;
                    break;
                case "btnManagetask":
                    addControl(new DefineTask());
                    pnlManageTask.BackColor = Color.Black;
                    break;
                case "btnmanagesubtask":
                    addControl(new DefineSubTask());
                    pnlManageSubtask.BackColor = Color.Black;
                    break;
                default:
                    break;
            }
        }
    }
}
