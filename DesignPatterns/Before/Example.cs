using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Before
{
	internal class Example
	{
		public static void Run()
		{
			CoffeeStore store = new CoffeeStore();
			store.OrderCoffee("American");
		}
	}
}
