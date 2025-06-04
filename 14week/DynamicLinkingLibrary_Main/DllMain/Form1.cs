using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DllMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInCSharp_Click(object sender, EventArgs e)
        {
            lblNPrime.Text = "...";
            lblTime.Text = "...";
            btnInCSharp.Enabled = false;
            btnInCPP.Enabled = false;
            Application.DoEvents();

            int nMax = Convert.ToInt32(txtNMax.Text);

            DateTime stime = DateTime.Now;
            PrimeCSharp.FindNumberOfPrimeNumber(nMax, out int nprime);
            double dtime = Util.TimeInSeconds(stime);

            lblNPrime.Text = Convert.ToString(nprime);
            lblTime.Text = string.Format("{0:0.00}", dtime);
            btnInCSharp.Enabled = true;
            btnInCPP.Enabled = true;
        }

        private void btnInCPP_Click(object sender, EventArgs e)
        {
            lblNPrime.Text = "...";
            lblTime.Text = "...";
            btnInCSharp.Enabled = false;
            btnInCPP.Enabled = false;
            Application.DoEvents();

            int nMax = Convert.ToInt32(txtNMax.Text);
            int nprime = 0;

            DateTime stime = DateTime.Now;
            dllPrime.dllFindNumberOfPrimeNumber(nMax, ref nprime);
            double dtime = Util.TimeInSeconds(stime);

            lblNPrime.Text = Convert.ToString(nprime);
            lblTime.Text = string.Format("{0:0.00}", dtime);
            btnInCSharp.Enabled = true;
            btnInCPP.Enabled = true;
        }

        int[] nums;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int nMax = Convert.ToInt32(txtNMax.Text);
            nums = new int[nMax];
            for (int i = 0; i < nums.Length; i++) nums[i] =  rnd.Next(1,10000);
        }

        private void btn_sort_cs_Click(object sender, EventArgs e)
        {
            lblNPrime.Text = "...";
            lblTime.Text = "...";
            btnInCSharp.Enabled = false;
            Application.DoEvents();

            DateTime stime = DateTime.Now;
            Sort();
            double dtime = Util.TimeInSeconds(stime);

            lblTime.Text = string.Format("{0:0.00}", dtime);
            btn_sort_cs.Enabled = true;
        }

        public void Sort()
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int jmin = i;
                int min = nums[i];

                for(int j = i+1;j < nums.Length; j++)
                {
                    if (min > nums[j])
                    {
                        jmin = j;
                        min = nums[j];
                    }
                }
                if(jmin!=i)
                {
                    nums[jmin] = nums[i];
                    nums[i] = min;
                }
            }
        }
    }
}
