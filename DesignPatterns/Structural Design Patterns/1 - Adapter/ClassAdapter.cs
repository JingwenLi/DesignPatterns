using System;

namespace DesignPatterns.ClassAdapter
{
	public class Client
	{
		public static void Run()
		{
			ITwoHoleTarget change = new ThreeToTwoAdapter();
			change.Request();
		}
	}

	public interface ITwoHoleTarget
	{
		void Request();
	}

	public abstract class ThreeHoleAdaptee
	{
		protected void SpecificRequest()
		{
			Console.WriteLine("使用三孔的插头");
		}
	}

	public class ThreeToTwoAdapter : ThreeHoleAdaptee, ITwoHoleTarget
	{
		public void Request()
		{
			this.SpecificRequest();
		}
	}
}
