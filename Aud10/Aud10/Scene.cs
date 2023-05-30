using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud10
{
    public class Scene
    {
        public List<Ball> Balls { get; set; }
        public int Width { get; set; }
        public int Hits { get; set; } = 0;
        public int Misses { get; set; } = 0;

        public Scene(int width)
        {
            Balls = new List<Ball>();
            this.Width = width;
        }

        public void AddBall(Ball ball)
        {
            Balls.Add(ball);
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
        }

        public void Move()
        {
            foreach (Ball b in Balls)
            {
                b.Move();
                if (b.Center.X > Width)
                {
                    b.Status = -1;
                }
            }
            DeleteBalls();
        }

        internal void Click(Point location)
        {
            foreach (Ball b in Balls)
            {
                if (b.IsHit(location))
                {
                    Hits++;
                }
            }
            DeleteBalls();
        }

        private void DeleteBalls()
        {
            for(int i=Balls.Count - 1; i >= 0; i--)
            {
                if (Balls[i].Status == 3)
                {
                    Balls.RemoveAt(i);
                }
                else if (Balls[i].Status == -1)
                {
                    Balls.RemoveAt(i);
                    ++Misses;
                }
            }
        }
    }
}
