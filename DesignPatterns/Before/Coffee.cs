using System;

namespace DesignPatterns
{
    public abstract class Coffee
    {
        public abstract string GetName();

        public void AddSugar()
        {
            Console.WriteLine("Add Sugar - Done");
        }

        public void AddMilk()
        {
            Console.WriteLine("Add Milk - Done");
        }
    }

    public class LatterCoffee : Coffee
    {
        public override string GetName()
        {
            return "LatterCoffee";
        }
    }

    public class AmericanCoffee : Coffee
    {
        public override string GetName()
        {
            return "AmericanCoffee";
        }
    }
}