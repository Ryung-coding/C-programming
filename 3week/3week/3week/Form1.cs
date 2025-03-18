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
            uint n = (uint)Convert.ToInt32(input.Text);
            uint bit_shitt = n<<2; //1의 2비트 이동이므로 00..00100=> 4가 나온다
            output.Text = bit_shitt.ToString();
        }
    }
}
