using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace TMS.UI.Utilities
{
    class CustomDatetimePicker : DateTimePicker
    {
        private Color fillcolor = Color.LightSeaGreen;
        private Color textcolor = Color.White;
        private Color bordercolor = Color.Gray;
        private int borderSize = 0;

        private bool dropdown = true;
        private Image CalenderImg = Properties.Resources.icons8_calendar_18;
        private RectangleF iconButton;
        private const int iconwidth = 34;
        private const int arrowwidth = 17;

        public Color FillColor
        {
            get
            {
                return fillcolor;
            }
            set
            {
                fillcolor = value;
                if(fillcolor.GetBrightness()>=0.6f)
                {
                    CalenderImg = Properties.Resources.calendarDark;
                }
                else
                {
                    CalenderImg = Properties.Resources.icons8_calendar_18;
                }
                this.Invalidate();
            }
        }
        public Color Textcolor { get { return textcolor; } set { textcolor = value; this.Invalidate(); } }
        public Color Bordercolor { get { return bordercolor; } set { bordercolor = value; this.Invalidate(); } }

        public int BorderSize { get { return borderSize; } set { borderSize = value; this.Invalidate(); } }

        public CustomDatetimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5f);
        }
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            dropdown = true;
        }
        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            dropdown = false;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen pen = new Pen(bordercolor, borderSize))
            using (SolidBrush fillbrush = new SolidBrush(fillcolor))
            using (SolidBrush textbrush = new SolidBrush(textcolor))
            using (SolidBrush iconbrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (StringFormat format = new StringFormat())
            {
                RectangleF dtpArea = new RectangleF(0, 0, this.Width - 0.5f, this.Height - 0.5f);
                RectangleF iconArea = new RectangleF(dtpArea.Width - iconwidth, 0, iconwidth, dtpArea.Height);
                pen.Alignment = PenAlignment.Inset;
                format.LineAlignment = StringAlignment.Center;


                graphics.FillRectangle(fillbrush, dtpArea);
                graphics.DrawString("   " + this.Text, this.Font, textbrush, dtpArea, format);

                if (dropdown == true) graphics.FillRectangle(iconbrush, iconArea);
                if (borderSize >= 1) graphics.DrawRectangle(pen, dtpArea.X, dtpArea.Y, dtpArea.Width, dtpArea.Height);
                graphics.DrawImage(CalenderImg, this.Width - CalenderImg.Width - 9, (this.Height - CalenderImg.Height) / 2);
            }
                
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconwidth = GetIconWidth();
            iconButton = new RectangleF(this.Width - iconwidth, 0, iconwidth,this.Height);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iconButton.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;

        }
        private int GetIconWidth()
        {
            int textwidth = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if(textwidth<=this.Width-(iconwidth+20))
            {
                return iconwidth;
            }
            else
            {
                return arrowwidth;
            }
        }
    }
}
