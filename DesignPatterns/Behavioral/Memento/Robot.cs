namespace DesignPatterns.Behavioral.Memento
{
    public class Robot
    {
        private string _leftLegState;

        private string _rightLegState;

        public RobotsStatesManager RobotStateManager { get; set; }

        public Robot(string leftLeg, string rightLeg)
        {
            _leftLegState = leftLeg;
            _rightLegState = rightLeg;
            RobotStateManager = new RobotsStatesManager();
            RobotStateManager.Save(_leftLegState, _rightLegState);
        }

        public void Move(string left, string right)
        {
            _leftLegState = left;
            _rightLegState = right;
            RobotStateManager.Save(_leftLegState, _rightLegState);
        }
    }
}