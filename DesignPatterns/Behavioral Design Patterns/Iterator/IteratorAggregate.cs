﻿using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
	abstract class IteratorAggregate : IEnumerable
	{
		// Returns an Iterator or another IteratorAggregate for the implementing
		// object.
		public abstract IEnumerator GetEnumerator();
	}

	// Concrete Collections provide one or several methods for retrieving fresh
	// iterator instances, compatible with the collection class.
	class WordsCollection : IteratorAggregate
	{
		List<string> _collection = new List<string>();

		bool _direction = false;

		public void ReverseDirection()
		{
			_direction = !_direction;
		}

		public List<string> getItems()
		{
			return _collection;
		}

		public void AddItem(string item)
		{
			this._collection.Add(item);
		}

		public override IEnumerator GetEnumerator()
		{
			return new AlphabeticalOrderIterator(this, _direction);
		}
	}
}
