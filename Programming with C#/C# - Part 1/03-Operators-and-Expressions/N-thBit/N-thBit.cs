using System;

// Task Description:
// Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.
// Input - On the first line you will receive the number P. On the second line you will receive the number N.
// Output is a single value - the value of the N-th bit in P.
// Constraints - N will be a positive integer and always smaller than 55. P will be: 0 <= P <= 2^55.

namespace N_thBit
{
    class Program
    {
        static void Main()
        {
            ulong p = ulong.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            int position = n;
            int mask = 1 << position;
            ulong maskUlong = (ulong)mask;

            ulong maskAndP = p & maskUlong;
            ulong bit = maskAndP >> position;

            Console.WriteLine(bit);
        }
    }
}
