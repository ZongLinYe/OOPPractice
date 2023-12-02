using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBall_1._2
{
    internal static class IntExtensions
    {
        public static int ShouldBePositive(this int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Int value error");
            }
            return value;
        }
    }
}
