using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBall_1._2
{
    public class Student
    {
        //private string _account;
        //private string _password;
        //private int _level;
        //private int _experience;
        private List<MissionCarryOn> _missionCarryOns;
        private List<Adventurer> _adventurers;

        public Student(
            string account, 
            string password,
            List<MissionCarryOn> missionCarryOns,
            List<Adventurer> adventurers
            )
        {
            Level = 1;
            Experience = 0;
            Account = account;
            Password = password;
            MissionCarryOns = missionCarryOns;
            Adventurers = adventurers;
        }
        public List<MissionCarryOn> MissionCarryOns
        {
            get { return _missionCarryOns; }
            private set
            {
                _missionCarryOns = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public List<Adventurer> Adventurers
        {
            get { return _adventurers; }
            private set
            {
                _adventurers = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public string Account { get; private set; }
        private string Password { get; set; }
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public void GainExperience(int experience)
        {
            Experience += experience;
            int newLevel = LevelSheet.Query(Experience);
            int levelUp = newLevel - Level;
            Console.WriteLine($"【獎勵】學員 {Account} 獲得經驗值 {experience}");
            for (int i = 0; i < levelUp; i++)
            {
                LevelUp();
            }


        }
        public void LevelUp()
        {
            Level++;
            Console.WriteLine($"【升級】學員 {Account} 升級到 {Level} 級");
        }
        public MissionCarryOn CarryOn(Mission mission)
        {
            Console.WriteLine($"【任務】學員 {Account} 開始新任務：{mission.Name}");
            MissionCarryOn missionCarryOn = new MissionCarryOn(this, mission);
            MissionCarryOns.Add(missionCarryOn); // 單向關聯
            return missionCarryOn;
        }
    }
}
