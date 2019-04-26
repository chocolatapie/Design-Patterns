using DesignPatterns.Structural.Adapter.Interfaces;

namespace DesignPatterns.Structural.Adapter
{
    class AmericanSocet
    {
        public void ConnectWithAmericanPlug(IAmericanPlug inputAmericanPlug)
        {
            inputAmericanPlug.ChargeFromAmericanSocet();
        }
    }
}
