using DesignPatterns.Prototype;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
	[TestClass]
	public class PrototypeTest
	{
		[TestMethod]
		public void TestShallowClone()
		{
			var obj = new ShallowClone(new int[] { 1, 2, 3, 4, 5 });
			var obj1 = obj.Clone();
			var obj2 = obj.Clone();

			obj.myValue[0] = 6;

			Assert.AreEqual(6, obj1.myValue[0]);
			Assert.AreEqual(6, obj2.myValue[0]);
		}

		[TestMethod]
		public void TestDeepClone()
		{
			var obj = new DeepClone(new int[] { 1, 2, 3, 4, 5 });
			var obj1 = obj.Clone();
			var obj2 = obj.Clone();

			obj.myValue[0] = 6;

			Assert.AreEqual(1, obj1.myValue[0]);
			Assert.AreEqual(1, obj2.myValue[0]);
		}
	}
}
