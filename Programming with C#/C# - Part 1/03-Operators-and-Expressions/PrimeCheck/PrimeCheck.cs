using System;

// Task Description:
// Write a program that reads an integer N (which will always be less than 100 or equal) and uses an expression
// to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
// Output true if the number is prime and false otherwise.

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            if (n < 0)
            {
                count++;
            }

            for (int i = 2; i < 101; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count > 1 ? "false" : "true");
        }
    }
}