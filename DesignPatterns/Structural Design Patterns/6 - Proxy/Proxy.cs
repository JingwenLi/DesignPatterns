using System;

namespace DesignPatterns.Proxy
{
	static void Main(string[] args)
	{
		var girl = new Girl("如花");
		var boy = new Boy("阿强");
		var proxy = new Proxy(boy, girl);
		proxy.GiveFlower();
		Console.ReadLine();
	}

	interface IGivegifts
	{
		void GiveFlower();
	}

	public class Girl
	{
		public string name;
		public Girl(string name)
		{
			this.name = name;
		}
	}

	public class Boy : IGivegifts
	{
		public string name;
		public Boy(string name)
		{
			this.name = name;
		}
		public void GiveFlower()
		{
			Console.WriteLine($"{name} give you flower");
		}
	}

	public class Proxy : IGivegifts
	{
		private Boy boy;
		private Girl girl;

		public Proxy(Boy boy, Girl girl)
		{
			boy = boy;
			girl = girl;
		}

		public void GiveFlower()
		{
			Console.WriteLine($"Dear {girl.name}");
			boy.GiveFlower();
		}
	}
}
