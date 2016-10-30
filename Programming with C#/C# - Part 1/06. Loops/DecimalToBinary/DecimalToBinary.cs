using System;

// Task Description:
// Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality!
// Input - On the only input line you will receive the decimal integer number.
// Output - Output a single string - the representation of the input decimal number in it's binary representation.
// Constraints - All numbers will always be valid 32-bit integers.

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            int numDecimal = int.Parse(Console.ReadLine());
            int reminder;
            string numBinary = string.Empty;

            while (numDecimal > 0)
            {
                reminder = numDecimal % 2;
                numDecimal /= 2;
                numBinary = reminder.ToString() + numBinary;
            }

            Console.WriteLine(numBinary);
        }
    }
}
