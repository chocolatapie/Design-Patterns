using System;

namespace DesignPatterns.Behavioral.Visitor.Hosts
{
    class GroseryStore : IHost, IInsuranceBuyer
    {
        public void BuyInsurance()
        {
            Console.WriteLine("Oh, no tnx, there is no need for it , now - Grosery says. ");
        }

        public void RecieveVisitor(IVisitor insuranceAgent)
        {
            insuranceAgent.DealWithHost(this);
        }
    }
}
