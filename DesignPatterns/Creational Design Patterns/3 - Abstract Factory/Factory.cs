using DesignPatterns.Before;

namespace DesignPatterns.AbstractFactory
{
	public class Client
	{
		public static void Run()
		{
			new XiaoMiFactory().CreateMobilePhone().Call();
			new HuaWeiFactory().CreateMobilePhone().Call();

			new XiaoMiFactory().CreateWatch().GetTime();
			new HuaWeiFactory().CreateWatch().GetTime();
		}
    }

    public interface IFactory
    {
        MobilePhone CreateMobilePhone();
        Watch CreateWatch();
    }

    public class XiaoMiFactory : IFactory
    {
        public MobilePhone CreateMobilePhone()
        {
            return new XiaoMiPhone();
        }

        public Watch CreateWatch()
        {
            return new XiaoMiWatch();
        }
    }

    public class HuaWeiFactory : IFactory
    {
        public MobilePhone CreateMobilePhone()
        {
            return new HuaWeiPhone();
        }

        public Watch CreateWatch()
        {
            return new HuaWeiWatch();
        }
    }
}
