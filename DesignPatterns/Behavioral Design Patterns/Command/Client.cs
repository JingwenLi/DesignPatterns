using System;
using System.Collections.Generic;

namespace DesignPatterns.Command
{
	internal class Client
	{
		public static void Run()
		{
			// The client code can parameterize an invoker with any commands.
			Invoker invoker = new Invoker();
			invoker.SetOnStart(new SimpleCommand("Say Hi!"));
			Receiver receiver = new Receiver();
			invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

			invoker.DoSomethingImportant();
		}
	}
}
