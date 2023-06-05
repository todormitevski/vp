using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles
{
    [Serializable]
    public class Scene
    {
        public List<Circle> Circles {  get; set; }

        public Scene()
        {
            Circles = new List<Circle>();
        }

        public void AddCircle(Point point, int radius, Color color)
        {
            Circles.Add(new Circle(point, radius, color));
        }

        public void Draw(Graphics g)
        {
            foreach (Circle c in Circles)
            {
                c.Draw(g);
            }
        }

        public void Select(Point point)
        {
            foreach (Circle c in Circles)
            {
                c.Select(point);
            }
        }

        public void DeleteSelected()
        {
            for(int i=Circles.Count - 1; i >= 0; i--)
            {
                if (Circles[i].IsSelected)
                {
                    Circles.RemoveAt(i);
                }
            }
        }
    }
}
