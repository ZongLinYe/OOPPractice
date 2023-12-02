namespace WaterBall_1._2
{
    public class MissionCarryOn
    {
        public MissionCarryOn(Student student, Mission mission)
        {
            Student = student;
            Mission = mission;
        }
        public MissionStatus Status { get; private set; } = MissionStatus.OnGoing;
        public Student Student { get; private set; }
        public Mission Mission { get; private set; }
        public void Complete()
        {
            Status = MissionStatus.Completed;
            Console.WriteLine($"【任務】學員 {Student.Account} \"{Mission.Name}\" ");
            Student.GainExperience(Mission.CalculateExperienceAward());
        }
    }

    public enum MissionStatus
    {
        None= 0,
        OnGoing=1,
        Completed=2
    }
}