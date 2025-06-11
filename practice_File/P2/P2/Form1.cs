using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace P2
{
    public partial class Form1 : Form
    {

        private TClient clientComm;
        string buf = "";

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress[] addrs = TSocket.HostAddresses();
            string myIP = addrs[1].ToString();
            string serverIP = myIP;
            if (clientComm == null) clientComm = new TClient(CirclePosDataArrived);
            clientComm.ClientBeginConnect(serverIP, 5000, myIP);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(clientComm != null) clientComm.ClientClose();
        }
        

        private void timer_Tick(object sender, EventArgs e)
        {
            if (clientComm != null)
            {
                if(clientComm.ClientStatus() == csConnStatus.Connected) lblConnState.Text = "comm : Connected";
                else lblConnState.Text = "comm : ";
            }
        }

        private void CirclePosDataArrived()
        {
            TDraw draw = new TDraw(picDraw, 0, 100, 00, 100);
            Color send_color = Color.Black;
            bool isFill = false;
            

            while (true)
            {

                buf += clientComm.GetRcvMsg();

                if (buf.Length > 0)
                {
                    int num = Convert.ToInt32(lblNRcv.Text);
                    lblNRcv.Text = (num + 1).ToString();
                }

                int idx1 = buf.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = buf.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 > idx1)
                {
                    string xypos = buf.Substring(idx1 + 1, idx2 - idx1 - 1);
                    char[] sep = new char[] { ',' };
                    string[] xy = xypos.Split(sep);
                    double[] x_point = new double[xy.Length-2];
                    double[] y_point = new double[xy.Length - 2];
                    int num = 0;
                    for (int i = 0; i < xy.Length; i++)
                    {
                        if (xy[i] == "Blue")
                        {
                            send_color = Color.Blue;
                            continue;
                        }

                        if (xy[i] == "Red")
                        {
                            send_color = Color.Red;
                            continue;
                        }
                        if (xy[i] == "Fill")
                        {
                            isFill = true;
                            continue;
                        }

                        if (xy[i] == "Line")
                        {
                            isFill = false;
                            continue;
                        }
                        else
                        {
                            string[] point = xy[i].Split(':');
                            if (point.Length == 2)
                            {
                                x_point[num] = draw.xpixelpos(Convert.ToDouble(point[0]));
                                y_point[num] = draw.ypixelpos(Convert.ToDouble(point[1]));


                                num++;
                            }
                        }

                        Graphics grp = picDraw.CreateGraphics();
                        Pen pen = new Pen(send_color, 2);
                        if (isFill)
                        {
                            SolidBrush brush = new SolidBrush(send_color);
                        }
                        
                        if (num > 1)
                        {
                            PointF[] points = new PointF[num];
                            for (int j = 0; j < num; j++)
                            {
                                points[j] = new PointF((float)x_point[j], (float)y_point[j]);
                            }
                            if (isFill)
                            {
                                SolidBrush brush = new SolidBrush(send_color);
                                grp.FillPolygon(brush, points);
                            }
                            else
                            {
                                grp.DrawPolygon(pen, points);
                            }
                        }


                    }

                }
                else
                    break;
            }
        }   

    }
}
