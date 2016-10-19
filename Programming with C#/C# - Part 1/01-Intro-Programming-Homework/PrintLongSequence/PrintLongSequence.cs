using System;

// Task Description:
// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            Console.BufferHeight = 1001;
            int numberToPrint;
            
            for (int i = 2; i <= 1001; i++)
            {
                if (i % 2 == 0)
                {
                    numberToPrint = i;
                }
                else
                {
                    numberToPrint = i * (-1);
                }
                Console.WriteLine(numberToPrint);
            }            
        }
    }
}
