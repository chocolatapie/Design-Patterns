using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    class Dad : AbstractFamilyMember
    {
        protected override void BathProcedures()
        {
            Console.WriteLine("I`m having shaving myself!");
        }

        protected override void Hook1()
        {
            Console.WriteLine("Before driving to work, I have to deliver my son to school!");
        }

        protected override void MainDailyActivity()
        {
            Console.WriteLine("All these guys in office are not able to work, without me!");
        }
    }
}