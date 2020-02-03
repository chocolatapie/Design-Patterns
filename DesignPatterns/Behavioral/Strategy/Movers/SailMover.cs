using System;

namespace DesignPatterns.Behavioral.Strategy.Movers
{
    public class SailMover : IMovingStrategy
    {
        public void MoveVessel(int inputSpeed)
        {
            inputSpeed = 20;
            Console.WriteLine("Now your vessel is moving 20 marine miles");
        }
    }
}
