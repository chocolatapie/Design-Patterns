using System.Collections.Generic;
using DesignPatterns.Structural.Composite.Interfaces;

namespace DesignPatterns.Structural.Composite.Models
{
    public class Box : IBox
    {
        public int TotalPrice { get; set; }

        public List<IProduct> Products { get; set; }

        public List<IBox> InnerBoxes { get; set; }

        public void AddProduct(Product inputProduct)
        {
            if (this.Products == null)
            {
                this.Products = new List<IProduct>();
            }
            this.Products.Add(inputProduct);
        }

        public void AddBox(Box inputBox)
        {
            if (this.InnerBoxes == null)
            {
                this.InnerBoxes = new List<IBox>();
            }
            this.InnerBoxes.Add(inputBox);
        }

        public void CountTotalPrice()
        {
            if (this.Products != null)
            {
                foreach (IProduct product in this.Products)
                {
                this.TotalPrice += product.Price;
                }
            }
            if (this.InnerBoxes != null)
            {
                foreach (IBox innerBox in this.InnerBoxes)
                {
                    innerBox.CountTotalPrice();
                    this.TotalPrice += innerBox.TotalPrice;
                }
            }
        }
    }
}