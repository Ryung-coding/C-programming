using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4week_assignment
{
    public partial class Form1 : Form
    {
        Random rnd = new Random(); //Random class 정의
        bool[] isopen = new bool[5] { false, false, false, false, false };

        private void closed_all()
        {
            card00.Image = Properties.Resources.closed;
            card01.Image = Properties.Resources.closed;
            card02.Image = Properties.Resources.closed;
            card03.Image = Properties.Resources.closed;
            card04.Image = Properties.Resources.closed;
            timer_open.Enabled = true;
            timer_closed.Enabled = false;
            for (int i = 0; i < 5; i++) isopen[i] = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_open_Tick(object sender, EventArgs e) //timer가 open이 된 순간 
        {
            int random_number = rnd.Next(5);
            switch (random_number)
            {
                case 0:
                    card00.Image = Properties.Resources.open;
                    break;

                case 1:
                    card01.Image = Properties.Resources.open;
                    break;

                case 2:
                    card02.Image = Properties.Resources.open;
                    break;

                case 3:
                    card03.Image = Properties.Resources.open;
                    break;

                case 4:
                    card04.Image = Properties.Resources.open;
                    break;
            }
            timer_open.Enabled = false;
            timer_closed.Enabled = true;
            isopen[random_number] = true;
        }

        private void timer_closed_Tick(object sender, EventArgs e)
        {
            closed_all();
        }

        private void card_Click(object sender, EventArgs e) //sender가 열렸는지에 대한 이벤트를 알려줌
        {
            int Hit_card = 0;
            PictureBox obj2pic = (PictureBox)sender;
            if (obj2pic == card00) Hit_card = 0;
            if (obj2pic == card01) Hit_card = 1;
            if (obj2pic == card02) Hit_card = 2;
            if (obj2pic == card03) Hit_card = 3;
            if (obj2pic == card04) Hit_card = 4;
            count.Text = (isopen[Hit_card] ? 1 + Convert.ToInt32(count.Text) : Convert.ToInt32(count.Text)).ToString();
            closed_all();
        }
    }
}
