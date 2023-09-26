namespace DesignPatterns.Observer.Event
{
	public class Client
	{
		public static void Run()
		{
			var subject = new Subject();
			var observerA = new ConcreteObserverA();
			var observerB = new ConcreteObserverB();

			subject.Handlers += observerA.Update;
			subject.Handlers += observerB.Update;

			subject.Notify();
		}
	}
}
