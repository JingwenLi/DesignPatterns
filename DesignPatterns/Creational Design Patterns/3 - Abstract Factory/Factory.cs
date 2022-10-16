namespace DesignPatterns.AbstractFactory
{
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
