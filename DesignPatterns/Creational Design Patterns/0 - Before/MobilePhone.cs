using System;

namespace DesignPatterns.Before
{

	public class Client
	{
		public static void Run()
		{
			new XiaoMiPhone().Call();
			new HuaWeiPhone().Call();
		}
    }

    public abstract class MobilePhone
    {
        public abstract string GetName();

        public void Call()
        {
            Console.WriteLine($"Call with {GetName()}");
        }
    }

    public class XiaoMiPhone : MobilePhone
    {
         public override string GetName()
         {
             return "Xiao Mi Phone";
         }
    }

    public class HuaWeiPhone : MobilePhone
    {
        public override string GetName()
        {
            return "Hua Wei Phone";
        }
    }
}