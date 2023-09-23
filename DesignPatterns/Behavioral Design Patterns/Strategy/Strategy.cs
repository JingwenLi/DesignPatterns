﻿using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
	public interface IStrategy
	{
		object DoAlgorithm(object data);
	}

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
