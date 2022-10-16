﻿namespace DesignPatterns
{
    public class MobilePhoneTest
    {
        public void Call(string name)
        {
            MobilePhone phone = null;
            if (name.Equals("Vivo"))
            {
                phone = new VivoPhone();
            }
            else if (name.Equals("Oppo"))
            {
                phone = new OppoPhone();
            }

            phone?.Call();
        }
    }
}