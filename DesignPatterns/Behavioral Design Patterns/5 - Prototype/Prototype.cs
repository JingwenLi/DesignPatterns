using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Prototype
{
    [Serializable]
    public abstract class PrototypeClass
    {
        public string myValue;

        public string MyValue
        {
            get { return myValue; }
            set { myValue = value; }
        }
        public abstract PrototypeClass Clone();
    }

    //浅拷贝
    public class ShallowClone : PrototypeClass
    {
        public ShallowClone(string value)
        {
            this.myValue = value;
        }

        public override PrototypeClass Clone()
        {
            return (PrototypeClass)this.MemberwiseClone();
        }
    }

    //深拷贝
    [Serializable]
    public class DeepClone : PrototypeClass
    {
        public DeepClone(string value)
        {
            this.myValue = value;
        }

        public override PrototypeClass Clone()
        {
            PrototypeClass deepObject;
            var memoryStream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(memoryStream, this);
            memoryStream.Position = 0;
            deepObject = (PrototypeClass)formatter.Deserialize(memoryStream);

            return deepObject;
        }
    }
}
