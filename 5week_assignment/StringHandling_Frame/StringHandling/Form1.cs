using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now; //Now뒤에 ()가 없기에 속성, 있다면 메소드 DateTime은 클래스다.
            lblTime.Text = t.ToString();

        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = st.Trim().Length; //Trim() 하면 앞뒤 띄어쓰기는 제거한다.
            txtOUT.Text = len.ToString();

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = int.Parse(txtIN2.Text);
            txtOUT.Text = st.Substring(0, len); //중간에 원하는 자리로부터 원하는 길이만큼 잘라서 출력한다. 0은 시작첫위치값을 말한다
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try //만일 try에 대한 에러가 발생했을경우, catch구문을 수행하도록 하는 구조다. 
            {
                string st = txtIN1.Text;
                int len = int.Parse(txtIN2.Text);
                txtOUT.Text = st.Substring(st.Length - len, len);
            }
            catch
            {
                MessageBox.Show("-1");
            }
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            //purpose: 2번째 글자부터 3개 뜯는것
            string st = txtIN1.Text;
            txtOUT.Text = st.Substring(1, 3);
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            txtOUT.Text = st.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            txtOUT.Text = st.ToLower();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string st1 = txtIN1.Text;
            string st2 = txtIN2.Text;

            // if (st1 == st2) txtOUT.Text = "T";
            // else txtOUT.Text = "F"; 

            // 위에 대해서 두 "값" 이 같다면 같다고 나올 것이다 
            // 그러나, st는 참조변수이므로 저 말을 곧이곧대로 받아들인다면
            // 두개의 참조변수가 가르키는 곳이 같은가? 를 의미하는 것이고 엄밀하게는 다르다고 해야 맞다
            // 참조변수들이 가르키는 곳 메모리의 값이 같은 것이지 주소가 같은건 X
            // 그러나 C#은 알잘딱으로 해준다~ 만약 엄밀하게 하고싶다면?

            if (st1.CompareTo(st2)==0) txtOUT.Text = "T";
            else txtOUT.Text = "F";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string st1 = txtIN1.Text;
            string st2 = txtIN2.Text;

            int index_pos = st1.IndexOf(st2);
            txtOUT.Text = index_pos.ToString();
        }

        private void btnPadLeft_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = int.Parse(txtIN2.Text);

            txtOUT.Text = st.PadLeft(len);
        }

        private void btnPadRight_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = int.Parse(txtIN2.Text);

            txtOUT.Text = st.PadRight(len);

            // DataTime.Now 와 st.Length의 차이란?
            // DataTime은 빵틀(클래스)이고 st는 빵(객체or인스턴스)다.
            // 인스턴스는 객체들의 차이를 의미한다.

            // string이라는 클래스형으로 st라는 객체를 만들었고 Length는 st의 객체마다의 차이의 요인
            // 이때의 Length는 인스턴스이다! -> 객체마다 유동적으로 변하므로 non-static이라고 쓴다
            // DataTime.Now는 모든 객체에 걸쳐 변하지않고 공통된 속성값이다 -> static값이다.

            // e.g. public static DataTime Now 이런식으로 써진다!!!
            // i.e. 각 속성 Now, Length들은 걔의 특성에 따라 클래스에 속성으로 귀속될지,
            //      객체 내 속성(인스턴스)로 할 것이지 정하는 것이 포인트다~
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string st = lblTime.Text;
            string[] word = st.Split(new char[] { '-', ' ', ':' });
            txtOUT.Text = word[4]+"h";
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string st = lblTime.Text;
            txtOUT.Text = st.Replace(" ", "");
        }
    }
}
