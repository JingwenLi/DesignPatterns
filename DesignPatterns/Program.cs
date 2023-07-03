using DesignPatterns.Singleton;
using System;

namespace DesignPatterns
{
	// The Memento interface provides a way to retrieve the memento's metadata,
	// such as creation date or name. However, it doesn't expose the
	// Originator's state.
	public interface IMemento
	{
		string GetName();

		string GetState();

		DateTime GetDate();
	}

	// The Concrete Memento contains the infrastructure for storing the
	// Originator's state.
	class ConcreteMemento : IMemento
	{
		private string _state;

		private DateTime _date;

		public ConcreteMemento(string state)
		{
			this._state = state;
			this._date = DateTime.Now;
		}

		// The Originator uses this method when restoring its state.
		public string GetState()
		{
			return this._state;
		}

		// The rest of the methods are used by the Caretaker to display
		// metadata.
		public string GetName()
		{
			return $"{this._date} / ({this._state.Substring(0, 9)})...";
		}

		public DateTime GetDate()
		{
			return this._date;
		}
	}
}
