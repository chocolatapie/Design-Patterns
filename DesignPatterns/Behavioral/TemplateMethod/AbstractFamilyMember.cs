using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    abstract class AbstractFamilyMember
    {
        public void PerformDailyActivities()
        {
            this.Wakeup();
            this.BathProcedures();
            this.Breakfast();
            this.Hook1();
            this.MainDailyActivity();
            this.Diner();
            this.Hook2();
        }
    
        protected void Wakeup()
        {
            Console.WriteLine("Hello, new day!");
        }

        protected void Breakfast()
        {
            Console.WriteLine("I`m having the most important meal in day");
        }

        protected void Diner()
        {
            Console.WriteLine("I`m having diner!");
        }

        protected abstract void BathProcedures();

        protected abstract void MainDailyActivity();

        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}
