namespace WaterBall_1._2
{
    public class Mission
    {
        private string _name;
        private int _number;
        private Challenge _challenge;
        private List<Scene> _scenes;
        public Mission(string name, int number, Challenge challenge, List<Scene> scenes)
        {
            Name = name;
            Number = number;
            Challenge = challenge;
            Scene = scenes;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value.LimitLength(1, 30); }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value.ShouldBePositive(); }

        }
        public int CalculateExperienceAward()
        {

            //throw new NotImplementedException();
            // TODO: Implement this method 底下所有 Scene 的經驗值加總
            return Scene.Sum(x => x.CalculateExperienceAward()); // 多形 Wow! C# is so cool!

        }
        public Challenge Challenge
        {
            get { return _challenge; }
            private set
            {
                _challenge = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public List<Scene> Scene
        {
            get { return _scenes; }
            private set
            {
                _scenes = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
    }
}