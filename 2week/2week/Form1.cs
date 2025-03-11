using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100;
            double d = a;
            Console.WriteLine(d);

            double aa = 100;
            int dd = (int)aa;
            Console.WriteLine(dd);

            double d_Max = double.MaxValue;
            Console.WriteLine(d_Max);
            int a_MMMMAX = (int)d_Max;
            Console.WriteLine(a_MMMMAX);



        }
    }
}
