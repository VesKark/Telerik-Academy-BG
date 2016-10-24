using System;

// Task Description:
// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer (read from the console).
// Input - On the only input line you will receive the unsigned integer number whose bits you must exchange.
// Output - On the only output line print the value of the integer with the exchanged bits.

namespace BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            int counter = 3;

            for (int i = 24; i < 27; i++)
            {
                int mask = 1 << i;
                uint bitValue = (uint)mask & number;
                uint bit = bitValue >> i;

                int bitMask = 1 << counter;
                uint andMask = (uint)bitMask & number;
                uint bitV = andMask >> counter;

                if (bit == 0)
                {
                    int maskBit = ~(1 << counter);
                    number = (uint)maskBit & number;
                    if (bit != bitV)
                    {
                        int maskBit1 = 1 << i;
                        number = (uint)maskBit1 | number;
                    }
                }
                else if (bit == 1)
                {
                    int maskBit = 1 << counter;
                    number = (uint)maskBit | number;
                    if (bit != bitV)
                    {
                        int maskBit1 = ~(1 << i);
                        number = (uint)maskBit1 & number;
                    }
                }
                counter++;
            }
            Console.WriteLine(number);
        }
    }
}
