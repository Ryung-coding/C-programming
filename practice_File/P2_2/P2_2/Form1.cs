using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isRot = false;
        private void btnRot_Click(object sender, EventArgs e)
        {
            if(picOrg.Image == null) return;

            double deg = Convert.ToDouble(txtDeg.Text);
            
            Bitmap bmapOrg = (Bitmap)picOrg.Image;
            Bitmap bmapRot = new Bitmap(picRot.ClientSize.Width, picRot.ClientSize.Height);

            TDraw draw = new TDraw(picRot, -bmapRot.Width/2, bmapRot.Width / 2, bmapRot.Height/2, -bmapRot.Height / 2);

            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    int red = bmapOrg.GetPixel(i, j).R;
                    int green = bmapOrg.GetPixel(i, j).G;
                    int blue = bmapOrg.GetPixel(i, j).B;

                    double ix; double iy;
                    
                    Rot2D(deg, draw.xposD(i), draw.yposD(j), out ix, out iy);
                    ix = draw.xpixelpos(ix);
                    iy = draw.ypixelpos(iy);

                    if (ix <= 0) ix = 0;
                    if (ix >= bmapRot.Width) ix = bmapRot.Width - 1;
                    if (iy <= 0) iy = 0;
                    if (iy >= bmapRot.Height) iy = bmapRot.Height - 1;

                    bmapRot.SetPixel((int)ix, (int)iy, Color.FromArgb(red, green, blue));
                }
            }
            picRot.Image = bmapRot;
            isRot = true;
        }

        private void chkInverse_CheckedChanged(object sender, EventArgs e)
        {
            if (picOrg.Image == null) return;
            Bitmap bmapOrg = (Bitmap)picOrg.Image;
            if(isRot) bmapOrg = (Bitmap)picRot.Image;
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

        private void Rot2D(double deg, double xp, double yp, out double xnew, out double ynew)
        {
            double rad = deg * Math.PI / 180.0;
            xnew = xp * Math.Cos(rad) - yp * Math.Sin(rad);
            ynew = xp * Math.Sin(rad) + yp * Math.Cos(rad);


        }
    }
}
