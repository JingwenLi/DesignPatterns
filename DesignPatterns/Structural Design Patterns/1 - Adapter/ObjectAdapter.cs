using System;

namespace DesignPatterns.Adapter
{
	public class Client
	{
		public static void Run()
		{
            var adaptee = new Adaptee();
            ITarget target1 = new ObjectAdapter(adaptee);
            ITarget target2 = new ClassAdapter();

			Console.WriteLine("Adaptee is incompatible with the target.");
            Console.WriteLine("But with adapter, client can call it's method.");

            Console.WriteLine(target1.GetRequest());
            Console.WriteLine(target2.GetRequest());
		}
	}

	// The Target defines the domain-specific interface used by the client code.
	public interface ITarget
	{
		string GetRequest();
	}

	// The Adaptee contains some useful behavior, but it's incompatible with the existing client code.
	// The Adaptee needs some adaptation before the client code can use it.
	public class Adaptee
	{
		public string GetSpecificRequest()
		{
			return "Specific request.";
		}
	}

	// Hold the object: Adaptee
	public class ObjectAdapter : ITarget
	{
		private readonly Adaptee _adaptee;

		public ObjectAdapter(Adaptee adaptee)
		{
			_adaptee = adaptee;
		}

		public string GetRequest()
		{
			return $"This is '{_adaptee.GetSpecificRequest()}'";
		}
	}

	// Implement class: Adaptee
	public class ClassAdapter : Adaptee, ITarget
	{
		public string GetRequest()
		{
			return $"This is '{GetSpecificRequest()}'";
		}
	}
}
