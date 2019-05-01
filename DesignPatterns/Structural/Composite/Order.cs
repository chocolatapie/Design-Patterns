using DesignPatterns.Structural.Composite.Interfaces;

namespace DesignPatterns.Structural.Composite
{
    public class Order
    {
        public IBox Box { get; set; }

        public int OrderPrice { get; set; }

        public Order(IBox box)
        {
            this.Box = box;
            this.Box.CountTotalPrice();
            this.OrderPrice = this.Box.TotalPrice;
        }
    }
}