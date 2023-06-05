using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    public class Scene
    {
        public List<Circle> Circles { get; set; }

        public Scene()
        {
            Circles = new List<Circle>();
        }

        public void AddCircle(Circle circle)
        {
            Circles.Add(circle);
        }

        public void Draw(Graphics g)
        {
            foreach (var circle in Circles)
            {
                circle.Draw(g);
            }
        }
    }
}
