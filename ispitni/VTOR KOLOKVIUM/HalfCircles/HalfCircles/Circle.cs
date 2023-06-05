using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    public class Circle
    {
        public Point Point { get; set; }
        public Color Color { get; set; }
        public int Radius { get; set; } = 30;

        public Circle(Point point, Color color)
        {
            Point = point;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            Brush brush1 = new SolidBrush(Color);
            Brush brush2 = new SolidBrush(Color);
            g.FillPie(brush1, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2, 0, 180);
            g.FillPie(brush2, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2, 180, 180);
            brush1.Dispose();
            brush2.Dispose();
        }
    }
}
