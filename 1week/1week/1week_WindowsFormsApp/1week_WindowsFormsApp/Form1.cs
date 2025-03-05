using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1week_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        int total = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblNum.Text = "0";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(lblNum.Text);
            n++;
            lblNum.Text = Convert.ToString(n);
        }
        private void up_Click(object sender, EventArgs e)
        {
            total+= Convert.ToInt32(lblNum.Text);
            textBox1.Text = Convert.ToString(total);
        }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
