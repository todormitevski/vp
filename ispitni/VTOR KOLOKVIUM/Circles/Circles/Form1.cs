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

namespace Circles
{
    public partial class Form1 : Form
    {
        Scene scene;
        Point currPoint;
        Point prevPoint;
        Color currColor;
        string FileName;
        int Radius;

        public Form1()
        {
            InitializeComponent();
            newScene();
            this.DoubleBuffered = true;
            currColor = Color.Green;
        }

        public void newScene()
        {
            scene = new Scene();
            prevPoint = Point.Empty;
            currPoint = Point.Empty;
            FileName = "Untitled";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (prevPoint.IsEmpty)
                {
                    prevPoint = e.Location;
                }
                else
                {
                    scene.AddCircle(prevPoint, Radius, currColor);
                    prevPoint = Point.Empty;
                    currPoint = Point.Empty;
                }
                Invalidate();
            }
            if(e.Button == MouseButtons.Right)
            {
                scene.Select(e.Location);
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currPoint = e.Location;
            Radius = (int)Math.Sqrt(Circle.Distance(currPoint, prevPoint));
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            scene.Draw(e.Graphics);
            if (!prevPoint.IsEmpty)
            {
                Pen radLine = new Pen(Color.Black, 3);
                radLine.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                e.Graphics.DrawEllipse(radLine, prevPoint.X - Radius, prevPoint.Y - Radius, Radius * 2, Radius * 2);
                radLine.Dispose();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                scene.DeleteSelected();
                Invalidate();
            }
            if(e.KeyCode == Keys.Escape)
            {
                prevPoint = Point.Empty;
                Invalidate();
            }
        }

        private void slNumCircles_Paint(object sender, PaintEventArgs e)
        {
            slNumCircles.Text = String.Format("Circles: {0}", scene.Circles.Count);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                currColor = cd.Color;
            }
        }

        public void saveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Circles doc file (*.crl)|*.crl";
                saveFileDialog.Title = "Save circles doc";
                saveFileDialog.FileName = FileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, scene);
                }
            }
        }

        public void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Circles doc file (*.crl)|*.crl";
            openFileDialog.Title = "Open Circles doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        scene = (Scene)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newScene();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newScene();
        }
    }
}
