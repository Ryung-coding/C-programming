using System;
static class TComm
{
    //===========================================================
    //  통신에 성공하면 true 리턴
    //===========================================================
    public static bool AskDigitalInput(TClient clientComm, out bool[] bits)
    {
        // 수신버퍼 청소
        string dum = clientComm.GetRcvMsg();

        // 명령 송신
        string st = TSocket.sSTX() + "RI" + TSocket.sETX();
        clientComm.ClientSend(st);

        // 송신시간 기록
        DateTime stime = DateTime.Now;

        // 수신 대기
        int idx1, idx2, indata = 0;
        bool success = false;
        string rbuff = "";
        while (true)
        {
            // timeout 검사
            double dtime = Util.TimeInSeconds(stime);
            if (dtime > 0.5) break;

            // 수신 버퍼 검사
            rbuff += clientComm.GetRcvMsg();

            idx1 = rbuff.IndexOf(TSocket.sACK());
            if (idx1 >= 0)
            {
                idx2 = rbuff.IndexOf(TSocket.sETX(), idx1);

                if (idx2 - idx1 == 5)
                {
                    if (rbuff.Substring(idx1 + 1, 2) == "RI")
                    {
                        // 한개의 block 찾음
                        string dd = rbuff.Substring(idx1 + 3, 2);
                        indata = Convert.ToInt32(dd, 16);   // 16진수를 10진수로 변환
                        success = true;
                        break;
                    }
                }
            }
        }
        if (success)
        {
            bits = new bool[8];
            bits[0] = ((indata & 0x01) > 0);
            bits[1] = ((indata & 0x02) > 0);
            bits[2] = ((indata & 0x04) > 0);
            bits[3] = ((indata & 0x08) > 0);
            bits[4] = ((indata & 0x10) > 0);
            bits[5] = ((indata & 0x20) > 0);
            bits[6] = ((indata & 0x40) > 0);
            bits[7] = ((indata & 0x80) > 0);
        }
        else
            bits = null;

        return success;
    }
}