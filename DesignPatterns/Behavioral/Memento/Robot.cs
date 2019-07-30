namespace DesignPatterns.Behavioral.Memento
{
    public class Robot
    {
        public string LeftLegState { get; set; }

        public string RightLegState { get; set; }

        public RobotsStatesManager RobotStateManager { get; set; }

        public Robot(string leftLeg, string rightLeg)
        {
            this.LeftLegState = leftLeg;
            this.RightLegState = rightLeg;
            RobotStateManager = new RobotsStatesManager();
        }


    }
}