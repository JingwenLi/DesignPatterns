namespace DesignPatterns.SimpleFactory
{
    public class CoffeeStore
    {
        public Coffee OrderCoffee(string type)
        {
            var factory = new SimpleCoffeeFactory();
            var coffee = factory.CreateCoffee(type);

            coffee.AddMilk();
            coffee.AddSugar();

            return coffee;
        }
    }
}