using System;

// Task Description:
// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality.
// Input - You will receive exactly one line containing an integer number representation in binary.
// Output - On the only output line write the decimal representation of the number.
// Constraints - All input numbers will be valid 32-bit integers.

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            
            string numBinary = Console.ReadLine();

            long numDecimal = 0;

            for (int i = 0; i < numBinary.Length; i++)
            {
                if (numBinary[numBinary.Length - i - 1] == '1')
                {
                    numDecimal += (long)Math.Pow(2, i);
                }
            }

            Console.WriteLine(numDecimal);
        }
    }
}
