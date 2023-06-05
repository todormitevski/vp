using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
    [Serializable]
    public class Scene
    {
        public List<Pie> Pies { get; set; }

        public Scene()
        {
            Pies = new List<Pie>();
        }

        public void AddPie(Pie pie)
        {
            Pies.Add(pie);
        }

        public void Draw(Graphics g)
        {
            foreach (Pie p in Pies)
            {
                p.Draw(g);
            }
        }

        public void TickPies()
        {
            for(int i = Pies.Count - 1; i >= 0; i--)
            {
                Pies[i].Ticks--;
                if (Pies[i].Ticks == 0)
                {
                    Pies.RemoveAt(i);
                }
            }
        }
    }
}
