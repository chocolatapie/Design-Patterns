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
