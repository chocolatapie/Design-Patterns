using DesignPatterns.Creational.Prototype.Interface;

namespace DesignPatterns.Creational.Prototype.Models
{
    class Legionare : ICloneable
    {
        public string Name { get; set; }
        public string Rank { get; set; }

        private Legionare _getLegionareClone()
        {
            Legionare cloneLegionare = new Legionare();
            cloneLegionare.Name = this.Name;
            cloneLegionare.Rank = this.Rank;

            return cloneLegionare;
        }

        public object GetClone()
        {
            return _getLegionareClone();
        }
    }
}
