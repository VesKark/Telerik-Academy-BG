using System;

// Task Description:
// Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x^2 + … + N!/x^N.
// Use only one loop. Print the result with 5 digits after the decimal point.

// Input:
// On the first line you will receive one number - N.
// On the second line you will receive another number - x.

// Output:
// Output only one number - the sum of the sequence for the given N and x.

// Constraints:
// N will always be a valid integer between 2 and 10, inclusive.
// X will always be a valid floating-point number between 0.5 and 100.

namespace CalculateFactorial
{
    class CalculateFactorial
    {
        static void Main()
        {

            ulong numN = ulong.Parse(Console.ReadLine());
            double numX = double.Parse(Console.ReadLine());
            ulong factorial = 1;
            double sum = 1 + 1 / numX;

            for (ulong counter = 2; counter <= numN; counter++)
            {
                factorial = factorial * counter;
                double pow = Math.Pow(numX, counter);
                sum = sum + (factorial / pow);
            }

            Console.WriteLine("{0:F5}", sum);           
        }
    }
}
