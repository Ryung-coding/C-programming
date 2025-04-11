using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6week_assignment
{
    public partial class Form1 : Form
    {
        List<Geom> geoms = new List<Geom>();  // 컨테이너 클래스 List !! 매우중요
        // Line[] lines = new Line[?]; 가 보통적인데 이런 경우 ?에 수값을 모른다!
        // 그러므로, 동적메모리에 대해 효과적으로 해주는 컨테이너 클래스를 쓰면 좋다 !

        Random rnd = new Random();

        private void RedrawAll()
        {
            Graphics grp = picDraw.CreateGraphics();
            grp.Clear(Color.White);
            for (int i = 0; i < geoms.Count; i++)
            {
                geoms[i].Draw(picDraw);  // 다형적 호출
            }

            this.lblNCir.Text = Circle.num.ToString();  // static 멤버의 access
            this.lblNDia.Text = Diamond.num.ToString();
            this.lblNTotal.Text = geoms.Count.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw3_Click(object sender, EventArgs e)
        {
            Geom geom;
            Color col;

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Circle(150, 220, 10, col);
            geoms.Add(geom);

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Diamond(200, 300, 20, 20, col);
            geoms.Add(geom);

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Rectangle(250, 130, 20, 20, col);
            geoms.Add(geom);

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Triangle(250, 130, 280, 140, 300, 100, col);
            geoms.Add(geom);

            for (int i = 0; i < geoms.Count; i++) geoms[i].Draw(picDraw); 
            // Draw함수가 알잘딱으로 다형적호출 실시

            RedrawAll();
        }

        private void btnDraw100_Click(object sender, EventArgs e)
        {
            Color col;
            int ngeom = 100;
            for (int i = 0; i < ngeom; i++)
            {
                if (rnd.Next(4) == 0) // Circle
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Circle cir = new Circle(rnd.Next(500), rnd.Next(500),rnd.Next(30), col);
                    geoms.Add(cir);
                }
                if (rnd.Next(4) == 1) // Diamond
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Diamond dia = new Diamond(rnd.Next(500), rnd.Next(500),rnd.Next(30), rnd.Next(30), col);
                    geoms.Add(dia);
                }
                if (rnd.Next(4) == 2) // Rectangle
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Rectangle rec = new Rectangle(rnd.Next(500), rnd.Next(500), rnd.Next(30), rnd.Next(30), col);
                    geoms.Add(rec);
                }
                if (rnd.Next(4) == 3) // Triangle 
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    int x0= rnd.Next(500);
                    int y0 = rnd.Next(500);
                    Triangle tri = new Triangle(x0, y0, x0 + rnd.Next(30), y0 + rnd.Next(30), x0 + rnd.Next(30), y0 + rnd.Next(30), col);
                    geoms.Add(tri);
                }
            }

            RedrawAll();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            geoms.Clear();
            Circle.num = 0;
            Diamond.num = 0;

            RedrawAll();
        }
    }
}
