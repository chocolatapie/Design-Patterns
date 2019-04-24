using System.Collections.Generic;
using DesignPatterns.Creational.Prototype.Interface;

namespace DesignPatterns.Creational.Prototype.Models
{
    class Legion : ICloneable
    {
        public string LegionName { get; set; }

        public List<Cohort> LegionsCohorts { get; set; }

        public Legion()
        {
            LegionsCohorts = new List<Cohort>();
        }

        private Legion _createLegionClone()
        {
            Legion cloneLegion = new Legion();
            cloneLegion.LegionName = this.LegionName;

            foreach (Cohort cohort in this.LegionsCohorts)
            {
                cloneLegion.LegionsCohorts.Add((Cohort) cohort.GetClone());
            }

            return cloneLegion;
        }

        public object GetClone()
        {
            return _createLegionClone();
        }
    }
}
