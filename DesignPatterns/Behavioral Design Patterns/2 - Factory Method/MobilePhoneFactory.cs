namespace DesignPatterns.FactoryMethod
{
	public interface IMobilePhoneFactory
    {
        MobilePhone CreateMobilePhone();
    }

    public class VivoPhoneFactory : IMobilePhoneFactory
    {
        public MobilePhone CreateMobilePhone()
        {
            return new VivoPhone();
        }
    }

    public class OppoPhoneFactory : IMobilePhoneFactory
    {
        public MobilePhone CreateMobilePhone()
        {
            return new OppoPhone();
        }
    }
}
