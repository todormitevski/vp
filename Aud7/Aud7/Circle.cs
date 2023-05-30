using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud7
{
    public class Circle : Shape
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; } = Color.Red;

        readonly int MinRadius = 5;
        readonly int MaxRadius = 80;
        bool IncrementSize = true;

        public Circle(Point center, int radius, Color color)
        {
            Center = center;
            Radius = radius;
            Color = color;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            brush.Dispose();

            if (IsSelected)
            {
                Pen pen = new Pen(Color.Purple, 5);
                g.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                pen.Dispose();
            }
        }

        internal override bool Hit(Point location)
        {
            bool result = Shape.Distance(Center, location) <= Radius;
            if (result)
            {
                IsSelected = !IsSelected;
            }
            return result;
        }

        internal override void Pulse()
        {
            if(IncrementSize)
            {
                Radius += 5;
                if(Radius >= MaxRadius)
                {
                    IncrementSize = false;
                }
            }
            else
            {
                Radius -= 5;
                if(Radius <= MinRadius)
                {
                    IncrementSize = true;
                }
            }
        }

        public override void MoveLeft()
        {
            if(IsSelected)
                Center = new Point(Center.X - 5, Center.Y);
        }

        public override void MoveRight()
        {
            if (IsSelected)
                Center = new Point(Center.X + 5, Center.Y);
        }

        public override void MoveUp()
        {
            if (IsSelected)
                Center = new Point(Center.X, Center.Y - 5);
        }

        public override void MoveDown()
        {
            if (IsSelected)
                Center = new Point(Center.X, Center.Y + 5);
        }
    }
}
