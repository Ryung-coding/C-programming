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

        private void geasangi_Click(object sender, EventArgs e)
        {
            int year_data = Convert.ToInt32(year.Text); //Convert.Toint XX 구문은 반올림을 한다        
            int month_data = Convert.ToInt32(month.Text);
            int day_data = Convert.ToInt32(day.Text);

            year_data = month_data == 1 || month_data == 2 ? year_data-- : year_data;
            month_data = month_data == 1 || month_data == 2 ? month_data+2 : month_data;
  
            //(int)로 안해도 int형 연산이므로 안해도 됨. 또한, 괄호또한 연산자의 우선순위에 따라 안해도 된다.
            //그러나 (2.6 * month_data + 1.6) 의 경우에는 소수로 인하여 double형으로 바뀌므로 int형 연산이 아니므로 (int)를 해줘야한다.
            
            int dayofweek = (year_data + (int)(year_data / 4) - (int)(year_data / 100) + (int)(year_data / 400) + (int)(2.6 * month_data + 1.6) + day_data) % 7;

            string[] yoil_list = new string[7] { "일", "월", "화", "수", "목", "금", "토" };
            yoil.Text = yoil_list[dayofweek];

        }
    }
}
