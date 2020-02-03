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
