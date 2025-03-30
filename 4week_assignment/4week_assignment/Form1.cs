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

        const float x_min = -2, x_max = 7;
        const float y_min = -5, y_max = 70;

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
            const int num_data = 6;
            float[] xw = new float[num_data] { 1F, 2F, 3F, 4F, 5F, 6F};
            float[] yw = new float[num_data] { 2.1F, 7.7F, 13.6F, 27.2F, 40.9F, 61.1F};

            Graphics grp = picDraw.CreateGraphics();

            grp.DrawLine(new Pen(Color.Black), xp2xw(x_min), yp2yw(0), xp2xw(x_max), yp2yw(0));
            grp.DrawLine(new Pen(Color.Black), xp2xw(0), yp2yw(y_min), xp2xw(0), yp2yw(y_max));

            for(int i = 0; i < num_data; i++) grp.DrawEllipse(new Pen(Color.Red), xp2xw(xw[i]), yp2yw(yw[i]), 2, 2);

            float sum_X1 = 0; float sum_X2 = 0; float sum_X3 = 0; float sum_X4 = 0;
            float sum_Y1 = 0; float sum_XY = 0; float sum_X2Y = 0;

            for (int i=0; i < num_data; i++)
            {
                sum_X1 += xw[i];
                sum_X2 += xw[i] * xw[i];
                sum_X3 += xw[i] * xw[i] * xw[i];
                sum_X4 += xw[i] * xw[i] * xw[i] * xw[i];

                sum_Y1 += yw[i];
                sum_XY += xw[i] * yw[i];
                sum_X2Y += xw[i] * xw[i] * yw[i];
            }
            float det = num_data * (sum_X2 * sum_X4 - sum_X3 * sum_X3) - sum_X1 * (sum_X1 * sum_X4 - sum_X3 * sum_X2) + sum_X2 * (sum_X1 * sum_X3 - sum_X2 * sum_X2);

            float a0 = (sum_Y1 * (sum_X2 * sum_X4 - sum_X3 * sum_X3) - sum_X1 * (sum_XY * sum_X4 - sum_X3 * sum_X2Y) + sum_X2 * (sum_XY * sum_X3 - sum_X2 * sum_X2Y)) / det;

            float a1 = (num_data * (sum_XY * sum_X4 - sum_X3 * sum_X2Y) - sum_Y1 * (sum_X1 * sum_X4 - sum_X3 * sum_X2) + sum_X2 * (sum_X1 * sum_X2Y - sum_XY * sum_X2)) / det;

            float a2 = (num_data * (sum_X2 * sum_X2Y - sum_XY * sum_X3) - sum_X1 * (sum_X1 * sum_X2Y - sum_XY * sum_X2) + sum_Y1 * (sum_X1 * sum_X3 - sum_X2 * sum_X2)) / det;


            for (float i = x_min; i < x_max - 0.1F; i = i + 0.1F) grp.DrawLine(new Pen(Color.Blue), xp2xw(i), yp2yw(a2 * i * i + a1 * i + a0), xp2xw(i + 0.1F), yp2yw(a2 * (i + 0.1F) * (i + 0.1F) + a1 * (i + 0.1F) + a0));
            

        }
    }
}
