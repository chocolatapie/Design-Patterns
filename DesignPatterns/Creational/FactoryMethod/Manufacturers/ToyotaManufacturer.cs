using DesignPatterns.Creational.FactoryMethod.Autos;

namespace DesignPatterns.Creational.FactoryMethod.Manufacturers
{
    class ToyotaManufacturer : AbstractManufacturer
    {
        public override IAutomobile CreateVehicle()
        {
            Camry allNewCamry = new Camry(140, "Toyota");
            return allNewCamry;
        }
    }
}
