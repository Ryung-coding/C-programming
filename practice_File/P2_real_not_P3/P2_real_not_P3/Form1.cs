using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_real_not_P3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DialogResult data = openFileDialog.ShowDialog();
            //if (data == DialogResult.OK)
            //{
            //    string fname = openFileDialog.FileName;
            //    picOrg.Load(fname);
            //}
        }
        private void chkInverse_CheckedChanged(object sender, EventArgs e)
        {

            Bitmap bmapOrg = (Bitmap)picRot.Image;
            if(picRot.Image ==null) bmapOrg = (Bitmap)picOrg.Image;
            Bitmap bmapRot = new Bitmap(picRot.ClientSize.Width, picRot.ClientSize.Height);
            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    int red = 255 - bmapOrg.GetPixel(i, j).R;
                    int green = 255 - bmapOrg.GetPixel(i, j).G;
                    int blue = 255 - bmapOrg.GetPixel(i, j).B;
                    bmapRot.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            picRot.Image = bmapRot;
        }

        private void btnRot_Click(object sender, EventArgs e)
        {
            double xnew, ynew;
            double deg = Convert.ToDouble(txtDeg.Text);

            Bitmap bmapOrg = (Bitmap)picOrg.Image;
            Bitmap bmapRot = new Bitmap(picRot.ClientSize.Width, picRot.ClientSize.Height);

            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    Rot2D(deg, i, j, out xnew, out ynew);

                    xnew = (int)xnew < 0 ? 0 : xnew;
                    ynew = (int)ynew < 0 ? 0 : ynew;
                    xnew = (int)xnew > bmapOrg.Width-1 ? bmapOrg.Width-1 : xnew;
                    ynew = (int)ynew > bmapOrg.Height - 1 ? bmapOrg.Height-1 : ynew;
                    bmapRot.SetPixel((int)xnew, (int)ynew, bmapOrg.GetPixel(i,j));
                }
            }
            picRot.Image = bmapRot;
        }

        private void Rot2D(double deg, double xp, double yp, out double xnew, out double ynew)
        {
            xp -= 200.0;
            yp -= 150.0;

            double rad = deg * Math.PI / 180.0;
            double cos = Math.Cos(rad);
            double sin = Math.Sin(rad);

            double xr = xp * cos + yp * sin;
            double yr = -xp * sin + yp * cos;

            xnew = xr + 200.0;
            ynew = yr + 150.0;

        }
    }
}
