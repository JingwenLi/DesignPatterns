using System;
using System.Collections.Generic;

namespace DesignPatterns.PublishSubscriber
{
	public class Publisher
	{
		private List<ISubscriber> subscribers = new List<ISubscriber>();

		public void Attach(ISubscriber subscriber)
		{
			subscribers.Add(subscriber);
		}

		public void Detach(ISubscriber subscriber)
		{
			subscribers.Remove(subscriber);
		}

		public void PublishMessage(Message message)
		{
			Console.WriteLine("Subject: Publishing...");
			foreach (var subscriber in subscribers)
			{
				subscriber.ReceiveMessage(message);
			}
		}
	}
}
