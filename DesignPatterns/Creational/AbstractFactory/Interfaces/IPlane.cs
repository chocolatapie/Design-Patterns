namespace DesignPatterns.Creational.AbstractFactory.Interfaces
{
    public interface IPlane
    {
        string Type { get; set; }

        void Fly(int distance);
    }
}