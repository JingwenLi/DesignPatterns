using DesignPatterns.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
	[TestClass]
	public class SingletonTest
	{
		[TestMethod]
		public void TestBefore()
		{
			Before.Client.Run();
		}

		[TestMethod]
		public void TestSimpleFactory()
		{
			SimpleFactory.Client.Run();
		}

		[TestMethod]
		public void TestFactoryMethod()
		{
			FactoryMethod.Client.Run();
		}

		[TestMethod]
		public void TestAbstractFactory()
		{
			AbstractFactory.Client.Run();
		}

		[TestMethod]
		public void TestBuilder()
		{
			Builder.Client.Run();
		}

		[TestMethod]
		public void TestPrototype()
		{
			Prototype.Client.Run();
		}

		[TestMethod]
		public void TestSingleton()
		{
			LazySingleton.GetInstance();
			InnerClassSignleton.GetInstance();
			HungrySingleton.GetInstance();
		}
	}
}
