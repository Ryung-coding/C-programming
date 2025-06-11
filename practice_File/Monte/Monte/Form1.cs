using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte
{
    public partial class Form1 : Form
    {
        const int nPoint = 10000;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            // 실제 비율 얻기
            int wd = picArea.ClientSize.Width;
            int ht = picArea.ClientSize.Height;
            int area = wd * ht;

            lblRatioReal.Text = Convert.ToString((100.0 * 100.0) / (double)area);

            // 랜덤점 발생
            Graphics grp = picArea.CreateGraphics();
            int nIn = 0, nOut = 0;
            for (int i = 0; i < nPoint; i++)
            {
                int xp = rnd.Next(wd);  // 0 ~ (wd-1) 중에 발생
                int yp = rnd.Next(ht);  // 0 ~ (ht-1) 중에 발생

                // 내부, 외부 판단
                if (InRect(100, 100, 199, 199, xp, yp))
                {
                    nIn++;
                    grp.DrawEllipse(new Pen(Color.Black), xp, yp, 1, 1);
                }
                else
                {
                    nOut++;
                    grp.DrawEllipse(new Pen(Color.Silver), xp, yp, 1, 1);
                }
            }

            // 결과 비율 출력
            lblRatioMonte.Text = Convert.ToString((double)nIn / (double)nPoint);
        }

        bool InRect(int xmin, int ymin, int xmax, int ymax, int xp, int yp)
        {
            if (xp < xmin) return false;
            if (xp > xmax) return false;
            if (yp < ymin) return false;
            if (yp > ymax) return false;
            return true;
        }
    }
}
