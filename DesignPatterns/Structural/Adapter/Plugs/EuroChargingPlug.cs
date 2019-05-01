using System;
using DesignPatterns.Structural.Adapter.Interfaces;

namespace DesignPatterns.Structural.Adapter.Plugs
{
    public class EuroChargingPlug : IEuroPlug
    {
        public void ChargeFromEuroSocet()
        {
            Console.WriteLine("I`m Euro plug and i`m charging!");
        }
    }
}