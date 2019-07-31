using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Behavioral.Memento;

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
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Abstract Factory
            //-------------------Abstract Factory-------------------------

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

            //AmericanSocet americanSocet = new AmericanSocet();
            //EuroChargingPlug euroPlug = new EuroChargingPlug();
            //EuroToAmericanSocetAdapter plugAdapter = new EuroToAmericanSocetAdapter(euroPlug);
            //americanSocet.ConnectWithAmericanPlug(plugAdapter);
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Bridge
            //-------------------Bridge-----------------------------------


            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Composite
            //-------------------Composite--------------------------------

            //Box MainBox = new Box();
            //Box InnerBox = new Box();
            //Box InnerInnerBox = new Box();

            //Product product1 = new Product("firstP",100);
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
            //Patient MikeWithBrokenLeg = new Patient("Mike","broken leg bone");
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


            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Iterator
            //-------------------Iterator---------------------------------

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


            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Memento
            //-------------------Memento---------------------------------

            //Robot robot = new Robot("stay","stay");
            //robot.Move("forward","stay");
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
            //    Console.WriteLine((string) ("Step: "+ i + " :: " + 
            //                                " 1) left leg: " + robotStates[i].GetState().First() +
            //                                " 2) right leg: " + robotStates[i].GetState().First()));
            //}
            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Observer
            //-------------------Observer---------------------------------


            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region State
            //-------------------State------------------------------------


            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Strategy
            //-------------------Strategy---------------------------------


            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region TemplateMethod
            //-------------------TemplateMethod---------------------------


            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #region Visitor
            //-------------------Visitor----------------------------------


            //Console.WriteLine();

            //------------------------------------------------------------
            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
