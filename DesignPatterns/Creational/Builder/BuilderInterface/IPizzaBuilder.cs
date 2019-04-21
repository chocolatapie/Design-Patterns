namespace DesignPatterns.Creational.Builder.BuilderInterface
{
    interface IPizzaBuilder
    {
        void InitializeMetricInfo();

        void InitializeIngredients();

        void InitializeAdditionInfo();

        void ReInitializeBuilder();

        Pizza GetPreparedPizza();
    }
}
