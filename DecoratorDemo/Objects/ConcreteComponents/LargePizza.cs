using System;

namespace DecoratorDemo
{
    public class LargePizza : Pizza
    {

        public LargePizza()
        {
            Description = "Large Pizza";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 9.00;
        }
    }
}