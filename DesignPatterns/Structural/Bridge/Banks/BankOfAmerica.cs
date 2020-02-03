using System;

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
