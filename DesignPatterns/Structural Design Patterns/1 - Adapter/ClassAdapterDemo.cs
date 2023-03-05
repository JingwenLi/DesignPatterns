using System;

namespace DesignPatterns.ClassAdapterDemo
{
	class Client
	{
		static void Main(string[] args)
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
