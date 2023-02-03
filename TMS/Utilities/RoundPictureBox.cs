using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TMS.UI.Utilities
{
    class RoundPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath graph = new GraphicsPath();
            graph.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(graph);
            base.OnPaint(pe);
        }
    }
}
