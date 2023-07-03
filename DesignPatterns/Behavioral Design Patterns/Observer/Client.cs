using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
	internal class Client
	{
		public static void Run()
		{
			// The client code.
			var subject = new Subject();
			var observerA = new ConcreteObserverA();
			subject.Attach(observerA);

			var observerB = new ConcreteObserverB();
			subject.Attach(observerB);

			subject.SomeBusinessLogic();
			subject.SomeBusinessLogic();

			subject.Detach(observerB);

			subject.SomeBusinessLogic();
		}
	}
}
