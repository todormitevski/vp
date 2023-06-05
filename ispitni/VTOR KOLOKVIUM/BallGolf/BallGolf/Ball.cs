using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGolf
{
    public class Ball
    {
        public int Radius { get; set; } = 25;
        public Point Center { get; set; }
        public Color Color { get; set; } = Color.Red;
        public bool IsInHole { get; set; } = false;
        public int Velocity { get; set; } = 10;
        public double Angle { get; set; }
        public float VelocityX { get; set; }
        public float VelocityY { get; set; }
        Random rand = new Random();

        public Ball(Point center, Color color)
        {
            Center = center;
            Color = color;

            Angle = rand.NextDouble() * 2 * Math.PI;
            VelocityX = (float)(Math.Cos(Angle) * Velocity);
            VelocityY = (float)(Math.Sin(Angle) * Velocity);
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }

        public void Move(int left, int top, int width, int height)
        {
            int nextX = (int)(Center.X + VelocityX);
            int nextY = (int)(Center.Y + VelocityY);
            int lft = left + Radius;
            int rgt = left + width - Radius;
            int tp = top + Radius;
            int btm = top + height - Radius;

            if(nextX <= left)
            {
                nextX = lft + (left - nextX);
                VelocityX = -VelocityX;
            }

            if(nextX >= rgt)
            {
                nextX = rgt - (nextX - rgt);
                VelocityX = -VelocityX;
            }

            if(nextY <= tp)
            {
                nextY = tp + (tp - nextY);
                VelocityY = -VelocityY;
            }

            if(nextY >= btm)
            {
                nextY = btm - (nextY - btm);
                VelocityY = -VelocityY;
            }

            Center = new Point(nextX, nextY);
        }

        public bool InHole(Hole hole)
        {
            float d = (Center.X - hole.Center.X) * (Center.X - hole.Center.X) + (Center.Y - hole.Center.Y) * (Center.Y - hole.Center.Y);
            return d <= Radius * Radius;
        }
    }
}
