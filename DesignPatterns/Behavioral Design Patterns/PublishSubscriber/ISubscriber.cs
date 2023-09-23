using System;

namespace DesignPatterns.PublishSubscriber
{
	public interface ISubscriber
	{
		void ReceiveMessage(Message message);
	}

	class ConcreteSubscriberA : ISubscriber
	{
		public void ReceiveMessage(Message message)
		{
			Console.WriteLine("ConcreteSubscriberA: Received message");
		}
	}

	class ConcreteSubscriberB : ISubscriber
	{
		public void ReceiveMessage(Message message)
		{
			Console.WriteLine("ConcreteSubscriberB: Received message");
		}
	}
}
