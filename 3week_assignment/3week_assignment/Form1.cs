using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3week_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //4로 나눈 값이 떨어지면 윤년
        //그러나 그 중 100으로 나누어 떨어지면 윤년이 아니다. 
        //하지만 400으로 나누어진다면 윤년이다. 
        private void geasangi_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(input.Text);
            bool isLeapyear = (year % 4 == 0 && year % 100 != 0) ? true : (year % 400 == 0) ? true : false;
            output.Text = isLeapyear == true ? "O" : "X";
        }
    }
}
