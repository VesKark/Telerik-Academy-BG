using System;

// Task Description:
// Write a program that reads from the console a positive integer number N and prints a matrix. Use two nested loops.
// Input - a single line, which contains the number N
// Output - matrix.
// Constraints - (1 <= N <= 20); N will always be a valid integer number.

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int numN = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numN ; i++)
            {
                for (int j = i + 1; j <= numN + i ; j++)
                {
                    Console.Write(j + " ");                    
                }
                Console.WriteLine();                
            }
        }
    }
}
