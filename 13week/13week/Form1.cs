using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace _13week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mat matOrg = Cv2.ImRead("Lake.JPG"); // Cv2가 openCV의 함수르 가지고 있는 객체이다.
            //자기 프로젝트명/bin/Debug 안에 넣으면 그림이 바로 잡히게 된다!
            pictureBox1.Image = matOrg.ToBitmap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mat matOrg = Cv2.ImRead("Lake.JPG");

            Mat matGray = matOrg.CvtColor(ColorConversionCodes.BGR2GRAY);
            pictureBox1.Image = matGray.ToBitmap();
        }
    }
}
