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

            if (serverComm == null) serverComm = new TServer(AskingBitsDataArrived);
            serverComm.ServerStartListen(myIP, 5002);   // 1024~65535 추천
        }
        private void CirclePosDataArrived()
        {

        }

        private void AskingBitsDataArrived()
        {

        }

    }
}
