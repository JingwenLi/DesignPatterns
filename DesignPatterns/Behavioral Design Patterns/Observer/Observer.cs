using System;

namespace DesignPatterns.Observer
{
	public interface IObserver
	{
		// Receive update from subject
		void Update(ISubject subject);
	}

	class ConcreteObserverA : IObserver
	{
		public void Update(ISubject subject)
		{
			Console.WriteLine("ConcreteObserverA: Reacted to the event.");
		}
	}

	class ConcreteObserverB : IObserver
	{
		public void Update(ISubject subject)
		{
			Console.WriteLine("ConcreteObserverA: Reacted to the event.");
		}
	}
}
