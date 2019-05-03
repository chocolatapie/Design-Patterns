using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator.ConcreteTypes
{
    class ConcreteCharacter : ICharacter
    {
        public int CharacterBasicArmor { get; set; }

        public ConcreteCharacter(int inputArmor)
        {
            this.CharacterBasicArmor = inputArmor;
        }

        public int GetProtectionFromArmor()
        {
            return CharacterBasicArmor;
        }
    }
}
