using System.Collections.Generic;
using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory
{
    class AircraftCarrier
    {
        public AbstractPlanesFactory PlanesFactory { get; set; }

        public List<IPlane> CarriedPlanes { get; set; }

        public AircraftCarrier(AbstractPlanesFactory inputFactory)
        {
            this.PlanesFactory = inputFactory;
            this.CarriedPlanes = new List<IPlane>();
        }

        public void AddMilitaryPlane()
        {
            this.CarriedPlanes.Add(this.PlanesFactory.CreateMilitaryPlane());
        }

        public void AddCivilPlane()
        {
            this.CarriedPlanes.Add(this.PlanesFactory.CreateCivilPlane());
        }
    }
}
