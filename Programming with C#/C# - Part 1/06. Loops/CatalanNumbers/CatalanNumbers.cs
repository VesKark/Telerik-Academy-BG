using System;
using System.Numerics;

// Task Description:
// In combinatorics, the Catalan numbers are calculated by specific formula: C = (2 * N)! / ((N + 1)! * N!)
// Write a program to calculate the N-th Catalan number by given N.

// Input - On the only line, you will receive the number N.
// Output - the N-th Catalan number.
// Constraints - N will always be a valid integer number in the range [0, 100]; Hint: overflow is possible.


namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            BigInteger numN = BigInteger.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;

            BigInteger numN1 = numN + 1;
            BigInteger n1Factorial = 1;

            BigInteger numN2 = numN * 2;
            BigInteger n2Factorial = 1;

            while (numN >= 1)
            {
                nFactorial *= numN;
                numN--;
            }

            while (numN1 >= 1)
            {
                n1Factorial *= numN1;
                numN1--;
            }

            while (numN2 >= 1)
            {
                n2Factorial *= numN2;
                numN2--;
            }

            Console.WriteLine(n2Factorial / (n1Factorial * nFactorial));
        }
    }
}
