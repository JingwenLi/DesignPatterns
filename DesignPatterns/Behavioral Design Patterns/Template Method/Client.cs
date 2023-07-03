using System;

namespace DesignPatterns.TemplateMethod
{
	internal class Client
	{

		// The client code calls the template method to execute the algorithm.
		// Client code does not have to know the concrete class of an object it
		// works with, as long as it works with objects through the interface of
		// their base class.
		public static void ClientCode(AbstractClass abstractClass)
		{
			// ...
			abstractClass.TemplateMethod();
			// ...
		}

		public static void Run()
		{
			Console.WriteLine("Same client code can work with different subclasses:");

			Client.ClientCode(new ConcreteClass1());

			Console.Write("\n");

			Console.WriteLine("Same client code can work with different subclasses:");
			Client.ClientCode(new ConcreteClass2());
		}
	}
}
