using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud7
{
    public class Square : Shape
    {
        public Point Center { get; set; }
        public int Size { get; set; }
        public Color Color { get; set; } = Color.Red;

        public Square(Point center, int size, Color color)
        {
            Center = center;
            Size = size;
            Color = color;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillRectangle(brush,Center.X - Size/2,Center.Y - Size/2,Size,Size);
            brush.Dispose();
        }

        public override void MoveDown()
        {
            //throw new NotImplementedException();
        }

        public override void MoveLeft()
        {
            //throw new NotImplementedException();
        }

        public override void MoveRight()
        {
            //throw new NotImplementedException();
        }

        public override void MoveUp()
        {
            //throw new NotImplementedException();
        }

        internal override bool Hit(Point location)
        {
            return false;
        }

        internal override void Pulse()
        {
            //throw new NotImplementedException();
        }
    }
}
