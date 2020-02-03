using System;

namespace DesignPatterns.Behavioral.Strategy.Movers
{
    public class EngineMover : IMovingStrategy
    {
        public void MoveVessel(int inputSpeed)
        {
            inputSpeed = 40;
            Console.WriteLine("Now your vessel is moving 40 marine miles");
        }
    }
}
