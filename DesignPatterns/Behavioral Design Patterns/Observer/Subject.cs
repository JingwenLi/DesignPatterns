using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
	public interface ISubject
	{
		void Attach(IObserver observer);

		void Detach(IObserver observer);

		void Notify();
	}

	public class Subject : ISubject
	{
		private List<IObserver> observers = new List<IObserver>();

		public void Attach(IObserver observer)
		{
			observers.Add(observer);
			Console.WriteLine("Subject: Attached an observer.");
		}

		public void Detach(IObserver observer)
		{
			observers.Remove(observer);
			Console.WriteLine("Subject: Detached an observer.");
		}

		public void Notify()
		{
			Console.WriteLine("Subject: Notifying observers...");
			foreach (var observer in observers)
			{
				observer.Update(this);
			}
		}

		public void SomeBusinessLogic()
		{
			Console.WriteLine("\nSubject: I'm doing something important.");
			Notify();
		}
	}
}
