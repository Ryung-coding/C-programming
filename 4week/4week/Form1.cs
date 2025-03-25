using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int n = int.Parse(data.Text);
            bool isPrime = true;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;  
                }
            }
            output.Text = isPrime ? "O" : "X";  
        }
    }
}
