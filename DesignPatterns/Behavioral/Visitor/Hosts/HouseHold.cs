using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Hosts
{
    class HouseHold : IHost, IInsuranceBuyer
    {
        public void BuyInsurance()
        {
            Console.WriteLine("Ok, I need it - Household says. ");
        }

        public void RecieveVisitor(IVisitor insuranceAgent)
        {
            insuranceAgent.DealWithHost(this);
        }
    }
}
