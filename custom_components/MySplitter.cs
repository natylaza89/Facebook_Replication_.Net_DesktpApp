using System.Drawing;
using System.Windows.Forms;

namespace DP_Task1.custom_components
{
    class MySplitter : Splitter
    {
        public ButtonBorderStyle BORDER_SIZE { get; private set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                             Color.Black, 0, ButtonBorderStyle.Inset,
                             Color.Yellow, 0, ButtonBorderStyle.Inset,
                             Color.Black, 1, ButtonBorderStyle.Inset,
                             Color.Blue, 0, ButtonBorderStyle.Inset);
        }
    }
}
