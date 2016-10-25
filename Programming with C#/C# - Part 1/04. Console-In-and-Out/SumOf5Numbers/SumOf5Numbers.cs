using System;

// Task Description:
// Write a program that reads 5 integer numbers from the console and prints their sum.
// All 5 numbers will always be valid integer numbers between -1000 and 1000, inclusive.

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }
    }
}
