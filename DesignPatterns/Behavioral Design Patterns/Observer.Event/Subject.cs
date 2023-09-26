using System;

namespace DesignPatterns.Observer.Event
{
	public interface ISubject
	{
		void Notify();
	}

	public class Subject : ISubject
	{
		public event EventHandler<EventArgs> Handlers;

		public void Notify()
		{
			Handlers?.Invoke(this, EventArgs.Empty);
		}
	}
}
