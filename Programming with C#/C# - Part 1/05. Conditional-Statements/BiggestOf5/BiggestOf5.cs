using System;

// Task Description:
// Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if-statements.
// Input - On the first 5 lines you will receive the 5 numbers, each on a separate line.
// Output - On the only output line, write the biggest of the 5 numbers.
// Constraints - The 5 numbers will always be valid floating-point numbers in the range [-200, 200].

namespace BiggestOf5
{
    class BiggestOf5
    {
        static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double number4 = double.Parse(Console.ReadLine());
            double number5 = double.Parse(Console.ReadLine());

            double biggest = number1;

            if (number2 > biggest)
            {
                biggest = number2;
            }
            if (number3 > biggest)
            {
                biggest = number3;
            }
            if (number4 > biggest)
            {
                biggest = number4;
            }
            if (number5 > biggest)
            {
                biggest = number5;
            }
            Console.WriteLine(biggest);
        }
    }
}
