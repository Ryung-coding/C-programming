using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace MonteTri
{
    class Triangle
    {
        public double x1, y1, x2, y2, x3, y3;

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;   
            this.y1 = y1;   
            this.x2 = x2;   
            this.y2 = y2;   
            this.x3 = x3;   
            this.y3 = y3;   
        }

        public double AreaSigned()
        {
            double area = (x1 * y2 + x2 * y3 + x3 * y1) -
                            (x1 * y3 + x3 * y2 + x2 * y1);
            area /= 2.0;
            return area;
        }

        public bool IsPointInside(double xp, double yp)
        {
            Triangle t1 = new Triangle(xp, yp, x1, y1, x2, y2);
            Triangle t2 = new Triangle(xp, yp, x2, y2, x3, y3);
            Triangle t3 = new Triangle(xp, yp, x3, y3, x1, y1);

            double a1 = t1.AreaSigned();
            double a2 = t2.AreaSigned();
            double a3 = t3.AreaSigned();

            return (a1 >= 0 && a2 >= 0 && a3 >= 0) || (a1 <= 0 && a2 <= 0 && a3 <= 0);
        }


        public void Draw(PictureBox pic, Color col, double xp, double yp)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawEllipse(new Pen(col), (float)xp, (float)yp, 1, 1);
        }
    }
}
