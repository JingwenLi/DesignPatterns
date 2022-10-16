using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Design_Patterns._6___Singleton
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
