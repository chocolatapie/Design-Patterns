namespace DesignPatterns.Creational.AbstractFactory.Interfaces.ConcretePlaneInterfaces
{
    public interface ICivilPlane : IPlane
    {
        int PassangersNumber { get; set; }
    }
}