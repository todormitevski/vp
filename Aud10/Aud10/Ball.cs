using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud10
{
    public class Ball
    {
        public Point Center { get; set; }

        //0 - red, 1 - yellow, 2 - green, 3 - for deletion, -1 ball offscreen
        public int Status { get; set; }
        public static int Radius { get; set; } = 25;

        public Ball(Point center, int status)
        {
            Center = center;
            Status = status;
        }

        public void Draw(Graphics g)
        {
            Brush brush;
            switch (Status)
            {
                case 0: brush = new SolidBrush(Color.Red); break;
                case 1: brush = new SolidBrush(Color.Yellow); break;
                default: brush = new SolidBrush(Color.Green); break;
            }

            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);

            Pen pen = new Pen(Color.HotPink, 4);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            pen.DashStyle = DashStyle.DashDot;
            g.DrawLine(pen, Center.X - 12, Center.Y - 12, Center.X + 12, Center.Y + 12);
            g.DrawLine(pen, Center.X - 12, Center.Y + 12, Center.X + 12, Center.Y - 12);

            brush.Dispose();
            pen.Dispose();
        }

        public bool IsHit(Point point)
        {
            bool result = Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2)) <= Radius;
            if (result)
            {
                ++Status;
                if (Status != 3)
                {
                    result = false;
                }
            }
            return result;
        }

        public void Move()
        {
            Center = new Point(Center.X + 10, Center.Y);
        }
    }
}
