using DesignPatterns.Creational.FactoryMethod.Manufacturers;
using System.Collections.Generic;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class FactoriesExecutor
    {
        private AbstractManufacturer _firstManufacturer;
        private AbstractManufacturer _secondManufacturer;

        public List<IAutomobile> Automobiles { get; set; }

        public FactoriesExecutor()
        {
            _firstManufacturer = new VWManufacturer();
            _secondManufacturer = new ToyotaManufacturer();
        }

        public void ProduceCars()
        {
            if (this.Automobiles == null)
                Automobiles = new List<IAutomobile>();
            Automobiles.Add(_firstManufacturer.CreateVehicle());
            Automobiles.Add(_secondManufacturer.CreateVehicle());
        }
    }
}
