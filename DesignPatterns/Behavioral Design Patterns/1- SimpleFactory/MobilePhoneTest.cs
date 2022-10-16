namespace DesignPatterns.SimpleFactory
{
    public class MobilePhoneTest
    {
        public void Call(string type)
        {
            var factory = new SimpleMobilePhoneFactory();
            var phone = factory.CreateMobilePhone(type);

            phone?.Call();
        }
    }
}