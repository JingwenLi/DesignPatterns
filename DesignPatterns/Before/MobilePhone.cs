using System;

namespace DesignPatterns
{
    public abstract class MobilePhone
    {
        public abstract string GetName();

        public void Call()
        {
            Console.WriteLine("Calling...");
        }
    }

    public class OppoPhone : MobilePhone
    {
         public override string GetName()
         {
             return "Oppo Phone";
         }
    }

    public class VivoPhone : MobilePhone
    {
        public override string GetName()
        {
            return "Vivo Phone";
        }
    }
}