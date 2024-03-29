﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
	[TestClass]
	public class BehavioralDesignPatternTest
	{
		[TestMethod]
		public void TestObserver()
		{
			Observer.Client.Run();
			Observer.Event.Client.Run();
			Observer.Delegate.Client.Run();
		}

		[TestMethod]
		public void TestPublishSubscriber()
		{
			PublishSubscriber.Client.Run();
		}

		[TestMethod]
		public void TestStrategy()
		{
			Strategy.Client.Run();
		}
	}
}
