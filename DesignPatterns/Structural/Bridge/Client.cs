using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    class Client
    {
        public BankAccount BankAccount { get; set; }

        public void CreateAccountInBank(IBank bank)
        {
            BankAccount = new BankAccount(bank);
        }
    }
}
