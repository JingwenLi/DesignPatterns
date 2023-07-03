using System;
using System.Collections.Generic;

namespace DesignPatterns.Memento
{
	internal class Client
	{
		public static void Run()
		{
			// Client code.
			Originator originator = new Originator("Super-duper-super-puper-super.");
			Caretaker caretaker = new Caretaker(originator);

			caretaker.Backup();
			originator.DoSomething();

			caretaker.Backup();
			originator.DoSomething();

			caretaker.Backup();
			originator.DoSomething();

			Console.WriteLine();
			caretaker.ShowHistory();

			Console.WriteLine("\nClient: Now, let's rollback!\n");
			caretaker.Undo();

			Console.WriteLine("\n\nClient: Once more!\n");
			caretaker.Undo();

			Console.WriteLine();
		}
	}
}
