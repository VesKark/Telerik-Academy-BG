using System;

// Task Description:
// Write a program that first reads 4 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n.
// Print the resulting integer on the console.
// Output - a single value - the value of n after the bit swaps.
// Constraints - the first and the second sequence of bits will never overlap.
//  n will always be a valid 32-bit positive integer.
//  p, q >= 0
//  p+k-1, q+k-1 < 32

namespace BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            uint numberN = uint.Parse(Console.ReadLine());
            int positionP = int.Parse(Console.ReadLine());
            int positionQ = int.Parse(Console.ReadLine());
            int numberK = int.Parse(Console.ReadLine());

            for (int i = positionP; i < positionP + numberK; i++)
            {
                uint mask1 = (uint)1 << i;
                uint mask2 = mask1 & numberN;
                uint bit = mask2 >> i;

                uint mask3 = (uint)1 << positionQ;
                uint mask4 = mask3 & numberN;
                uint bit1 = mask4 >> positionQ;

                if (bit == 0)
                {
                    uint mask5 = (uint)~(1 << positionQ);
                    numberN = mask5 & numberN;
                    if (bit != bit1)
                    {
                        uint mask6 = (uint)1 << i;
                        numberN = mask6 | numberN;
                    }
                }
                else if (bit == 1)
                {
                    uint mask7 = (uint)1 << positionQ;
                    numberN = mask7 | numberN;
                    if (bit != bit1)
                    {
                        uint mask8 = (uint)~(1 << i);
                        numberN = mask8 & numberN;
                    }
                }
                positionQ++;
            }
            Console.WriteLine(numberN);
        }
    }
}