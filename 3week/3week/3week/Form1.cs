using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(input.Text);
            int namergi = 0;
            while (true)
            {
                if (n <= 0) break; else namergi = n % 10;
                output.Text += namergi.ToString() + "\r\n";
                n /= 10;
            }
        }
    }
}
