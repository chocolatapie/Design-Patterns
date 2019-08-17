using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    class InsuranceAgent : IVisitor
    {
        public void DealWithHost(IHost inputHost)
        {
            (inputHost as IInsuranceBuyer).BuyInsurance();
        }
    }
}
