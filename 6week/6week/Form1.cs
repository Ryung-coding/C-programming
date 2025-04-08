using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            // Cat cat_null = new Cat();
            Cat cat = new Cat("ryung", "white");
        }

        private void btn_N_cat_Click(object sender, EventArgs e)
        {
            GC.Collect(); //바로 가비지 컬렉터를 작동하도록 설정.
            label1.Text = Cat.Ncat.ToString();
        }

    }
}
