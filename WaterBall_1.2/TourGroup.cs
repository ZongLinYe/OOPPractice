using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBall_1._2
{
    public class TourGroup
    {
        private int _number;
        private List<Adventurer> _adventurers;
        //private Journey _journey;
        public TourGroup(int number, List<Adventurer> adventurers)
        {
            Number = number;
            Adventurers = adventurers;
        }
        public int Number
        {
            get { return _number; }
            private set
            {
                _number = value.ShouldBePositive();
            }
        }
        public List<Adventurer> Adventurers
        {
            get { return _adventurers; }
            private set
            {
                _adventurers = value ?? throw new ArgumentNullException(nameof(value));
                // 請注意這裡，要設定 Adventurer 的 TourGroup
                foreach (var adventurer in _adventurers)
                {
                    adventurer.TourGroup = this;
                }
            }
        }
        //public Journey Journey
        //{
        //    get { return _journey; }
        //    private set
        //    {
        //        _journey = value ?? throw new ArgumentNullException(nameof(value));
        //    }
        //}
        /// <summary>
        /// 請注意 TourGroup 與 Adventurer 是雙向關聯，兩邊都要設定
        /// </summary>
        /// <param name="adventurer"></param>
        public void AddAdventurer(Adventurer adventurer)
        {
            Adventurers.Add(adventurer);
            adventurer.TourGroup = this;
        }
    }
}
