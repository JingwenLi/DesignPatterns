using System;

namespace DesignPatterns.Singleton
{
	public class HungrySingleton
    {
        private static readonly HungrySingleton instance = new HungrySingleton();

        private HungrySingleton()
        {
        }

        public static void HI()
        {
            Console.WriteLine("HI~");
        }

        public static HungrySingleton GetInstance()
		{
			return instance;
		}
	}
}
