using DesignPatterns.Creational.Builder.BuilderInterface;

namespace DesignPatterns.Creational.Builder.Builders
{
    class DominosBuilder : IPizzaBuilder
    {
        private Pizza _pizza;

        public DominosBuilder()
        {
            ReInitializeBuilder();
        }
        
        public void ReInitializeBuilder()
        {
            this._pizza = null;
            this._pizza = new Pizza();
        }

        public Pizza GetPreparedPizza()
        {
            Pizza resultPizza = this._pizza;
            return resultPizza;
        }

        public void InitializeAdditionInfo()
        {
            this._pizza.IsSpicy = true;
            this._pizza.IsVegetarian = false;
        }

        public void InitializeIngredients()
        {
            this._pizza.HasCheese = false;
            this._pizza.HasMilkySauce = false;
            this._pizza.HasPaperoni = true;
            this._pizza.HasTomatoSauce = true;
            this._pizza.HasMushrooms = true;
        }

        public void InitializeMetricInfo()
        {
            this._pizza.Name = "Dominos";
            this._pizza.Price = 77;
            this._pizza.Size = 120;
            this._pizza.Weight = 500;
        }
    }
}
