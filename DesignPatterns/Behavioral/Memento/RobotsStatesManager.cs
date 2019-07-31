using System.Collections.Generic;
using System.Linq;

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
            RobotMemento memento = new RobotMemento(leftLeg, rightLeg);
            RobotMementos.Add(memento);
        }

        public RobotMemento GetPreviousState()
        {
            return RobotMementos.Last();
        }

        public List<RobotMemento> GetHistory()
        {
            return RobotMementos;
        }
    }
}