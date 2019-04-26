using DesignPatterns.Structural.Composite.Interfaces;

namespace DesignPatterns.Structural.Composite.Models
{
    public class Product : IProduct
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}