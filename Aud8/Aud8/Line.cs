using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud8
{
    internal class Line
    {
        public Point PointA { get; set; }
        public Point PointB { get; set; }
        public Color Color { get; set; }
        public int Thickness { get; set; }

        public Line(Point pointA, Point pointB, Color color, int thickness)
        {
            PointA = pointA;
            PointB = pointB;
            Color = color;
            Thickness = thickness;
        }

        public void Draw (Graphics g)
        {
            Pen pen = new Pen(Color, Thickness);
            g.DrawLine(pen, PointA, PointB);
            pen.Dispose();
        }
    }
}
