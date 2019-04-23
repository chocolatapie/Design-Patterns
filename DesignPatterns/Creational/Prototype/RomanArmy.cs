using DesignPatterns.Creational.Prototype.Models;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Prototype
{
    class RomanArmy
    {
        public List<Legion> RomanLegions { get; set; }

        public RomanArmy()
        {
            RomanLegions = new List<Legion>();
        }
    }
}
