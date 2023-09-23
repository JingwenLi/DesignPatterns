using System;

namespace DesignPatterns.Strategy
{
	public class Client
	{
		public static void Run()
		{
			var context = new Context();

			context.SetStrategy(new ConcreteStrategyA());
			context.ExecuteStrategy();

			Console.WriteLine();

			context.SetStrategy(new ConcreteStrategyB());
			context.ExecuteStrategy();
		}
	}
}
