using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TMS.App_Code
{
    class MenuColorTable : ProfessionalColorTable
    {
        private Color backcolor;
        private Color leftcoloumncolor;
        private Color bordercolor;
        private Color menuitembordercolor;
        private Color menuitemselectedcolor;

        public MenuColorTable(bool ismainmenu, Color primarycolor)
        {
            if(ismainmenu)
            {
                backcolor = Color.FromArgb(37, 39, 60);
                leftcoloumncolor = Color.FromArgb(32, 33, 51);
                bordercolor = Color.FromArgb(32, 33, 51);
                menuitembordercolor = primarycolor;
                menuitemselectedcolor = primarycolor;
            }
            else
            {
                backcolor = Color.White;
                leftcoloumncolor = Color.LightGray;
                bordercolor = Color.LightGray;
                menuitembordercolor = primarycolor;
                menuitemselectedcolor = primarycolor;
            }
        }
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return backcolor;
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return bordercolor;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return menuitembordercolor;
            }
        }
        public override Color MenuItemSelected
        {
            get
            {
                return menuitemselectedcolor;
            }
        }
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return leftcoloumncolor;
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return leftcoloumncolor;
            }
        }
        public override Color ImageMarginRevealedGradientEnd
        {
            get
            {
                return leftcoloumncolor;
            }
        }


    }
}
