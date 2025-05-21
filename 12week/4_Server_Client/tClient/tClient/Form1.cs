using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;


namespace tClient
{
    public partial class Form1 : Form
    {
        private TClient clientChat; //채팅용
        private TClient clientCopy; //원위치복사용
        private TClient clientComm; //비트통신용
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void btnServerMe_Click(object sender, EventArgs e)
        {
            txtServerIP.Text = TSocket.HostAddressesv4().ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (clientChat != null) clientChat.ClientClose();
            if (clientCopy != null) clientCopy.ClientClose();
            if (clientComm != null) clientComm.ClientClose();
        }

        private void timConnStatus_Tick(object sender, EventArgs e)
        {
            if (clientChat == null) { lblConnChat.Text = "Chat : " + "NULL"; }
            else
            {
                csConnStatus conn = clientChat.ClientStatus();
                lblConnChat.Text = "Chat : " + conn.ToString();
            }

            if (clientCopy == null) { lblConnCopy.Text = "Copy : " + "NULL"; }
            else
            {
                csConnStatus conn = clientCopy.ClientStatus();
                lblConnCopy.Text = "Copy : " + conn.ToString();
            }

            if (clientComm == null) { lblConnComm.Text = "Comm : " + "NULL"; }
            else
            {
                csConnStatus conn = clientComm.ClientStatus();
                lblConnComm.Text = "Comm : " + conn.ToString();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string serverIP = txtServerIP.Text; 
            string clientIP = TSocket.HostAddressesv4().ToString();

            if (clientChat == null) clientChat = new TClient();
            clientChat.ClientBeginConnect(serverIP, 5000, clientIP);   // 1024~65535 추천

            if (clientCopy == null) clientCopy = new TClient();
            clientCopy.ClientBeginConnect(serverIP, 5001, clientIP);   // 1024~65535 추천

            if (clientComm == null) clientComm = new TClient();
            clientComm.ClientBeginConnect(serverIP, 5002, clientIP);   // 1024~65535 추천
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (clientChat == null) return;

            string st = txtSend.Text.Trim();
            if (st.Length <= 0) return;

            clientChat.ClientSend(st + "\r\n");
            txtDialog.Text += "[Me] " + st + "\r\n";
            txtSend.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') btnSend.PerformClick();
        }

        private void timGetRcvMsg_Tick(object sender, EventArgs e)
        {
            if (clientChat == null) return;
            string st = clientChat.GetRcvMsg();
            if (st.Length > 0) txtDialog.Text += st;
        }

        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            lblO.Left = e.X;
            lblO.Top = e.Y;

            string st = TSocket.sSTX() + Convert.ToString(e.X) +
                        "," + Convert.ToString(e.Y) + TSocket.sETX();
            clientCopy.ClientSend(st);
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            lblO.Left = e.X;
            lblO.Top = e.Y;

            string st = TSocket.sSTX() + Convert.ToString(e.X) +
                        "," + Convert.ToString(e.Y) + TSocket.sETX();
            clientCopy.ClientSend(st);
        }

        private void btnReadBits_Click(object sender, EventArgs e)
        {
            if (clientComm == null) return;
            if (clientComm.ClientStatus() != csConnStatus.Connected) return;

            bool success = TComm.AskDigitalInput(clientComm, out bool[] bits);
            if (success)
            {
                picLamp00.BackColor = bits[0] ? Color.GreenYellow : Color.Gray;
                picLamp01.BackColor = bits[1] ? Color.GreenYellow : Color.Gray;
                picLamp02.BackColor = bits[2] ? Color.GreenYellow : Color.Gray;
                picLamp03.BackColor = bits[3] ? Color.GreenYellow : Color.Gray;
                picLamp04.BackColor = bits[4] ? Color.GreenYellow : Color.Gray;
                picLamp05.BackColor = bits[5] ? Color.GreenYellow : Color.Gray;
                picLamp06.BackColor = bits[6] ? Color.GreenYellow : Color.Gray;
                picLamp07.BackColor = bits[7] ? Color.GreenYellow : Color.Gray;
            }
            lblCommOK.Text =
                        Convert.ToString(Convert.ToInt32(lblCommOK.Text) + 1);
        }

        private void timAskBits_Tick(object sender, EventArgs e)
        {
            btnReadBits.PerformClick();
        }
    }
}
