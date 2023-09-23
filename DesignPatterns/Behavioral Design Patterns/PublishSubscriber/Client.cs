namespace DesignPatterns.PublishSubscriber
{
	internal class Client
	{
		public static void Run()
		{
			var message = new Message("Important Info");
			var publisher = new Publisher();
			var observerA = new ConcreteSubscriberA();
			var observerB = new ConcreteSubscriberB();

			publisher.Attach(observerA);
			publisher.Attach(observerB);
			publisher.PublishMessage(message);
		}
	}
}
