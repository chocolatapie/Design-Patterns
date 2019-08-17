using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
