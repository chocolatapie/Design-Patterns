using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    class Ship : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            if((publisher as LightBeacon).NumberOfShipsInQueue > 3)
            {
                Console.WriteLine("I`m setting into port!");
            }
            if ((publisher as LightBeacon).NumberOfShipsInQueue < 3)
            {
                Console.WriteLine("There is not enough ships to set to port!");
            }
        }
    }
}
