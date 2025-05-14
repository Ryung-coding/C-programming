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

namespace Polling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setDOStatus()
        {
            if (!serialPort.IsOpen) return;

            setCommLamp(true);

            bool[] bits = new bool[8];
            bits[0] = chkDO0.Checked;
            bits[1] = chkDO1.Checked;
            bits[2] = chkDO2.Checked;
            bits[3] = chkDO3.Checked;
            bool success = TComm.SetDigitalOutput(serialPort, bits);
        }

        private void setAOStatus()
        {
            if (!serialPort.IsOpen) return;

            setCommLamp(true);

            int[] davals = new int[4];
            davals[0] = hscLED0.Value;
            davals[1] = hscLED1.Value;
            davals[2] = hscLED2.Value;
            davals[3] = hscLED3.Value;
            bool success = TComm.SetAnalogData(serialPort, davals);
        }

        private void setLEDStatus()
        {
            if (radDigital.Checked) setDOStatus();
            if (radAnalog.Checked) setAOStatus();
        }
        private void setCommLamp(bool isOn)
        {
            picComm.Image = (isOn) ? Properties.Resources.LampOn : Properties.Resources.LampOff;
        }

        private void chkComm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComm.Checked)
            {
                bool success = SPort.OpenPorts(serialPort,
                                                Convert.ToInt32(txtPortNum.Text));
                if (!success)
                {
                    MessageBox.Show("시리얼포트를 열지 못했습니다", "오류");
                }
            }
            else
            {
                SPort.ClosePorts(serialPort);
            }
            setLEDStatus();
        }

        private void timCommMon_Tick(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) return;

            //---------------------------------------------
            // Digital Input
            //---------------------------------------------
            setCommLamp(true);

            bool[] bits = new bool[8];
            int adval_null;
            //bool success = TComm.AskDigitalInput(serialPort, bits);
            bool success = Ask_AB_Data(serialPort, out bits, out adval_null);
            if (success)
            {
                chkButton0.Checked = bits[0];
                chkButton1.Checked = bits[1];
                chkButton2.Checked = bits[2];
                chkButton3.Checked = bits[3];
            }

            //---------------------------------------------
            // AD
            //---------------------------------------------
            setCommLamp(true);

            bool[] bits_null = new bool[8];
            int adval;
            //success = TComm.AskADData(serialPort, out adval);
            success = Ask_AB_Data(serialPort, bits_null, out adval);

            if (success)
            {
                txtAD.Text = Convert.ToString(adval);
            }
        }

        private void timLampOff_Tick_1(object sender, EventArgs e)
        {
            setCommLamp(false);
        }

        private void chkDO_CheckedChanged(object sender, EventArgs e)
        {
            setLEDStatus();
        }

        private void hscLED_Scroll(object sender, ScrollEventArgs e)
        {
            lblLED0.Text = hscLED0.Value.ToString();
            lblLED1.Text = hscLED1.Value.ToString();
            lblLED2.Text = hscLED2.Value.ToString();
            lblLED3.Text = hscLED3.Value.ToString();
            setLEDStatus();
        }

        private void radDigital_CheckedChanged(object sender, EventArgs e)
        {
            setLEDStatus();
        }

        private void radAnalog_CheckedChanged(object sender, EventArgs e)
        {
            setLEDStatus();
        }
    }
}
