using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agario
{
    [Serializable]
    public class Player
    {
        public int Radius { get; set; }
        public Color Color { get; set; }
        public bool Alive { get; set; }
        public Point Point { get; set; }

        public Player()
        {
            Radius = 25;
            Color = Color.Black;
            Alive = false;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }

        public void Move(Point point)
        {
            Point = point;
        }

        public bool CheckCollision(Point point)
        {
            bool collision = Math.Sqrt(Math.Pow(Point.X - point.X, 2) + Math.Pow(Point.Y - point.Y, 2)) <= Radius;
            return collision;
        }

        public void PopBall()
        {
            if (Radius >= 70)
            {
                Alive = false;
                Radius = 15;
            }
            Radius += 5;
        }
    }
}
