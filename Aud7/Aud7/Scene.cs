using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud7
{
    public class Scene
    {
        public List<Shape> Shapes { get; set; } = new List<Shape>();
        public void addShape(Shape shape)
        {
            Shapes.Add(shape);
        }
        public void Draw(Graphics g)
        {
            foreach (Shape shape in Shapes)
            {
                shape.Draw(g);
            }
        }

        internal bool Hit(Point location)
        {
            foreach(Shape shape in Shapes)
            {
                if (shape.Hit(location))
                {
                    return true;
                }
            }
            return false;
        }

        internal void MoveDown()
        {
            foreach (Shape shape in Shapes) 
            { 
                shape.MoveDown();
            }
        }

        internal void MoveLeft()
        {
            foreach (Shape shape in Shapes)
            {
                shape.MoveLeft();
            }
        }

        internal void MoveRight()
        {
            foreach (Shape shape in Shapes)
            {
                shape.MoveRight();
            }
        }

        internal void MoveUp()
        {
            foreach (Shape shape in Shapes)
            {
                shape.MoveUp();
            }
        }

        internal void Pulse()
        {
            foreach (Shape shape in Shapes){
                shape.Pulse();
            }
        }
    }
}
