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
            int input_data1 = Convert.ToInt32(input1.Text, 2); //2진수라고 인식해서 바꿈
            int input_data2 = Convert.ToInt32(input2.Text, 2); //2진수라고 인식해서 바꿈
            input1.Text = input_data1.ToString();
            input2.Text = input_data2.ToString();
            int and_bit = input_data1 | input_data2; //사실상 그냥 합의 의미
            int or_bit = input_data1 | input_data2; //사실상 그냥 합의 의미
            int hat_bit = input_data1 | input_data2; //사실상 그냥 합의 의미
            output.Text = and_bit.ToString();

        }
    }
}
