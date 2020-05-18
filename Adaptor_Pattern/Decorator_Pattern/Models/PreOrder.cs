using System;
using System.Linq;

namespace Decorator_Pattern.Models
{
    public class PreOrder : OrderBase
    {
        public override int CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a preorder.");
            return products.Sum(x => x.Price) * 2;
        }
    }
}
