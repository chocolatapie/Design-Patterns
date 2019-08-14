using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public interface IMediatorAirport
    {
        void Notify(object sender, string ev);

        void AddAirPortsPair(IUsualAirport firstAirPort, IUsualAirport secondAirPort);
    }
}
