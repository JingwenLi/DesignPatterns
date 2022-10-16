namespace DesignPatterns
{
	public class SimpleCoffeeFactory
    {
        public Coffee CreateCoffee(string type)
        {
            Coffee coffee = null;
            if ("American".Equals(type))
            {
                coffee = new AmericanCoffee();
            }
            else if ("Latter".Equals(type))
            {
                coffee = new LatterCoffee();
            }
            return coffee;
        }
    }
}
