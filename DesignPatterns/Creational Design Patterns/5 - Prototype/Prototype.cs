using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Prototype
{
	public class Client
	{
		public static void Run()
		{
			RunShallowClone();
			RunDeepClone();
		}

		static void RunShallowClone()
		{
			var obj = new ShallowClone(new int[] { 1, 2, 3, 4, 5 });
			var obj1 = obj.Clone();
			var obj2 = obj.Clone();

			obj.myValue[0] = 6;

			Console.WriteLine(obj1.myValue[0]);
			Console.WriteLine(obj2.myValue[0]);
		}

        static void RunDeepClone()
		{
			var obj = new DeepClone(new int[] { 1, 2, 3, 4, 5 });
			var obj1 = obj.Clone();
			var obj2 = obj.Clone();

			obj.myValue[0] = 6;

			Console.WriteLine(obj1.myValue[0]);
			Console.WriteLine(obj2.myValue[0]);
		}
    }

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
