using System;

namespace DesignPatterns.Structural.Bridge.Banks
{
    class Agricole : IBank
    {
        public void ReplenishBalance()
        {
            Console.WriteLine("It is Agricole bank! You are replenishing your balance!");
        }

        public void Withdraw()
        {
            Console.WriteLine("It is Agricole bank! You are withdrawing your money!");
        }
    }
}
