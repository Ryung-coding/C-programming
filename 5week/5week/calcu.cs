using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5week
{
    internal class calcu
    {
        public static void Divide(int a, int b, out int quo, out int remain)
        {
            quo = a / b;
            remain = a % b;
        }

        public static void Swap(ref int a,ref int b)
        {
            int buf = a;
            a = b;
            b = buf;
        }
    }
}
