namespace DesignPatterns.FactoryMethod
{
	public class CoffeeStore
    {
        public Coffee OrderCoffee(ICoffeeFactory factory)
        {
            Coffee coffee = factory.CreateCoffee();

            coffee.AddMilk();
            coffee.AddMilk();

            return coffee;
        }
    }
}
