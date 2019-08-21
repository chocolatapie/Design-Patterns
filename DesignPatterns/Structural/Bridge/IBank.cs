using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    interface IBank
    {
        void ReplenishBalance();

        void Withdraw();
    }
}
