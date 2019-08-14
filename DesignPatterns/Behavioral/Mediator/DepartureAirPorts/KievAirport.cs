using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.DepartureAirPorts
{
    public class KievAirport : IUsualAirport
    {
        private IMediatorAirport _hubAirport;

        public string Name { get; set; } = "Kiev";

        public void Arrival()
        {
            this._hubAirport.Notify(this, "Arrival");
        }

        public void Departure()
        {
            this._hubAirport.Notify(this, "Departure");
        }

        public void SetMediator(IMediatorAirport mediator)
        {
            this._hubAirport = mediator;
        }
    }
}
