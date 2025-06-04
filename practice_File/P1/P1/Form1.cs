using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class Form1 : Form
    {
        int delta = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (lblstring1.Visible == false && lblstring2.Visible == false && lblstring3.Visible == false)
            {
                timer.Enabled = false;
                MessageBox.Show("game over");
                Application.Exit();
            }
            
            lblstring1.Top += delta;
            lblstring2.Top += delta;
            lblstring3.Top += delta;

            if (lblstring1.Top+lblstring1.Height > picDraw.Height) lblstring1.Visible = false;
            if (lblstring2.Top + lblstring2.Height > picDraw.Height) lblstring2.Visible = false;
            if (lblstring3.Top + lblstring3.Height > picDraw.Height) lblstring3.Visible = false;
        }

        private void lblstring1_Click(object sender, EventArgs e)
        {
            if (lblstring1.Visible)
            {
                score++;
                lblstring1.Visible = false;
            }
            lblscore.Text = score.ToString();
        }

        private void lblstring2_Click(object sender, EventArgs e)
        {
            if (lblstring2.Visible)
            {
                score++;
                lblstring2.Visible = false;
            }
            lblscore.Text = score.ToString();
        }

        private void lblstring3_Click(object sender, EventArgs e)
        {
            if (lblstring3.Visible)
            {
                score++;
                lblstring3.Visible = false;
            }
            lblscore.Text = score.ToString();
        }
    }
}
