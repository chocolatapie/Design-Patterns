namespace DesignPatterns.Behavioral.Mediator.ArrivalAirPorts
{
    public class RejkjavikAirport : IUsualAirport
    {
        private IMediatorAirport _hubAirport;

        public string Name { get; set; } = "Rejkjavik";

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