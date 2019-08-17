using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    interface IPublisher
    {
        void Attach(ISubscriber subscriber);

        void Detach(ISubscriber subscriber);

        void Notify();
    }
}
