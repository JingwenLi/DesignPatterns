using DesignPatterns.Before;

namespace DesignPatterns.SimpleFactory
{
	public class Client
	{
		public static void Run()
		{
			var factory = new SimpleMobilePhoneFactory();
			factory.CreateMobilePhone("XiaoMi").Call();
			factory.CreateMobilePhone("HuaWei").Call();
		}
    }

    public class SimpleMobilePhoneFactory
    {
        public MobilePhone CreateMobilePhone(string name)
        {
            if (name.Equals("XiaoMi"))
            {
                return new XiaoMiPhone();
            }
            else if (name.Equals("HuaWei"))
            {
                return new HuaWeiPhone();
            }

            return null;
        }
    }
}
