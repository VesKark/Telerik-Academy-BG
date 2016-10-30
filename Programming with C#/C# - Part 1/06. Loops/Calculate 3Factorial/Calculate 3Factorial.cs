using System;
using System.Numerics;

// Task Description:
// In combinatorics, the number of ways to choose N different members out of a group of N different elements (also known as
// the number of combinations) is calculated by the following formula: (N / K) = N! / (K! * (N - K)!)
// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program
// that calculates N! / (K! * (N - K)!) for given N and K. Try to use only two loops.

// Input:
// On the first line, there will be only one number - N.
// On the second line, there will also be only one number - K.

// Output:
// On the only output line, write the result of the calculation for the provided N and K.

// Constraints: (1 < K < N < 100); Hint: overflow is possible.

namespace Calculate_3Factorial
{
    class Program
    {
        static void Main()
        {
            BigInteger numN = BigInteger.Parse(Console.ReadLine());
            BigInteger numK = BigInteger.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger diff = numN - numK;

            while (numN - numK >= 1)
            {
                nFactorial *= numN;
                numN--;
            }

            while (diff >= 1)
            {
                kFactorial *= diff;
                diff--;     
            }

            Console.WriteLine(nFactorial / kFactorial);
        }
    }
}
