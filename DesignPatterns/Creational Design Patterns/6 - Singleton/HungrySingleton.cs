namespace DesignPatterns.Singleton
{
	public class HungrySingleton
    {
        private static readonly HungrySingleton instance = new HungrySingleton();

        private HungrySingleton()
        {
        }

        public static HungrySingleton GetInstance()
        {
            return instance;
        }
    }
}
