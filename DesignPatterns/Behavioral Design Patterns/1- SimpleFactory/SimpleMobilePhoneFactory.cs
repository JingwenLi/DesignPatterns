namespace DesignPatterns.SimpleFactory
{
    public class SimpleMobilePhoneFactory
    {
        public MobilePhone CreateMobilePhone(string name)
        {
            if (name.Equals("Vivo"))
            {
                return new VivoPhone();
            }
            else if (name.Equals("Oppo"))
            {
                return new OppoPhone();
            }

            return null;
        }
    }
}
