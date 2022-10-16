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
			var Obj1 = obj.Clone();
			var Obj2 = obj.Clone();

			obj.myValue[0] = 6;

			Assert.AreEqual(6, Obj1.myValue[0]);
			Assert.AreEqual(6, Obj2.myValue[0]);
		}

		[TestMethod]
		public void TestDeepClone()
		{
			var obj = new DeepClone(new int[] { 1, 2, 3, 4, 5 });
			var Obj1 = obj.Clone();
			var Obj2 = obj.Clone();

			obj.myValue[0] = 6;

			Assert.AreEqual(1, Obj1.myValue[0]);
			Assert.AreEqual(1, Obj2.myValue[0]);
		}
	}
}
