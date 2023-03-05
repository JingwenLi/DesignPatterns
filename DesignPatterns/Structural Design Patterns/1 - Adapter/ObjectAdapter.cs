using System;

namespace DesignPatterns.ObjectAdapter
{
	class Client
	{
		static void Main(string[] args)
		{
			TwoHoleTarget homeTwoHole = new ThreeToTwoAdapter();
			homeTwoHole.Request();
		}
	}

	public class TwoHoleTarget
	{
		public virtual void Request()
		{
			Console.WriteLine("使用两孔的插头");
		}
	}

	public class ThreeHoleAdaptee
	{
		public void SpecificRequest()
		{
			Console.WriteLine("使用三孔的插头");
		}
	}

	public class ThreeToTwoAdapter : TwoHoleTarget
	{
		private ThreeHoleAdaptee threeHoleAdaptee = new ThreeHoleAdaptee();

		public override void Request()
		{
			threeHoleAdaptee.SpecificRequest();
		}
	}
}
