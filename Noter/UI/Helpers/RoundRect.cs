using System.Drawing;
using System.Drawing.Drawing2D;

namespace Noter.UI.Helpers
{
    public static class RoundRect
    {
        public static GraphicsPath Round(Rectangle rectangle, int slope)
        {
            var path = new GraphicsPath(FillMode.Winding);
            path.AddArc(rectangle.X, rectangle.Y, slope, slope, 180f, 90f);
            path.AddArc(rectangle.Right - slope, rectangle.Y, slope, slope, 270f, 90f);
            path.AddArc(rectangle.Right - slope, rectangle.Bottom - slope, slope, slope, 0f, 90f);
            path.AddArc(rectangle.X, rectangle.Bottom - slope, slope, slope, 90f, 90f);
            path.CloseFigure();
            return path;
        }

        public static GraphicsPath Round(int x, int y, int height, int width, int slope)
        {
            return Round(new Rectangle(x, y, height, width), slope);
        }
    }
}