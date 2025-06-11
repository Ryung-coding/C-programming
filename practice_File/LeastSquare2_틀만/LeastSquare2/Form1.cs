using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeastSquare2
{
    public partial class Form1 : Form
    {
        
        double xmin = -2, xmax = 7;
        double ymin = -5, ymax = 70;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            const int ndat = 6;
            double[] xw = new double[ndat] { 1, 2, 3, 4, 5, 6 };
            double[] yw = new double[ndat] { 2.1, 7.7, 13.6, 27.2, 40.9, 61.1 };

            TDraw draw = new TDraw(picDraw,xmin,xmax,ymin,ymax);
            draw.DrawLine(Color.Black, xmin, 0, xmax, 0);
            draw.DrawLine(Color.Black, 0, ymin, 0, ymax);

            double sum_X1 = 0, sum_X2 = 0, sum_X3 = 0, sum_X4 = 0;
            double sum_Y1 = 0, sum_XY = 0, sum_X2Y = 0;
            double a0=0, a1 = 0, a2 = 0;
            for (int i = 0; i < ndat; i++)
            {
                draw.DrawEllipse(Color.Blue, (xw[i]), (yw[i]), draw.xsizeD(3), draw.ysizeD(3));
                sum_X1 += xw[i];
                sum_X2 += xw[i] * xw[i];
                sum_X3 += xw[i] * xw[i] * xw[i];
                sum_X4 += xw[i] * xw[i] * xw[i] * xw[i];

                sum_Y1 += yw[i];
                sum_XY += xw[i] * yw[i];
                sum_X2Y += xw[i] * xw[i] * yw[i];
            }

            for (int i = 0; i < ndat; i++)
            {
                double det = ndat * (sum_X2 * sum_X4 - sum_X3 * sum_X3) - sum_X1 * (sum_X1 * sum_X4 - sum_X3 * sum_X2) + sum_X2 * (sum_X1 * sum_X3 - sum_X2 * sum_X2);

                 a0 = (sum_Y1 * (sum_X2 * sum_X4 - sum_X3 * sum_X3) - sum_X1 * (sum_XY * sum_X4 - sum_X3 * sum_X2Y) + sum_X2 * (sum_XY * sum_X3 - sum_X2 * sum_X2Y)) / det;

                 a1 = (ndat * (sum_XY * sum_X4 - sum_X3 * sum_X2Y) - sum_Y1 * (sum_X1 * sum_X4 - sum_X3 * sum_X2) + sum_X2 * (sum_X1 * sum_X2Y - sum_XY * sum_X2)) / det;

                 a2 = (ndat * (sum_X2 * sum_X2Y - sum_XY * sum_X3) - sum_X1 * (sum_X1 * sum_X2Y - sum_XY * sum_X2) + sum_Y1 * (sum_X1 * sum_X3 - sum_X2 * sum_X2)) / det;

            }

            for (double x = xmin; x < xmax; x += 0.01)
            {
                double y1 = a0 * x * x + a1 * x + a2;
                double x2 = x + 0.01;
                double y2 = a0 * x2 * x2 + a1 * x2 + a2;
                draw.DrawLine(Color.Red, x, y1, x2, y2);
            }

        }
    }
}
