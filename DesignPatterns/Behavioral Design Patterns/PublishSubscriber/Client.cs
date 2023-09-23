namespace DesignPatterns.PublishSubscriber
{
	public class Client
	{
		public static void Run()
		{
			var message1 = new Message("Important Info 1");
			var message2 = new Message("Important Info 2");

			var publisher = new Publisher();

			var observerA = new ConcreteSubscriberA();
			var observerB = new ConcreteSubscriberB();

			publisher.Attach(observerA);
			publisher.Attach(observerB);
			publisher.PublishMessage(message1);
			publisher.PublishMessage(message2);
		}
	}
}
