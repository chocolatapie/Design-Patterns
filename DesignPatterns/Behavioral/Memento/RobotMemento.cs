using System.Collections.Generic;

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

        public List<string> GetState()
        {
            List<string> states = new List<string>();
            states.Add(LeftLegState);
            states.Add(RightLegState);

            return states;
        }
    }
}