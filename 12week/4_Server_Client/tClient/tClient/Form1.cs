using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


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
    }
}
