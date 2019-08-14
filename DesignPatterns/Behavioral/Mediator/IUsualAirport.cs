using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public interface IUsualAirport
    {
        string Name { get; set; }

        void SetMediator(IMediatorAirport mediator);

        void Departure();

        void Arrival();
    }
}
