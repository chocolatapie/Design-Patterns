using DesignPatterns.Creational.AbstractFactory.Interfaces.ConcretePlaneInterfaces;

namespace DesignPatterns.Creational.AbstractFactory.Interfaces
{
    public abstract class AbstractPlanesFactory
    {
        public abstract ICivilPlane CreateCivilPlane();
        public abstract IMilitaryPlane CreateMilitaryPlane();
    }
}
