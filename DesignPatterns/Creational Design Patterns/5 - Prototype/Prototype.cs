using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Prototype
{
    [Serializable]
    public abstract class PrototypeClass
    {
        public int[] myValue;

        public int[] MyValue
        {
            get { return myValue; }
            set { myValue = value; }
        }
        public abstract PrototypeClass Clone();
    }

    public class ShallowClone : PrototypeClass
    {
        public ShallowClone(int[] value)
        {
            myValue = value;
        }

        public override PrototypeClass Clone()
        {
            return (PrototypeClass)this.MemberwiseClone();
        }
    }

    [Serializable]
    public class DeepClone : PrototypeClass
    {
        public DeepClone(int[] value)
        {
            myValue = value;
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
