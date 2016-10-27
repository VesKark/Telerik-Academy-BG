using System;

// Task Description:
// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.
// Input - On the first three lines, you will receive the three numbers, each on a separate line.
// Output - Output a single line - the sign of the product of the three numbers.

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());

            if (number1 * number2 * number3 > 0)
            {
                Console.WriteLine("+");
            }
            else if (number1 == 0 || number2 == 0 || number3 == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
