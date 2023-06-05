using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGolf
{
    public class Hole
    {
        public static readonly int Radius = 30;
        public Point Center {  get; set; }
        public int Count { get; set; }

        public Hole(Point center)
        {
            Center = center;
            Count = 0;
        }

        public void Draw(Graphics g, Font font)
        {
            Brush brush = new SolidBrush(Color.Black);
            Brush fontBrush = new SolidBrush(Color.White);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            g.DrawString(string.Format("{0}", Count), font, fontBrush, Center.X - 10, Center.Y - 10);
        }

        public bool Touches(int x, int y)
        {
            return (x - Center.X) * (x - Center.X) + (y - Center.Y) * (y - Center.Y) <= Radius * Radius;
        }
    }
}
