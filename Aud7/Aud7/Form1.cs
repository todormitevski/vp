using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aud7
{
    public partial class Form1 : Form
    {
        Scene scene = new Scene();
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                scene.addShape(new Square(e.Location, rand.Next(20, 50), Color.Green));
            }
            else
            {
                if (!scene.Hit(e.Location))
                {
                    scene.addShape(new Circle(e.Location, rand.Next(20, 50), Color.Red));
                }
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Pulse();
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                scene.MoveUp();
            } else if(e.KeyCode == Keys.Down)
            {
                scene.MoveDown();
            } else if(e.KeyCode == Keys.Left)
            {
                scene.MoveLeft();
            } else if(e.KeyCode == Keys.Right)
            {
                scene.MoveRight();
            }
            Invalidate();
        }
    }
}
