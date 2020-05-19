using Decorator_Pattern.Models;
using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularOrder = new RegularOrder();
            Console.WriteLine(regularOrder.CalculateTotalOrderPrice());
            Console.WriteLine();

            var preOrder = new PreOrder();
            Console.WriteLine(preOrder.CalculateTotalOrderPrice());
            Console.WriteLine();

            var premiumPreorder = new PremiumPreOrder(preOrder);
            Console.WriteLine(premiumPreorder.CalculateTotalOrderPrice());
        }
    }
}
