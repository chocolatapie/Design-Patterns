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
