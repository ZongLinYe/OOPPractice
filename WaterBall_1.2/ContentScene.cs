using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBall_1._2
{
    internal class ContentScene : Scene
    {
        public ContentScene(int number, string name, int experienceAward) : base(number, name, experienceAward)
        {
        }

        public override int CalculateExperienceAward()
        {
            return (int)(ExperienceAward*1.1);
        }
    }
}
