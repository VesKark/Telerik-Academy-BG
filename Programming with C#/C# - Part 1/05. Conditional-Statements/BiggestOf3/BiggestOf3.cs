using System;

// Task Description:
// Write a program that finds the biggest of three numbers that are read from the console.
// Output - On the only output line, write the biggest of the three numbers.
// Constraints - The three numbers will always be valid floating-point numbers in the range [-200, 200].

namespace BiggestOf3
{
    class BiggestOf3
    {
        static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());

            double numCompare1 = Math.Max(number1, number2);
            double numCompare2 = Math.Max(numCompare1, number3);

            if (numCompare1 >= -200 && numCompare1 <= 200 && numCompare2 >= -200 && numCompare2 <= 200)
            {
                Console.WriteLine(numCompare2);
            }            
        }
    }
}
