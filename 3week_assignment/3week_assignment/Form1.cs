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
        private void Setting_CheckBox(int input_data)
        {
            chk0.Checked = (input_data & 0x01) != 0;
            chk1.Checked = (input_data & 0x02) != 0;
            chk2.Checked = (input_data & 0x04) != 0;
            chk3.Checked = (input_data & 0x08) != 0;
            chk4.Checked = (input_data & 0x10) != 0;
            chk5.Checked = (input_data & 0x20) != 0;
            chk6.Checked = (input_data & 0x40) != 0;
            chk7.Checked = (input_data & 0x80) != 0;
        }

        private int Setting_TxtNumber()
        {
            int total_data = 0;
            total_data += chk0.Checked == true ? 0x01 : 0;
            total_data += chk1.Checked == true ? 0x02 : 0;
            total_data += chk2.Checked == true ? 0x04 : 0;
            total_data += chk3.Checked == true ? 0x08 : 0;
            total_data += chk4.Checked == true ? 0x10 : 0;
            total_data += chk5.Checked == true ? 0x20 : 0;
            total_data += chk6.Checked == true ? 0x40 : 0;
            total_data += chk7.Checked == true ? 0x80 : 0;
            return total_data;
        }

        private void btnToBit_Click(object sender, EventArgs e)
        {
            Setting_CheckBox(Convert.ToInt32(txtNumber.Text));
        }

        private void btnFromBit_Click(object sender, EventArgs e)
        {
            txtNumber.Text = Setting_TxtNumber().ToString();
        }

        private void On_Click(object sender, EventArgs e)
        {
            int on_check_number_value = Convert.ToInt32(txtIndex.Text);
            or비트 연산을 하면 됨
            
        }

        private void Off_Click(object sender, EventArgs e)
        {
            and비트 연산을 하면 됨 0 이었던 곳은 여전히 0이고 reverse하고 나서 and하면 꺼짐
        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            xor하면 됨
        }

        private void btnShiftUp_Click(object sender, EventArgs e)
        {

        }

        private void btnShiftDown_Click(object sender, EventArgs e)
        {

        }
    }
}
