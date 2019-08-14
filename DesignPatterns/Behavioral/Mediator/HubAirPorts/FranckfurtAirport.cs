using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.HubAirPorts
{
    public class FranckfurtAirport : IMediatorAirport
    {
        public List<AirportsPair> PairsOfAirports { get; set; }

        public FranckfurtAirport()
        {
            PairsOfAirports = new List<AirportsPair>();
        }

        public void AddAirPortsPair(IUsualAirport firstAirPort, IUsualAirport secondAirPort)
        {
            AirportsPair pair = new AirportsPair(firstAirPort, secondAirPort);
            firstAirPort.SetMediator(this);
            secondAirPort.SetMediator(this);

            PairsOfAirports.Add(pair);
        }

        public void Notify(object sender, string ev)
        {
            AirportsPair currentPair = null;

            foreach (var airportsPair in this.PairsOfAirports)
            {
                if(airportsPair.FirstAirPort == sender || airportsPair.SecondAirPort == sender)
                {
                    currentPair = airportsPair;
                }
            }

            if (currentPair == null)
                return;

            if(ev == "Arrival")
            {
                Console.WriteLine((sender as IUsualAirport).Name + " :");
                Console.WriteLine("Plane is arriving.");
                
                IUsualAirport secondAirport = GetPairedAirport(sender as IUsualAirport, currentPair);
                Console.WriteLine(secondAirport.Name + " :");
                Console.WriteLine("Plane is departureing.");

                Console.WriteLine();
                return;
            }
            if (ev == "Departure")
            {
                Console.WriteLine((sender as IUsualAirport).Name + " :");
                Console.WriteLine("Plane is departureing.");

                IUsualAirport secondAirport = GetPairedAirport(sender as IUsualAirport, currentPair);
                Console.WriteLine(secondAirport.Name + " :");
                Console.WriteLine("Plane is arriving.");

                Console.WriteLine();
            }
        }

        private IUsualAirport GetPairedAirport(IUsualAirport inputA, AirportsPair inputP)
        {
            if (inputA == inputP.FirstAirPort)
                return inputP.SecondAirPort;

            return inputP.FirstAirPort;
        }
    }
}
