namespace DesignPatterns.Behavioral.Mediator
{
    public interface IMediatorAirport
    {
        void Notify(object sender, string ev);

        void AddAirPortsPair(IUsualAirport firstAirPort, IUsualAirport secondAirPort);
    }
}
