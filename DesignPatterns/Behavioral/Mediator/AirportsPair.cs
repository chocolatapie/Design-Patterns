namespace DesignPatterns.Behavioral.Mediator
{
    public class AirportsPair
    {
        public IUsualAirport FirstAirPort { get; set; }

        public IUsualAirport SecondAirPort { get; set; }

        public AirportsPair(IUsualAirport inputFirstAirport, IUsualAirport inputSecondAirport)
        {
            this.FirstAirPort = inputFirstAirport;
            this.SecondAirPort = inputSecondAirport;
        }
    }
}
