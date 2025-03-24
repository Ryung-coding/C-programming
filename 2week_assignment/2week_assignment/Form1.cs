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
        int dx = 0; int dy = 10; 
        bool Flag_x = true; bool Flag_y = true;
        int past_distance = 0;

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

            int distance = (int)Math.Sqrt(Math.Pow(this.ClientSize.Width / 2 - pic_ball.Left, 2)+ Math.Pow(this.ClientSize.Height / 2 - pic_ball.Top, 2));
            pic_ball.BackColor = distance - past_distance > 0 ? Color.Blue : Color.Red;
            past_distance = distance;
        }

        private void fast_radio_CheckedChanged(object sender, EventArgs e) { timer.Interval = 10;}
        private void slow_radio_CheckedChanged(object sender, EventArgs e) { timer.Interval = 50;}

        private void pic_ball_Click(object sender, EventArgs e)
        {

        }
    }
}
