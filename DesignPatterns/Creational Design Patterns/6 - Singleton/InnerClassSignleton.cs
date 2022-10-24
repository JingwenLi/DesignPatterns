using System;

namespace DesignPatterns.Singleton
{
    public class InnerClassSignleton
    {
        private InnerClassSignleton()
        {
        }

        private class InnerClassHolder
        {
            public static InnerClassSignleton instance = new InnerClassSignleton();
        }

        public static void HI()
        {
            Console.WriteLine("HI~");
        }

        public static InnerClassSignleton GetInstance()
		{
			return InnerClassHolder.instance;
		}
	}
}
