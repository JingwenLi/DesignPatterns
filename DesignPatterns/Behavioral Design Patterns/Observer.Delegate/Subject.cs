using System;

namespace DesignPatterns.Observer.Delegate
{
	public delegate void MyEventHandler(object sender, EventArgs e);

	public interface ISubject
	{
		void Notify();
	}

	public class Subject : ISubject
	{
		public event MyEventHandler Handlers;

		public void Notify()
		{
			Handlers?.Invoke(this, EventArgs.Empty);
		}
	}
}
