using System;
using System.Numerics;

// Task Description:
// Write a program that calculates N! / K! for given N and K. Use only one loop.

// Input:
// On the first line, there will be only one number - N.
// On the second line, there will be only one number - K.

// Output:
// Output a single line, consisting of the result from the calculation described above.

// Constraints: (1 < K < N < 100); N and K will always be valid integer numbers; Hint: overflow is possible.

namespace CalculateFactorialAgain
{
    class CalculateFactorialAgain
    {
        static void Main()
        {

            BigInteger numN = BigInteger.Parse(Console.ReadLine());
            BigInteger numK = BigInteger.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            
            while (numN - numK >= 1)
            {
                nFactorial *= numN;
                numN--;
            }

            Console.WriteLine( (nFactorial));            
        }

    }

}

