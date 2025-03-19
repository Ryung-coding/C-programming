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

        private void total2hms_Click(object sender, EventArgs e)
        {
            int total_sec = Convert.ToInt32(input.Text);
            hour.Text = (total_sec / 3600).ToString();
            min.Text = ((total_sec - Convert.ToInt32(hour.Text) * 3600) / 60).ToString();
            sec.Text = ((total_sec - Convert.ToInt32(hour.Text) * 3600 - Convert.ToInt32(min.Text) * 60)).ToString();
        }

        private void hms2total_Click(object sender, EventArgs e)
        {
            int hour_data = Convert.ToInt32(hour.Text);
            int min_data = Convert.ToInt32(min.Text);
            int sec_data = Convert.ToInt32(sec.Text);
            input.Text = (hour_data * 3600 + min_data * 60 + sec_data).ToString();
        }
    }
}
