namespace DesignPatterns.SimpleFactory
{
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
