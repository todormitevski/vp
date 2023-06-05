using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalfCircles
{
    public partial class Form1 : Form
    {
        Scene scene;
        Color currColor;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            New();
            currColor = Color.Red;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            scene.AddCircle(new Circle(e.Location, currColor));
            UpdateStatus();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        public void New()
        {
            scene = new Scene();
            UpdateStatus();
            Invalidate();
        }

        public void UpdateStatus()
        {
            slNumCircles.Text = String.Format("Total: {0}", scene.Circles.Count);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            New();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                currColor = cd.Color;
            }
        }
    }
}
