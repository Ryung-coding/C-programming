using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (draw == null) draw = new TDraw(picDraw, 0, 100, 0, 100);
        }

        private List<Circle> circles = new List<Circle>(); //가변적이어야하므로 이게 맞다

        Random rnd = new Random();
        TDraw draw = null;

        private void picDraw_Click(object sender, EventArgs e)
        {
            if (radAdd.Checked)
            {
                double xcen = rnd.NextDouble() * 100;
                double ycen = rnd.NextDouble() * 100;
                Circle one_circle = new Circle(xcen, ycen);
                circles.Add(one_circle);
                for (int i = 0; i < circles.Count; i++)
                {
                    circles[i].draw(draw);
                }
            }
            if(radDel.Checked)
            {
                draw.ClearDrawing(picDraw.BackColor);
            }
        }

        private void chkMove_CheckedChanged(object sender, EventArgs e)
        {
            //null
        }

        private void btnAdd100_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                double xcen = rnd.NextDouble() * 100;
                double ycen = rnd.NextDouble() * 100;
                Circle one_circle = new Circle(xcen, ycen);
                circles.Add(one_circle);
            }
            for(int i = 0; i < circles.Count; i++)
            {
                circles[i].draw(draw);
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            draw.ClearDrawing(picDraw.BackColor);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(chkMove.Checked)
            {
                draw.ClearDrawing(picDraw.BackColor);
                for (int i = 0; i < circles.Count; i++)
                {
                    circles[i].move(0, 100, 0, 100);
                    circles[i].draw(draw);
                }
            }
            lblNCir.Text = "원 개수: " + circles.Count.ToString();
        }

        private void picDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (radAdd.Checked)
            {
                Circle cir = new Circle(draw.xposD(e.X), draw.yposD(e.Y));
                circles.Add(cir);
                for (int i = 0; i < circles.Count; i++)
                {
                    circles[i].draw(draw);
                }
            }
            else if (radDel.Checked)
            {
                List<Circle> cdel = new List<Circle>();
                for (int i = 0; i < circles.Count; i++)
                {
                    if (circles[i].isinside(draw.xposD(e.X), draw.yposD(e.Y))) cdel.Add(circles[i]);
                }

                for (int i = 0; i < cdel.Count; i++) circles.Remove(cdel[i]);
                for (int i = 0; i < circles.Count; i++)
                {
                    circles[i].draw(draw);
                }
            }
        }
    }
}
