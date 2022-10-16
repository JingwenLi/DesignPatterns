using System;

namespace DesignPatterns.Singleton
{
    class InnerClassSignleton
    {
        private InnerClassSignleton()
        {
        }
        
        private static class InnerClassHolder
        {
            public static InnerClassSignleton instance = new InnerClassSignleton();
        }

        public static InnerClassSignleton GetInstance()
        {
            return InnerClassHolder.instance;
        }
    }
}
