using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

class Geom
{
    public virtual void Draw(PictureBox pic) { }
    public Color col;
}


class Circle : Geom
{
    private int xcen, ycen, radius;
    public static int num;

    public Circle(int xcen, int ycen, int radius, Color col)
    {
        this.col = col;     // 상속된 속성
        this.xcen = xcen;   // 확장된 속성
        this.ycen = ycen;
        this.radius = radius;
        num++;              // static 멤버
    }

    public override void Draw(PictureBox pic)
    {
        Graphics grp = pic.CreateGraphics();
        grp.DrawEllipse(new Pen(col), xcen, ycen, radius * 2, radius * 2);
    }
}

class Diamond : Geom
{
    private int xcen, ycen, xsize, ysize;
    public static int num;

    public Diamond(int x, int y, int xs, int ys, Color col)
    {
        this.col = col;
        this.xcen = x;
        this.ycen = y;
        this.xsize = xs;
        this.ysize = ys;
        num++;
    }

    public override void Draw(PictureBox pic)
    {
        Graphics grp = pic.CreateGraphics();
        grp.DrawLine(new Pen(col), xcen + xsize / 2, ycen, xcen, ycen + ysize / 2);
        grp.DrawLine(new Pen(col), xcen, ycen + ysize / 2, xcen - xsize / 2, ycen);
        grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen, xcen, ycen - ysize / 2);
        grp.DrawLine(new Pen(col), xcen, ycen - ysize / 2, xcen + xsize / 2, ycen);
    }
}

class Rectangle : Geom
{
    private int xcen, ycen, xsize, ysize;
    public static int num;

    public Rectangle(int x, int y, int xs, int ys, Color col)
    {
        this.col = col;
        this.xcen = x;
        this.ycen = y;
        this.xsize = xs;
        this.ysize = ys;
        num++;
    }

    public override void Draw(PictureBox pic)
    {
        Graphics grp = pic.CreateGraphics();
        grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen + ysize / 2, xcen + xsize / 2, ycen + ysize / 2);
        grp.DrawLine(new Pen(col), xcen + xsize / 2, ycen + ysize / 2, xcen + xsize / 2, ycen - ysize / 2);
        grp.DrawLine(new Pen(col), xcen + xsize / 2, ycen - ysize / 2, xcen - xsize / 2, ycen - ysize / 2);
        grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen - ysize / 2, xcen - xsize / 2, ycen + ysize / 2);
    }
}

class Triangle : Geom
{
    private int x1, y1, x2, y2, x3, y3;
    public static int num;

    public Triangle(int x1, int y1, int x2, int y2, int x3, int y3, Color col)
    {
        this.col = col;
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
        num++;
    }

    public override void Draw(PictureBox pic)
    {
        Graphics grp = pic.CreateGraphics();
        grp.DrawLine(new Pen(col), x1, y1, x2, y2);
        grp.DrawLine(new Pen(col), x2, y2, x3, y3);
        grp.DrawLine(new Pen(col), x3, y3, x1, y1);
    }
}