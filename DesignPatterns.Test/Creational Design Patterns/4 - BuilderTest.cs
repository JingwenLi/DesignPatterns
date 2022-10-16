using DesignPatterns.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
	[TestClass]
	public class BuilderTest
	{
		[TestMethod]
		public void TestMethod()
		{
			new Director(new CostEffectiveBuilder()).AssembleComputer();
			new Director(new HighPerformanceBuilder()).AssembleComputer();
		}
	}
}
