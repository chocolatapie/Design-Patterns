using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Memento
{
    public class RobotsStatesManager
    {
        private  List<RobotMemento> RobotMementos { get; set; }

        public RobotsStatesManager()
        {
            RobotMementos = new List<RobotMemento>();
        }

        public void Save(string leftLeg, string rightLeg)
        {

        }

        public RobotMemento GetPreviousState()
        {
            return null;
        }

        public List<RobotMemento> GetHistory()
        {
            return null;
        }
    }
}