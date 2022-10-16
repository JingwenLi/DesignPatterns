namespace DesignPatterns.AbstractFactory
{
	public class MobilePhoneTest
    {
        public void TestCall(IMobilePhoneFactory factory)
        {
            factory.CreateMobilePhone().Call();
        }
    }
}
