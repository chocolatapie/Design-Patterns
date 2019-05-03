using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator.ConcreteTypes
{
    class HeavyArmoredCharacter : AbstractCharacterDecorator
    {
        private readonly int _additionalHeavyArmor = 100;

        public HeavyArmoredCharacter(ICharacter inputCharacter) : base(inputCharacter)
        {}

        public override int GetProtectionFromArmor()
        {
            return this.Character.GetProtectionFromArmor() + this._additionalHeavyArmor;
        }
    }
}
