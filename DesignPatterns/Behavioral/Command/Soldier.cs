using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    class Soldier
    {
        public void FireArms()
        {
            Console.WriteLine("Yes sir! I`m fireing from my gun!");
        }

        public void MoveForward()
        {
            Console.WriteLine("Yes sir! I`m advancing forward!");
        }
    }
}
