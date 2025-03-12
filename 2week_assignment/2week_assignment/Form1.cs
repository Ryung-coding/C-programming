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
        int dx = 2; int dy = 2;
        bool Flag_x = true; bool Flag_y = true;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.ClientSize.Width - pic_ball.Width < pic_ball.Left) Flag_x = false;
            if (this.ClientSize.Height - pic_ball.Height< pic_ball.Top) Flag_y = false;
            if (pic_ball.Left < 0) Flag_x = true;
            if (pic_ball.Top < 0) Flag_y = true;

            pic_ball.Left = Flag_x == true ? pic_ball.Left + dx : pic_ball.Left - dx;
            pic_ball.Top = Flag_y == true ? pic_ball.Top + dy : pic_ball.Top - dy;


        }

        private void fast_radio_CheckedChanged(object sender, EventArgs e) { timer.Interval = 10;}
        private void slow_radio_CheckedChanged(object sender, EventArgs e) { timer.Interval = 50;}

    }
}
