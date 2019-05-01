using System;
using DesignPatterns.Creational.AbstractFactory.Interfaces.ConcretePlaneInterfaces;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    class Boeing747 : ICivilPlane
    {
        public string Type { get; set; }

        public void Fly(int distance)
        {
            throw new NotImplementedException();
        }

        public int PassangersNumber { get; set; }
    }
}
