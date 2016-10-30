using System;

// Task Description:
// Write a program that enters from the console a positive integer N and prints all the numbers from 1 to N inclusive,
// on a single line, separated by a whitespace.

namespace Numbers1toN
{
    class Numbers1toN
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());

            for (int n = 1; n <= numberN; n++)
            {
                Console.Write(n + " ");
            }
        }
    }
}
