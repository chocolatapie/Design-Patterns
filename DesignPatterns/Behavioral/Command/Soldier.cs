using System;

namespace DesignPatterns.Behavioral.Command
{
    class Soldier
    {
        public void FireArms()
        {
            Console.WriteLine("Yes sir! I do fire from my gun!");
        }

        public void MoveForward()
        {
            Console.WriteLine("Yes sir! I`m advancing forward!");
        }
    }
}
