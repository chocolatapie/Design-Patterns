using DesignPatterns.Creational.Builder.BuilderInterface;
using DesignPatterns.Creational.Builder.Builders;

namespace DesignPatterns.Creational.Builder
{
    class Pizzeria
    {
        private IPizzaBuilder _firstBuilder;
        private IPizzaBuilder _secondBuilder;
        private IPizzaBuilder _thirdBuilder;
        private static string _firstPizzaName = "Paperoni";
        private static string _secondPizzaName = "Dominos";
        private static string _thirdPizzaName = "Margarita";


        public Pizzeria()
        {
            _firstBuilder = new PaperoniBuilder();
            _secondBuilder = new DominosBuilder();
            _thirdBuilder = new MargaritaBuilder();
        }

        public Pizza MakePizza(string pizzaRequest)
        {
            Pizza newPizza = null;
            if(pizzaRequest == _firstPizzaName)
            {
                _firstBuilder.InitializeIngredients();
                _firstBuilder.InitializeMetricInfo();
                _firstBuilder.InitializeAdditionInfo();
                 newPizza = _firstBuilder.GetPreparedPizza();
                _firstBuilder.ReInitializeBuilder();
            }
            if (pizzaRequest == _secondPizzaName)
            {
                _secondBuilder.InitializeIngredients();
                _secondBuilder.InitializeMetricInfo();
                _secondBuilder.InitializeAdditionInfo();
                 newPizza = _secondBuilder.GetPreparedPizza();
                _secondBuilder.ReInitializeBuilder();
            }
            if (pizzaRequest == _thirdPizzaName)
            {
                _thirdBuilder.InitializeIngredients();
                _thirdBuilder.InitializeMetricInfo();
                _thirdBuilder.InitializeAdditionInfo();
                 newPizza = _thirdBuilder.GetPreparedPizza();
                _thirdBuilder.ReInitializeBuilder();
            }
            if (newPizza != null)
                return newPizza;
            return null;
        }
    }
}
