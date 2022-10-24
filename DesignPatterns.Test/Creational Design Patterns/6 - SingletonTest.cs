using DesignPatterns.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
	[TestClass]
	public class SingletonTest
	{
		[TestMethod]
		public void TestGetInstance()
		{
			LazySingleton.GetInstance();
			LazySingleton.GetInstance();

			InnerClassSignleton.GetInstance();
			HungrySingleton.GetInstance();
		}
	}
}
