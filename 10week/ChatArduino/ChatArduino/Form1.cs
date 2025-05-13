using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChatArduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                success = SPort.OpenPorts(serialPort, Convert.ToInt32(txtPortNum.Text));
            }
            catch
            { }

            if (success)
            {
                btnOpen.Enabled = false;
                btnSend.Enabled = true;
            }
            else { MessageBox.Show("시리얼포트를 열지 못했습니다", "오류"); }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //제거必
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SPort.GetPortsList();

            lblCOMs.Text = "";
            for (int i = 0; i < ports.Length; i++)
            {
                lblCOMs.Text = lblCOMs.Text + ports[i] + "\r\n";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtDialog.Text.Length > 1200) txtDialog.Text = "";

            string st = txtInput.Text.Trim();
            if (st.Length == 0) return;

            st = st + "\r\n";
            SPort.Send(serialPort, st);

            txtDialog.Text += "[PC] " + st;
            txtInput.Text = "";
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //이함수는 Received되었을때 callback처럼 작동해주는 이벤트

            if (txtDialog.Text.Length > 1200) txtDialog.Text = ""; //1200자 이상으로 print상태면 제거

            string inp = SPort.Read(serialPort); //우편함이라고 칭하는 곳에 내용을 읽는 내장함수
            //이때 우편함의 내용은 제거된다!
            //txtDialog.Text += "[Arduino] " + inp;  
            //이때 위와같이 작성하면, 다른 쓰레드여서 오류
            txtDialog.Invoke((MethodInvoker)(() => txtDialog.Text = "[Arduino] " + inp));  
            // 다른 쓰레드에서는 Invoke를 사용해서 작업을 위임
        }
    }
}
