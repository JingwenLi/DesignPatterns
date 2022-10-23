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
			var costEffectiveComputer = new Director(new CostEffectiveBuilder()).BuildComputer();
			Console.WriteLine(costEffectiveComputer.CPU);
			Console.WriteLine(costEffectiveComputer.Disk);
			Console.WriteLine(costEffectiveComputer.GraphicsCard);
			Console.WriteLine(costEffectiveComputer.MainBoard);
			Console.WriteLine(costEffectiveComputer.Memory);

			Console.WriteLine();

			var highPerformanceComputer = new Director(new HighPerformanceBuilder()).BuildComputer();
			Console.WriteLine(highPerformanceComputer.CPU);
			Console.WriteLine(highPerformanceComputer.Disk);
			Console.WriteLine(highPerformanceComputer.GraphicsCard);
			Console.WriteLine(highPerformanceComputer.MainBoard);
			Console.WriteLine(highPerformanceComputer.Memory);
		}
	}
}
