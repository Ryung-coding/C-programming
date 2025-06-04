using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_zip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(label1.Text);
            label1.Text = (--num).ToString();

            if (num == 0)
            {
                timer1.Enabled = false; //이거 안까먹게 조심
                MessageBox.Show("bye");
                Application.Exit();
            }

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            label1.Left = rnd.Next(this.ClientSize.Width - label1.Width);
            label1.Top = rnd.Next(this.ClientSize.Height - label1.Height);  
        }
    }
}

