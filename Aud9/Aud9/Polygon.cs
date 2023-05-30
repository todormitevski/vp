using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aud9
{
    [Serializable]
    public class Polygon
    {
        List<Point> Points;
        public bool IsClosed { get; set; } = false;
        public bool CloseEnough { get; set; } = false;
        public Point Cursor { get; set; }

        public Polygon()
        {
            Points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            if (CloseEnough)
            {
                Points.Add(Points[0]);
                IsClosed = true;
                CloseEnough = false;
            }
            else
            {
                Points.Add(point);
            }
        }

        public void MoveCursor(Point cursor)
        {
            if(Points.Count >= 3) //so it's atleast a triangle
            {
                Point startingPoint = Points[0];
                var distance = Math.Sqrt(Math.Pow(startingPoint.X - cursor.X, 2) + Math.Pow(startingPoint.Y - cursor.Y, 2));
                CloseEnough = distance < 5;
            }
            Cursor = cursor;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            if(Points.Count > 1)
            {
                g.DrawLines(pen, Points.ToArray());
            }

            if (CloseEnough)
            {
                Point startingPoint = Points[0];
                g.DrawEllipse(pen, startingPoint.X - 5, startingPoint.Y - 5, 10, 10);
            }
            pen.Dispose();

            pen = new Pen(Color.Gray);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            if(Points.Count > 0)
            {
                g.DrawLine(pen, Points[Points.Count - 1], Cursor);
            }
            pen.Dispose();

            if (IsClosed && Points.Count > 1)
            {
                Brush brush = new SolidBrush(Color.Red);
                g.FillPolygon(brush, Points.ToArray());
            }
        }
    }
}
