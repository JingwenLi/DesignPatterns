using DesignPatterns.SimpleFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns
{
    public class MobilePhoneTest
    {
        [TestClass]
        public class SimpleFactoryTest
        {
            [TestMethod]
            public void TestCall()
            {
                new XiaoMiPhone().Call();
                new HuaWeiPhone().Call();
            }
        }
    }
}