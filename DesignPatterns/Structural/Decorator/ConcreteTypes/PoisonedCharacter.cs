using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator.ConcreteTypes
{
    class PoisonedCharacter : AbstractCharacterDecorator
    {
        private readonly int _armorDebuffFromPoison = -45;

        public PoisonedCharacter(ICharacter inputCharacter) : base(inputCharacter)
        { }

        public override int GetProtectionFromArmor()
        {
            return this.Character.GetProtectionFromArmor() + this._armorDebuffFromPoison;
        }
    }
}
