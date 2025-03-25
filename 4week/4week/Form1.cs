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

        private void button1_Click(object sender, EventArgs e)
        {
            uint num = 0;
            while(true)
            {
                Application.DoEvents(); //이벤트를 처리하고 이 while문을 돌라고 명령하는 것이다.
                // 이걸 안한다면, 모든 Thread가 while내의 num값을 올리기만 하고 일을 못한다.
                data.Text = (++num).ToString();
                if (checkBox.Checked) break;
            }
        }
    }
}
