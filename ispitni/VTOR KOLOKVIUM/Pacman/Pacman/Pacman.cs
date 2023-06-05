using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Pacman
    {
        public Point Position { get; set; }
        public String Direction { get; set; }
        public static int Radius { get; set; } = 20;
        public int Velocity { get; set; }
        public bool Zinat { get; set; }
        public Brush Brush { get; set; } = new SolidBrush(Color.Yellow);

        public Pacman()
        {
            Velocity = Radius;
            Position = new Point(7, 5);
            Direction = "right";
        }

        public void ChangeDirection(String direction)
        {
            this.Direction = direction;
        }

        public void Move()
        {
            switch (Direction)
            {
                case "left": Position = new Point(Position.X - 1, Position.Y); break;
                case "right": Position = new Point(Position.X + 1, Position.Y); break;
                case "up": Position = new Point(Position.X, Position.Y - 1); break;
                case "down": Position = new Point(Position.X - 1, Position.Y); break;
            }

            if(Position.X > 15)
            {
                Position = new Point(0, Position.Y);
            }
            if(Position.X < 0)
            {
                Position = new Point(15, Position.Y);
            }
            if(Position.Y > 10)
            {
                Position = new Point(Position.X, 0);
            }
            if(Position.Y < 0)
            {
                Position = new Point(Position.X, 10);
            }

            Zinat = !Zinat;
        }

        public void Draw(Graphics g)
        {
            if (Zinat)
            {

            }
            else
            {
                g.FillEllipse(Brush, Position.X - Radius, Position.Y - Radius, 2 * Radius, 2 * Radius);
            }
        }
    }
}
