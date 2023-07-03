using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
	// The Strategy interface declares operations common to all supported
	// versions of some algorithm.
	//
	// The Context uses this interface to call the algorithm defined by Concrete
	// Strategies.
	public interface IStrategy
	{
		object DoAlgorithm(object data);
	}

	// Concrete Strategies implement the algorithm while following the base
	// Strategy interface. The interface makes them interchangeable in the
	// Context.
	class ConcreteStrategyA : IStrategy
	{
		public object DoAlgorithm(object data)
		{
			var list = data as List<string>;
			list.Sort();

			return list;
		}
	}

	class ConcreteStrategyB : IStrategy
	{
		public object DoAlgorithm(object data)
		{
			var list = data as List<string>;
			list.Sort();
			list.Reverse();

			return list;
		}
	}
}
