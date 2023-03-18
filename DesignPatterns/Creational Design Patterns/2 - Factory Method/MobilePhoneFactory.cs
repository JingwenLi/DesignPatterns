using DesignPatterns.Before;

namespace DesignPatterns.FactoryMethod
{
	public class Client
	{
		public static void Run()
		{
			new XiaoMiFactory().CreateMobilePhone().Call();
			new HuaWeiFactory().CreateMobilePhone().Call();
		}
    }

    public interface IMobilePhoneFactory
    {
        MobilePhone CreateMobilePhone();
    }

    public class XiaoMiFactory : IMobilePhoneFactory
    {
        public MobilePhone CreateMobilePhone()
        {
            return new XiaoMiPhone();
        }
    }

    public class HuaWeiFactory : IMobilePhoneFactory
    {
        public MobilePhone CreateMobilePhone()
        {
            return new HuaWeiPhone();
        }
    }
}
