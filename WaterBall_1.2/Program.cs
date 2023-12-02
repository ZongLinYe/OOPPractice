namespace WaterBall_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 註冊學生
            Student student = new Student(
                "小明",
                "password",
                new List<MissionCarryOn>(),
                new List<Adventurer>()
                );

            // 開設旅程
            Journey designPattern = new Journey(
                "軟體設計模式精通之旅",
                "學習設計模式",
                1000,
                new List<Chapter>()
                {
                    new Chapter(
                        1,
                        "物件導向不新手的新手村",
                        new List<Mission>(){ 
                            new Mission(
                                "OOA | 建出你的領域模型吧",
                                1,
                                new Challenge(1,"我做一次，你做一次！一起建出領域模型吧！") ,
                                new List<Scene>()
                                {
                                    new VideoScene(1,"我是影片一",100),
                                    new VideoScene(2,"我是影片二",100),
                                    new ContentScene(3,"我是文章一",100),
                                } ) ,
                        })
                },
                new List<Adventurer>(),
                new List<TourGroup>()
                );

            // 學員參與旅程
           var  adventurer= designPattern.Join(student);
            var  tourGroup = adventurer.TourGroup;
            var adventurers= tourGroup.Adventurers;

            // 查看學員目前正在執行的第一項任務
            var missionCarryOn = student.MissionCarryOns.First();

            Console.WriteLine($"學員 {student.Account} 正在執行任務 \"{missionCarryOn.GetMissionName()}\"");

            // 學員完成這項任務
            missionCarryOn.Complete();


        }
    }
}
