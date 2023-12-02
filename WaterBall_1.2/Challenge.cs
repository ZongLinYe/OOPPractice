using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBall_1._2
{
    public class Challenge
    {
        private string _name;
        private int _number;
        public Challenge(int number, string name)
        {
            Number = number;
            Name = name;
        }
        public int Number
        {
            get { return _number; }
            private set
            {
                _number = value.ShouldBePositive();
            }
        }
        public string Name
        {
            get { return _name; }
            private set
            {
                _name = value.LimitLength(1, 30);
            }
        }
    }
}
