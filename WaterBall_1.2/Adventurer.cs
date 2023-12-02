using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBall_1._2
{
    public class Adventurer
    {
        private int _number;
        private Student _student;
        private Journey _journey;
        private TourGroup _tourGroup;

        public Adventurer(
            int number, 
            Student student, 
            Journey journey)
        {
            Number = number;
            Student = student;
            Journey = journey;
        }

        public int Number
        {
            get { return _number; }
            private set
            {
                _number = value.ShouldBePositive();
            }
        }
        public Student Student
        {
            get { return _student; }
            private set
            {
                _student = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public Journey Journey
        {
            get { return _journey; }
            private set
            {
                _journey = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        /// <summary>
        /// 沒有在建構子初始化 TourGroup ，因為 Adventurer 是之後才被加進 TourGroup 的
        /// 在 TourGroup 實作 Add Adventurer 方法
        /// </summary>
        public TourGroup TourGroup
        {
            get { return _tourGroup; }
            internal set
            {
                _tourGroup = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        internal void CarryOn(Mission firstMission)
        {
            //throw new NotImplementedException();
            Student.CarryOn(firstMission);
        }
    }
}
