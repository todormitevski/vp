using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aud10
{
    public partial class FlyingBallsForm : Form
    {
        Scene scene;
        int timerTicks = 0;
        Random rand = new Random();
        public FlyingBallsForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            timer1.Start();
            scene = new Scene(this.Width);
            slHitsMisses.Text = "Hits: 0 | Misses: 0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Move();
            if(timerTicks % 7 == 0)
            {
                scene.AddBall(new Ball(new Point(-Ball.Radius, rand.Next(2 * Ball.Radius, this.Height - 2 * Ball.Radius)), rand.Next(3)));
            }
            ++timerTicks;
            UpdateStatusLabel();
            Invalidate();
        }

        private void FlyingBallsForm_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void FlyingBallsForm_MouseClick(object sender, MouseEventArgs e)
        {
            scene.Click(e.Location);
            UpdateStatusLabel();
            Invalidate();
        }

        private void UpdateStatusLabel()
        {
            slHitsMisses.Text = $"Hits: {scene.Hits} | Misses: {scene.Misses}";
        }

        private void FlyingBallsForm_ResizeEnd(object sender, EventArgs e)
        {
            scene.Width = this.Width;
        }
    }
}
