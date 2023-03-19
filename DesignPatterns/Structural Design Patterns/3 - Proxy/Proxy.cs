using System;

namespace DesignPatterns.Proxy
{
	// The Subject interface declares common operations for both RealSubject and the Proxy.
	// As long as the client works with RealSubject using this interface, you'll be able to pass in a proxy instead of a real subject.
	public interface ISubject
	{
		void Request();
	}

	// The RealSubject contains some core business logic.
	// Usually, RealSubjects are capable of doing some useful work which may also be very slow or sensitive.
	class RealSubject : ISubject
	{
		public void Request()
		{
			Console.WriteLine("RealSubject: Request...");
		}
	}

	class Proxy : ISubject
	{
		private RealSubject realSubject;

		public Proxy(RealSubject realSubject)
		{
			this.realSubject = realSubject;
		}

		public void Request()
		{
			if (CheckAccess())
			{
				realSubject.Request();

				LogAccess();
			}
		}

		public bool CheckAccess()
		{
			Console.WriteLine("Proxy: Checking access.");

			return true;
		}

		public void LogAccess()
		{
			Console.WriteLine("Proxy: Logging request time.");
		}
	}

	public class Client
	{
		public static void Run()
		{
			Console.WriteLine("Client: Executing with a real subject:");
			var realSubject = new RealSubject();
			Execute(realSubject);

			Console.WriteLine();

			Console.WriteLine("Client: Executing with a proxy:");
			Proxy proxy = new Proxy(realSubject);
			Execute(proxy);
		}

		public static void Execute(ISubject subject)
		{
			subject.Request();
		}
	}
}
