using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Form1 : Form
    {
        private int x = 0; int y = 0;
        private Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void picClock_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawEllipse(new Pen(Color.Blue), x, y, 20, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 10; y += 20;
            if(bitmap==null) bitmap = new Bitmap(picClock.ClientSize.Width, picClock.ClientSize.Height);
            
            Graphics grp = Graphics.FromImage(bitmap);
            grp.Clear(picClock.BackColor);
            grp.DrawEllipse(new Pen(Color.Blue), x, y, 20, 20);
            
            picClock.Image = bitmap;
            //picClock.Invalidate();
        }
    }
}
