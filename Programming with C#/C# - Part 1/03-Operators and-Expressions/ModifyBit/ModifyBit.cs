using System;

// Task Description:
// We are given an integer number N (read from the console), a bit value V (read from the console as well: v = 0 or 1) and
// a position P (read from the console). Write a sequence of operators that modifies N to hold the value V at the position P
// from the binary representation of N while preserving all other bits in N.
// Print the resulting number on the console.
// Output a single line containing the value of the number N with the modified bit.
// Constraints:
//    N will always be a valid 64-bit unsigned integer.
//    P will always be between in the range (0, 64).
//    V will be always either 0 or 1.

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            ulong numberN = ulong.Parse(Console.ReadLine());
            int positionP = int.Parse(Console.ReadLine());
            byte bitValue = byte.Parse(Console.ReadLine());

            if (positionP > 0 && positionP < 65 && bitValue == 0)
            {
                ulong mask = (ulong)~(1 << positionP);
                numberN = mask & numberN;
                Console.WriteLine(numberN);
            }

            else if (positionP > 0 && positionP < 65 && bitValue == 1)
            {
                ulong mask = (ulong)1 << positionP;
                numberN = mask | numberN;
                Console.WriteLine(numberN);
            }

        }
    }
}