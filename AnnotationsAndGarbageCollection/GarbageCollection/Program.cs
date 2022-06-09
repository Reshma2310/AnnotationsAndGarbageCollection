using System;
namespace GarbageCollection
{
    internal class Program
    {
        static void Main()
        {
            long mem1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[50000];//Allocate an Array and make it unreachable
                values = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                GC.Collect();//Collect Gargare
            }
            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }
        }
    }
}