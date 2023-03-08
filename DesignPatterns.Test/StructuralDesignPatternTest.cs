using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns
{
	[TestClass]
	public class StructuralDesignPatternTest
	{
		[TestMethod]
		public void TestAdapter()
		{
			Adapter.Client.Run();
		}

		[TestMethod]
		public void TestBridge()
		{
			Bridge.Client.Run();
			CompareAdapterWithBridge.Client.Run();
		}
		
		[TestMethod]
		public void TestDecorator()
		{
			Decorator.Client.Run();
		}

		[TestMethod]
		public void TestFacade()
		{
			Facade.Client.Run();
		}

		[TestMethod]
		public void TestProxy()
		{
			Proxy.Client.Run();
		}
	}
}
