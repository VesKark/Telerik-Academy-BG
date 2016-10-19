using System;

// Task Description:
// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int x = 2;
            int y = -3;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(x + x);
            Console.WriteLine(y - x);
            Console.WriteLine(x + x + x);
            Console.WriteLine(y - x - x);
            Console.WriteLine(x + x + x + x);
            Console.WriteLine(y - x - x - x);
            Console.WriteLine(x + x + x + x + x);
            Console.WriteLine(y - x - x - x - x);
        }
    }
}
