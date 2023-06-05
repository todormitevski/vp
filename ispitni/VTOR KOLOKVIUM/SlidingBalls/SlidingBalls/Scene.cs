using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class Scene
    {
        public List<BGBall> BGBalls { get; set; }
        public List<Villain> Villains { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Scene(int width, int height)
        {
            BGBalls = new List<BGBall>();
            Villains = new List<Villain>();
            Width = width;
            Height = height;
        }

        public void AddBall(Ball ball)
        {
            if(ball.Color == Color.Red)
            {
                Villains.Add((Villain)ball);
            }
            else
            {
                BGBalls.Add((BGBall)ball);
            }
        }

        public bool CheckIfMovingVillain()
        {
            foreach (Villain villain in Villains)
            {
                if (villain.IsMoving)
                    return true;
            }
            return false;
        }

        public void Draw(Graphics g)
        {
            foreach (BGBall ball in BGBalls)
            {
                ball.Draw(g);
            }
            foreach (Villain ball in Villains)
            {
                ball.Draw(g);
            }
        }

        public void Activate()
        {
            if (!CheckIfMovingVillain())
            {
                for(int i = Villains.Count - 1; i >= 0; i--)
                {
                    Villains[i].IsMoving = true;
                }
            }
        }

        public void Move()
        {
            for (int i = Villains.Count - 1; i >= 0; i--)
            {
                if (Villains[i].IsMoving)
                {
                    Villains[i].Move();
                }
            }
        }
    }
}
