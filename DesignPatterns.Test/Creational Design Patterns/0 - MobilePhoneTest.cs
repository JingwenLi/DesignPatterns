using DesignPatterns.SimpleFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns
{
    [TestClass]
    public class MobilePhoneTest
    {
        [TestMethod]
        public void TestCall()
        {
            new XiaoMiPhone().Call();
            new HuaWeiPhone().Call();
        }
    }
}