using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBall_1._2
{
    internal class Chapter
    {
        private string _name;
        private int _number;
        private List<Mission> _missions;

        public Chapter(int number, string name, List<Mission> missions)
        {
            Number = number;
            Name = name;
            Mission = missions;
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
        public List<Mission> Mission
        {
            get { return _missions; }
            private set
            {
                _missions = value ?? throw new ArgumentNullException(nameof(value));       
            }
        }
        //public Journey Journey { get; private set; }

    }
}
