namespace DesignPatterns.Observer
{
	internal class Client
	{
		public static void Run()
		{
			var subject = new Subject();
			var observerA = new ConcreteObserverA();
			var observerB = new ConcreteObserverB();

			subject.Attach(observerA);
			subject.Attach(observerB);
			subject.SomeBusinessLogic();
			subject.SomeBusinessLogic();

			subject.Detach(observerB);
			subject.SomeBusinessLogic();
		}
	}
}
