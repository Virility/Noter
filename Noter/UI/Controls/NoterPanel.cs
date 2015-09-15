using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Noter.UI.Helpers;

namespace Noter.UI.Controls
{
    public class NoterPanel : ContainerControl
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.FromArgb(96, 110, 121));

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var innerRectangle = ClientRectangle;
            innerRectangle.Height -= 4;

            g.FillPath(Brushes.LightGray, RoundRect.Round(ClientRectangle, 7));
            g.FillPath(Brushes.White, RoundRect.Round(innerRectangle, 7));

            base.OnPaint(e);
        }
    }
}