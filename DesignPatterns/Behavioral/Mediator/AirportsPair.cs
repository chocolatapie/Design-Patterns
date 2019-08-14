using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class AirportsPair
    {
        public IUsualAirport FirstAirPort { get; set; }

        public IUsualAirport SecondAirPort { get; set; }

        public AirportsPair(IUsualAirport inputFirstAirport, IUsualAirport inputSecondAirport)
        {
            this.FirstAirPort = inputFirstAirport;
            this.SecondAirPort = inputSecondAirport;
        }
    }
}
