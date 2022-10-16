namespace DesignPatterns
{
    public class MobilePhoneTest
    {
        public void TestCall(string name)
        {
            MobilePhone phone = null;
            if (name.Equals("XiaoMi"))
            {
                phone = new XiaoMiPhone();
            }
            else if (name.Equals("HuaWei"))
            {
                phone = new HuaWeiPhone();
            }

            phone?.Call();
        }
    }
}