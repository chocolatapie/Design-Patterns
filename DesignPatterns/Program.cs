using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational
            //-------------------Factory Method---------------------------
            //FactoriesExecutor factoriesExecutor = new FactoriesExecutor();
            //factoriesExecutor.ProduceCars();
            //foreach (IAutomobile auto in factoriesExecutor.Automobiles)
            //{
            //    Console.WriteLine(auto.GetInfoThisAuto());
            //}
            //Console.WriteLine();
            //------------------------------------------------------------

            //-------------------Singleton--------------------------------
            //Universe uniwerse1 = Universe.GetUniverse();
            //Universe uniwerse2 = Universe.GetUniverse();
            //uniwerse1.WaitForHumanity();
            //uniwerse2.WaitForHumanity();
            //Console.WriteLine();
            //------------------------------------------------------------

            //-------------------Builder----------------------------------
            //Pizzeria pizzeria = new Pizzeria();
            //Pizza margarita = pizzeria.MakePizza("Margarita");
            //Console.WriteLine("This is "+margarita.Name + " pizza.");
            //Console.WriteLine("It has " + margarita.Price + " UAH price.");
            //Console.WriteLine("It weights " + margarita.Weight + " gramms.");
            //Console.WriteLine();
            //------------------------------------------------------------

            //-------------------Prototype--------------------------------

            //------------------------------------------------------------

            //-------------------Abstract Factory-------------------------

            //------------------------------------------------------------
            #endregion

            Console.ReadLine();
        }
    }
}
