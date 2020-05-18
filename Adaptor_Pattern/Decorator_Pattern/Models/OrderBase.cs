using System.Collections.Generic;

namespace Decorator_Pattern.Models
{
    public abstract class OrderBase
    {
        protected List<Product> products = new List<Product>
        {
            new Product {Name = "Phone", Price = 587},
            new Product {Name = "Tablet", Price = 800},
            new Product {Name = "PC", Price = 1200}
        };

        public abstract int CalculateTotalOrderPrice();
    }
}
