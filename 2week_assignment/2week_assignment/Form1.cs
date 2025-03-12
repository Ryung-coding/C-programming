using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2week_assignment
{
    public partial class Form1 : Form
    {
        Random rnd = new Random(); //Heap에다가 참조변수를 저장해서 rnd라는 이름으로 
        // Random : 클래스 -> .NET에서 제공하는 기본 클래스
        // rnd : 이건 참조변수! -> 이건 참조형식으로 정의해야한다 1. Array 2. Class 3. String
        // new Random() : 클래스의 객체에 메모리를 할당해서 참조를 반환
        // 이 공간은 프로그램이 실행될때, 작동되는 구조이다.

        public Form1()
        {
            InitializeComponent();
        }

        private void time_Controller_Tick(object sender, EventArgs e)
        {
            //도구상자내 [구성요소] -> [타이머]

            // Enabled를 true로 하면 실행시 바로 작동
            // interval : 몇 ms로 돌것인지 설정
            // 타이머의 [속성]안 [번개]를 누르면 Tick이라는 이벤트 존재

            //int count = (int)label.Text; -> 이거 안된다! string to int, int to string
            int count = Convert.ToInt32(label.Text);
            count--;
            label.Text = Convert.ToString(count);
            //label.Text = count.ToString();
            if (count == 0)
            {
                time_Controller.Enabled = false; //break 방식
                MessageBox.Show("lol :) Kikikikiki"); //메세지 형이 나오는 구문, 버튼 눌러야 다음으로 진행
                Application.Exit(); //프로그램이 끝남
            }

        }

        private void undo_MouseMove(object sender, MouseEventArgs e)
        {
            // 버튼의 [속성]안 [번개] 내 [클릭]이 디폴트 이벤트
            // MouseMove : 버튼위에 마우스가 움직이면 작동됨
            // 버튼명.Left는 버튼의 좌측 하단기준으로 윈도우 왼쪽까지의 px량
            // 버튼명.Top는 버튼의 상단 기준으로 윈도우 위쪽까지의 px량
            // Note* 윈도우의 좌측상단이 (0,0)이다

            undo.Left = rnd.Next(this.ClientSize.Width-undo.Width); 
            // rnd라는 객체의 Next라는 함수를 써서 (N)을 쓰면 0~N-1이 랜덤으로 나옴
            undo.Top = rnd.Next(this.ClientSize.Height - undo.Height); 
            // 이때 this라는 것은 내가 지금 Form이라는 내에서 Form의 값을 쓰고 있어서 this. 을 통해 구해온다 나머진 괜찮다

        }
    }
}
