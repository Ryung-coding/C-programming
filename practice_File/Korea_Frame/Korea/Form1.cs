using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Korea
{
    public partial class Form1 : Form
    {
        double xmin = 0;
        double xmax = 350;
        double ymin = 350;
        double ymax = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            DialogResult rtn = openFileDialog1.ShowDialog();
            if(rtn == DialogResult.OK)
            {
                string fname = openFileDialog1.FileName;
                lblFileName.Text = fname;

                string[] lines = File.ReadAllLines(fname);
                int lineCount = Convert.ToInt32(lines[0]);
                int[] x_pos = new int[lineCount];
                int[] y_pos = new int[lineCount];

                for(int i = 0; i < lineCount; i++)
                {
                    string[] parts = lines[i + 1].Split(',');
                    x_pos[i] = Convert.ToInt32(parts[0]);
                    y_pos[i] = Convert.ToInt32(parts[1]);
                }

                TDraw draw = new TDraw(picDraw, xmin, xmax, ymin, ymax);

                for (int i = 1; i < lineCount-1; i++)
                {
                    draw.DrawLine(Color.Red, x_pos[i-1], y_pos[i-1], x_pos[i], y_pos[i]);
                }


            }
        }
    }
}
