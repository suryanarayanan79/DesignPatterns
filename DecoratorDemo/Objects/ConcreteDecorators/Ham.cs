using System;

namespace DecoratorDemo
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza)
            : base(pizza)
        {
            Description = "Ham";
        }

        public override string GetDescription()
        {
            return String.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.00;
        }
    }
}
