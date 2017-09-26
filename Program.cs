using System;

namespace Ch02_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:NO} to {int.MaxValue:NO}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:NO} to {double.MaxValue:NO}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:NO} to {decimal.MaxValue:NO}.");

            double a = 0.1M;
            double b = 0.2M;
            if (a + b == 0.3M) ;
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }
            Console.ReadLine();
        }
    }
}
