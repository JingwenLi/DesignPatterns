using System;

namespace DesignPatterns.Decorator
{
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

		// The Decorator delegates all operations to the wrapped component.
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

	public class Client
	{
		public static void Run()
		{
			var simple = new ConcreteComponent();
			Console.WriteLine("RESULT: " + simple.Operation());

			var decorator1 = new ConcreteDecoratorA(simple);
			Console.WriteLine("RESULT: " + decorator1.Operation());

			// Note how decorators can wrap not only simple components but the other decorators as well.
			var decorator2 = new ConcreteDecoratorB(decorator1);
			Console.WriteLine("RESULT: " + decorator2.Operation());
		}
	}
}