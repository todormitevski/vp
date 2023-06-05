using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
    [Serializable]
    public class Pie
    {
        public Point Point { get; set; }
        public Color Color { get; set; }
        public int Radius { get; set; }
        public int Ticks { get; set; } = 4;

        public Pie(Point point, Color color)
        {
            Point = point;
            Color = color;
            Radius = 25;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillPie(brush, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2, 0, 90 * Ticks);
            brush.Dispose();
        }
    }
}
