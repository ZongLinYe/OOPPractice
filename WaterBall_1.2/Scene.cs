using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBall_1._2
{
    public abstract class Scene
    {
        private string _name;
        private int _number;
        private int _experienceAward;
        public Scene(int number, string name, int experienceAward)
        {
            Number = number;
            Name = name;
            ExperienceAward = experienceAward;
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
        public int ExperienceAward
        {
            get { return _experienceAward; }
            private set
            {
                _experienceAward = value;
            }
        }
        public abstract int CalculateExperienceAward();

    }
}
