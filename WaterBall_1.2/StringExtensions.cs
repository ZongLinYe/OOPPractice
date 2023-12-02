using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBall_1._2
{
    public static class StringExtensions
    {
        public static string LimitLength(this string value, int minLength, int maxLength)
        {
            if (value.Length < minLength || value.Length > maxLength)
            {
                throw new ArgumentException("String length error");
            }
            return value;
        }
    }
}
