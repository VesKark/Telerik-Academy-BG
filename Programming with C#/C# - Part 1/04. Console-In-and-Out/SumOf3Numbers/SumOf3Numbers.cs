using System;

// Task Description:
// Write a program that reads 3 real numbers (a, b, c) from the console and prints their sum.
// Constraints - a, b and c will always be valid real numbers between -1000 and 1000, inclusive.

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double sum = a + b + c;
            Console.WriteLine(sum);
        }
    }
}
