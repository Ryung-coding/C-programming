using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class Form1: Form
    {
        int dx = 2;
        int dy = 2;
        bool x_heat = false;
        bool y_heat = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picBall.Left + picBall.Width >= this.ClientSize.Width) x_heat = true;
            else if (picBall.Left <= 0) x_heat = false;
            picBall.Left = x_heat ? picBall.Left - dx : picBall.Left + dx;

            if (picBall.Top+ picBall.Height>= this.ClientSize.Height) y_heat = true;
            else if (picBall.Top <= 0) y_heat = false;
            picBall.Top = y_heat ? picBall.Top- dy : picBall.Top+ dy    ;
        }

        private void radFast_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 3;
        }

        private void radSlow_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 20;
        }
    }
}
