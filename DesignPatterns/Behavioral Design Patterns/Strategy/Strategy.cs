using System;

namespace DesignPatterns.Strategy
{
	public interface IStrategy
	{
		void Execute();
	}

	public class ConcreteStrategyA : IStrategy
	{
		public void Execute()
		{
			Console.WriteLine("Executing strategy A");
		}
	}

	public class ConcreteStrategyB : IStrategy
	{
		public void Execute()
		{
			Console.WriteLine("Executing strategy B");
		}
	}
}
