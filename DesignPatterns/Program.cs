using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Prototype.Models;
using DesignPatterns.Creational.Singleton;
using System;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational

            #region Factory Method
            //-------------------Factory Method---------------------------
            //FactoriesExecutor factoriesExecutor = new FactoriesExecutor();
            //factoriesExecutor.ProduceCars();
            //foreach (IAutomobile auto in factoriesExecutor.Automobiles)
            //{
            //    Console.WriteLine(auto.GetInfoThisAuto());
            //}
            //Console.WriteLine();
            //------------------------------------------------------------
            #endregion

            #region Singleton
            //-------------------Singleton--------------------------------
            //Universe uniwerse1 = Universe.GetUniverse();
            //Universe uniwerse2 = Universe.GetUniverse();
            //uniwerse1.WaitForHumanity();
            //uniwerse2.WaitForHumanity();
            //Console.WriteLine();
            //------------------------------------------------------------
            #endregion

            #region Builder
            //-------------------Builder----------------------------------
            //Pizzeria pizzeria = new Pizzeria();
            //Pizza margarita = pizzeria.MakePizza("Margarita");
            //Console.WriteLine("This is "+margarita.Name + " pizza.");
            //Console.WriteLine("It has " + margarita.Price + " UAH price.");
            //Console.WriteLine("It weights " + margarita.Weight + " gramms.");
            //Console.WriteLine();
            //------------------------------------------------------------
            #endregion

            #region Prototype
            //-------------------Prototype--------------------------------
            //RomanArmy romanArmy = new RomanArmy();
            //Legion legion = new Legion();
            //legion.LegionName = "Legio Italica";
            //Cohort cohort = new Cohort();
            //cohort.CohortName = "First Cohort";
            //Legionare firstLegionarie = new Legionare();
            //firstLegionarie.Name = "Pulo";
            //firstLegionarie.Rank = "Centurion";
            //Legionare secondLegionarie = new Legionare();
            //secondLegionarie.Name = "Titus";
            //secondLegionarie.Rank = "Decan";
            //cohort.Legionaries.Add(firstLegionarie);
            //cohort.Legionaries.Add(secondLegionarie);
            //legion.LegionsCohorts.Add(cohort);
            //romanArmy.RomanLegions.Add(legion);
            //romanArmy.RomanLegions.Add((Legion)legion.GetClone());
            //romanArmy.RomanLegions.Add((Legion)legion.GetClone());
            //romanArmy.RomanLegions.Add((Legion)legion.GetClone());
            //foreach (var legio in romanArmy.RomanLegions)
            //{
            //    if(legio == legion)
            //    {
            //        Console.WriteLine("We are the original {0} legion! AveCeasar!",legio.LegionName);
            //    }
            //    else
            //    {
            //        Console.WriteLine("We are the clones!! Ave ceasar!");
            //    }
            //}
            //------------------------------------------------------------
            #endregion

            # region Abstract Factory
            //-------------------Abstract Factory-------------------------
            AirBusFactory factory1 = new AirBusFactory();
            BoeingFactory factory2 = new BoeingFactory();
            AircraftCarrier aircraft1 = new AircraftCarrier(factory1);
            AircraftCarrier aircraft2 = new AircraftCarrier(factory2);
            aircraft1.AddMilitaryPlane();
            aircraft1.AddMilitaryPlane();
            aircraft1.AddMilitaryPlane();
            aircraft2.AddCivilPlane();
            aircraft2.AddCivilPlane();
            aircraft2.AddCivilPlane();
            Console.WriteLine("FirstCarrier has: ");
            foreach (IPlane plane in aircraft1.CarriedPlanes)
            {
                Console.WriteLine(plane.GetType().Name);
            }
            Console.WriteLine("SecondCarrier has: ");
            foreach (IPlane plane in aircraft2.CarriedPlanes)
            {
                Console.WriteLine(plane.GetType().Name);
            }
            //------------------------------------------------------------
            #endregion
            #endregion

            Console.ReadLine();
        }
    }
}
