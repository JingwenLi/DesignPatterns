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
			Console.WriteLine("Publisher: Attached an subscriber.");
		}

		public void Detach(ISubscriber subscriber)
		{
			subscribers.Remove(subscriber);
			Console.WriteLine("Publisher: Attached an subscriber.");
		}

		public void PublishMessage(Message message)
		{
			Console.WriteLine($"\nPublisher: Publishing {message.Content}");
			foreach (var subscriber in subscribers)
			{
				subscriber.ReceiveMessage(message);
			}
		}
	}
}
