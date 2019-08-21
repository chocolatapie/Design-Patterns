using DesignPatterns.Behavioral.Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    class Officer
    {
        public Soldier CurrentSoldier { get; set; }

        public ICommand MoveCommand { get; set; }

        public ICommand FireCommand { get; set; }

        public void InitializeCurrentSoldier(Soldier inputSoldier)
        {
            this.CurrentSoldier = inputSoldier;
        }

        public void OrderMoveForward()
        {
            this.MoveCommand = new MoveForwardCommand(this.CurrentSoldier);
            this.MoveCommand.Execute();
        }

        public void OrederFire()
        {
            this.FireCommand = new FireArmsCommand(this.CurrentSoldier);
            this.FireCommand.Execute();
        }
    }
}
