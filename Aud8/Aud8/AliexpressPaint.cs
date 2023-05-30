using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aud8
{
    public partial class AliexpressPaint : Form
    {
        Scene scene;
        public AliexpressPaint()
        {
            InitializeComponent();
            scene = new Scene(this.Width ,this.Height);
            this.DoubleBuffered = true;
            slCountLines.Text = "Lines: 0";
        }

        private void AliexpressPaint_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddPoint(e.Location);
            scene.UndoStack.Clear();
            updateStatus();
            Invalidate();
        }

        private void AliexpressPaint_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                scene.Color = colorDialog.Color;
            }
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normalToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = false;
            thinToolStripMenuItem.Checked = true;
            scene.Thickness = 1;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thinToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = true;
            scene.Thickness = 2;
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thinToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = true;
            scene.Thickness = 3;
        }

        private void AliexpressPaint_MouseMove(object sender, MouseEventArgs e)
        {
            scene.Cursor = e.Location;
            Invalidate();
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Positioner = !scene.Positioner;
            positionerToolStripMenuItem.Checked = !positionerToolStripMenuItem.Checked;
        }
    
        private void updateStatus()
        {
            slCountLines.Text = $"Lines: {scene.Lines.Count}";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Undo();
            Invalidate();
            updateStatus();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Redo();
            Invalidate();
            updateStatus();
        }
    }
}
