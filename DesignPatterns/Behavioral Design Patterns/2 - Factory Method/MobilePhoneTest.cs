namespace DesignPatterns.FactoryMethod
{
	public class MobilePhoneTest
    {
        public void Call()
        {
            var factory = new VivoPhoneFactory();
            var phone = factory.CreateMobilePhone();

            phone?.Call();
        }
    }
}
