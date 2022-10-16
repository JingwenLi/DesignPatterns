namespace DesignPatterns.FactoryMethod
{
	public class MobilePhoneTest
    {
        public void Call(IMobilePhoneFactory factory)
        {
            factory.CreateMobilePhone().Call();
        }
    }
}
