using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
