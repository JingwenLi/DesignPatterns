using System;

namespace DesignPatterns.Facade
{
	public class Client
	{
		public static void Run()
		{
			var subSystem1 = new SubSystem1();
			var subSystem2 = new SubSystem2(); 
			var facade = new Facade(subSystem1, subSystem2);
			facade.Operation();
		}
	}

	public class SubSystem1
	{
		public string Operation1()
		{
			return "SubSystem1: Ready!\n";
		}

		public string OperationN()
		{
			return "SubSystem1: Go!\n";
		}
	}

	public class SubSystem2
	{
		public string Operation1()
		{
			return "SubSystem2: Get ready!\n";
		}

		public string OperationZ()
		{
			return "SubSystem2: Fire!\n";
		}
	}

	public class Facade
	{
		protected SubSystem1 subSystem1;

		protected SubSystem2 subSystem2;

		public Facade(SubSystem1 subSystem1, SubSystem2 subSystem2)
		{
			this.subSystem1 = subSystem1;
			this.subSystem2 = subSystem2;
		}

		public void Operation()
		{
			subSystem1.Operation1();
			subSystem2.Operation1();

			subSystem1.OperationN();
			subSystem2.OperationZ();
		}
	}
}