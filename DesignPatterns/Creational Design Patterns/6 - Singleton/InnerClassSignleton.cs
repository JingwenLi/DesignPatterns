using System;

namespace DesignPatterns.Singleton
{
	class InnerClassSignleton
    {
        private static class InnerClassHolder
        {
            public static InnerClassSignleton instance = new InnerClassSignleton();
        }

        private InnerClassSignleton()
        {
            if (InnerClassHolder.instance != null)
            {
                throw new Exception("单例模式不允许多个实例");
            }
        }

        public static InnerClassSignleton getInstance()
        {
            return InnerClassHolder.instance;
        }
    }
}
