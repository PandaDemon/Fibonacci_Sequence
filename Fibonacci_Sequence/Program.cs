using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Fibonacci_Sequence
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            CalculatingFibonacciSequence();
        }

        public static void CalculatingFibonacciSequence()
        {
            var fib_list = new ArrayList();
            int fib1 = 1;
            int fib2 = 0;
            int nth;
            int i = 0;

            Console.WriteLine("Int Fibonacci limit:");
            nth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            while (i < nth)
            {
                int fib_temp = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib_temp;
                i = i + 1;
                fib_list.Add(fib2);
                Console.WriteLine($"{fib2}");
            }
            Console.WriteLine(" ");
            FibonacciSum(fib_list);
            
        }

        public static void FibonacciSum(IEnumerable my_ist) 
        {
            int sum = 0;
            foreach (int i in my_ist)
            {
                sum = sum + i;
                SaveInFile(i);
            }
            Console.WriteLine($"Fibonacci sum: {sum}");
            SaveInFile(sum);
        }

        public static void SaveInFile(int i)
        {
            string path = @"C:\Users\Michael\source\repos\Fibonacci_Sequence\Fibonacci_Sequence\SaveForAsya.txt";
            
            if (!File.Exists(path))
            {
                string createText = i + Environment.NewLine;
                File.WriteAllText(path, createText, Encoding.UTF8);
            }

            string appendText = i + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
        }
    }
}
