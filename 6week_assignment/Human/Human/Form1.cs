using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Human human = new Human();
            human.age = 20;
            //human.added1 = 

            Man man = new Man();
            man.age = 21;       // 상속 받은 속성
            man.added1 = 99;    // 추가된 속성
        }

        private void call_button_Click(object sender, EventArgs e)
        {
            Human human = new Human();
            human.favorite();

            Man man = new Man();
            man.favorite();

            Woman women = new Woman();
            women.favorite();

            human = man;
            human.favorite();

            human = women;
            human.favorite();
        }

        Random rnd = new Random();
        private void call_btn_random_Click(object sender, EventArgs e)
        {
            Human[] humans = new Human[100];
            for(int i=0; i < 100; i++)
            {
                int random_value = rnd.Next(3);
                if (random_value == 0) humans[i] = new Human();
                if (random_value == 1) humans[i] = new Man(); 
                // Man이 Human형의 상속형이라 humans에 한번에 저장 가능
                if (random_value == 2) humans[i] = new Woman();
                // Woman이 Human형의 상속형이라 humans에 한번에 저장 가능
            }
            for (int i = 0; i < 100; i++) humans[i].favorite();
        }
    }
}
