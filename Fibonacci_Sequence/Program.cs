using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatingFibonacciSequence();
        }

        public static void CalculatingFibonacciSequence()
        {
            var fibonacciList = new ArrayList();
            int fib1 = 1;
            int fib2 = 0;
            int fibonacciLimit;
            int i = 0;

            Console.WriteLine("Int Fibonacci limit:");
            fibonacciLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            while (i < fibonacciLimit)
            {
                int fibTemp = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibTemp;
                i += 1;
                fibonacciList.Add(fib2);
                Console.WriteLine($"{fib2}");
            }
            Console.WriteLine(" ");
            FibonacciSum(fibonacciList);
            
        }

        public static void FibonacciSum(IEnumerable myList) 
        {
            int sum = 0;
            foreach (int i in myList)
            {
                sum = sum + i;
                SaveInFile("", i);
            }
            Console.WriteLine($"Fibonacci sum: {sum}");
            SaveInFile("Fibonacci sum: ", sum);
        }

        public static void SaveInFile(string name, int text)
        {
            string path = @"C:\Users\Michael\source\repos\Fibonacci_Sequence\Fibonacci_Sequence\SaveForAsya.txt";

            string appendText = name + text + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
        }
    }
}
