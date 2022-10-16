namespace DesignPatterns.FactoryMethod
{
	public class MobilePhoneTest
    {
        public void Call()
        {
            new VivoPhoneFactory().CreateMobilePhone().Call();
            new OppoPhoneFactory().CreateMobilePhone().Call();
        }
    }
}
