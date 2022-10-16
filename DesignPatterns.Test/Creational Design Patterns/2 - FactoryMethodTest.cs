﻿using DesignPatterns.FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
	[TestClass]
	public class FactoryMethodTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			new XiaoMiFactory().CreateMobilePhone().Call();
			new HuaWeiFactory().CreateMobilePhone().Call();
		}
	}
}