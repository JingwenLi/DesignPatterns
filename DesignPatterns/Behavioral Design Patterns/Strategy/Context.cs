﻿using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
	class Context
	{
		private IStrategy _strategy;

		public Context()
		{ }

		// Usually, the Context accepts a strategy through the constructor, but
		// also provides a setter to change it at runtime.
		public Context(IStrategy strategy)
		{
			_strategy = strategy;
		}

		// Usually, the Context allows replacing a Strategy object at runtime.
		public void SetStrategy(IStrategy strategy)
		{
			_strategy = strategy;
		}

		// The Context delegates some work to the Strategy object instead of
		// implementing multiple versions of the algorithm on its own.
		public void DoSomeBusinessLogic()
		{
			Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
			var result = _strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

			string resultStr = string.Empty;
			foreach (var element in result as List<string>)
			{
				resultStr += element + ",";
			}

			Console.WriteLine(resultStr);
		}
	}
}
