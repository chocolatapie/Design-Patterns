using System;
using DesignPatterns.Structural.Facade.Interfaces;

namespace DesignPatterns.Structural.Facade.Subsystems
{
    public class ATMHardvare : IATMHardvareDirector
    {
        public void GiveMoney()
        {
            Console.WriteLine("Take your money!");
        }
    }
}