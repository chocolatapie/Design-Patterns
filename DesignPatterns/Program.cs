using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------Factory Method---------------------------
            FactoriesExecutor factoriesExecutor = new FactoriesExecutor();
            factoriesExecutor.ProduceCars();
            foreach(IAutomobile auto in factoriesExecutor.Automobiles)
            {
                Console.WriteLine(auto.GetInfoThisAuto());
            }
            Console.WriteLine();
            //------------------------------------------------------------

            //-------------------Singletone-------------------------------
            Universe uniwerse1 = Universe.GetUniverse();
            Universe uniwerse2 = Universe.GetUniverse();
            uniwerse1.WaitForHumanity();
            uniwerse2.WaitForHumanity();
            Console.WriteLine();
            //------------------------------------------------------------






            Console.ReadLine();
        }
    }
}
