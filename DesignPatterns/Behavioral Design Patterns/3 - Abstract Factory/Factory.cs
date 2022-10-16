﻿namespace DesignPatterns.AbstractFactory
{
    //有的时候，我们要创建一些相关联的或依赖的一族对象，这个时候可以把创建这些对象用抽象工厂来实现，而不是用工厂方法模式来实现，
    //(如果用工厂方法模式来实现，一个抽象产品对应一个抽象工厂，那样的情况叫做“类型爆炸”)
    public interface IFactory
    {
        MobilePhone CreateMobilePhone();
        Watch CreateWatch();
    }

    public class XiaoMiFactory : IFactory
    {
        public MobilePhone CreateMobilePhone()
        {
            return new XiaoMiPhone();
        }

        public Watch CreateWatch()
        {
            return new XiaoMiWatch();
        }
    }

    public class HuaWeiFactory : IFactory
    {
        public MobilePhone CreateMobilePhone()
        {
            return new HuaWeiPhone();
        }

        public Watch CreateWatch()
        {
            return new HuaWeiWatch();
        }
    }
}
