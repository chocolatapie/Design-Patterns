namespace DesignPatterns.Behavioral.Mediator.DepartureAirPorts
{
    public class StPetersburgAirport : IUsualAirport
    {
        private IMediatorAirport _hubAirport;

        public string Name { get; set; } = "StPetersburg";

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
