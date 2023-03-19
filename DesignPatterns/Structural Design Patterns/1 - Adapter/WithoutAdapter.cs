using System;

namespace DesignPatterns.WithoutAdapter
{
	// The Client Interface. It describes a protocol that other classes must follow to be able to collaborate with the client code.
	public interface ITarget
	{
		string GetRequest();
	}

	// The Adaptee contains some useful behavior.
	// The client can’t use this class directly because it's incompatible with the client code.
	public class Adaptee
	{
		public string GetSpecificRequest()
		{
			return "Specific request.";
		}
	}

	public class Client
	{
		public static void Run()
		{
			var adaptee = new Adaptee();
			Console.WriteLine("Adaptee is incompatible. The client can not use it.");
		}

		public static void Use(ITarget target)
		{
			Console.WriteLine(target.GetRequest());
		}
	}
}