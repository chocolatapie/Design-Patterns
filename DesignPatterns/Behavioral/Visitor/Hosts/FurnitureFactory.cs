using System;

namespace DesignPatterns.Behavioral.Visitor.Hosts
{
    class FurnitureFactory : IHost, IInsuranceBuyer
    {
        public void BuyInsurance()
        {
            Console.WriteLine("Ok, I will buy some - Furniture Factory says. ");
        }

        public void RecieveVisitor(IVisitor insuranceAgent)
        {
            insuranceAgent.DealWithHost(this);
        }
    }
}
