using Pacman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class HoodPacman : Form
    {
        Timer timer;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        bool[][] World;
        public HoodPacman()
        {
            InitializeComponent();
            foodImage = Resources.caster;
            this.DoubleBuffered = true;
            newGame();
        }

        public void newGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.Radius * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.Radius * (WORLD_HEIGHT + 1);

            World = new bool[WORLD_WIDTH][];
            for(int i = 0; i < World.Length; i++)
            {
                World[i] = new bool[WORLD_HEIGHT];
                for(int j = 0; j < World[i].Length; j++)
                {
                    World[i][j] = true;
                }
            }

            timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Start();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < WORLD_WIDTH; i++)
            {
                for(int j = 0; j < WORLD_HEIGHT; j++)
                {
                    if(pacman.Position == new Point(i, j))
                    {
                        World[i][j] = false;
                    }
                }
            }

            pacman.Move();
            Invalidate();
        }

        private void HoodPacman_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                pacman.ChangeDirection("up");
            } else if(e.KeyCode == Keys.S)
            {
                pacman.ChangeDirection("down");
            } else if(e.KeyCode == Keys.A)
            {
                pacman.ChangeDirection("left");
            } else if(e.KeyCode == Keys.D)
            {
                pacman.ChangeDirection("right");
            }
            Invalidate();
        }

        private void HoodPacman_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for(int i = 0; i < World.Length; i++)
            {
                for(int j = 0; j < World[i].Length; j++)
                {
                    if (World[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Height) / 2, i * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }
    }
}
