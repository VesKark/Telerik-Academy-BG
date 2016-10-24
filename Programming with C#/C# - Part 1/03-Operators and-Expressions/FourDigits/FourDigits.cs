using System;

// Task Description:
// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
// Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
// Puts the last digit in the first position: dabc (in our example 1201) and prints the result.
// Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            ushort number = ushort.Parse(Console.ReadLine());

            int fourthDigit = number % 10;
            int thirdDigit = (number / 10) % 10;
            int secondDigit = (number / 100) % 10;
            int firstDigit = (number / 1000) % 10;

            Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
        }
    }
}
