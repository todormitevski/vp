using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agario
{
    public partial class HoodAgario : Form
    {
        Scene Scene;
        int Ticks = 0;
        public HoodAgario()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Start();
            Scene = new Scene(Width, Height);
        }

        private void HoodAgario_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.MoveEnemies();
            Ticks++;

            if(Ticks % 7 == 0)
            {
                Enemy enemy = new Enemy(new Point(Scene.rand.Next(50, Width - 50), Scene.rand.Next(50, Height - 50)), Scene.rand.Next(1, 5));
                Scene.AddEnemy(enemy);
            }

            Invalidate();
        }

        private void HoodAgario_MouseMove(object sender, MouseEventArgs e)
        {
            if (Scene.Player.Alive)
            {
                Scene.Player.Move(e.Location);
            }
            Scene.checkForDeletion(Scene.Player);
            Invalidate();
        }

        private void HoodAgario_MouseClick(object sender, MouseEventArgs e)
        {
            if (!Scene.Player.Alive)
                Scene.Player.Alive = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Saving Agario App";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Scene);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a Agario drawing";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                Scene = (Scene)formatter.Deserialize(fs);
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                pauseToolStripMenuItem.Text = "Play";
            }
            else
            {
                timer1.Start();
                pauseToolStripMenuItem.Text = "Pause";
            }
        }
    }
}
