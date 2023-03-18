using System;

// The Facade class provides a simple interface to the complex logic of one or several subsystems.
// The Facade delegates the requests to subsystem.
// All of this shields the client from the undesired complexity of the subsystem.
namespace DesignPatterns.Facade
{
	public class SubSystem1
	{
		public void Operation1()
		{
			Console.WriteLine("SubSystem1: Ready!");
		}

		public void OperationN()
		{
			Console.WriteLine( "SubSystem1: Go!");
		}
	}

	public class SubSystem2
	{
		public void Operation1()
		{
			Console.WriteLine("SubSystem2: Get ready!");
		}

		public void OperationZ()
		{
			Console.WriteLine("SubSystem2: Fire!");
		}
	}

	public class Facade
	{
		protected SubSystem1 subSystem1;

		protected SubSystem2 subSystem2;

		public Facade()
		{
			this.subSystem1 = new SubSystem1();
			this.subSystem2 = new SubSystem2();
		}

		public void Operation()
		{
			subSystem1.Operation1();
			subSystem2.Operation1();

			subSystem1.OperationN();
			subSystem2.OperationZ();
		}
	}

	public class Client
	{
		public static void Run()
		{
			var facade = new Facade();
			facade.Operation();
		}
	}
}