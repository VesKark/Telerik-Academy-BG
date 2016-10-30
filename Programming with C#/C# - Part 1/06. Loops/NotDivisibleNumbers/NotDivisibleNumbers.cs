using System;

// Task Description:
// Write a program that reads from the console a positive integer N and prints all the numbers from 1 to N not divisible by 3 or 7,
// on a single line, separated by a space.
// Constraints - (1 < N< 1500).

namespace NotDivisibleNumbers
{
    class NotDivisibleNumbers
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());

            for (int n = 1; n <= numberN; n++)
            {
                if (n % 3 != 0 && n % 7 != 0)
                {
                    Console.Write(n + " ");
                }               
            }
        }
    }
}
