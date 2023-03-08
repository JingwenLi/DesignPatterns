using System;

namespace DesignPatterns.Decorator
{
	public class Client
	{
		public static void Run()
		{
			var simple = new ConcreteComponent();
			Console.WriteLine("I get a simple component:");
			Console.WriteLine("RESULT: " + simple.Operation()); 
			Console.WriteLine();

			var decorator1 = new ConcreteDecoratorA(simple);
			Console.WriteLine("I get a decorated component:");
			Console.WriteLine("RESULT: " + decorator1.Operation());
			Console.WriteLine();

			// Note how decorators can wrap not only simple components but the other decorators as well.
			var decorator2 = new ConcreteDecoratorB(decorator1);
			Console.WriteLine("I get a decorated component:");
			Console.WriteLine("RESULT: " + decorator2.Operation());
			Console.WriteLine();
		}
	}

	// The base Component interface defines operations that can be altered by decorators.
	public abstract class Component
	{
		public abstract string Operation();
	}

	// Concrete Components provide default implementations of the operations.
	class ConcreteComponent : Component
	{
		public override string Operation()
		{
			return "ConcreteComponent";
		}
	}

	abstract class Decorator : Component
	{
		protected Component component;

		public Decorator(Component component)
		{
			this.component = component;
		}

		// The Decorator delegates all work to the wrapped component.
		public override string Operation()
		{
			return component.Operation();
		}
	}

	class ConcreteDecoratorA : Decorator
	{
		public ConcreteDecoratorA(Component comp) : base(comp) { }
		
		public override string Operation()
		{
			return $"ConcreteDecoratorA({base.Operation()})";
		}
	}

	class ConcreteDecoratorB : Decorator
	{
		public ConcreteDecoratorB(Component comp) : base(comp) { }

		public override string Operation()
		{
			return $"ConcreteDecoratorB({base.Operation()})";
		}
	}
}