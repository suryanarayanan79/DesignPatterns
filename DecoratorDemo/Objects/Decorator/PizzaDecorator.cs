using System;

namespace DecoratorDemo
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza _pizza; 

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.Description;
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }
    }
}
