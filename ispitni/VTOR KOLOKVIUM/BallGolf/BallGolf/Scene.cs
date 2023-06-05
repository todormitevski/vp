using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGolf
{
    public class Scene
    {
        public List<Ball> Balls { get; set; }
        public List<Hole> Holes { get; set; }
        Random rand;
        Font font;

        public Scene()
        {
            Balls = new List<Ball>();
            Holes = new List<Hole>();
            rand = new Random();
            font = new Font("Arial", 20);
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
            foreach (Hole hole in Holes)
            {
                hole.Draw(g, font);
            }
        }

        public void MoveBalls(int left, int top, int width, int height)
        {
            foreach (Ball b in Balls)
            {
                b.Move(left, top, width, height);
            }
        }

        public void CheckCollisions()
        {
            for(int i = 0; i < Balls.Count; i++)
            {
                for(int j = 0; j < Holes.Count; j++)
                {
                    if (Balls[i].InHole(Holes[j]))
                    {
                        Balls[i].IsInHole = true;
                        Holes[j].Count++;
                    }
                }
            }

            for(int i = Balls.Count - 1; i >= 0; i--)
            {
                if (Balls[i].IsInHole)
                {
                    Balls.RemoveAt(i);
                }
            }
        }

        public void GenerateHoles(int left, int top, int width, int height)
        {
            Holes = new List<Hole>();
            GenerateHolesR(left, top, width, height);
        }

        public void GenerateHolesR(int left, int top, int width, int height)
        {
            if (Holes.Count == 5) return;
            int x = rand.Next(left + Hole.Radius, (left + width) - Hole.Radius);
            int y = rand.Next(top + Hole.Radius, (top + height) - Hole.Radius);
            bool touches = false;

            foreach (Hole hole in Holes)
            {
                touches = hole.Touches(x, y);
                if (touches) break;
            }

            if (!touches)
            {
                Hole h = new Hole(new Point(x, y));
                Holes.Add(h);
            }
            GenerateHolesR(left, top, width, height);
        }
    }
}
