using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Korea
{
    public partial class Form1 : Form
    {
        double xmin = 0;
        double xmax = 350;
        double ymin = 350;
        double ymax = 0;

        private float xpixel(double xw)
        {
            return (float)(picDraw.ClientSize.Width *
                              (xw - xmin) / (xmax - xmin));
        }

        private float ypixel(double yw)
        {
            return (float)(picDraw.ClientSize.Height *
                              (1 - (yw - ymin) / (ymax - ymin)));
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            DialogResult rtn = openFileDialog1.ShowDialog(); //F9으로 여기에다가 break하고 F10으로 Modal 실행
            if (rtn != DialogResult.OK) return;
            string file_name = openFileDialog1.FileName;
            lblFileName.Text = file_name;

            try
            {
                string[] stall = File.ReadAllLines(file_name);
                int count_line = int.Parse(stall[0]);
                int[] x_px = new int[count_line];
                int[] y_px = new int[count_line];

                for(int i=0;i<count_line;i++)
                {
                    string[] set_point = stall[i + 1].Split(',');
                    x_px[i] = int.Parse(set_point[0].Trim());
                    y_px[i] = int.Parse(set_point[1].Trim());
                }

                Graphics grp = picDraw.CreateGraphics();
                for(int i=1;i<count_line;i++)
                {
                    grp.DrawLine(new Pen(Color.Black), xpixel(x_px[i - 1]), ypixel(y_px[i - 1]), xpixel(x_px[i]), ypixel(y_px[i]));
                }
            }
            catch { return; }
        }
    }
}
