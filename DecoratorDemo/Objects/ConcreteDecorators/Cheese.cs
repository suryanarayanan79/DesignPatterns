using System;

namespace DecoratorDemo
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza)
            : base(pizza)
        {
            Description = "Cheese";
        }

        public override string GetDescription()
        {
            return String.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 1.25;
        }
    }
}