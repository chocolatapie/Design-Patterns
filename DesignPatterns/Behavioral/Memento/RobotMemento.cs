namespace DesignPatterns.Behavioral.Memento
{
    public class RobotMemento
    {
        private string LeftLegState;

        private string RightLegState;

        public RobotMemento(string leftLeg, string rightLeg)
        {
            this.LeftLegState = leftLeg;
            this.RightLegState = rightLeg;
        }
    }
}