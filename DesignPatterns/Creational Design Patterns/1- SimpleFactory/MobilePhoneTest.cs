namespace DesignPatterns.SimpleFactory
{
    public class MobilePhoneTest
    {
        public void TestCall(string type)
        {
            var factory = new SimpleMobilePhoneFactory();
            factory.CreateMobilePhone(type).Call();
        }
    }
}