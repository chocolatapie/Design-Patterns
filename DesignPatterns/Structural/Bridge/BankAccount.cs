using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    class BankAccount
    {
        IBank _thisBank;

        public BankAccount(IBank inputBank)
        {
            this._thisBank = inputBank;
        }

        public void Replenish()
        {
            _thisBank.ReplenishBalance();
        }

        public void Withdraw()
        {
            _thisBank.Withdraw();
        }
    }
}
