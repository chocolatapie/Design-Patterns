namespace DesignPatterns.Behavioral.Command.Commands
{
    class MoveForwardCommand : ICommand
    {
        public Soldier CurrentSoldier { get; set; }

        public MoveForwardCommand(Soldier inputSoldier)
        {
            this.CurrentSoldier = inputSoldier;
        }

        public void Execute()
        {
            this.CurrentSoldier.MoveForward();
        }
    }
}
