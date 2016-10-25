using System;

// Task Description:
// Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.
// Input - On the first line, you will receive the number N. On each of the next N lines, you will receive a floating-point number.
// Output - must output only one number - the sum of the N numbers.
// Constraints - (1 <= N <= 200); All numbers will be valid floating-point numbers in the range [-1000, 1000].

namespace SumOfNnumbers
{
    class SumOfNnumbers
    {
        static void Main()
        {
            byte numberN = byte.Parse(Console.ReadLine());
            double sum = 0;

            if (numberN >= 1 && numberN <= 200)
            {
                for (double i = 0; i < numberN; i++)
                {
                    double number = double.Parse(Console.ReadLine());
                    sum = sum + number;
                }
                Console.WriteLine(sum);
            }
        }
    }
}