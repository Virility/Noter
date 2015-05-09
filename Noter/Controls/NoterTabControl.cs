using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Noter.Helpers;

namespace Noter.Controls
{
    public sealed class NoterTabControl : TabControl
    {
        private readonly Pen _p1;
        private readonly Pen _p2;
        private readonly Pen _p3;

        private readonly SolidBrush _b1;
        private readonly SolidBrush _b2;

        private readonly Font _tabFont;
        private readonly StringFormat _stringFormat;

        public NoterTabControl()
        {
            SetStyle((ControlStyles)139286, true);
            SetStyle(ControlStyles.Selectable, false);

            SizeMode = TabSizeMode.Fixed;
            Alignment = TabAlignment.Left;
            ItemSize = new Size(28, 115);
            DrawMode = TabDrawMode.OwnerDrawFixed;

            _p1 = new Pen(Color.FromArgb(65, 75, 85));
            _p2 = new Pen(Color.FromArgb(115, 125, 135));
            _p3 = new Pen(Color.FromArgb(20, 0, 0, 0), 4);

            _b1 = new SolidBrush(Color.FromArgb(80, 90, 100));
            _b2 = new SolidBrush(Color.FromArgb(210, 220, 230));
            
            _tabFont = new Font("Verdana", 7.5f, FontStyle.Bold);
            _stringFormat = new StringFormat
                {LineAlignment = StringAlignment.Center};
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.FromArgb(96, 110, 121));

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath graphicsPath;
            var itemHeight = ItemSize.Height + 2;

            for (var i = 0; i < TabCount; i++) 
            {
                var tabPage = TabPages[i];

                var tabRectangle = GetTabRect(i);
                tabRectangle.Y += 2;
                tabRectangle.Height -= 3;
                tabRectangle.Width += 5;
                tabRectangle.X -= 1;

                if (i == SelectedIndex)
                {
                    using (graphicsPath = RoundRect.Round(tabRectangle, 7))
                    {
                        g.FillPath(_b1, graphicsPath);
                        g.DrawPath(_p2, graphicsPath);
                    }

                    using (graphicsPath = RoundRect.Round(tabRectangle.X + 2, tabRectangle.Y + 3, tabRectangle.Width, tabRectangle.Height - 6, 7))
                        g.DrawPath(_p3, graphicsPath);
                }

                tabRectangle.X += 10;

                var offsetTabRectangle = tabRectangle;
                offsetTabRectangle.Y += 1;
                offsetTabRectangle.X += 1;

                var tabText = tabPage.Text.ToUpper();
                g.DrawString(tabText, _tabFont, Brushes.Black, offsetTabRectangle, _stringFormat);
                g.DrawString(tabText, _tabFont, (i == SelectedIndex) ? Brushes.White : _b2, tabRectangle, _stringFormat);
            }

            using (graphicsPath = RoundRect.Round(itemHeight, 0, Width - itemHeight - 1, Height - 1, 15))
            {
                g.FillPath(Brushes.White, graphicsPath);
                g.DrawPath(_p1, graphicsPath);
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            if (e.Control is TabPage)
                e.Control.BackColor = Color.White;

            base.OnControlAdded(e);
        }
    }
}