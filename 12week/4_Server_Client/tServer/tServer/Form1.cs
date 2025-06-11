using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace tServer
{
    public partial class Form1 : Form
    {
        private TServer serverChat; //채팅용
        private TServer serverCopy; //원위치복사용
        private TServer serverComm; //비트통신용

        private string rbuffcir = "";   // 원위치송신메시지 저장버퍼
        private string rbuffbit = "";   // 비트정보 asking 메시지 저장버퍼
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            string hostname = TSocket.HostName();
            IPAddress[] addrs = TSocket.HostAddresses();

            string st = hostname + "\r\n";
            for (int i = 0; i < addrs.Length; i++)
            {
                st = st + addrs[i].ToString() + "\r\n";
            }

            lblComInfo.Text = st;

            btnServerMe.PerformClick();
        }

        private void btnServerMe_Click(object sender, System.EventArgs e)
        {
            txtMyIP.Text = TSocket.HostAddressesv4().ToString();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            if (serverChat != null) serverChat.ServerClose();
            if (serverCopy != null) serverCopy.ServerClose();
            if (serverComm != null) serverComm.ServerClose();
        }

        private void timConnStatus_Tick(object sender, System.EventArgs e)
        {
            if (serverChat == null) { lblConnChat.Text = "Chat : " + "NULL"; }
            else
            {
                csConnStatus conn = serverChat.ServerStatus();
                lblConnChat.Text = "Chat : " + conn.ToString();
            }

            if (serverCopy == null) { lblConnCopy.Text = "Copy : " + "NULL"; }
            else
            {
                csConnStatus conn = serverCopy.ServerStatus();
                lblConnCopy.Text = "Copy : " + conn.ToString();
            }

            if (serverComm == null) { lblConnComm.Text = "Comm : " + "NULL"; }
            else
            {
                csConnStatus conn = serverComm.ServerStatus();
                lblConnComm.Text = "Comm : " + conn.ToString();
            }
        }

        private void btnListen_Click(object sender, System.EventArgs e)
        {
            string myIP = txtMyIP.Text;

            if (serverChat == null) serverChat = new TServer();
            serverChat.ServerStartListen(myIP, 5000);   // 1024~65535 추천

            if (serverCopy == null) serverCopy = new TServer(CirclePosDataArrived);
            serverCopy.ServerStartListen(myIP, 5001);   // 1024~65535 추천

      
        }

        private void CirclePosDataArrived()
        {
            while (true)
            {
                rbuffcir += serverCopy.GetRcvMsg();
                int idx1 = rbuffcir.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = rbuffcir.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 > idx1)
                {
                    string xypos = rbuffcir.Substring(idx1 + 1, idx2 - idx1 - 1);
                    char[] sep = new char[] { ',' };
                    string[] xy = xypos.Split(sep);
                    //lblO.Left = Convert.ToInt32(xy[0]);
                    //lblO.Top = Convert.ToInt32(xy[1]); 크로스스레드 접근 에러
                    lblO.Invoke((MethodInvoker)(() => lblO.Left = Convert.ToInt32(xy[0])));  // 다른 쓰레드에서는 Invoke를 사용해서 작업을 위임
                    lblO.Invoke((MethodInvoker)(() => lblO.Top = Convert.ToInt32(xy[1]))); rbuffcir = rbuffcir.Substring(idx2 + 1);
                }
                else
                    break;
            }
        }

        private void AskingBitsDataArrived()
        {
            while (true)
            {
                rbuffbit += serverComm.GetRcvMsg();
                int idx1 = rbuffbit.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = rbuffbit.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 - idx1 == 3)
                {
                    string stnet = rbuffbit.Substring(idx1 + 1, 2);
                    if (stnet == "RI")
                    {
                        int ibits = 0;
                        if (chkDI0.Checked) ibits += 0x1;
                        if (chkDI1.Checked) ibits += 0x2;
                        if (chkDI2.Checked) ibits += 0x4;
                        if (chkDI3.Checked) ibits += 0x8;
                        if (chkDI4.Checked) ibits += 0x10;
                        if (chkDI5.Checked) ibits += 0x20;
                        if (chkDI6.Checked) ibits += 0x40;
                        if (chkDI7.Checked) ibits += 0x80;

                        string hexnum = Util.Hex(ibits);
                        if (hexnum.Length == 1) hexnum = "0" + hexnum;
                        string st = TSocket.sACK() + "RI" + hexnum + TSocket.sETX();
                        serverComm.ServerSend(st);
                    }
                    // 처리한 곳까지 잘라내기
                    rbuffbit = rbuffbit.Substring(idx2 + 1);
                }
            }
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            if (serverChat == null) return;

            string st = txtSend.Text.Trim();
            if (st.Length <= 0) return;

            serverChat.ServerSend(st + "\r\n");
            txtDialog.Text += "[Me] " + st + "\r\n";
            txtSend.Text = "";
        }

        private void timGetRcvMsg_Tick(object sender, System.EventArgs e)
        {
            if (serverChat == null) return;
            string st = serverChat.GetRcvMsg();
            if (st.Length > 0) txtDialog.Text += st;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') btnSend.PerformClick();
        }

        private double add(double x, double y)
        { return x + y; }

    }
}
