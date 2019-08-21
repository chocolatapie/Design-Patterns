using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Banks
{
    class BankOfAmerica : IBank
    {
        public void ReplenishBalance()
        {
            Console.WriteLine("It is Bank of America! You are replenishing your balance!");
        }

        public void Withdraw()
        {
            Console.WriteLine("It is Bank of America! You are withdrawing your money!");
        }
    }
}
