using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    interface ICommand
    {
        Soldier CurrentSoldier { get; set; }

        void Execute();
    }
}
