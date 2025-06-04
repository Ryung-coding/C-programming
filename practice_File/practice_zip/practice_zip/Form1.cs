using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_zip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Mouse Down은 눌렀을때 한번이다 누르고 꾸욱 되는게 아님!
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) 
        {
            //Graphics grp = pictureBox1.CreateGraphics();
            //Color col = Color.Black;
            //Pen pen = new Pen(col);
            //if(radio_red.Checked ) col = Color.Red;
            //else if(radio_green.Checked ) col = Color.Green;
            //else if(radio_blue.Checked ) col = Color.Blue;

            //grp.DrawEllipse(pen, e.X, e.Y, 1, 1);
        }


        int x_past = 0;
        int y_past = 0;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                x_past = e.X;
                y_past = e.Y; 
            }

            Graphics grp = pictureBox1.CreateGraphics();
            Color col = Color.Black;
            
            if (radio_red.Checked) col = Color.Red;
            else if (radio_green.Checked) col = Color.Green;
            else if (radio_blue.Checked) col = Color.Blue;
            Pen pen = new Pen(col); //정의되는 위치 조심하기

            if (e.Button == MouseButtons.Left)
            {
                //grp.DrawEllipse(pen, e.X, e.Y, 1, 1);
                grp.DrawLine(pen, e.X, e.Y, x_past, y_past);
                x_past = e.X;
                y_past = e.Y;
            }

        }
    }
}