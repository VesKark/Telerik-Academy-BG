using System;
using System.Numerics;

// Task Description:
// Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
// Your program should work well for very big numbers, e.g.N = 100000.
// Input - On the only input line, you will receive a single integer - the number N.
// Output - Output a single number - the count of trailing zeroes for the N!
// Constraints - N will always be a valid positive integer number.

namespace TrailingZeroNfactorial
{
    class TrailingZeroNfactorial
    {
        static void Main()
        {
            // Variant 01 (slower):

            BigInteger numN = BigInteger.Parse(Console.ReadLine());
            BigInteger product = 1;

            for (BigInteger i = 1; i <= numN; i++)
            {
                product *= i;                
            }
                     
            int counter = 0;
            while (product % 10 == 0)
            {
                counter++;
                product /= 10;
            }
            
            Console.WriteLine(counter);

            // Variant 02 (faster):

            int numberN = int.Parse(Console.ReadLine());

            int counterZeroes = 0;

            if (numberN == 5)
            {
                counterZeroes = 1;
            }

            else
            {
                for (int i = 5; numberN / i >= 1; i *= 5)
                {
                    counterZeroes += numberN / i;
                }
            }

            Console.WriteLine(counterZeroes);
        }
    }
}
