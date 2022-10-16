namespace DesignPatterns
{
	public interface ICoffeeFactory
    {
        Coffee CreateCoffee();
    }

    public class AmericanCoffeeFactory : ICoffeeFactory
    {
        public Coffee CreateCoffee()
        {
            return new AmericanCoffee();
        }
    }

    public class LatterCoffeeFactory : ICoffeeFactory
    {
        public Coffee CreateCoffee()
        {
            return new LatterCoffee();
        }
    }
}
