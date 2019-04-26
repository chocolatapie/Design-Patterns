using System;
using DesignPatterns.Structural.Facade.Interfaces;

namespace DesignPatterns.Structural.Facade.Subsystems
{
    public class BankMessgeReciever : IBankMessageReciever
    {
        public void RecieveMessege()
        {
            Console.WriteLine("Yes, I can give you some cash!");
        }
    }
}