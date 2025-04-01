using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcu.Divide(10, 3, out int q, out int r);

            int x = 3; int y = 4;
            calcu.Swap(ref x, ref y);

            Console.WriteLine(q);
            Console.WriteLine(r);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
