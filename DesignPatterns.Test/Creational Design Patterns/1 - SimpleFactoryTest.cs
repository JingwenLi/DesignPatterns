using DesignPatterns.SimpleFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
	[TestClass]
	public class SimpleFactoryTest
	{
		[TestMethod]
		public void TestMethod()
		{
			var factory = new SimpleMobilePhoneFactory();
			factory.CreateMobilePhone("XiaoMi").Call();
			factory.CreateMobilePhone("HuaWei").Call();
		}
	}
}
