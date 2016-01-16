using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorDemo
{
    public class Peppers : PizzaDecorator
    {
        public Peppers(Pizza pizza)
            : base(pizza)
        {
            Description = "Peppers";
        }

        public override string GetDescription()
        {
            return String.Format("{0}, {1}", _pizza.GetDescription(), Description);
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 2.00;
        }
    }
}
