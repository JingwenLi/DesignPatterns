using System;

namespace DesignPatterns.Observer.Delegate
{
	public interface IObserver
	{
		// Receive update from subject
		void Update(object sender, EventArgs e);
	}

	class ConcreteObserverA : IObserver
	{
		public void Update(object sender, EventArgs e)
		{
			Console.WriteLine("ObserverA: Reacted to the event.");
		}
	}

	class ConcreteObserverB : IObserver
	{
		public void Update(object sender, EventArgs e)
		{
			Console.WriteLine("ObserverB: Reacted to the event.");
		}
	}
}
