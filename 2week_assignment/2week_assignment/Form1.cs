using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2week_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x_past = 0; int y_past = 0;


        private void pic_draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Graphics grp = pic_draw.CreateGraphics();
            
            Color col = Color.Brown;
            
            if (red.Checked) col = Color.Red;
            if (green.Checked) col = Color.Green;
            if (blue.Checked) col = Color.Blue;

            Pen pen = new Pen(col);
            // grp.DrawEllipse(pen, e.X, e.Y, 10, 10); -> 이러면 너무 이산적으로 그려진다 -> 그전과 이전을 선으로 이어보자
            grp.DrawLine(pen, x_past, y_past, e.X, e.Y); 
            x_past = e.X;
            y_past = e.Y;
        }

        private void pic_draw_MouseDown(object sender, MouseEventArgs e)
        {
            // 이런식으로 해야 시작 초기값에 대한 튐을 방지한다
            // 이러면 초기값이 마우스를 누른 순간으로 되니 점프하는일이 없다
            x_past = e.X; 
            y_past = e.Y;
        }
    }
}
