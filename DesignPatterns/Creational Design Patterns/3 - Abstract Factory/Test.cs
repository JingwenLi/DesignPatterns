namespace DesignPatterns.AbstractFactory
{
	public class Test
    {
        public void TestCall(IFactory factory)
        {
            factory.CreateMobilePhone().Call();
        }

        public void TestGetTime(IFactory factory)
        {
            factory.CreateWatch().GetTime();
        }
    }
}
