using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointDraw
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int xprev, yprev;

        private void picDraw_MouseDown(object sender, MouseEventArgs e)
        {
            xprev = e.X;
            yprev = e.Y;
        }

        private void picDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Graphics grp = picDraw.CreateGraphics();

            Color col = Color.Red;
            if (radRed.Checked) col = Color.Red;
            if (radGreen.Checked) col = Color.Green;
            if (radBlue.Checked) col = Color.Blue;

            Pen pen = new Pen(col);
            //grp.DrawEllipse(pen, e.X, e.Y, 1, 1);
            grp.DrawLine(pen, xprev, yprev, e.X, e.Y);

            xprev = e.X;
            yprev = e.Y;
        }
    }
}
