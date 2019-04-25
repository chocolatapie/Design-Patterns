namespace DesignPatterns.Creational.AbstractFactory.Interfaces.ConcretePlaneInterfaces
{
    public interface IMilitaryPlane : IPlane
    {
        int GunCaliber { get; set; }
    }
}