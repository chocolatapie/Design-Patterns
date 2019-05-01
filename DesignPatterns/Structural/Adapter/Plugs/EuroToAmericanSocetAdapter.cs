using DesignPatterns.Structural.Adapter.Interfaces;

namespace DesignPatterns.Structural.Adapter.Plugs
{
    public class EuroToAmericanSocetAdapter : IAmericanPlug
    {
        public IEuroPlug EuroPlug { get; set; }

        public EuroToAmericanSocetAdapter(IEuroPlug inputEuroPlug)
        {
            this.EuroPlug = inputEuroPlug;
        }

        public void ChargeFromAmericanSocet()
        {
            EuroPlug.ChargeFromEuroSocet();
        }
    }
}