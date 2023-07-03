using System;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibility
{
	internal class Client
	{
		public static void Run()
		{
			// The other part of the client code constructs the actual chain.
			var monkey = new MonkeyHandler();
			var squirrel = new SquirrelHandler();
			var dog = new DogHandler();

			monkey.SetNext(squirrel).SetNext(dog);

			// The client should be able to send a request to any handler, not
			// just the first one in the chain.
			Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
			Run(monkey);
			Console.WriteLine();

			Console.WriteLine("Subchain: Squirrel > Dog\n");
			Run(squirrel);
		}

		public static void Run(AbstractHandler handler)
		{
			foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
			{
				Console.WriteLine($"Client: Who wants a {food}?");

				var result = handler.Handle(food);

				if (result != null)
				{
					Console.Write($"   {result}");
				}
				else
				{
					Console.WriteLine($"   {food} was left untouched.");
				}
			}
		}
	}
}
