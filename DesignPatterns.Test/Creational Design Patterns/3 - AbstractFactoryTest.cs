using DesignPatterns.AbstractFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
	[TestClass]
	public class AbstractFactoryTest
	{
		[TestMethod]
		public void TestCall()
		{
			new XiaoMiFactory().CreateMobilePhone().Call();
			new HuaWeiFactory().CreateMobilePhone().Call();
		}

		[TestMethod]
		public void TestGetTime()
		{
			new XiaoMiFactory().CreateWatch().GetTime();
			new HuaWeiFactory().CreateWatch().GetTime();
		}
	}
}
