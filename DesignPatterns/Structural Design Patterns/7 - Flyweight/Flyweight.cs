using System;
using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
	public class Client
	{
		public static void Run()
		{
			var factory = new FlyweightFactory();

			var flyweightA = factory.GetFlyweight("A");
			flyweightA.Operation();

			var flyweightB = factory.GetFlyweight("B");
			flyweightB.Operation();

			var flyweightC = factory.GetFlyweight("C");
			flyweightC.Operation();

			var flyweightD = factory.GetFlyweight("D");
			flyweightD.Operation();
		}
	}

	public abstract class Flyweight
	{
		public abstract void Operation();
	}

	public class ConcreteFlyweight : Flyweight
	{
		public override void Operation()
		{
			Console.WriteLine("");
		}
	}

	class FlyweightFactory
	{
		public Dictionary<string, Flyweight> Flyweights = new Dictionary<string, Flyweight>();

		public Flyweight GetFlyweight(string key)
		{
			if (Flyweights.ContainsKey(key))
			{
				return Flyweights[key];
			}
			else
			{
				Flyweights.Add(key, new ConcreteFlyweight());
				return Flyweights[key];
			}
		}
	}
}
