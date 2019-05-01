using DesignPatterns.Creational.AbstractFactory.Interfaces;
using DesignPatterns.Creational.AbstractFactory.Interfaces.ConcretePlaneInterfaces;
using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    public class AirBusFactory : AbstractPlanesFactory
    {
        public override ICivilPlane CreateCivilPlane()
        {
            return new AirBus360();
        }

        public override IMilitaryPlane CreateMilitaryPlane()
        {
            return new F16();
        }
    }
}