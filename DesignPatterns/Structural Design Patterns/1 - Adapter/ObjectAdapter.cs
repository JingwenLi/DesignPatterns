using System;

namespace DesignPatterns.Adapter
{
	public class Client
	{
		public static void Run()
		{
            var adaptee = new Adaptee();
            Console.WriteLine("Adaptee is incompatible. The client can not use it.");

			//ITarget target1 = new ObjectAdapter(adaptee);
			//ITarget target2 = new ClassAdapter();
			//Console.WriteLine("But with adapter, the client can use it.");

			//Use(target1);
			//Use(target2);
		}

		public static void Use(ITarget target)
		{
			Console.WriteLine(target.GetRequest());
		}
	}

	// The Client Interface. It describes a protocol that other classes must follow to be able to collaborate with the client code.
	public interface ITarget
	{
		string GetRequest();
	}

	// The Adaptee contains some useful behavior. The client can’t use this class directly because it's incompatible with the client code.
	public class Adaptee
	{
		public string GetSpecificRequest()
		{
			return "Specific request.";
		}
	}

	//// Hold the object: Adaptee
	//public class ObjectAdapter : ITarget
	//{
	//	private readonly Adaptee _adaptee;

	//	public ObjectAdapter(Adaptee adaptee)
	//	{
	//		_adaptee = adaptee;
	//	}

	//	public string GetRequest()
	//	{
	//		return $"This is '{_adaptee.GetSpecificRequest()}'";
	//	}
	//}

	//// Implement class: Adaptee
	//public class ClassAdapter : Adaptee, ITarget
	//{
	//	public string GetRequest()
	//	{
	//		return $"This is '{GetSpecificRequest()}'";
	//	}
	//}
}
