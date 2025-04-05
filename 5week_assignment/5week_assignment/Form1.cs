using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5week_assignment
{
    public partial class Form1 : Form
    {
        const int N = 100000;

        int x1 = 160; int y1 =  70;
        int x2 =  50; int y2 = 410;
        int x3 = 340; int y3 = 290;

        Random rnd = new Random();
        double Calculate_Area(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double area = ((x1 * y2 + x2 * y3 + x3 * y1) - (x1 * y3 + x3 * y2 + x2 * y1)) / 2;
            return area;
        }

        bool InArea(int x1, int y1, int x2, int y2, int x3, int y3, int x0, int y0)
        {
            double area_120 = Calculate_Area(x1, y1, x2, y2, x0, y0);
            double area_023 = Calculate_Area(x0, y0, x2, y2, x3, y3);
            double area_103 = Calculate_Area(x1, y1, x0, y0, x3, y3);

            if ((area_120 > 0 && area_023 > 0 && area_103 > 0) || (area_120 < 0 && area_023 < 0 && area_103 < 0)) return true;
            else return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            int width = picArea.ClientSize.Width;
            int height = picArea.ClientSize.Height;
            int All_area = width * height;

            double triangle_area = Calculate_Area(x1, y1, x2, y2, x3, y3);
            triangle_area = triangle_area < 0 ? -1 * triangle_area : triangle_area;
            ratio_real.Text = Convert.ToString(triangle_area / All_area);

            Graphics grp = picArea.CreateGraphics();

            int In_count = 0, Out_count = 0;


            for (int step=0; step < N; step++)
            {
                int x0 = rnd.Next(width);
                int y0 = rnd.Next(height);

                if(InArea(x1, y1, x2, y2,  x3,  y3,  x0, y0) == true)
                {
                    In_count++;
                    grp.DrawEllipse(new Pen(Color.Black), x0, y0, 1, 1);
                }
                else
                {
                    Out_count++;
                    grp.DrawEllipse(new Pen(Color.Silver), x0, y0, 1, 1); ;
                }

                ratio_monte.Text = Convert.ToString((double)In_count / ((double)In_count+(double)Out_count));
                in_area.Text = In_count.ToString();
                out_area.Text = Out_count.ToString();
            }
        }
    }
}
