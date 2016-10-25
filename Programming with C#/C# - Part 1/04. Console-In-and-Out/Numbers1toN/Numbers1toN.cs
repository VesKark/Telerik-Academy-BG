using System;

// Task Description:
// Write a program that reads an integer number N from the console and prints all the numbers in the interval [1, N],
// each on a single line.
// Output - You should print the numbers from 1 to N, each on a separate line.
// Constraints - (1 <= N< 1000), N will always be a valid integer number.

namespace Numbers1toN
{
    class Numbers1toN
    {
        static void Main()
        {
            ushort numberN = ushort.Parse(Console.ReadLine());            

            if (numberN >= 1 && numberN <= 1000)
            {
                for (ushort i = 1; i <= numberN; i++)
                {
                    Console.WriteLine(i);
                }               
            }            
        }
    }
}
