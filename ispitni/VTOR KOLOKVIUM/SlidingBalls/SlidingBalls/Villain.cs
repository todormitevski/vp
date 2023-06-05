using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class Villain : Ball
    {
        public bool IsMoving;
        public int Velocity;
        public int Direction;
        public Villain(Point point, Color color, int direction) : base(point, color)
        {
            IsMoving = false;
            Velocity = 10;
            Direction = direction;
        }

        public bool IsHit(Ball ball)
        {
            bool hit = false;
            if(ball.Color == Color.Green)
            {
                hit = Math.Sqrt(Math.Pow(Point.X - ball.Point.X, 2) + Math.Pow(Point.Y - ball.Point.Y, 2)) <= Radius;
            }
            return hit;
        }

        public void Move()
        {
            switch (Direction)
            {
                case 0: Point = new Point(Point.X + Velocity, Point.Y); break;
                case 1: Point = new Point(Point.X - Velocity, Point.Y); break;
                case 2: Point = new Point(Point.X, Point.Y + Velocity); break;
                case 3: Point = new Point(Point.X, Point.Y - Velocity); break;
            }
        }
    }
}
