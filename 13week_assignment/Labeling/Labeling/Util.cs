using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labeling
{
    public static class Util
    {
        //=================================================================
        //  시간 측정
        //=================================================================
        public static double TimeInSeconds(DateTime stime)
        {
            TimeSpan dtime = DateTime.Now - stime;
            return dtime.TotalSeconds;
        }
    }
}
