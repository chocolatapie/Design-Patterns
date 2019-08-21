﻿using DesignPatterns.Behavioral.ChainResponsibility;
using DesignPatterns.Behavioral.ChainResponsibility.MedPersonel;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Command.Commands;
using DesignPatterns.Behavioral.Iterator.Collection;
using DesignPatterns.Behavioral.Iterator.Iterators;
using DesignPatterns.Behavioral.Mediator.ArrivalAirPorts;
using DesignPatterns.Behavioral.Mediator.DepartureAirPorts;
using DesignPatterns.Behavioral.Mediator.HubAirPorts;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.State.StudentsStates;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Behavioral.Visitor.Hosts;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.Interfaces;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Prototype.Models;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Adapter.Plugs;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Bridge.Banks;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Composite.Models;
using DesignPatterns.Structural.Decorator.ConcreteTypes;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Facade.Interfaces;
using DesignPatterns.Structural.Facade.Subsystems;
using DesignPatterns.Structural.Proxy.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational

            #region Factory Method
            //-------------------Factory Method---------------------------

            //Console.WriteLine("---Factory Method---");
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

            //Console.WriteLine("---Singleton---");
            //Universe uniwerse1 = Universe.GetUniverse();
            //Universe uniwerse2 = Universe.GetUniverse();
            //uniwerse1.WaitForHumanity();
            //uniwerse2.WaitForHumanity();
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Builder
            //-------------------Builder----------------------------------

            //Console.WriteLine("---Builder---");
            //Pizzeria pizzeria = new Pizzeria();
            //Pizza margarita = pizzeria.MakePizza("Margarita");
            //Console.WriteLine("This is " + margarita.Name + " pizza.");
            //Console.WriteLine("It has " + margarita.Price + " UAH price.");
            //Console.WriteLine("It weights " + margarita.Weight + " gramms.");
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Prototype
            //-------------------Prototype--------------------------------

            //Console.WriteLine("---Prototype---");
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
            //    if (legio == legion)
            //    {
            //        Console.WriteLine("We are the original {0} legion! AveCeasar!", legio.LegionName);
            //    }
            //    else
            //    {
            //        Console.WriteLine("We are the clones!! Ave ceasar!");
            //    }
            //}
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Abstract Factory
            //-------------------Abstract Factory-------------------------

            //Console.WriteLine("---Abstract Factory---");
            //AirBusFactory factory1 = new AirBusFactory();
            //BoeingFactory factory2 = new BoeingFactory();
            //AircraftCarrier aircraft1 = new AircraftCarrier(factory1);
            //AircraftCarrier aircraft2 = new AircraftCarrier(factory2);
            //aircraft1.AddMilitaryPlane();
            //aircraft1.AddMilitaryPlane();
            //aircraft1.AddMilitaryPlane();
            //aircraft2.AddCivilPlane();
            //aircraft2.AddCivilPlane();
            //aircraft2.AddCivilPlane();
            //Console.WriteLine("FirstCarrier has: ");
            //foreach (IPlane plane in aircraft1.CarriedPlanes)
            //{
            //    Console.WriteLine(plane.GetType().Name);
            //}
            //Console.WriteLine("SecondCarrier has: ");
            //foreach (IPlane plane in aircraft2.CarriedPlanes)
            //{
            //    Console.WriteLine(plane.GetType().Name);
            //}
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #endregion

            #region Structural

            #region Adapter
            //-------------------Adapter----------------------------------

            //Console.WriteLine("---Adapter---");
            //AmericanSocet americanSocet = new AmericanSocet();
            //EuroChargingPlug euroPlug = new EuroChargingPlug();
            //EuroToAmericanSocetAdapter plugAdapter = new EuroToAmericanSocetAdapter(euroPlug);
            //americanSocet.ConnectWithAmericanPlug(plugAdapter);
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Bridge
            //-------------------Bridge-----------------------------------
            //Console.WriteLine("---Bridge---");
            //Client client = new Client();
            //OTP otpBank = new OTP();
            //client.CreateAccountInBank(otpBank);

            //client.BankAccount.Replenish();
            //client.BankAccount.Withdraw();

            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Composite
            //-------------------Composite--------------------------------

            //Console.WriteLine("---Composite---");

            //Box MainBox = new Box();
            //Box InnerBox = new Box();
            //Box InnerInnerBox = new Box();

            //Product product1 = new Product("firstP", 100);
            //Product product2 = new Product("secondP", 120);
            //Product product3 = new Product("thirdP", 120);
            //MainBox.AddProduct(product1);
            //MainBox.AddProduct(product2);
            //MainBox.AddProduct(product3);
            //MainBox.AddBox(InnerBox);

            //Product product11 = new Product("firstP1", 100);
            //Product product21 = new Product("secondP1", 120);
            //Product product31 = new Product("thirdP1", 120);
            //InnerBox.AddProduct(product11);
            //InnerBox.AddProduct(product21);
            //InnerBox.AddProduct(product31);
            //InnerBox.AddBox(InnerInnerBox);

            //Product product111 = new Product("firstP11", 100);
            //Product product211 = new Product("secondP11", 120);
            //Product product311 = new Product("thirdP11", 120);
            //InnerInnerBox.AddProduct(product111);
            //InnerInnerBox.AddProduct(product211);
            //InnerInnerBox.AddProduct(product311);

            //Order order = new Order(MainBox);
            //Console.WriteLine("The total Price of your order is : ");
            //Console.WriteLine(order.OrderPrice + " dollars");
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Decorator
            //-------------------Decorator--------------------------------

            //Console.WriteLine("---Decorator---");

            //Console.WriteLine("I`m JohnSnow and i have following armor: ");
            //ConcreteCharacter JohnSnow = new ConcreteCharacter(20);
            //Console.WriteLine(JohnSnow.CharacterBasicArmor);
            //HeavyArmoredCharacter JonSnowArmored = new HeavyArmoredCharacter(JohnSnow);
            //Console.WriteLine("Now I have a shield and my total armor is: ");
            //Console.WriteLine(JonSnowArmored.GetProtectionFromArmor());
            //Console.WriteLine("God damn it, i was poisoned!");
            //PoisonedCharacter JohnArmoredAndPoisoned = new PoisonedCharacter(JonSnowArmored);
            //Console.WriteLine("Current armor is: " + JohnArmoredAndPoisoned.GetProtectionFromArmor());
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Facade
            //-------------------Facade-----------------------------------

            //Console.WriteLine("---Facade---");

            //IATMHardvareDirector hardvareDir = new ATMHardvare();
            //IBankMessageReciever reciever = new BankMessgeReciever();
            //IBankMessageSender sender = new BankMessageSender();
            //ATM atm = new ATM(hardvareDir, reciever, sender);
            //atm.GiveClientMoney();
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Flyweight
            //-------------------Flyweight--------------------------------


            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Proxy
            //-------------------Proxy------------------------------------

            //Console.WriteLine("---Proxy---");

            //TimeConsumingStorageService consumingService = new TimeConsumingStorageService();
            //ProxyService proxyService = new ProxyService(consumingService);
            //Console.WriteLine("Recieving object first time:");
            //Console.WriteLine(proxyService.ReturnAnObjectOnRequest("A").ObjName);
            //Console.WriteLine("Recieving second time: ");
            //Console.WriteLine(proxyService.ReturnAnObjectOnRequest("A").ObjName);
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #endregion

            #region Behavioral

            #region ChainResponsibility
            //-------------------ChainResponsibility----------------------

            //Console.WriteLine("---Chain of responsibility---");

            //Patient MikeWithBrokenLeg = new Patient("Mike", "broken leg bone");
            //Patient BobWithDaltonism = new Patient("Bob", "Daltonism");

            //OrthopedicTraumatologist ortoped = new OrthopedicTraumatologist(null);
            //Traumatologist traumatolog = new Traumatologist(ortoped);
            //Therapist therapist = new Therapist(traumatolog);
            //Nurse nurse = new Nurse(therapist);

            //nurse.TryToCure(MikeWithBrokenLeg.Disease);
            //nurse.TryToCure(BobWithDaltonism.Disease);

            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Command
            //-------------------Command---------------------------------

            //Console.WriteLine("---Command---");
            //Soldier soldier = new Soldier();
            //Officer officer = new Officer();
            //officer.InitializeCurrentSoldier(soldier);
            //officer.OrderMoveForward();
            //officer.OrederFire();

            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Iterator
            //-------------------Iterator---------------------------------

            //Console.WriteLine("---Iterator---");

            //Console.WriteLine("Binary tree with custom iterator: ");
            //CustomBinaryTree tree = new CustomBinaryTree();
            //tree.AddValue(5);
            //tree.AddValue(-7);
            //tree.AddValue(8);
            //tree.AddValue(-3);
            //tree.AddValue(-6);
            //tree.AddValue(45);
            //tree.AddValue(22);
            //InOrderIterator iterator = new InOrderIterator(tree.RootNode);
            //tree.ChangeIterator(iterator);
            //Console.WriteLine("InOrder Iterator");
            //foreach (TreeNode node in tree)
            //{
            //    Console.WriteLine(node.NodeValue);
            //}
            //Console.WriteLine("PreOrder iterator");
            //PreOrderIterator iterator2 = new PreOrderIterator(tree.RootNode);
            //tree.ChangeIterator(iterator2);
            //Console.WriteLine("InOrder Iterator");
            //foreach (TreeNode node in tree)
            //{
            //    Console.WriteLine(node.NodeValue);
            //}
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Mediator
            //-------------------Mediator---------------------------------

            //Console.WriteLine("---Mediator---");

            //NYCAirport nYCAirport = new NYCAirport();
            //KievAirport kievAirport = new KievAirport();

            //RejkjavikAirport rejkjavikAirport = new RejkjavikAirport();
            //StPetersburgAirport stPetersburgAirport = new StPetersburgAirport();

            //FranckfurtAirport francfurtAirport = new FranckfurtAirport();
            //francfurtAirport.AddAirPortsPair(kievAirport, nYCAirport);
            //francfurtAirport.AddAirPortsPair(stPetersburgAirport, rejkjavikAirport);

            //kievAirport.Departure();
            //rejkjavikAirport.Arrival();
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Memento
            //-------------------Memento---------------------------------

            //Console.WriteLine("---Memento---");

            //Robot robot = new Robot("stay", "stay");
            //robot.Move("forward", "stay");
            //robot.Move("stay", "forward");
            //robot.Move("forward", "stay");
            //robot.Move("stay", "forward");
            //robot.Move("forward", "stay");
            //robot.Move("stay", "forward");
            //robot.Move("forward", "stay");
            //robot.Move("stay", "forward");

            //List<RobotMemento> robotStates = robot.RobotStateManager.GetHistory();
            //for (int i = 0; i < robotStates.Count; i++)
            //{
            //    Console.WriteLine((string)("Step: " + i + " :: " +
            //                                " 1) left leg: " + robotStates[i].GetState().First() +
            //                                " 2) right leg: " + robotStates[i].GetState().First()));
            //}
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Observer
            //-------------------Observer---------------------------------

            //Console.WriteLine("---Observer---");

            //LightBeacon lightBeacon = new LightBeacon();
            //Ship ship1 = new Ship();
            //Ship ship2 = new Ship();
            //Ship ship3 = new Ship();
            //Ship ship4 = new Ship();

            //lightBeacon.Attach(ship1);
            //lightBeacon.Attach(ship2);
            //lightBeacon.Attach(ship3);
            //lightBeacon.Attach(ship4);

            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region State
            //-------------------State------------------------------------

            //Console.WriteLine("---State---");

            //Student student = new Student();
            //student.SetUpInitialState(new RegularStudent(student));

            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Strategy
            //-------------------Strategy---------------------------------

            //Console.WriteLine("---Strategy---");

            //Vessel yacht = new Vessel("Sails");
            //yacht.ChangeContext("Oars");
            //yacht.ChangeContext("Engine");

            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region TemplateMethod
            //-------------------TemplateMethod---------------------------

            //Console.WriteLine("---TemplateMethod---");
            //Dad dad = new Dad();
            //Son son = new Son();

            //son.PerformDailyActivities();
            //Console.WriteLine();
            //dad.PerformDailyActivities();

            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Visitor
            //-------------------Visitor----------------------------------

            //Console.WriteLine("---Visitor---");

            //List<IHost> hosters = new List<IHost>();

            //FurnitureFactory ffuctory = new FurnitureFactory();
            //GroseryStore gStore = new GroseryStore();
            //HouseHold hHodl = new HouseHold();
            //InsuranceAgent iAgent = new InsuranceAgent();
            //hosters.Add(ffuctory);
            //hosters.Add(gStore);
            //hosters.Add(hHodl);

            //foreach (IHost hoster in hosters)
            //{
            //    hoster.RecieveVisitor(iAgent);
            //}

            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
