using System;

namespace DecoratorDemo
{
    public class SmallPizza : Pizza
    {

        public SmallPizza()
        {
            Description = "Small Pizza";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculateCost()
        {
            return 3.00;
        }
    }
}
