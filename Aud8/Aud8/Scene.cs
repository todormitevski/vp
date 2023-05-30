using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aud8
{
    internal class Scene
    {
        public List<Line> Lines { get; set; }
        public Point LastPoint { get; set; }
        public Color Color { get; set; }
        public int Thickness { get; set; }
        public bool Positioner { get; set; }
        public Point Cursor { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Stack<Line> UndoStack { get; set; }

        public Scene(int Width, int Height)
        {
            Lines = new List<Line>();
            Color = Color.Red;
            Thickness = 1;
            LastPoint = Point.Empty;
            Positioner = false;
            this.Width = Width;
            this.Height = Height;
            UndoStack = new Stack<Line>();
        }

        public void AddPoint(Point point)
        {
            if (!LastPoint.IsEmpty)
            {
                Lines.Add(new Line(LastPoint, point, Color, Thickness));
            }
            LastPoint = point;
        }

        public void Draw(Graphics g)
        {
            foreach (Line line in Lines)
            {
                line.Draw(g);
            }

            if (Positioner)
            {
                Pen pen = new Pen(Color.Black);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(pen, new Point(0, Cursor.Y), new Point(Width, Cursor.Y));
                g.DrawLine(pen, new Point(Cursor.X, 0), new Point(Cursor.X, Height));
                pen.Dispose();
            }
        }

        internal void Undo()
        {
            if(Lines.Count > 0)
            {
                Line lastLine = Lines[Lines.Count - 1];
                UndoStack.Push(lastLine);
                Lines.RemoveAt(Lines.Count - 1);
                if (Lines.Count == 0)
                {
                    LastPoint = Point.Empty;
                }
                else
                {
                    LastPoint = Lines[Lines.Count - 1].PointB;
                }
            }
        }

        internal void Redo()
        {
            if(UndoStack.Count > 0)
            {
                Line line = UndoStack.Pop();
                Lines.Add(line);
                LastPoint = line.PointB;
            }
        }
    }
}
