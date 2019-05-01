using System;
using DesignPatterns.Creational.AbstractFactory.Interfaces.ConcretePlaneInterfaces;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class F16 : IMilitaryPlane
    {
        public string Type { get; set; }

        public void Fly(int distance)
        {
            throw new NotImplementedException();
        }

        public int GunCaliber { get; set; }
    }
}