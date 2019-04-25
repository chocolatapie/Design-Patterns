using DesignPatterns.Creational.AbstractFactory.Interfaces.ConcretePlaneInterfaces;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class B52 : IMilitaryPlane
    {
        public string Type { get; set; }

        public void Fly(int distance)
        {
            throw new System.NotImplementedException();
        }

        public int GunCaliber { get; set; }
    }
}