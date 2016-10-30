using System;

// MMSA (Min, Max, Sum, Average) of N Numbers!
// Task Description:
// Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number,
// the sum and the average of all numbers (displayed with 2 digits after the decimal point).
// Input - Starts by the number N (alone in a line) followed by N lines, each holding an integer number.
// Output - Like in the examples below:

// Input:
// On the first line, you will receive the number N.
// On each of the next N lines, you will receive a single integer number.

// Output:
// The output must always consist of exactly 4 lines - the minimal element on the first line, the maximal on the second,
// the sum on the third and the average on the fourth, in the following format:
//      min= 3.00
//      max= 6.00
//      sum= 9.00
//      avg= 4.50

// Constraints:
//      1 <= N <= 1000
//     All numbers will be valid integer numbers that will be in the range [-10000, 10000]

namespace MMSAofNumbers
{
    class MMSAofNumbers
    {
        static void Main()
        {
            ushort numberN = ushort.Parse(Console.ReadLine());

            double sum = 0;
            double max = double.NegativeInfinity;
            double min = double.PositiveInfinity;

            for (int i = 0; i < numberN; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
                if (num > max) max = num;
                if (num < min) min = num;
            }
            Console.WriteLine("min={0:0.00}", min);
            Console.WriteLine("max={0:0.00}", max);
            Console.WriteLine("sum={0:0.00}", sum);
            Console.WriteLine("avg={0:0.00}", (double)sum / numberN);
        }    
    }
}
