namespace DesignPatterns.Behavioral.Command
{
    interface ICommand
    {
        Soldier CurrentSoldier { get; set; }

        void Execute();
    }
}
