using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4week_assignment
{
    public partial class Form1 : Form
    {

        const float x_min = -5, x_max = 20;
        const float y_min = -5, y_max = 20;

        private float xp2xw(float xw)
        {
            float w = picDraw.ClientSize.Width;
            return w * (xw - x_min) / (x_max - x_min);
        }

        private float yp2yw(float yw)
        {
            float h = picDraw.ClientSize.Height;
            return h * (1 - ((yw - y_min) / (y_max - y_min)));
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            const int num_data = 10;
            float[] xw = new float[num_data] { 1F, 2F, 3F, 4F, 5F, 6F, 7F, 8F, 9F, 10F };
            float[] yw = new float[num_data] { 1.3F, 3.5F, 4.2F, 5.0F, 7.0F, 8.8F, 10.1F, 12.5F, 13.0F, 15.6F };

            Graphics grp = picDraw.CreateGraphics();

            grp.DrawLine(new Pen(Color.Black), xp2xw(x_min), yp2yw(0), xp2xw(x_max), yp2yw(0));
            grp.DrawLine(new Pen(Color.Black), xp2xw(0), yp2yw(y_min), xp2xw(0), yp2yw(y_max));

            for(int i = 0; i < num_data; i++) grp.DrawEllipse(new Pen(Color.Red), xp2xw(xw[i]), yp2yw(yw[i]), 2, 2);

            float sum_XY = 0, sum_XX = 0;
            float sum_X = 0, sum_Y = 0;

            for(int i=0; i < num_data; i++)
            {
                sum_XY += xw[i] * yw[i];
                sum_X += xw[i];
                sum_Y += yw[i];
                sum_XX += xw[i] * xw[i];
            }

            float a = (num_data * sum_XY - sum_X * sum_Y) / (num_data * sum_XX - sum_X * sum_X);
            float b = (sum_Y - a * sum_X) / num_data;

            grp.DrawLine(new Pen(Color.Blue), xp2xw(x_min), yp2yw(a * x_min + b), xp2xw(x_max), yp2yw(a * x_max + b));

            //cramer rule로 하면 잘 됨 -> 과제 힌트

        }
    }
}
