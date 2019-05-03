namespace DesignPatterns.Structural.Decorator.Interfaces
{
    abstract class AbstractCharacterDecorator : ICharacter
    {
        public ICharacter Character { get; set; }

        public AbstractCharacterDecorator(ICharacter inputCharacter)
        {
            this.Character = inputCharacter;
        }

        public virtual int GetProtectionFromArmor()
        {
            return this.Character.GetProtectionFromArmor();
        }
    }
}
