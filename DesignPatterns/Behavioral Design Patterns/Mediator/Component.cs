using System;

namespace DesignPatterns.Mediator
{
	// The Base Component provides the basic functionality of storing a
	// mediator's instance inside component objects.
	class BaseComponent
	{
		protected IMediator _mediator;

		public BaseComponent(IMediator mediator = null)
		{
			this._mediator = mediator;
		}

		public void SetMediator(IMediator mediator)
		{
			this._mediator = mediator;
		}
	}

	// Concrete Components implement various functionality. They don't depend on
	// other components. They also don't depend on any concrete mediator
	// classes.
	class Component1 : BaseComponent
	{
		public void DoA()
		{
			Console.WriteLine("Component 1 does A.");

			this._mediator.Notify(this, "A");
		}

		public void DoB()
		{
			Console.WriteLine("Component 1 does B.");

			this._mediator.Notify(this, "B");
		}
	}

	class Component2 : BaseComponent
	{
		public void DoC()
		{
			Console.WriteLine("Component 2 does C.");

			this._mediator.Notify(this, "C");
		}

		public void DoD()
		{
			Console.WriteLine("Component 2 does D.");

			this._mediator.Notify(this, "D");
		}
	}
}
