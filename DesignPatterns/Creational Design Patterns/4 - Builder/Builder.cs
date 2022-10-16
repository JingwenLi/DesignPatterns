using System;

namespace DesignPatterns.Builder
{
	public abstract class Builder
    {
        protected Computer computer = new Computer();

        public abstract void BuildCPU();
        public abstract void BuildMemory();
        public abstract void BuildDisk();
        public abstract void BuildGraphicsCard();
        public abstract void BuildMainBoard();

        public Computer GetComputer()
        {
            return computer;
        }
    }

    public class CostEffectiveBuilder : Builder
    {
        public override void BuildCPU()
        {
            computer.CPU = "i5处理器";
            Console.WriteLine("i5处理器");
        }

        public override void BuildDisk()
        {
            computer.Disk = "512G固态";
            Console.WriteLine("512G固态");
        }

        public override void BuildGraphicsCard()
        {
            computer.GraphicsCard = "RTX 3050";
            Console.WriteLine("RTX 3050");
        }

        public override void BuildMainBoard()
        {
            computer.MainBoard = "联想主板";
            Console.WriteLine("联想主板");
        }

        public override void BuildMemory()
        {
            computer.Memory = "16G内存";
            Console.WriteLine("16G内存");
        }
    }

    public class HighPerformanceBuilder : Builder
    {
        public override void BuildCPU()
        {
            computer.CPU = "i7处理器";
            Console.WriteLine("i7处理器");
        }

        public override void BuildDisk()
        {
            computer.Disk = "i7处理器";
            Console.WriteLine("1T固态");
        }

        public override void BuildGraphicsCard()
        {
            computer.GraphicsCard = "RTX 3090";
            Console.WriteLine("RTX 3090");
        }

        public override void BuildMainBoard()
        {
            computer.MainBoard = "联想主板";
            Console.WriteLine("联想主板");
        }

        public override void BuildMemory()
        {
            computer.Memory = "32G内存";
            Console.WriteLine("32G内存");
        }
    }
}
