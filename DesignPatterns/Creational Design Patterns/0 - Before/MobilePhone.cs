using System;

namespace DesignPatterns
{
    public abstract class MobilePhone
    {
        public abstract string GetName();

        public void Call()
        {
            Console.WriteLine($"Call with {GetName()}");
        }
    }

    public class XiaoMiPhone : MobilePhone
    {
         public override string GetName()
         {
             return "Xiao Mi Phone";
         }
    }

    public class HuaWeiPhone : MobilePhone
    {
        public override string GetName()
        {
            return "Hua Wei Phone";
        }
    }
}