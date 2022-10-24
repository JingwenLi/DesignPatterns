﻿using DesignPatterns.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
	[TestClass]
	public class SingletonTest
	{
		[TestMethod]
		public void TestGetInstance()
		{
			var obj1 = InnerClassSignleton.GetInstance();
			var obj2 = InnerClassSignleton.GetInstance();
			Assert.AreEqual(obj2, obj1);

			var obj3 = HungrySingleton.GetInstance();
			var obj4 = HungrySingleton.GetInstance();
			Assert.AreEqual(obj3, obj4);
		}
	}
}
