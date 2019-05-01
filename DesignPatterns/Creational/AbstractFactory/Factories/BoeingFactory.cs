using DesignPatterns.Creational.AbstractFactory.Interfaces;
using DesignPatterns.Creational.AbstractFactory.Interfaces.ConcretePlaneInterfaces;
using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    class BoeingFactory : AbstractPlanesFactory
    {
        public override ICivilPlane CreateCivilPlane()
        {
            return new Boeing747();
        }

        public override IMilitaryPlane CreateMilitaryPlane()
        {
            return new B52();
        }
    }
}
