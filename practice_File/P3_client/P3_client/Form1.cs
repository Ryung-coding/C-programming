using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace P3_client
{
    public partial class Form1 : Form
    {
        private TClient client;
        string buf = "";
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress[] addrs = TSocket.HostAddresses();
            string myIP = addrs[1].ToString();
            if (client == null) client = new TClient(callback_funtion);
            client.ClientBeginConnect(myIP, 5000, myIP);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            client.ClientClose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(client == null) return;
            if(client.ClientStatus() == csConnStatus.Connected)
            {
                lblConnState.Text = "Connected";
            }
            else
            {
                lblConnState.Text = "Disconnected";
            }
        }

        private void callback_funtion()
        {
            if (client == null) return;

            Color col = Color.Black;
            bool isFill = false;
            int num = 0;

            while (true)
            {
                buf += client.GetRcvMsg();

                if (buf.Length> 0)
                {
                    int heartbeat = Convert.ToInt32(lblNRcv.Text);
                    lblNRcv.Text = (++heartbeat).ToString();
                    int start = buf.IndexOf(TSocket.sSTX());
                    int end = buf.IndexOf(TSocket.sETX());
                    
                    if(start >= 0 && end > start) 
                    {
                        buf = buf.Substring(start + 1, end - start - 1);
                        String[] data = buf.Split(new char[] { ',' });
                        double[] x_point = new double[data.Length - 2];
                        double[] y_point = new double[data.Length - 2];

                        for (int i = 0; i < data.Length; i++)
                        {
                            if (data[i] == "Red")
                            {
                                col = Color.Red;
                                continue;
                            }
                            if (data[i] == "Blue")
                            {
                                col = Color.Blue;
                                continue;
                            }
                            if (data[i] == "Fill")
                            {
                                isFill = true;
                                continue;
                            }
                            if (data[i] == "Line")
                            {
                                isFill = false;
                                continue;
                            }
                            else
                            {
                                string[] point = new string[2];
                                point = data[i].Split(new char[] { ':' });
                                if (point.Length == 2)
                                {
                                    x_point[num] = Convert.ToDouble(point[0]);
                                    y_point[num] = Convert.ToDouble(point[1]);
                                    num++;
                                }
                                
                            }
                        }

                        Graphics grp = picDraw.CreateGraphics();

                        PointF[] points = new PointF[num];
                        for (int i = 0; i < num; i++)
                        {
                            points[i].X = (float)x_point[i];
                            points[i].Y = (float)y_point[i];
                        }
                        if (isFill)
                        {
                            grp.FillPolygon(new SolidBrush(col), points);
                        }
                        else
                        {
                            grp.DrawPolygon(new Pen(col), points);
                        }
                    }

                }
                else break;
            }
        }
    }
}
