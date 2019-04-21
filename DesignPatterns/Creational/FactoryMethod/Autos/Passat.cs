using System;

namespace DesignPatterns.Creational.FactoryMethod.Autos
{
    class Passat : IAutomobile
    {
        public int HorsePower { get; set; }
        public string Manufacturer { get; set; }
        public int СarMileage { get; set; }

        public Passat(int horsePow, string manufacturer)
        {
            this.СarMileage = 0;
            this.HorsePower = horsePow;
            this.Manufacturer = manufacturer;
        }

        public string GetInfoThisAuto()
        {
            string info = "This is a Passat vehicle, produced by " + this.Manufacturer + ", it has " +
                          this.HorsePower + " of horse power" + " , with " + СarMileage.ToString() + " mileage.";
            return info;
        }

        public void Ride(int miles)
        {
            this.СarMileage += miles;
        }
    }
}
