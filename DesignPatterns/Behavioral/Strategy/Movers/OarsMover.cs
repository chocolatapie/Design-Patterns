﻿using System;

namespace DesignPatterns.Behavioral.Strategy.Movers
{
    public class OarsMover : IMovingStrategy
    {
        public void MoveVessel(int inputSpeed)
        {
            inputSpeed = 15;
            Console.WriteLine("Now your vessel is moving 15 marine miles");
        }
    }
}
