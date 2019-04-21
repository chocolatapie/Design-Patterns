using DesignPatterns.Creational.Builder.BuilderInterface;

namespace DesignPatterns.Creational.Builder.Builders
{
    class DominosBuilder : IPizzaBuilder
    {
        private Pizza _pizza;

        public DominosBuilder()
        {
            _reInitializeBuilder();
        }
        
        private void _reInitializeBuilder()
        {
            this._pizza = null;
            this._pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            Pizza resultPizza = this._pizza;
            this._reInitializeBuilder();
            return resultPizza;
        }

        public void InitializeAdditionInfo()
        {
            throw new System.NotImplementedException();
        }

        public void InitializeIngredients()
        {
            throw new System.NotImplementedException();
        }

        public void InitializeMetricInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}
