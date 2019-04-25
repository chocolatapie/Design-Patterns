using System;
using System.Runtime.CompilerServices;
using DesignPatterns.Creational.AbstractFactory.Interfaces.ConcretePlaneInterfaces;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    class AirBus360 : ICivilPlane
    {
        public string Type { get; set; }

        public int PassangersNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Fly(int distance)
        {
            throw new NotImplementedException();
        }
    }
}
