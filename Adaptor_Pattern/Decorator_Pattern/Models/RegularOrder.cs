using System;
using System.Linq;

namespace Decorator_Pattern.Models
{
    public class RegularOrder : OrderBase
    {
        public override int CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a regular order");
            return products.Sum(x => x.Price);
        }
    }
}
