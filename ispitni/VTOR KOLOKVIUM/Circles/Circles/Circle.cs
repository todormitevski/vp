using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles
{
    [Serializable]
    public class Circle
    {
        public Point Point { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public Circle(Point point, int radius, Color color)
        {
            Point = point;
            Radius = radius;
            Color = color;
            IsSelected = false;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);

            if (IsSelected)
            {
                Pen pen = new Pen(Brushes.Red, 5);
                g.DrawEllipse(pen, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
                pen.Dispose();
            }

            brush.Dispose();
        }

        public static float Distance(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);
        }

        public void Select(Point point)
        {
            if (Distance(point, Point) <= Radius * Radius)
            {
                IsSelected = !IsSelected;
            }
        }
    }
}
