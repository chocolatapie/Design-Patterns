using DesignPatterns.Creational.FactoryMethod.Autos;

namespace DesignPatterns.Creational.FactoryMethod.Manufacturers
{
    class VWManufacturer : AbstractManufacturer
    {
        public override IAutomobile CreateVehicle()
        {
            Passat allNewPassat = new Passat(150, "VolksWagen");
            return allNewPassat;
        }
    }
}
