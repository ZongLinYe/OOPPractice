using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WaterBall_1._2
{
    public class Journey
    {
        private string _name;
        private string _description;
        private decimal _price;
        private List<Adventurer> _adventurers;
        private List<TourGroup> _tourGroups;

        public Journey(
            string name,
            string description,
            decimal price,
            List<Chapter> chapters,
            List<Adventurer> adventurers,
            List<TourGroup> tourGroups)
        {
            Name = name;
            Description = description;
            Price = price;
            Chapters = chapters;
            Adventurers = adventurers;
            TourGroups = tourGroups;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value.LimitLength(1, 30);
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            private set
            {
                _description = value.LimitLength(0, 300);
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            private set
            {
                _price = value.ShouldBeBiggerThan(1);
            }
        }
        public List<Adventurer> Adventurers
        {
            get
            {
                return _adventurers;
            }
            private set
            {
                _adventurers = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public List<TourGroup> TourGroups
        {
            get
            {
                return _tourGroups;
            }
            private set
            {
                _tourGroups = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public List<Chapter> Chapters { get; private set; }

        public Adventurer Join(Student student)
        {
            // 取得學號
            int number = Adventurers.Count + 1;
            // 建立與冒險者的雙向關聯
            Adventurer adventurer = new Adventurer(number, student, this);
            _adventurers.Add(adventurer);
            student.Adventurers.Add(adventurer);

            // 開始第一項任務
            Mission firstMission = GetFirstMission();
            //adventurer.Student.CarryOn(firstMission);
            adventurer.CarryOn(firstMission);

            // 配對旅團
            TourGroup tourGroup = MatchTourGroup(adventurer);
            tourGroup.AddAdventurer(adventurer);
            Console.WriteLine($"【旅程】冒險者 {student.Account} 加入旅程 {Name} --> 匹配至旅團 {tourGroup.Number}");


            return adventurer;
        }

        private TourGroup MatchTourGroup(Adventurer adventurer)
        {
            // 匹配算法
            if (TourGroups.Count == 0)
            {
                // 沒有旅團，建立新旅團
                int number = TourGroups.Count + 1;
                TourGroup newTourGroup = new TourGroup(number, new List<Adventurer>());
                TourGroups.Add(newTourGroup);
                return newTourGroup;
            }

            // 隨機加入到其中一個旅團
            Random random = new Random();
            int index = random.Next(0, TourGroups.Count);
            TourGroup tourGroup = TourGroups[index];

            return tourGroup;

        }

        private Mission GetFirstMission()
        {
            return Chapters.First(c => c.Number == 1).Missions.First(m => m.Number == 1);
        }
    }
}
