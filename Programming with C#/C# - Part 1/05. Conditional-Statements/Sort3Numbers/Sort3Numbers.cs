using System;

// Task Description:
// Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if-statements.
// Don’t use arrays and the built-in sorting functionality!
// Input - On the first three lines, you will receive the three numbers, each on a separate line.
// Output - Output a single line on the console - the sorted numbers, separated by a whitespace.
// Constraints - The three numbers will always be valid integer numbers in the range [-1000, 1000].

namespace Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            if (number1 >= number2 && number1 >= number3)
            {
                if (number2 >= number3)
                {
                    Console.WriteLine(number1 + " " + number2 + " " + number3);
                }
                else if (number2 < number3)
                {
                    Console.WriteLine(number1 + " " + number3 + " " + number2);
                }              
            }

            else if (number2 >= number1 && number2 >= number3)
            {
                if (number1 >= number3)
                {
                    Console.WriteLine(number2 + " " + number1 + " " + number3);
                }
                else if (number1 < number3)
                {
                    Console.WriteLine(number2 + " " + number3 + " " + number1);
                }
            }

            else if (number3 >= number2 && number3 >= number1)
            {
                if (number2 >= number1)
                {
                    Console.WriteLine(number3 + " " + number2 + " " + number1);
                }
                else if (number2 < number1)
                {
                    Console.WriteLine(number3 + " " + number1 + " " + number2);
                }
            }
        }
    }
}
