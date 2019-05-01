using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite.Interfaces
{
    public interface IBox
    {
        int TotalPrice { get; set; }

        List<IProduct> Products { get; set; }

        List<IBox> InnerBoxes { get; set; }

        void CountTotalPrice();
    }
}