using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TMS.UI.Utilities
{
    class CustomDatetimePicker : DateTimePicker
    {
        private Color _fillColor = Color.LightSeaGreen;
        private Color _textColor = Color.White;
        private Color _borderColor = Color.Gray;

        private int _borderSize = 0;

        private bool _dropDown = true;

        private Image _calenderImage = Properties.Resources.icons8_calendar_18;

        private RectangleF _iconButton;
        
        private const int _iconWidth = 34;
        private const int _arrowWidth = 17;


        public Color FillColor
        {
            get
            {
                return _fillColor;
            }
            set
            {
                _fillColor = value;
                if(_fillColor.GetBrightness()>=0.6f)
                {
                    _calenderImage = Properties.Resources.calendarDark;
                }
                else
                {
                    _calenderImage = Properties.Resources.icons8_calendar_18;
                }
                this.Invalidate();
            }
        }
        
        public Color Textcolor { get { return _textColor; } set { _textColor = value; this.Invalidate(); } }
     
        public Color Bordercolor { get { return _borderColor; } set { _borderColor = value; this.Invalidate(); } }

        public int BorderSize { get { return _borderSize; } set { _borderSize = value; this.Invalidate(); } }

        public CustomDatetimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5f);
        }
        
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            _dropDown = true;
        }
       
        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            _dropDown = false;
        }
        
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }
       
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen pen = new Pen(_borderColor, _borderSize))
            using (SolidBrush fillBrush = new SolidBrush(_fillColor))
            using (SolidBrush textBrush = new SolidBrush(_textColor))
            using (SolidBrush iconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (StringFormat stringFormat = new StringFormat())
            {
                RectangleF dtpArea = new RectangleF(0, 0, this.Width - 0.5f, this.Height - 0.5f);
                RectangleF iconArea = new RectangleF(dtpArea.Width - _iconWidth, 0, _iconWidth, dtpArea.Height);
                pen.Alignment = PenAlignment.Inset;
                stringFormat.LineAlignment = StringAlignment.Center;


                graphics.FillRectangle(fillBrush, dtpArea);
                graphics.DrawString("   " + this.Text, this.Font, textBrush, dtpArea, stringFormat);

                if (_dropDown == true) graphics.FillRectangle(iconBrush, iconArea);
                if (_borderSize >= 1) graphics.DrawRectangle(pen, dtpArea.X, dtpArea.Y, dtpArea.Width, dtpArea.Height);
                graphics.DrawImage(_calenderImage, this.Width - _calenderImage.Width - 9, (this.Height - _calenderImage.Height) / 2);
            }       
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconWidth();
            _iconButton = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }
     
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_iconButton.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;

        }
        
        private int GetIconWidth()
        {
            int textWidth = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if(textWidth<=this.Width-(_iconWidth+20))
            {
                return _iconWidth;
            }
            else
            {
                return _arrowWidth;
            }
        }
    }
}
