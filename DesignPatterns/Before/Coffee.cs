using System;

namespace DesignPatterns.Before
{
    public abstract class Coffee
    {
        public abstract string GetName();

        public void AddSugar()
        {
            Console.WriteLine("加糖");
        }

        public void AddMilk()
        {
            Console.WriteLine("加奶");
        }
    }

    public class LatterCoffee : Coffee
    {
        public override string GetName()
        {
            return "拿铁咖啡";
        }
    }

    public class AmericanCoffee : Coffee
    {
        public override string GetName()
        {
            return "美式咖啡";
        }
    }
}