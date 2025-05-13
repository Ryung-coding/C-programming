using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SPort
{
    private static List<byte> rcvbytes = new List<byte>();

    public static char sSTX() { return Convert.ToChar(0x02); }
    public static char sETX() { return Convert.ToChar(0x03); }
    public static char sEOT() { return Convert.ToChar(0x04); }
    public static char sENQ() { return Convert.ToChar(0x05); }
    public static char sACK() { return Convert.ToChar(0x06); }
    public static char sNAK() { return Convert.ToChar(0x15); }
    public static char sCR() { return Convert.ToChar(13); }
    public static char sLF() { return Convert.ToChar(10); }
    public static string sCRLF() { return "\r\n"; }

    //========================================================
    //  컴퓨터에 존재하는 Port 알아보기
    //========================================================
    public static string[] GetPortsList() //컴퓨터에 연결된 CoM List를 확인하는 함수다 
    {
        List<string> serialportlist = new List<string>();
        serialportlist.Clear();
        foreach (string comport in SerialPort.GetPortNames()) //이게 꿀팁 함수다~!~
        {
            serialportlist.Add(comport);
        }
        return serialportlist.ToArray();
    }

    //========================================================
    //  Port 열기
    //========================================================
    public static bool OpenPorts(SerialPort sport, int portnum)
    {
        if (sport.IsOpen) sport.Close();

        //SerialPort 초기설정
        sport.PortName = "COM" + portnum.ToString();
        sport.BaudRate = 9600;
        sport.DataBits = 8; //미국은 7bit를 하는데 우린 한글이라 8 bit를 쓴다
        sport.Parity = Parity.None;
        sport.StopBits = StopBits.One;
        //여기까지가 기본적인 설정

        sport.ReceivedBytesThreshold = 1; //이게 꼭 있어야한다 -> 1바이트만 수신되더라도 작동하기 위해

        bool rtn;
        try
        {
            sport.Open();
            rtn = true;
        }
        catch { rtn = false; }

        return rtn;
    }

    //========================================================
    //  Port 닫기
    //========================================================
    public static void ClosePorts(SerialPort sport)
    {
        if (sport.IsOpen) sport.Close();
    }

    //========================================================
    //  데이터보내기
    //========================================================
    public static void Send(SerialPort sport, string text)
    {
        sport.Write(text); //한글이 없는 경우 전송
    }
    public static void SendUnicode(SerialPort sport, string text)
    {
        byte[] tmp = Encoding.UTF8.GetBytes(text); //한글이 있는경우 수정하여 전송
        sport.Write(tmp, 0, tmp.Length);
    }

    //========================================================
    //  데이터읽기
    //========================================================
    public static string Read(SerialPort sport)
    {
        return sport.ReadExisting(); 
        //나에게 날아온 창(우편함)에 대해서 읽는다
        //만일 없다면 아무짓도 안하겠죠 허허
    }
    public static string ReadUnicode(SerialPort sport, byte endByte)
    {
        while (true)
        {
            byte inbyte = (byte)sport.ReadByte();
            rcvbytes.Add(inbyte);
            if (inbyte == endByte) break;
        }

        byte[] bytes = rcvbytes.ToArray();
        rcvbytes.Clear();

        string st = Encoding.UTF8.GetString(bytes);
        return st;
    }
}