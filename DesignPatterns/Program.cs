using DesignPatterns.Creational.FactoryMethod;
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
            //------------------------------------------------------------








            Console.ReadLine();
        }
    }
}
