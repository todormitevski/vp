using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agario
{
    [Serializable]
    public class Enemy
    {
        public Point Point { get; set; }
        public static int Radius { get; set; } = 15;
        public Color Color { get; set; }
        public int Direction { get; set; }

        public Enemy(Point point, int direction)
        {
            Point = point;
            Direction = direction;
        }

        public void Draw(Graphics g)
        {
            Random random = new Random();
            int randColor = random.Next(0, 2);
            if(randColor == 0)
            {
                Color = Color.Lime;
            }
            else
            {
                Color = Color.Yellow;
            }

            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);

            Pen pen = new Pen(Color.Black);
            pen.Width = 1;
            g.DrawEllipse(pen, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
            
            brush.Dispose();
            pen.Dispose();
        }

        public void Move()
        {
            switch (Direction)
            {
                case 1: Point = new Point(Point.X, Point.Y - Radius); break;
                case 2: Point = new Point(Point.X, Point.Y + Radius); break;
                case 3: Point = new Point(Point.X - Radius, Point.Y); break;
                case 4: Point = new Point(Point.X + Radius, Point.Y); break;
            }
        }

        public void Bounce()
        {
            switch (Direction)
            {
                case 1: Direction = 2; break;
                case 2: Direction = 1; break;
                case 3: Direction = 4; break;
                case 4: Direction = 3; break;
            }
        }
    }
}
