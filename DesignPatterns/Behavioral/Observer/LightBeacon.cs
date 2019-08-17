using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    class LightBeacon : IPublisher
    {
        private List<ISubscriber> _subscribers;

        public int NumberOfShipsInQueue { get; set; }

        public LightBeacon()
        {
            _subscribers = new List<ISubscriber>();
        }

        public void Attach(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
            this.NumberOfShipsInQueue++;
            this.Notify();
        }

        public void Detach(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
            this.NumberOfShipsInQueue--;
            this.Notify();
        }

        public void Notify()
        {
            foreach (ISubscriber subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }
    }
}
