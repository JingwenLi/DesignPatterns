using DesignPatterns.Builder;
using System;

namespace DesignPatterns.Builder
{
	public class Test
    {
        static void TestComputer(string[] args)
        {
            Console.WriteLine("===============高性能电脑==================");
            var highPerformanceBuilder = new HighPerformanceBuilder();
            showComputer(highPerformanceBuilder);


            Console.WriteLine("===============高性价比电脑==================");
            var costEffectiveBuilder = new CostEffectiveBuilder();
            showComputer(costEffectiveBuilder);
        }

        private static void showComputer(Builder builder)
        {
            var director = new Director(builder);
            var computer = director.AssembleComputer();
            Console.WriteLine($"CPU为   {computer.CPU}");
            Console.WriteLine($"内存为  {computer.Memory}");
        }
    }
}
