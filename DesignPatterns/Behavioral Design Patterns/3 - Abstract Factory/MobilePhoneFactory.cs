namespace DesignPatterns.AbstractFactory
{
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
