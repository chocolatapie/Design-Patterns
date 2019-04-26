using System;
using DesignPatterns.Structural.Facade.Interfaces;

namespace DesignPatterns.Structural.Facade.Subsystems
{
    public class BankMessageSender : IBankMessageSender
    {
        public void SendMessage()
        {
            Console.WriteLine("I will ask the bank, can I give you money.");
        }
    }
}