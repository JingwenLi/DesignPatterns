namespace DesignPatterns.SimpleFactory
{
    public class MobilePhoneTest
    {
        public void Call(string type)
        {
            var factory = new SimpleMobilePhoneFactory();
            factory.CreateMobilePhone("Vivo").Call();
            factory.CreateMobilePhone("Oppo").Call();
        }
    }
}