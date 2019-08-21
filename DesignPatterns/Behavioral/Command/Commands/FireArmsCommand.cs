using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Commands
{
    class FireArmsCommand : ICommand
    {
        public Soldier CurrentSoldier { get; set; }

        public FireArmsCommand(Soldier inputSoldier)
        {
            CurrentSoldier = inputSoldier;
        }

        public void Execute()
        {
            this.CurrentSoldier.FireArms();
        }
    }
}
