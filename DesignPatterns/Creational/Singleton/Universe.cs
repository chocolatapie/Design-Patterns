using System;
using System.Threading;

namespace DesignPatterns.Creational.Singleton
{
    public class Universe
    {
        private bool IsHumanityExist;
        private static Universe _universe;
        private static object syncRoot = new Object();

        private Universe()
        { }

        public static Universe GetUniverse()
        {
            lock (syncRoot)
            {
                if (_universe == null)
                {
                    _universe = new Universe();
                }
            }
            return _universe;
        }

        public void WaitForHumanity()
        {
            if(IsHumanityExist)
            {
                Console.WriteLine("Humans already exist!");
            }
            if(!IsHumanityExist)
            {
                Thread.Sleep(3000);
                IsHumanityExist = true;
                Console.WriteLine("Adam and Eve were born!!!");
            }
        }
    }
}
