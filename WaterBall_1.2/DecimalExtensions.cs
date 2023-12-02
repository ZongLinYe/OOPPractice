using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBall_1._2
{
    public static class DecimalExtensions
    {
        public static decimal ShouldBeBiggerThan(this decimal value, decimal minValue)
        {
            if (value < minValue)
            {
                throw new ArgumentException("Decimal value error");
            }
            return value;
        }
    }
}
