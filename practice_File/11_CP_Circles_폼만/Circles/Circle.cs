using System;
using System.Drawing;

class Circle
{
    private static Random rnd = new Random();
    private double xcen, ycen, radius;
    private int red, green, blue;
    private double xmov, ymov;

    // 생성자 - 주어진 위치에 랜덤 크기, 랜덤 색의 원 생성
    public Circle(double xcen, double ycen)
    {
        this.xcen = xcen;
        this.ycen = ycen;
        this.radius = rnd.Next(10) + 2;
        this.red = rnd.Next(200);
        this.green = rnd.Next(200);
        this.blue = rnd.Next(200);  // 너무밝지않게
        while (true) { this.xmov = rnd.Next(-3, 3); if (xmov != 0) break; }
        while (true) { this.ymov = rnd.Next(-3, 3); if (ymov != 0) break; }
    }

    // 움직임
    public void move(double xmin, double xmax, double ymin, double ymax)
    {
        if (xcen <= xmin + radius) xmov = Math.Abs(xmov);
        if (xcen >= xmax - radius) xmov = -Math.Abs(xmov);

        if (ycen <= ymin + radius) ymov = Math.Abs(ymov);
        if (ycen >= ymax - radius) ymov = -Math.Abs(ymov);

        xcen += xmov;
        ycen += ymov;
    }

    // 그리기
    public void draw(TDraw canvas)
    {
        canvas.DrawEllipse(Color.FromArgb(this.red, this.green, this.blue),
        this.xcen, this.ycen, this.radius * 2, this.radius * 2);
    }

    // 주어진 점이 내부인지 판단
    public bool isinside(double xp, double yp)
    {
        double dx = xp - this.xcen;
        double dy = yp - this.ycen;
        double dist = Math.Sqrt(dx * dx + dy * dy);
        return (dist <= this.radius) ? true : false;
    }
}