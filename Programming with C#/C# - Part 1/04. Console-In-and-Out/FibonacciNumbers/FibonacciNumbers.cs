using System;

// Task Description:
// Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence
// (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
// Constraints - (1 <= N <= 50); N will always be a valid positive integer number.

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            ulong numberN = ulong.Parse(Console.ReadLine());
            ulong[] fibNumbers = new ulong[numberN + 1];
            fibNumbers[0] = 0;
            fibNumbers[1] = 1;

            if (numberN >= 1 && numberN <= 50)
            {
                if (numberN > 1)
                for (ulong i = 2; i < numberN; i++)
                {
                    fibNumbers[1] = 1;
                    fibNumbers[i] = fibNumbers[i - 2] + fibNumbers[i - 1];
                }

                for (ulong i = 0; i < numberN; i++)
                {
                    Console.Write(fibNumbers[i]);
                    if (i >= 0 && i < numberN - 1)
                    {
                        Console.Write(", ");
                    }
                }                
                Console.WriteLine();
            }
        }
    }
}