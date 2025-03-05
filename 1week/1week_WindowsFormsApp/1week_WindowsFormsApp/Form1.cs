using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1week_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            
            i++;

            label1.Text = i.ToString()+"번!!!!";

            //MessageBox.Show("message cmd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
