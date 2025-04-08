using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6week
{
    class RyungMath
    {
        public static void Normalize(double[] vec, out double[] uvec)
        {
            uvec = new double[3];

            double magnitude = Math.Sqrt((vec[0] * vec[0] + vec[1] * vec[1] + vec[2] * vec[2]));
            uvec[0] = vec[0] / magnitude;
            uvec[1] = vec[1] / magnitude;
            uvec[2] = vec[2] / magnitude;
        }


    }
}
