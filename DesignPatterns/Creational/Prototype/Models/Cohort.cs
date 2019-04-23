using System.Collections.Generic;
using DesignPatterns.Creational.Prototype.Interface;

namespace DesignPatterns.Creational.Prototype.Models
{
    class Cohort : ICloneable
    {
        public string CohortName { get; set; }

        public List<Legionare> Legionaries { get; set; }

        public Cohort()
        {
            this.Legionaries = new List<Legionare>();
        }

        private Cohort _getCohortClone()
        {
            Cohort cloneCohort = new Cohort();
            cloneCohort.CohortName = this.CohortName;

            cloneCohort.Legionaries = new List<Legionare>();
            foreach (Legionare legionare in this.Legionaries)
            {
                cloneCohort.Legionaries.Add((Legionare) legionare.GetClone());
            }

            return cloneCohort;
        }

        public object GetClone()
        {
            return _getCohortClone();
        }
    }
}
