namespace DesignPatterns.Behavioral.Observer
{
    interface IPublisher
    {
        void Attach(ISubscriber subscriber);

        void Detach(ISubscriber subscriber);

        void Notify();
    }
}
