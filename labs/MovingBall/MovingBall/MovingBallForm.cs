﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingBall
{
    public partial class MovingBallForm : Form
    {
        Timer timer;
        Ball ball;
        Graphics graphics;
        Brush brush;
        Pen pen;
        Rectangle bounds;
        Bitmap doubleBuffer;
        static readonly int FPS = 60;
        public MovingBallForm()
        {
            InitializeComponent();
            bounds = new Rectangle(10, 10, this.Bounds.Width - 40, this.Bounds.Height - 60);
            doubleBuffer = new Bitmap(Width, Height);
            graphics = CreateGraphics();
            ball = new Ball(Width / 2, Height / 2, 20, 10, (float)(Math.PI / 4));
            ball.Bounds = bounds;
            Show();
            brush = new SolidBrush(Color.Blue);
            pen = new Pen(Color.Red);
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000 / FPS;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(doubleBuffer);
            g.Clear(Color.White);
            g.DrawRectangle(pen, bounds);
            ball.Draw(brush, g);
            ball.Move();
            graphics.DrawImageUnscaled(doubleBuffer, 0, 0);
        }
    }
}
