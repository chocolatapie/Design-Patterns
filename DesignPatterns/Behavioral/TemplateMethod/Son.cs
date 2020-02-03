using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    class Son : AbstractFamilyMember
    {
        protected override void BathProcedures()
        {
            Console.WriteLine("I `m having my teeth brushing with child toothpast");
        }

        protected override void MainDailyActivity()
        {
            Console.WriteLine("I`m listening algebra classes at my school");
        }

        protected override void Hook2()
        {
            Console.WriteLine("I was allowed to play some pc - games!");
        }
    }
}
