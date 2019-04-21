namespace DesignPatterns.Creational.FactoryMethod
{
    public interface IAutomobile
    {
        int HorsePower { get; set; }

        int СarMileage { get; set; }

        string Manufacturer { get; set; }

        string GetInfoThisAuto();
        
        void Ride(int miles);
    }
}
