using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGolf
{
    public partial class BallGolf : Form
    {
        Scene scene;
        Color currentColor;
        Timer timer;
        int leftX;
        int topY;
        int width;
        int height;

        private string FileName;

        public BallGolf()
        {
            InitializeComponent();
            scene = new Scene();
            currentColor = Color.Red;
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Start();
            leftX = 20;
            topY = 60;
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);
            scene.GenerateHoles(leftX, topY, width, height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.MoveBalls(leftX, topY, width, height);
            scene.CheckCollisions();
            Invalidate();
        }

        private void BallGolf_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(pen, leftX, topY, width, height);
            pen.Dispose();
            scene.Draw(e.Graphics);
        }

        private void BallGolf_Resize(object sender, EventArgs e)
        {
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);
        }

        //GOTOVI SME ALO

        private void SaveFile()
        {
            if(FileName == null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Ball Golf file (*.bll)|*.bll";
                sfd.Title = "Save Game";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileName = sfd.FileName;
                }
            }
            if(FileName != null)
            {
                using (FileStream fs = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, scene);
                }
            }
        }

        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ball Golf file (*.bll)|*.bll";
            ofd.Title = "Open Game";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;
                try
                {
                    using (FileStream fs = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        scene = (Scene)formatter.Deserialize(fs);
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show("Count not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate();
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                currentColor = cd.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            Invalidate();
        }

        private void BallGolf_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddBall(new Ball(e.Location, currentColor));
            Invalidate();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            scene.GenerateHoles(leftX, topY, width, height);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}
