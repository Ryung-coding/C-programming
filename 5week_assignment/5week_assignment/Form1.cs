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
        const int N = 50000;
        Random rnd = new Random();

        bool InReact(int x_min, int x_max, int y_min, int y_max, int x_point, int y_point)
        {
            if (x_point < x_min || x_point > x_max) return false;
            if (y_point < y_min || y_point > y_max) return false;
            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            int width = picArea.ClientSize.Width;
            int height = picArea.ClientSize.Height;
            int area = width * height;

            ratio_real.Text = Convert.ToString((100.0 * 100.0) / (double)area);

            Graphics grp = picArea.CreateGraphics();
            int In_count = 0, Out_count = 0;


            for (int step=0; step < N; step++)
            {
                int x_point = rnd.Next(width);
                int y_point = rnd.Next(height);

                if(InReact(100,100,199,199, x_point,y_point) == true)
                {
                    In_count++;
                    grp.DrawEllipse(new Pen(Color.Black), x_point, y_point, 1, 1);
                }
                else
                {
                    Out_count++;
                    grp.DrawEllipse(new Pen(Color.Silver), x_point, y_point, 1, 1);
                }
                ratio_monte.Text = Convert.ToString((double)In_count / (double)Out_count);
            }
        }
    }
}
