using System;

// Task Description:
// Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and prints a matrix holding the
// numbers from 1 to N*N in the form of square spiral.
// Input - The input will always consist of a single line containing a single number - N.
// Output - Output a spiral matrix as described below.
// Constraints - N will always be a valid integer number.

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            Console.SetWindowSize(100, 30); //System.Console.SetWindowSize(100, 30);

            int n = int.Parse(Console.ReadLine());

            Console.Clear();

            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            int value = 1;

            if (n > 0 && n < 21)
            {
                while (value <= n * n)
                {
                    while (col < matrix.GetLength(0) && matrix[col, row] == 0)
                    {
                        matrix[row, col++] = value;
                        value++;
                    }

                    col--;
                    row++;

                    while (row < matrix.GetLength(1) && matrix[row, col] == 0)
                    {
                        matrix[row++, col] = value;
                        value++;
                    }

                    row--;
                    col--;

                    while (col >= 0 && matrix[row, col] == 0)
                    {
                        matrix[row, col--] = value;
                        value++;
                    }

                    col++;
                    row--;

                    while (row >= 0 && matrix[row, col] == 0)
                    {
                        matrix[row--, col] = value;
                        value++;
                    }

                    col++;
                    row++;
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.SetCursorPosition(j * 4, i * 2);
                        Console.Write(matrix[i, j]);
                        //Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("out of range");
            }
        }
    }
}