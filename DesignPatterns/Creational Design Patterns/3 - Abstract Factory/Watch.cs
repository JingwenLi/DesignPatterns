using System;

namespace DesignPatterns.AbstractFactory
{
    public abstract class Watch
    {
        public abstract string GetName();

        public void GetTime()
        {
            Console.WriteLine($"Current Time is {DateTime.Now} -- {GetName()}");
        }
    }

    public class XiaoMiWatch : Watch
    {
        public override string GetName()
        {
            return "Xiao Mi Watch";
        }
    }

    public class HuaWeiWatch : Watch
    {
        public override string GetName()
        {
            return "Hua Wei Watch";
        }
    }
}