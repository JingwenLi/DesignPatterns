namespace DesignPatterns.SimpleFactory
{
    public class MobilePhoneTest
    {
        public void Call(string type)
        {
            var factory = new SimpleMobilePhoneFactory();
            factory.CreateMobilePhone(type).Call();
        }
    }
}