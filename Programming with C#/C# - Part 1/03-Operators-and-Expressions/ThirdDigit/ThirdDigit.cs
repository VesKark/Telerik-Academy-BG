using System;

// Task Description:
// Write a program that reads an integer N from the console and prints true if the third digit of N is 7,
// or "false THIRD_DIGIT", where you should print the third digits of N.
// N will always be valid non-negative integer number.
// The counting is done from right to left, meaning 123456's third digit is 4.

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            uint N = uint.Parse(Console.ReadLine());

            double div100 = N / 100;
            double div10 = div100 % 10;

            if (div10 == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + div10);
            }
        }
    }
}
