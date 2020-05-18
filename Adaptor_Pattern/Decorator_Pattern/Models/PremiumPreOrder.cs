using System;

namespace Decorator_Pattern.Models
{
    public class PremiumPreOrder : OrderDecorator
    {
        public PremiumPreOrder(OrderBase order) : base(order)
        { }

        public override int CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in the {nameof(CalculateTotalOrderPrice)} class.");
            var preOrderPrice = base.CalculateTotalOrderPrice();

            Console.WriteLine("Adding additional discount to a preorder price");
            return preOrderPrice * 1;
        }
    }
}
