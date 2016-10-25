using System;

// Task Description:
// Write a program that reads two positive integer numbers N and M and prints how many numbers exist between them such that
// the reminder of the division by 5 is 0.
// Constraints - (0 <= N <= M <= 2000).

namespace Interval
{
    class Interval
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int count = 0;

            if (numberN >= 0 && numberN <= numberM && numberM <= 2000)
            {
                for (int i = numberN + 1; i < numberM; i++)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                    }                    
                }
                Console.WriteLine(count);
            }
        }
    }
}
