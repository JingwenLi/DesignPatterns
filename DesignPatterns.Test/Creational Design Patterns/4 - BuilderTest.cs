using DesignPatterns.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatterns.Test
{
	[TestClass]
	public class BuilderTest
	{
		[TestMethod]
		public void TestBuild()
		{
			new Director(new CostEffectiveBuilder()).BuildComputer();

			Console.WriteLine();

			new Director(new HighPerformanceBuilder()).BuildComputer();
		}
	}
}
