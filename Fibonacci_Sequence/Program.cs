using System;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int fib1 = 1;
            int fib2 = 0;
            int n;

            Console.WriteLine("Fib n");
            n = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            while (i < n)
            {
                int fib_sum = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib_sum;
                i = i + 1;
                Console.WriteLine($"{fib2}");
            }
            //Console.WriteLine(fib2);
        }
    }
}
