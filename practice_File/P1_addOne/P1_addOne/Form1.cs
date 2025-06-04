using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_addOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            int reset = 0;
            score.Text = reset.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int now_score = Convert.ToInt32(score.Text);
            score.Text = (now_score + 1).ToString();
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            int now_score = Convert.ToInt32(score.Text);
            score.Text = (now_score + Convert.ToInt32(add_score.Text)).ToString();
        }
    }
}
