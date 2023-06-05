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

namespace SlidingBalls
{
    public partial class Form1 : Form
    {
        Scene scene;
        Random rand;
        string FileName;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Start();
            rand = new Random();
            New();
        }

        public void New()
        {
            scene = new Scene(Width, Height);
            FileName = null;
            UpdateStatus();
            Invalidate();
        }

        public void UpdateStatus()
        {
            slActiveBalls.Text = String.Format("Active: {0}", scene.BGBalls.Count + scene.Villains.Count);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            New();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int type = rand.Next(0, 2);
            if(e.Button == MouseButtons.Left)
            {
                if (type == 0)
                {
                    scene.BGBalls.Add(new BGBall(e.Location, Color.Green));
                }
                else
                {
                    scene.BGBalls.Add(new BGBall(e.Location, Color.Blue));
                }
                UpdateStatus();
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int dir = rand.Next(0, 4);
                scene.Villains.Add(new Villain(e.Location, Color.Red, dir));
            }
            else if(e.Button == MouseButtons.Left)
            {
                scene.Activate();
            }
            UpdateStatus();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        public void Save()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Balls doc file (*.bll)|*.bll";
                saveFileDialog.Title = "Save balls doc";
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

        public void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Balls doc file (*.bll)|*.bll";
            openFileDialog.Title = "Open balls doc file";
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
            Save();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Move();
            Invalidate();
        }
    }
}
